using System;

using ConsoleCalculatorB2A.Operations;
using ConsoleCalculatorB2A.ErrorHandling;




namespace ConsoleCalculatorB2A
{
    public class Calculator
    {
        
        
        
        int menuSelection;
        public void StartCalculator()
        {
            while (true)
            {
                var errorHandler = new InvalidIO();

                Console.WriteLine("0 - Exit Application");
                Console.WriteLine("1 - Addition");
                Console.WriteLine("2 - Subtraction");
                Console.WriteLine("3 - Multiplication");
                Console.WriteLine("4 - Division");
                Console.WriteLine();
                Console.Write("Make a selection:> ");

                if (!int.TryParse(Console.ReadLine(), out menuSelection))
                {
                    errorHandler.InvalidInput();
                    continue;
                }

                if (menuSelection == 0) break;
                Console.Clear();
                switch (menuSelection)
                {
                    case 1:
                        new Addition().Add();
                        break;
                    case 2:
                        new Subtraction().Subtract();
                        break;
                    case 3:
                        new Multiplication().Multiply();
                        break;
                    case 4:
                        new Division().Divide();
                        break;
                    default:
                        errorHandler.InvalidSelection();
                        break;

                }
                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey();
                Console.Clear();

            }
        }
    }
}