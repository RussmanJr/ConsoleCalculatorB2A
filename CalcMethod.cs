using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ConsoleCalculatorB2A
{
    internal class CalcMethod
    {
        int userSwitch;

        public (int xValue, int yValue) UserValues()
        {
            Console.WriteLine("Enter a value for x: ");
            int xValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a value for y: ");
            int yValue = Convert.ToInt32(Console.ReadLine());
            return (xValue, yValue);
        }

        public void Addition()
        {
            Console.WriteLine("ADDITION");
            var results = UserValues();
            int x = results.xValue;
            int y = results.yValue;
            int sum = x + y;
            Console.WriteLine("The sum of two numbers is: " + sum);
        }

        public void Subtraction()
        {
            Console.WriteLine("SUBTRACTION");
            var results = UserValues();
            int x = results.xValue;
            int y = results.yValue;
            int total = x - y;
            Console.WriteLine("The subtracted numbers equal: " + total);
        }

        public void Multiplication()
        {
            Console.WriteLine("MULTIPLICATION");
            var results = UserValues();
            int x = results.xValue;
            int y = results.yValue;
            int product = x * y;
            Console.WriteLine("The product of two numbers is: " + product);
        }

        public void Division()
        {
            Console.WriteLine("DIVISION");
            var results = UserValues();
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

        public void StartCalculator()
        {
            while (true)
            {
                
                Console.WriteLine("0 - Exit Application");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");
                Console.WriteLine();
                Console.Write("Make a selection:> ");

                if (!int.TryParse(Console.ReadLine(), out userSwitch))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (userSwitch == 0) break;
                Console.Clear();
                switch (userSwitch)
                {
                    case 1:
                        Addition();
                        break;
                    case 2:
                        Subtraction();
                        break;
                    case 3:
                        Multiplication();
                        break;
                    case 4:
                        Division();
                        break;
                    default:
                        Console.WriteLine("Invalid selection. Try again.");
                        break;

                }
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}
