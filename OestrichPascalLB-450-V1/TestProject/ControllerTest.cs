using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OestrichPascalLB_450_V1;

namespace TestProject
{
    [TestClass]
    public class ControllerTest
    {
        [TestMethod]
        public void TestControllerWithMockStubSquare()
        {
            //Arrange
            MockStubSquare mockStubSquare = new MockStubSquare();
            Controller controller = new(mockStubSquare);
            List<double> expectCalculationResults = new List<double> {1.0, 4.0 };
            List<double> actualCalculationResults = new List<double>();

            //Act
             controller.Controll();
            //Assert

            CollectionAssert.AreEqual(expectCalculationResults, mockStubSquare.Calculate(actualCalculationResults));
            Assert.AreEqual("Surface | Circumference", mockStubSquare.ShowAttributes());
            Assert.AreEqual("Square", mockStubSquare.ShapeType);
        }
        [TestMethod]
        public void TestControllerWithMockStubCircle()
        {
            //Arrange
            MockStubCircle mockStubCircle = new MockStubCircle();
            Controller controller = new(mockStubCircle);
            List<double> expectCalculationResults = new List<double> { 14.3239, 7.16195, 161.14337 };
            List<double> actualCalculationResults = new List<double>();

            //Act
            controller.Controll();

            //Assert
            CollectionAssert.AreEqual(expectCalculationResults, mockStubCircle.Calculate(actualCalculationResults));
            Assert.AreEqual("Diameter | Radius | Surface", mockStubCircle.ShowAttributes());
            Assert.AreEqual("Circle", mockStubCircle.ShapeType);
        }
        [TestMethod]
        public void TestControllerWithMockSpySquare()
        {
            // Arrange
            MockSpySquare mockSpySquare = new MockSpySquare("Square");
            Controller controller = new Controller(mockSpySquare);
            List<double> expectedPassedCalculations = new List<double>{1.0, 2.0};

            // Act
            controller.Controll();

            // Assert
            Assert.IsTrue(mockSpySquare.MethodCalls.Contains(nameof(MockSpySquare.CollectData)), "CollectData was not called on the spy.");

            Assert.IsTrue(mockSpySquare.MethodCalls.Contains(nameof(MockSpySquare.Calculate)), "Calculate was not called on the spy.");

            Assert.IsTrue(mockSpySquare.MethodCalls.Contains(nameof(MockSpySquare.ShowAttributes)), "ShowAttributes was not called on the spy.");

            CollectionAssert.AreEqual(expectedPassedCalculations, mockSpySquare.Calculate(new List<double>()));

            Assert.AreEqual(expectedPassedCalculations.Count, mockSpySquare.PassedCalculations.Count, "The calculation results do not match the expected values.");
        }
        [TestMethod]
        public void TestControllerWithMockSpyCircle()
        {
            // Arrange
            MockSpyCircle mockSpyCircle = new MockSpyCircle("Circle");
            Controller controller = new Controller(mockSpyCircle);
            List<double> expectedPassedCalculations = new List<double> { 1.0, 2.0 };

            // Act
            controller.Controll();

            // Assert
            Assert.IsTrue(mockSpyCircle.MethodCalls.Contains(nameof(MockSpyCircle.CollectData)), "CollectData was not called on the spy.");

            Assert.IsTrue(mockSpyCircle.MethodCalls.Contains(nameof(MockSpyCircle.Calculate)), "Calculate was not called on the spy.");

            Assert.IsTrue(mockSpyCircle.MethodCalls.Contains(nameof(MockSpyCircle.ShowAttributes)), "ShowAttributes was not called on the spy.");

            CollectionAssert.AreEqual(expectedPassedCalculations, mockSpyCircle.Calculate(new List<double>()));

            Assert.AreEqual(expectedPassedCalculations.Count, mockSpyCircle.PassedCalculations.Count, "The calculation results do not match the expected values.");
        }
    }
}
