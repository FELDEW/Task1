using System;

namespace Задачка_1
{
    public class Triangle : Figure
    {
        double a;
        double b;
        double c;
        public Triangle(double[] input)
        {
            a = input[0];
            b = input[1];
            c = input[2];
        }

        // расчет площади 
        public override double Area()  
        {
            double p = (a + b + c) / 2;
            return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
        }

        // называем треугольником
        public override string ShapeName()  
        {

            // проверка на прямоугольность
            bool RightTriangle = (
                Math.Pow(a, 2) == Math.Pow(b, 2) + Math.Pow(c, 2) ||      
                Math.Pow(b, 2) == Math.Pow(a, 2) + Math.Pow(c, 2) ||
                Math.Pow(c, 2) == Math.Pow(b, 2) + Math.Pow(a, 2));

            if (RightTriangle)        
            {
                return "Прямоугольный треугольник";
            }
            else
            {
                return "Треугольник";
            }
        }
    }
}
