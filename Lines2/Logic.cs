using System.Drawing;
using System.Windows.Forms;
namespace Lines2
{
    class Logic
    {
        public static void FindPixel(myPoint a, myPoint b, myPoint c, myPoint d, PaintEventArgs e)
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
            float x, y;
            float n = (ay - by) * (dx - cx) - (cy - dy) * (bx - ax);
            float m = -((ax * by - bx * ay) * (dx - cx) - (cx * dy - dx * cy) * (bx - ax));
            x = m / n;
            y = ((cy - dy) * (-x) - (cx * dy - dx * cy)) / (dx - cx);

            if (n == 0)
            {
                MessageBox.Show("Нет точки пересечения");
            }
            else
            {
                if (((ax <= x) && (bx >= x) && (cx <= x) && (dx >= x)) || ((ay <= y) && (by >= y) && (cy <= y) && (dy >= y)) || ((ax >= x) && (bx <= x) && (cx >= x) && (dx <= x)) || ((ay >= y) && (by <= y) && (cy >= y) && (dy <= y)))
                {
                    e.Graphics.DrawEllipse(Pens.Red, x, y, 1, 1);
                    string str = "Кооординаты точек: 1)A(" + ax + ";" + ay + ")" + " 2)B(" + bx + "; " + by + ")" + " 3)C(" + cx + "; " + cy + ")" + " 4)D(" + dx + "; " + dy + ")" + " 5)Точка пересечения(" + (int)x + "; " + (int)y + ")";
                    MessageBox.Show("Координаты точек: " + str,
                        "Сообщение",
                        MessageBoxButtons.OK);
                }
                else
                    MessageBox.Show("Нет точки пересечения");
            }
        }
        public static void info()
        {

        }

    }
}
