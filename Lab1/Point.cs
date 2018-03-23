namespace Lab1
{
    public class Point
    {
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        static public int x0 { get => 0; }
        static public int y0 { get => 0; }
    }
    public class DPoint
    {
        public double x;
        public double y;

        public DPoint(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
