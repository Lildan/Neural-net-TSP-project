using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSPSimulatedAnnelaing
{
    public class Point
    {
        public double X { get; set; }

        public double Y { get; set; }

        public Point(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Distance in Euclid`s space using Pifagore`s theoreme
        /// </summary>
        /// <param name="p">Another point to find distance to it</param>
        /// <returns></returns>
        public double Distance(Point p)
        {
            return Math.Sqrt((this.X - p.X) * (this.X - p.X) + (this.Y - p.Y) * (this.Y - p.Y));
        }

        public override string ToString()
        {
            return "(" + X.ToString() + ", " + Y.ToString() + ")";
        }

        public bool Equals(Point p)
        {
            return (this.X == p.X && this.Y == p.Y);
        }

        public Point Copy()
        {
            return new Point(this.X, this.Y);
        }
    }
}
