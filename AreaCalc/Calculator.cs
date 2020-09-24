using System;

namespace AreaCalc
{
    public class Calculator
    {
        public double FindCircleArea(double r)
        {
            return new Circle(r).FindArea();
        }

        public double FindTriangleArea(double a, double b, double c)
        {
            return new Triangle(a, b ,c).FindArea();
        }

        public Boolean IsSquare(double a, double b, double c)
        {
            return new Triangle(a, b ,c).IsSquare();
        }
        
        /*Что касается поиска площади фигуры не зная ее типа встает вопрос как задавать ее границы:
         - это может быть многоугольник, тогда нужно ожидать список длинн сторон
         - фигура может быть задана кривой, тогда нам нужно знать ее функцию
        */
        
    }
}