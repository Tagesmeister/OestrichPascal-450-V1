using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OestrichPascalLB_450_V1
{
    internal class Start
    {
        Controller cli;
        bool check = true;
        public Start()
        {
            int input = UserInputToCreateObject();

            if (input == 1)
            {
                cli = new Controller(new Square("Square"));
            }
            else if (input == 2)
            {
                cli = new Controller(new Circle("Circle"));
            }

            cli.Controll();
        }
        private int UserInputToCreateObject()
        {
            while (true)
            {
                try
                {
                    int input;

                    Console.WriteLine("Chose one of the shapes (1 Square) (2 Circle)");
                    input = Convert.ToInt32(Console.ReadLine());

                    Console.Clear();

                    // Condition for logicerrors
                    if (input != 1 && input != 2) { throw new Exception(); }

                    return input;
                }
                catch
                {
                    Console.WriteLine("ERROR: Invalid input");
                }


            }

        }
    }
}
