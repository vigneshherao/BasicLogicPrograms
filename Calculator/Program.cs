 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String value;
            do
            {
                Console.WriteLine("First number");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("symbol");
                String symbol = Console.ReadLine();
                Console.WriteLine("Second number");
                int num2 = Convert.ToInt32(Console.ReadLine());
                switch (symbol)
                {
                    case "+":
                        Console.WriteLine(num1 + num2);
                        break;
                    case "-":
                        Console.WriteLine(num1 - num2);
                        break;
                    case "*":
                        Console.WriteLine(num1 * num2);
                        break;
                    case "/":
                        Console.WriteLine(num1 / num2);
                        break;
                    case "%":
                        Console.WriteLine(num1 % num2);
                        break;

                    default:
                        Console.WriteLine("wrong input");
                        break;
                }
                Console.WriteLine("Do you want to continue press Y|y or Exit N|n");
                value = Console.ReadLine();
            } while (value == "Y" || value == "y");
        }
    }
}
