using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OestrichPascalLB_450_V1
{
    internal interface IShape
    {
        public string ShapeType { get; set; }

        public List<double> CollectData(List<double> calculation);
        public List<double> Calculate(List<double> calculation);
        public string ShowAttributes();
    }
}
