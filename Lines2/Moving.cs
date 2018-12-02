namespace Lines2
{
    class Moving
    {
        public static void MovingUp(ref myPoint point, int k)
        {
            point.Point.Y = point.Point.Y - k;
        }
        public static void MovingDown(ref myPoint point, int k)
        {
            point.Point.Y = point.Point.Y + k;

        }
        public static void MovingRight(ref myPoint point, int k)
        {
            point.Point.X = point.Point.X + k;
        }
        public static void MovingLeft(ref myPoint point, int k)
        {
            point.Point.X = point.Point.X - k;
        }

    }
}
