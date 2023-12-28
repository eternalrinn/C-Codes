using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("ADDITION PROGRAM\n\tEnter Num1: ");
                    double num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("\t\t+");
                    Console.Write("\tEnter Num2: ");
                    double num2 = double.Parse(Console.ReadLine());
                    Console.WriteLine("\tAnswer: " + (num1 + num2));

                }
                catch
                {
                    Console.WriteLine("Enter whole number only!");

                }
                Thread.Sleep(2000);
                Console.Clear();
            }
        }
    }
}
