using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;
using OestrichPascalLB_450_V1;

namespace TestProject
{
     public class MockStubSquare : IShape
    {
        public string ShapeType { get; set; } = "Square";
        private double _surface = 1.0;
        private double _circumference = 4.0;

        public List<double> CollectData(List<double> calculation)
        {
            return Calculate(calculation);
        }
        public List<double> Calculate(List<double> calculation)
        {
            // Add given Data from attributes in collection.
            calculation.Add(_surface);
            calculation.Add(_circumference);
            return calculation;
        }
        public string ShowAttributes()
        {
            // give back the attributes to test it.
            return "Surface | Circumference";
        }
    }
}
