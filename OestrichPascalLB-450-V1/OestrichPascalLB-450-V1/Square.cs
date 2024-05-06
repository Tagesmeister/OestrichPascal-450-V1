using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OestrichPascalLB_450_V1
{
    internal class Square : IShape
    {
        private string _shapeType;
        private double _lenght;
        private double _width;
        private double _surface;
        private double _circumference;

        public double Lenght { get { return _lenght; } set { _lenght = value; } }
        public double Width { get { return _width; } set { _width = value; } }
        public string ShapeType
        {
            get { return _shapeType; }
            set { _shapeType = value; }
        }
        public Square(string shapeType)
        {
            _shapeType = shapeType;
        }
        public List<double> CollectData(List<double> calculation)
        {
            Console.WriteLine("Give Datas to thise Attributes.");

            while (true)
            {
                Console.WriteLine("Lenght");
                try
                {
                    _lenght = Convert.ToDouble(Console.ReadLine());

                    TestLogicError();

                    Console.WriteLine("Width");
                    _width = Convert.ToDouble(Console.ReadLine());

                    TestLogicError();


                    return Calculate(calculation);
                }
                catch { Console.WriteLine("ERROR: Invalid input"); }
            }

        }
        private void TestLogicError()
        {
            // Condition for logicerrors
            if (_lenght < 0 || _width < 0 || _lenght > 10000 || _width > 10000) { throw new Exception(); }
        }
        public List<double> Calculate(List<double> calculation)
        {
            _surface = _lenght * _width;
            _circumference = 2 * _lenght + 2 * _width;

            calculation.Add(_surface);
            calculation.Add(_circumference);

            return calculation;
        }
        public string ShowAttributes()
        {
            return "Surface | Circumference";
        }
    }
}
