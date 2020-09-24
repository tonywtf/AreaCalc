using System;

namespace AreaCalc
{
    public class Triangle : IFigure
    {
        private double a;
        private double b;
        private double c;

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public double FindArea()
        {
            if (!IsTriangleCorrect())
            {
                return 0;
            }
            var p = (a + b + c) / 2;
            var s = Math.Sqrt(p * (p - a)*(p - b)*(p - c));
            return s;
        }

        public Boolean IsSquare()
        {
            if (!IsTriangleCorrect())
            {
                return false;
            }
            
            var result = false;
            if (a > b & a > c)
            {
                result = (a * a).Equals(b * b + c * c) ;
            } else if (b > a & b > c)
            {
                result = (b * b).Equals(a * a + c * c);
            }
            else
            {
                result = (c * c).Equals(b * b + a * a);
            }

            return result;
        }

        private Boolean IsTriangleCorrect()
        {
            if (a < 0 || b < 0 || c < 0)
            {
                return false;
            }else  if (a > b + c)
            {
                return false;
            } else if (b > a + c)
            {
                return false;
            } else if (c > a + b)
            {
                return false;
            }
            return true;
        }
    }
}