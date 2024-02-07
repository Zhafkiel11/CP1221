using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act1Calc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String value;
            do
            {
                int res;
                Console.WriteLine("Enter 1st Number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter 2nd Number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a symbol(/,+,-,*): ");
                String symbol = Console.ReadLine();




                switch (symbol)
                {
                    case "+":
                        res = num1 + num2;
                        Console.WriteLine("addition: " + res);
                        break;
                    case "-":
                        res = num1 - num2;
                        Console.WriteLine("Subtraction: " + res);
                        break;
                    case "*":
                        res = num1 * num2;
                        Console.WriteLine("Multiplication: " + res);
                        break;
                    case "/":
                        res = num1 / num2;
                        Console.WriteLine("Division: " + res);
                        break;
                    default:
                        Console.WriteLine("Wrong Input");
                        break;

                }
                Console.ReadLine();

                Console.WriteLine("Do you want to continue? y/n");

                value = Console.ReadLine();
            }
            while (value == "y" || value == "Y"); 
        }
    }
}


