using System.Drawing;
using System.Windows.Forms;
namespace Lines2
{
    class DrawLogic
    {

        public static void FindPixel(myPoint a, myPoint b, myPoint c, myPoint d, PaintEventArgs e, ref double x, ref double y, ref string str)
        {
            int ax = a.Point.X;
            int ay = a.Point.Y;
            int bx = b.Point.X;
            int by = b.Point.Y;
            int cx = c.Point.X;
            int cy = c.Point.Y;
            int dx = d.Point.X;
            int dy = d.Point.Y;
            if (c.Point.X > d.Point.X && c.Point.Y > d.Point.X)
            {
                int p1;
                p1 = cx;
                cx = dx;
                dx = p1;
                p1 = cy;
                cy = dy;
                dy = p1;
            }

            float n = (ay - by) * (dx - cx) - (cy - dy) * (bx - ax);
            float m = -((ax * by - bx * ay) * (dx - cx) - (cx * dy - dx * cy) * (bx - ax));
            x = m / n;
            y = ((cy - dy) * (-x) - (cx * dy - dx * cy)) / (dx - cx);

            if (n == 0)
            {
                str = "Нет точки пересечения";
            }
            else
            {
                if (((ax <= x) && (bx >= x) && (cx <= x) && (dx >= x)) || ((ay <= y) && (by >= y) && (cy <= y) && (dy >= y)) || ((ax >= x) && (bx <= x) && (cx >= x) && (dx <= x)) || ((ay >= y) && (by <= y) && (cy >= y) && (dy <= y)))
                {
                    e.Graphics.DrawEllipse(Pens.Red, (int)x, (int)y, 1, 1);
                    str = "(" + (int)x + "; " + (int)y + ")";
                }
                else
                    str = "Нет точки пересечения";
            }
        }
        public static void DrawPoint(myPoint point, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(Pens.Red, point.Point.X - 4, point.Point.Y - 4, 8, 8);
        }

    }
}
