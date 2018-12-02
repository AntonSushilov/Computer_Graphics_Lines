using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Lines2
{
    public partial class MainForm : Form
    {
        public static List<myPoint> points = new List<myPoint>();
        public bool check = true;
        public bool ch = true;
        public bool check2 = false;

        public MainForm()
        {
            InitializeComponent();
        }

        public myPoint a, b, c, d;

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            for (int i = 0; i < points.Count; i++)
            {
                e.Graphics.DrawEllipse(Pens.Red, points[i].Point.X - 4, points[i].Point.Y - 4, 8, 8);

            }
            if (points.Count == 4)
            {
                if (ch || check2)
                {

                    ch = false;
                    e.Graphics.DrawLine(Pens.Black, points[0].Point.X, points[0].Point.Y, points[1].Point.X, points[1].Point.Y);
                    e.Graphics.DrawLine(Pens.Black, points[2].Point.X, points[2].Point.Y, points[3].Point.X, points[3].Point.Y);
                    a = points[0];
                    b = points[1];
                    c = points[2];
                    d = points[3];
                    check2 = false;
                    Logic.FindPixel(a, b, c, d, e);

                }
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (check)
            {
                myPoint p = new myPoint();
                p.Point.X = e.X;
                p.Point.Y = e.Y;
                points.Add(p);
                this.Invalidate();
                AddValue();
            }
        }



        public void AddValue()
        {

            if (points.Count < 4)
            {
                check = true;
            }
            else
            {
                check = false;
            }
        }

        private void buttonClear(object sender, EventArgs e)
        {

            ch = true;
            check = true;
            points.Clear();
            this.Invalidate();

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            this.Invalidate();

            int k = (int)numericUpDownMove.Value;
            a.Point.Y = a.Point.Y - k;
            b.Point.Y = b.Point.Y - k;
            c.Point.Y = c.Point.Y - k;
            d.Point.Y = d.Point.Y - k;
            check2 = true;
        }



        private void buttonRigth_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            int k = (int)numericUpDownMove.Value;
            a.Point.X = a.Point.X + k;
            b.Point.X = b.Point.X + k;
            c.Point.X = c.Point.X + k;
            d.Point.X = d.Point.X + k;
            check2 = true;
        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            int k = (int)numericUpDownMove.Value;
            a.Point.Y = a.Point.Y + k;
            b.Point.Y = b.Point.Y + k;
            c.Point.Y = c.Point.Y + k;
            d.Point.Y = d.Point.Y + k;
            check2 = true;
        }

        private void buttonInfo_Click(object sender, EventArgs e)
        {

        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            int k = (int)numericUpDownMove.Value;
            a.Point.X = a.Point.X - k;
            b.Point.X = b.Point.X - k;
            c.Point.X = c.Point.X - k;
            d.Point.X = d.Point.X - k;
            check2 = true;
        }



        private void buttonPlus_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            double k = (double)numericUpDownScope.Value;
            a.Point.X = (int)(a.Point.X * k);
            a.Point.Y = (int)(a.Point.Y / k);
            b.Point.X = (int)(b.Point.X / k);
            b.Point.Y = (int)(b.Point.Y * k);
            c.Point.X = (int)(c.Point.X * k);
            c.Point.Y = (int)(c.Point.Y / k);
            d.Point.X = (int)(d.Point.X / k);
            d.Point.Y = (int)(d.Point.Y * k);
            check2 = true;

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            this.Invalidate();
            double k = (double)numericUpDownScope.Value;

            check2 = true;
        }

    }


}
