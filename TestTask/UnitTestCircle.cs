using Microsoft.VisualStudio.TestTools.UnitTesting;
using Задачка_1;

namespace TestShapeApp
{
    [TestClass]
    public class UnitTestCircle
    {
        [TestMethod]
        public void TestCircleArea()
        {
            double[] input = { 3 };                 
            string expected = "28,2743338823081";
            string expectedName = "Круг";
            Circle circle = new Circle(input);      
            double actual = circle.Area();
            string actualName = circle.ShapeName();
            Assert.AreEqual(expectedName, actualName);
            Assert.AreEqual(expected, actual.ToString());      
        }
    }
}
