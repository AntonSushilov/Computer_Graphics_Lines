namespace Lines2
{
    class Moving
    {
        public static void MovingUp(myPoint a, myPoint b, myPoint c, myPoint d, int k)
        {
            a.Point.X = a.Point.X - k;
            b.Point.X = b.Point.X - k;
            c.Point.X = c.Point.X - k;
            d.Point.X = d.Point.X - k;

        }

    }
}
