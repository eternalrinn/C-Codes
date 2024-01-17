using System;
using System.Linq;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        string[] fruits = { "apple", "orange", "grapes", "pineapple", "mango", "watermelon", "guava", "lemon", "kiwi", "dragonfruit" };
        int count = 0;

        while (true)
        {
            Console.Write("Enter fruit: ");
            string user = Console.ReadLine();

            if (fruits.Contains(user))
            {
                if (user.Length <= 5)
                {
                    Console.WriteLine($"{user} [{user.Length}] is short");
                }
                else
                {
                    Console.WriteLine($"{user} [{user.Length}] is long");
                }
                count++;
            }
            else
            {
                Console.WriteLine("Not in the list");
                count = 0;
                Thread.Sleep(1500);
                Console.Clear();
            }

            if (count == 10)
            {
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("FRUIT LIST");
                foreach (string fruit in fruits)
                {
                    Console.WriteLine($"{fruit} = {fruit.Length} letters");
                }
                Thread.Sleep(5000);
                break;
            }
        }
    }
}
