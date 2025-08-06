using System;


namespace ConsoleCalculatorB2A.Requests
{
    internal class GetUserValues
    {
        public static (int xValue, int yValue) InputValues()
        {
            Console.WriteLine("Enter a value for x: ");
            int xValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for y: ");
            int yValue = Convert.ToInt32(Console.ReadLine());
            return (xValue, yValue);
        }
    }
}
