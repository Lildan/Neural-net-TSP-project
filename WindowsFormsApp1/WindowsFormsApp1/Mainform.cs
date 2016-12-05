using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSPSimulatedAnnelaing
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.ListPoints = new List<Point>();
            this.ListBoxOfPoints.DataSource = this.ListPoints;
            this.Gamilton = false;

            this.DoubleBuffered = true;
        }

        public List<Point> ListPoints;

        public bool Gamilton { get; set; }

        public TSPSimulatedAnnealing anneal;

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        //Panel to Draw graphics
        private void VisualizationPanel_Paint(object sender, PaintEventArgs e)
        {
            if (this.anneal != null)
            {
                Point[] array = new Point[anneal.points.Length];
                for (int i = 0; i < anneal.points.Length; i++)
                {
                    array[i] = anneal.points[anneal.GetArray()[i]];
                }
                Size PanelSize = this.VisualizationPanel.Size;
                int width = PanelSize.Width;
                int height = PanelSize.Height;
                //scaling points to display on panel
                double minH = array.Min(element => element.Y);
                double maxH = array.Max(element => element.Y);
                double minW = array.Min(element => element.X);
                double maxW = array.Max(element => element.X);

                SolidBrush pointBrush = new SolidBrush(Color.Red);
                Pen linePen = new Pen(Color.Green);
                Graphics g = this.VisualizationPanel.CreateGraphics();

                for (int i = 0; i < array.Length; i++)
                {
                    array[i].X = (array[i].X - minW) * (width - 10) / (maxW - minW) + 5;
                    array[i].Y = -(array[i].Y - maxH) * (height - 10) / (maxH - minH) + 5;

                    g.FillEllipse(pointBrush, (float)array[i].X - 5, (float)array[i].Y - 5, 10, 10);


                    if (i == 0)
                    {
                        pointBrush = new SolidBrush(Color.Blue);
                    }
                    else
                    {
                        g.DrawLine(linePen, (float)array[i - 1].X, (float)array[i - 1].Y, (float)array[i].X, (float)array[i].Y);
                    }
                }

            }
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }



        private void AddManualButton_Click(object sender, EventArgs e)
        {

            if (Double.TryParse(this.XInput.Text, out double x) && Double.TryParse(this.YInput.Text, out double y))
            {
                Point p = new Point(x, y);
                foreach (Point point in ListPoints)
                {
                    if (point.Equals(p))
                    {
                        MessageBox.Show("This point is already in list.");
                        return;
                    }
                }
                ListPoints.Add(p);
                UpdateListBox();
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Incorrect input of coordinates!");
            }
        }

        private void UpdateListBox()
        {
            this.ListBoxOfPoints.DataSource = null;
            this.ListBoxOfPoints.DataSource = this.ListPoints;
        }

        private void ClearInputs()
        {
            this.XInput.Text = String.Empty;
            this.YInput.Text = String.Empty;
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            this.ListPoints = new List<Point>();
            UpdateListBox();
        }

        private void Calculate_Click(object sender, EventArgs e)
        {
            if (!ValidateParameters())
            {
                return;
            }

            this.anneal = new TSPSimulatedAnnealing(this.ListPoints.ToArray(),
                Double.Parse(this.StartTemperatureMaskedTextBox.Text),
                Double.Parse(this.StopTemperatureMaskedTextBox.Text),
                Int32.Parse(this.CyclesNumberMaskedTextBox.Text),
                this.Gamilton);
            StartCalculationThread();
        }

        //#TODO
        private bool ValidateParameters()
        {
            return true;
        }

        private void StartCalculationThread()
        {
            ThreadStart ts = new ThreadStart(this.ThreadProc);
            Thread thread = new Thread(ts);
            thread.Start();
        }

        private void ThreadProc()
        {
            double newCost;
            double oldCost = anneal.Error;

            int sameEpocs = 0;

            while (sameEpocs < 50)
            {
                this.anneal.Iteration();
                newCost = this.anneal.Error;

                if (oldCost == newCost)
                {
                    sameEpocs++;
                }
                else
                {
                    sameEpocs = 0;
                    oldCost = newCost;
                    this.VisualizationPanel.Invalidate();
                }
            }
            this.VisualizationPanel.Invalidate();
        }

        private void GamiltonCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            this.Gamilton = this.GamiltonCheckBox.Checked;
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(this.RandomNumTextBox.Text, out int num) && num > 0)
            {
                Random rand = new Random();
                for (int i = 0; i < num; i++)
                {
                    Point p = new Point(rand.Next(0, 721), rand.Next(0, 721));
                    bool isin = false;
                    foreach(Point point in this.ListPoints)
                    {
                        if (point.Equals(p))
                        {
                            isin = true;
                            i--;
                            break;
                        }
                    }
                    if (!isin)
                    {
                        this.ListPoints.Add(p);
                    }
                }
                UpdateListBox();
            }
            else
            {
                MessageBox.Show("Incorrect number of points to generate.");
            }
        }
    }
}
