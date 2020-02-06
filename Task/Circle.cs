using System;

namespace Задачка_1
{
    public class Circle : Figure
    {
        double Radius;
        public Circle (double [] input)
        {
         Radius = input[0];
        }

        // расчет площади 
        public override double Area()    
        {
            return Math.PI * Math.Pow(Radius, 2);
        }


        // называем кругом
        public override string ShapeName()   
        {
            return "Круг";
        }

    }
}   


