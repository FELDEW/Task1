using Microsoft.VisualStudio.TestTools.UnitTesting;
using Задачка_1;

namespace TestShapeApp
{
    [TestClass]
    public class UnitTestTriangle
    {
        [TestMethod]

        public void TestTriangle1()
        {
            // 1-ый тест на непрямоугольный треугольник
            double[] input = { 3.3, 2, 1.5 };              
            string expectedS = "0,9509994742375";
            string expectedName = "Треугольник";
            Triangle triangle = new Triangle(input);       
            double actualS = triangle.Area();
            string actualName = triangle.ShapeName();
            Assert.AreEqual(expectedName, actualName);     
            Assert.AreEqual(expectedS, actualS.ToString());
        }
        [TestMethod]
        public void TestTriangle2()
        {
            // 2-ой тест на прямоугольный треугольник
            double[] input = { 3, 4, 5 };                     
            string expectedS = "6";
            string expectedName = "Прямоугольный треугольник";
            Triangle triangle = new Triangle(input);            
            double actualS = triangle.Area();
            string actualName = triangle.ShapeName();
            Assert.AreEqual(expectedName, actualName);          
            Assert.AreEqual(expectedS, actualS.ToString());
        }
    }
}
