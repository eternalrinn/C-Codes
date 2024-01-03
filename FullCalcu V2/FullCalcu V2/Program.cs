using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FullCalcu_V2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool contiee = true;
            while (contiee == true)
            {
                double x, y;
                string ops, again;
                try
                {
                    InputTwoNum(out x, out y);
                }
                catch
                {
                    Console.WriteLine("Numbers only!");
                    Thread.Sleep(500);
                    Console.Clear();
                    continue;
                }
                do
                {
                    try
                    {
                        ChooseOperator(out ops, x, y);
                    }
                    catch
                    {
                        Console.WriteLine($"1-4 Only");
                        Thread.Sleep(500);
                        Console.Clear();
                        continue;
                    }
                    break;
                }

                while (true);
                Console.WriteLine("Would you like to continue? Y or N");
                string answer = Console.ReadLine();
                if (answer == "Y".ToLower())
                {
                    contiee = true;
                }
                else if (answer == "N".ToLower())
                {
                    Console.WriteLine("Thanks for using the program!");
                    Thread.Sleep(1000);
                    contiee = false;
                }
                Console.Clear();

            }


        }
        private static void InputTwoNum(out double x, out double y)
        {
            Console.Write("--CALCULATOR PROGRAM--\n\tEnter num1: ");
            x = double.Parse(Console.ReadLine());
            Console.Write("\tEnter num2: ");
            y = double.Parse(Console.ReadLine());
        }
        private static void ChooseOperator(out string ops, double x, double y)
        {
            Console.WriteLine("CHOOSE AN OPERATOR [1-4]\n\t1.[+]ADDITION\n\t2.[-]SUBTRACTION\n\t3.[*]MULTIPLICATION\n\t4.[/]DIVISION");
            ops = Console.ReadLine();
            if (ops != "1" && ops != "2" && ops != "3" && ops != "4") 
            {
                throw new InvalidOperationException();
            }
            switch(ops)
            {
                case "1":
                    Console.WriteLine("\tAnswer: " + (x + y));
                    break;
                case "2":
                    Console.WriteLine("\tAnswer: "+(x - y));
                    break;
                case "3":
                    Console.WriteLine("\tAnswer: " + (x * y));
                    break;
                case "4":
                    if (y != 0)
                    {
                        Console.WriteLine("\tAnswer: " + (x / y));
                    }
                    else
                    {
                        Console.WriteLine("\tCannot divide by zero!");
                    }
                    break;
                default:
                    Console.WriteLine("1-4 ONLY");
                    break;


            }
        }
    }
}
