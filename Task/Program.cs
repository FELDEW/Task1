using System;
using System.Linq;

namespace Задачка_1
{
    class Program
    {
        static void Main(string[] args)
        {

            // обьявляем входные данные
            double[] text = Console.ReadLine().Replace(".",",").Split(' ').Select(Double.Parse).ToArray();  

            // в зависимости от количества сторон, понимаем какая фигура задана
            switch (text.Length)                     
            {
                 // круг
                case 1:                             
                    Figure circle = new Circle(text);
                    circle.GetInfo();
                    break;

                 // треугольник
                case 3:                              
                    Figure triangle = new Triangle(text);
                    triangle.GetInfo();
                    break;

                 // или непонятно
                default:                              
                    Console.WriteLine("Неизвестная фигура");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
