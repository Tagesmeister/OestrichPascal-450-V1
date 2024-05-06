using OestrichPascalLB_450_V1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TestProject
{
    [TestClass]
    public class UnitTests
    {
        [TestMethod]
        public void TestCalculationCircle()
        {
            // Arrange
            Circle circle = new Circle("Circle");
            circle.Circumference = 50;

            List<double> expectValues = new List<double> { 15.915494309189533576888376337251, 7.9577471545947667884441881686257, 198.94367886486916971110470421564 };
            List<double> resultList = new List<double>();

            // Act
            circle.Calculate(resultList);

            // Assert
            CollectionAssert.AreEqual(expectValues, resultList);
        }
        [TestMethod]
        public void TestCalculationSquare()
        {
            // Arrange
            Square square = new Square("Square");
            square.Lenght = 10;
            square.Width = 20;

            List<double> expectValues = new List<double> { 200, 60 };
            List<double> resultList = new List<double>();

            // Act
            square.Calculate(resultList);

            // Assert
            CollectionAssert.AreEqual(expectValues,resultList);
        }
    }
}
