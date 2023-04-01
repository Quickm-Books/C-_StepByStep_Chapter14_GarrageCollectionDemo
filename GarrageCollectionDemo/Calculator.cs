using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarrageCollectionDemo
{
    class Calculator
    {
        public Calculator()
        {
            Console.WriteLine("Calculator instance created");
        }

        ~Calculator()
        {
            Console.WriteLine("Calculator instance finalized");
        }

        public int Divide(int first, int second)
        {
            return first / second;
        }
    }
}
