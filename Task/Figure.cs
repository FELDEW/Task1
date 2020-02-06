using System;

namespace Задачка_1
{
   public abstract class Figure
    {
        public abstract string ShapeName();
        public abstract double Area();
        public void GetInfo ()
        {
            Console.WriteLine($"Это {ShapeName()}");
            Console.WriteLine($"Площадь:{Area()}");
            Console.ReadKey();
        }
    }
}
