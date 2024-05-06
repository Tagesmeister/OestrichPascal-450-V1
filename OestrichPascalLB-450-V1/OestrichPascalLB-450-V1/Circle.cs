using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("TestProject")]

namespace OestrichPascalLB_450_V1
{
    internal class Circle : IShape
    {
        private string _shapeType;
        private double _circumference;
        private double _diameter;
        private double _radius;
        private double _surface;

        public double Circumference { get { return _circumference; } set { _circumference = value; } }
        public string ShapeType
        {
            get { return _shapeType; }
            set { _shapeType = value; }
        }
        public Circle(string shapeType)
        {
            _shapeType = shapeType;
        }
        public List<double> CollectData(List<double> calculation)
        {
            Console.WriteLine("Give Datas to this Attribute.");

            while (true)
            {
                Console.WriteLine("circumference");
                try
                {
                    _circumference = Convert.ToDouble(Console.ReadLine());

                    // Condition for logicerrors
                    if (_circumference < 0 || _circumference > 10000 || _circumference > 10000) { throw new Exception(); }

                    return Calculate(calculation);
                }
                catch { Console.WriteLine("ERROR: Invalid input"); }
            }
        }
        public List<double> Calculate(List<double> calculation)
        {

            _diameter = _circumference / Math.PI;
            _radius = _diameter / 2;
            _surface = (_radius * _radius) * Math.PI;

            calculation.Add(_diameter);
            calculation.Add(_radius);
            calculation.Add(_surface);

            return calculation;
        }
        public string ShowAttributes()
        {
            return "Diameter | Radius | Surface ";
        }
    }
}
