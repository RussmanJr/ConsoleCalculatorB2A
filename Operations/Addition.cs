using System;
using ConsoleCalculatorB2A;
using ConsoleCalculatorB2A.Requests;

namespace ConsoleCalculatorB2A.Operations
{
    public class Addition
    {
        public void Add()
        {
            Console.WriteLine("ADDITION");
            var results = GetUserValues.InputValues();
            int x = results.xValue;
            int y = results.yValue;
            int sum = x + y;
            Console.WriteLine("The sum of two numbers is: " + sum);
        }
    }
}
