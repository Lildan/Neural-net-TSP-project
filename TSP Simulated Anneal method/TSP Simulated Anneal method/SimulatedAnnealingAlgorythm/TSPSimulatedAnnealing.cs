using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSPSimulatedAnnelaing
{
    public class TSPSimulatedAnnealing : SimulatedAnnealing<int>
    {
        public Point[] points;

        protected int[] path;

        protected bool gamilton;

        protected double[,] distanceMatrix;

        public TSPSimulatedAnnealing(Point[] points, double startTemp, double stopTemp, int cycles, bool gamilton)
        {
            this.temperature = startTemp;
            this.StartTemperature = startTemp;
            this.StopTemperature = stopTemp;
            this.Cycles = cycles;
            this.gamilton = gamilton;

            this.points = points;
            this.path = InitializePath();
            this.distanceMatrix = CalculateDistancesMatrix();

        }

        public override double DetermineError()
        {
            double totalLength = 0;
            for (int i = 0; i < path.Length - 1; i++)
            {
                totalLength += distanceMatrix[path[i], path[i + 1]];
            }
            if (this.gamilton)
            {
                totalLength += distanceMatrix[path.Last(), path.First()];
            }
            return totalLength;
        }

        public override int[] GetArray()
        {
            return this.path;
        }

        public override int[] GetArrayCopy()
        {
            int[] result = new int[this.path.Length];
            Array.Copy(this.path, result, this.path.Length);
            return result;
        }

        public override void PutArray(int[] array)
        {
            this.path = array;
        }

        public override void Randomize()
        {
            int length = this.path.Length;

            Random rand = new Random();

            for (int i = 0; i < this.temperature; i++)
            {
                int index1 = rand.Next(0, this.path.Length);
                int index2 = rand.Next(0, this.path.Length);
                if (index1 != index2)
                {
                    if (index2 < index1)
                    {
                        int temp = index1;
                        index1 = index2;
                        index2 = temp;
                    }

                    double distance = 0;
                    //case we  change the endpoint of the path
                    if (index2 == this.path.Length - 1)
                    {
                        if (this.gamilton)
                        {
                            distance = distanceMatrix[path[index1], path[index1 + 1]] +
                                       distanceMatrix[path[index2], path[0]] -
                                       distanceMatrix[path[index1], path[index2]] -
                                       distanceMatrix[path[index1 + 1], path[0]];
                        }
                        else //not gamilton. We dont count the distances from last point to the starting point
                        {
                            distance = distanceMatrix[path[index1], path[index1 + 1]] -
                                       distanceMatrix[path[index1], path[index2]];
                        }
                    }
                    else//default case. Changing the connections inside the path
                    {
                        distance = distanceMatrix[path[index1], path[index1 + 1]] +
                                   distanceMatrix[path[index2], path[index2 + 1]] -
                                   distanceMatrix[path[index1], path[index2]] -
                                   distanceMatrix[path[index1 + 1], path[index2 + 1]];
                    }

                    if (distance > 0)
                    {
                        for (; index2 > index1; index2--)
                        {
                            int temp = this.path[index1 + 1];
                            this.path[index1 + 1] = this.path[index2];
                            this.path[index2] = temp;
                            index1++;
                        }
                    }
                }
            }

        }

        private double[,] CalculateDistancesMatrix()
        {
            double[,] matrix = new double[points.Length, points.Length];

            Parallel.For(0, points.Length, (i) =>
             {
                 for (int j = 0; j < i; j++)
                 {
                     matrix[i, j] = points[i].Distance(points[j]);
                     matrix[j, i] = matrix[i, j];
                 }
                 matrix[i, i] = 0;
             }
            );
            return matrix;
        }

        private int[] InitializePath()
        {
            int[] path = new int[this.points.Length];
            for (int i = 0; i < path.Length; i++)
            {
                path[i] = i;
            }
            return path;
        }
    }
}
