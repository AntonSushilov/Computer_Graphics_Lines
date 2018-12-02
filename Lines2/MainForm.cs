using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lines2
{
    public partial class MainForm : Form
    {
        public static List<myPoint> points = new List<myPoint>();
        public myPoint a, b, c, d;
        public bool checkPoints = true;

        public static double x, y;

        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (checkPoints)
            {
                myPoint p = new myPoint();
                p.Point.X = e.X;
                p.Point.Y = e.Y;
                points.Add(p);
                AddValue();
                Invalidate();
            }
        }
        public void AddValue()
        {

            if (points.Count < 4)
            {
                checkPoints = true;
            }
            else
            {
                checkPoints = false;
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < points.Count; i++)
            {
                DrawLogic.DrawPoint(points[i], e);
            }


            if (points.Count == 4)
            {
                a = points[0];
                b = points[1];
                c = points[2];
                d = points[3];
                labelPointA.Text = "A: " + "(" + a.Point.X + "; " + a.Point.Y + ")";
                labelPointB.Text = "B: " + "(" + b.Point.X + "; " + b.Point.Y + ")";
                labelPointC.Text = "C: " + "(" + c.Point.X + "; " + c.Point.Y + ")";
                labelPointD.Text = "D: " + "(" + d.Point.X + "; " + d.Point.Y + ")";


                e.Graphics.DrawLine(Pens.Black, a.Point.X, a.Point.Y, b.Point.X, b.Point.Y);
                e.Graphics.DrawLine(Pens.Black, c.Point.X, c.Point.Y, d.Point.X, d.Point.Y);

                string str = "";
                //DrawLogic.FindPixel(a, b, c, d, e, ref str);
                DrawLogic.FindPixel(a, b, c, d, e, ref x, ref y, ref str);
                labelPointO.Text = "O: " + str;
            }
        }








        //КНОПКИ................................


        private void buttonClear(object sender, EventArgs e)
        {
            checkPoints = true;
            points.Clear();
            this.Invalidate();
        }
        private void buttonUp_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            int k = (int)numericUpDownMove.Value;
            Moving.MovingUp(ref a, k);
            Moving.MovingUp(ref b, k);
            Moving.MovingUp(ref c, k);
            Moving.MovingUp(ref d, k);
        }
        private void buttonRigth_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            int k = (int)numericUpDownMove.Value;
            Moving.MovingRight(ref a, k);
            Moving.MovingRight(ref b, k);
            Moving.MovingRight(ref c, k);
            Moving.MovingRight(ref d, k);
        }
        private void buttonDown_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            int k = (int)numericUpDownMove.Value;
            Moving.MovingDown(ref a, k);
            Moving.MovingDown(ref b, k);
            Moving.MovingDown(ref c, k);
            Moving.MovingDown(ref d, k);
        }
        private void buttonLeft_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            int k = (int)numericUpDownMove.Value;
            Moving.MovingLeft(ref a, k);
            Moving.MovingLeft(ref b, k);
            Moving.MovingLeft(ref c, k);
            Moving.MovingLeft(ref d, k);
        }


        private void buttonPlus_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            double k = (double)numericUpDownScope.Value;
            Scope.ScopeLinePlus(ref a, ref b, x, y, k);
            Scope.ScopeLinePlus(ref c, ref d, x, y, k);


        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            double k = (double)numericUpDownScope.Value;
            Scope.ScopeLineMinus(ref a, ref b, x, y, k);
            Scope.ScopeLineMinus(ref c, ref d, x, y, k);
        }

    }


}
