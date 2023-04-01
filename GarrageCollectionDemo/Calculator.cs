using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarrageCollectionDemo
{
    class Calculator : IDisposable
    {
        public Calculator()
        {
            Console.WriteLine("Calculator instance created");
        }

        ~Calculator()
        {
            Console.WriteLine("Calculator instance finalized");
            this.Dispose();
        }

        public void Dispose()
        {
            Console.WriteLine("Calculator instance being disposed");
        }

        public int Divide(int first, int second)
        {
            return first / second;
        }
    }
}
