using ConsoleCalculatorB2A.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculatorB2A.Operations
{
    internal class Multiplication
    {
        public void Multiply()
        {
            Console.WriteLine("MULTIPLICATION");
            var results = GetUserValues.InputValues();
            int x = results.xValue;
            int y = results.yValue;
            int product = x * y;
            Console.WriteLine("The product of two numbers is: " + product);
        }
    }
}
