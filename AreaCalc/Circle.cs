namespace AreaCalc
{
    public class Circle  : IFigure
    {
        private double r;

        public Circle(double r)
        {
            this.r = r;
        }

        public double FindArea()
        {
            if (r < 0)
            {
                return 0;
            }
            return r * r * 3.14;
        }
    }
}