using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculatorB2A.ErrorHandling
{
    internal class InvalidIO
    {
        public void InvalidSelection() {
            Console.WriteLine("Invalid selection. Try again.");
        }

        public void InvalidInput()
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
    }
}
