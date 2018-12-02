namespace Lines2
{
    public class Scope
    {
        public static void ScopeLinePlus(ref myPoint a, ref myPoint b, double xmid, double ymid, double k)
        {

            a.Point.X = a.Point.X - (int)((xmid - a.Point.X) * (k - 1));
            a.Point.Y = a.Point.Y - (int)((ymid - a.Point.Y) * (k - 1));

            b.Point.X = b.Point.X - (int)((xmid - b.Point.X) * (k - 1));
            b.Point.Y = b.Point.Y - (int)((ymid - b.Point.Y) * (k - 1));

        }
        public static void ScopeLineMinus(ref myPoint a, ref myPoint b, double xmid, double ymid, double k)
        {
            double kf = 1 / k;
            a.Point.X = a.Point.X + (int)((xmid - a.Point.X) * kf);
            a.Point.Y = a.Point.Y + (int)((ymid - a.Point.Y) * kf);

            b.Point.X = b.Point.X + (int)((xmid - b.Point.X) * kf);
            b.Point.Y = b.Point.Y + (int)((ymid - b.Point.Y) * kf);
        }
    }
}
