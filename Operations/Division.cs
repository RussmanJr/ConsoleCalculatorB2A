using ConsoleCalculatorB2A.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculatorB2A.Operations
{
    internal class Division
    {
        public void Divide()
        {
            Console.WriteLine("DIVISION");
            var results = GetUserValues.InputValues();
            int x = results.xValue;
            int y = results.yValue;

            if (y == 0)
            {
                Console.WriteLine("Division by zero is not allowed.");
                return;
            }

            int total = x / y;
            Console.WriteLine(x + " divided by " + y + " equals: " + total);
        }
    }
}
