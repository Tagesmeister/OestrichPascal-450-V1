using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
[assembly: InternalsVisibleTo("TestProject")]

namespace OestrichPascalLB_450_V1
{
    internal class Controller
    {
        private readonly IShape _ishape;
        List<double> _calculation;

        public Controller (IShape shape)
        {
            _ishape = shape;
        }
        public void Controll()
        {
            _calculation = new List<double>();
            _ishape.CollectData(_calculation);

            OutputCalculation();
        }
        private void OutputCalculation()
        {
            Console.WriteLine(_ishape.ShapeType);

            Console.WriteLine(_ishape.ShowAttributes());

            Console.WriteLine("");

            foreach (double i in _calculation)
            {

                Console.Write($" {i}" + " |");
            }

            Console.WriteLine("Calculation are correct.");
        }
    }
}
