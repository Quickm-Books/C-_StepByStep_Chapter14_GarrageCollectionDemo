using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollectionDemo
{
    class Calculator : IDisposable
    {
        private bool disposed = false;

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
            if (!this.disposed)
            {
                Console.WriteLine("Calculator instance being disposed");
            }

            this.disposed = true;
            GC.SuppressFinalize(this);
        }

        public int Divide(int first, int second)
        {
            return first / second;
        }
    }
}
