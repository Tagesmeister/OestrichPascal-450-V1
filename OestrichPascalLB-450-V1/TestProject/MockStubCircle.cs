using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OestrichPascalLB_450_V1;

namespace TestProject
{
    internal class MockStubCircle : IShape
    {
        public string ShapeType { get; set; } = "Circle";
        private double _diameter = 14.3239;
        private double _radius = 7.16195;
        private double _surface = 161.14337;

        public List<double> CollectData(List<double> calculation)
        {
            // No userinputs
            return Calculate(calculation);
        }
        public List<double> Calculate(List<double> calculation)
        {
            // Add given Data from attributes in collection.
            calculation.Add(_diameter);
            calculation.Add(_radius);
            calculation.Add(_surface);
            return calculation;
        }
        public string ShowAttributes()
        {
            // give back the attributes to test it.
            return "Diameter | Radius | Surface";
        }

    }
}
