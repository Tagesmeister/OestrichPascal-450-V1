using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OestrichPascalLB_450_V1;

namespace TestProject
{

    public class MockSpySquare : IShape
    {
        private string _shapeName;
        public string ShapeType { get; set; }

        public List<string> MethodCalls = new List<string>();
        public List<List<double>> PassedCalculations = new List<List<double>>();

        public MockSpySquare(string shapeType)
        {
            _shapeName = shapeType;
        }

        public List<double> CollectData(List<double> calculation)
        {
            
            MethodCalls.Add(nameof(CollectData));
            return Calculate(calculation);
        }

        public List<double> Calculate(List<double> calculation)
        {
            MethodCalls.Add(nameof(Calculate));
            PassedCalculations.Add(calculation);

            return new List<double> { 1.0, 2.0 };
        }

        public string ShowAttributes()
        {
            MethodCalls.Add(nameof(ShowAttributes));
            // Give back a string value to fulfill the interface.
            return "TestString";
        }
    }
}
