using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user = "";
            string pw = "";
            string user_signup = "";
            string pw_signup = "";
            string pet = "";
            string birthplace = "";
            string crush = "";
            string recovery = "";
            string new_pw = "";
            string new_user = "";
            string rec1 = "";
            bool wrongpass = true;


            while (wrongpass)
            {
                Console.WriteLine("[1]LOGIN\n[2]SIGNUP");
                string l_s = Console.ReadLine();

                if (l_s == "2")
                {
                    if (user_signup == "" && pw_signup == "")
                    {
                        Console.Clear();
                        Console.WriteLine("\tSIGNUP");
                        Console.WriteLine("\nCreate a Username: ");
                        user_signup = Console.ReadLine();
                        Console.WriteLine("\nCreate a Password: ");
                        pw_signup = Console.ReadLine();
                        Console.WriteLine("Confirm password? Y or N");
                        string confirm = Console.ReadLine();

                        if (confirm == "Y".ToLower())
                        {
                            Console.WriteLine("Succesfully created an account");
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("Choose a recovery question incase you forgot your password : \n[1] Pet name\n[2] Birthplace\n[3] Crush name");
                            recovery = Console.ReadLine();
                            Thread.Sleep(500);
                            Console.Clear();
                            switch (recovery)
                            {
                                case "1":
                                    {
                                        rec1 = "Pet";
                                        Console.WriteLine("Enter your pet name: ");
                                        pet = Console.ReadLine();
                                        Console.WriteLine($"Your recovery answer is {pet}");
                                        break;
                                    }
                                case "2":
                                    {
                                        rec1 = "Birthplace";
                                        Console.WriteLine("Enter your birthplace: ");
                                        birthplace = Console.ReadLine();
                                        Console.WriteLine($"Your recovery answer is {birthplace}");
                                        break;
                                    }
                                case "3":
                                    {
                                        rec1 = "Crush";
                                        Console.WriteLine("Enter your crush name: ");
                                        crush = Console.ReadLine();
                                        Console.WriteLine($"Your recovery answer is {crush}");
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Choose [1-3]");
                                        break;
                                    }
                            }
                        }
                        else if (confirm == "N".ToLower())
                        {
                            Thread.Sleep(500);
                            Console.Clear();
                            Console.WriteLine("\nRe-enter your password");
                            pw_signup = Console.ReadLine();
                            Console.WriteLine("Succesfully created an account");
                            Thread.Sleep(1000);
                            Console.Clear();
                            Console.WriteLine("Choose a recovery question incase you forgot your password: \n[1]Pet name\n[2]Birthplace\n[3]Crush name");
                            recovery = Console.ReadLine();
                            Thread.Sleep(500);
                            Console.Clear();
                            switch (recovery)
                            {
                                case "1":
                                    {
                                        rec1 = "Pet";
                                        Console.WriteLine("Enter your pet name: ");
                                        pet = Console.ReadLine();
                                        Console.WriteLine($"Your recovery answer is {pet}");
                                        break;
                                    }
                                case "2":
                                    {
                                        rec1 = "Birthplace";
                                        Console.WriteLine("Enter your birthplace: ");
                                        birthplace = Console.ReadLine();
                                        Console.WriteLine($"Your recovery answer is {birthplace}");
                                        break;
                                    }
                                case "3":
                                    {
                                        rec1 = "Crush";
                                        Console.WriteLine("Enter your crush name: ");
                                        crush = Console.ReadLine();
                                        Console.WriteLine($"Your recovery answer is {crush}");
                                        break;
                                    }
                                default:
                                    {
                                        Console.WriteLine("Choose [1-3]");
                                        break;
                                    }
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("You already have an account, go login!");
                    }
                   
                    Thread.Sleep(1000);
                    Console.Clear();


                }
                else if (l_s == "1")
                {
                    int attempt = 0;
                    int max_attempt = 3;
                    string recovery_answer = "";
                    string new_confirm;

                    if (user_signup == "" && pw_signup == "")
                    {
                        Console.WriteLine("Must create an account first");
                        Thread.Sleep(1000);
                        Console.Clear();
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("\tLOGIN");
                        Console.WriteLine("\nEnter your username: ");
                        user = Console.ReadLine();

                        do
                        {
                            while (user != user_signup)
                            {
                                Console.WriteLine("Invalid username");
                                Thread.Sleep(1000);
                                Console.Clear();
                                Console.WriteLine("\nRe-enter your username");
                                attempt += 1;
                                if (attempt == max_attempt)
                                {
                                    Console.WriteLine("Forgot username or password");
                                    Thread.Sleep(500);
                                    Console.WriteLine("Answer the recovery option");
                                    Thread.Sleep(500);
                                    Console.WriteLine($"Who is your {rec1}");
                                    recovery_answer = Console.ReadLine();
                                }
                                user = Console.ReadLine();
                                Thread.Sleep(500);
                            }

                            Console.WriteLine("Enter your password: ");
                            pw = Console.ReadLine();

                            while (pw != pw_signup)
                            {
                                Console.WriteLine("Invalid password");
                                Thread.Sleep(500);
                                Console.Clear();
                                Console.WriteLine("\nRe-enter your password");
                                attempt += 1;
                                if (attempt == max_attempt)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Forgot password");
                                    Thread.Sleep(500);
                                    Console.WriteLine("Answer the recovery option");
                                    Thread.Sleep(500);
                                    Console.WriteLine($"Who is your {rec1}");
                                    recovery_answer = Console.ReadLine();

                                    if (recovery_answer == pet || recovery_answer == birthplace || recovery_answer == crush)
                                    {
                                        Console.Clear();
                                        Console.WriteLine("Enter your new password: ");
                                        new_pw = Console.ReadLine();
                                        Console.WriteLine("Confirm password? Y or N");
                                        new_confirm = Console.ReadLine();
                                        if (new_confirm == "Y".ToLower())
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Enter your password: ");
                                            pw = Console.ReadLine();
                                            if (pw == new_pw)
                                            {
                                                Console.WriteLine("Successfully login");
                                                Thread.Sleep(2000);
                                                wrongpass = false;
                                                break;
                                            }
                                        }
                                        else if (new_confirm == "N".ToLower())
                                        {
                                            Console.WriteLine("\nRe-enter your password");
                                            pw = Console.ReadLine();
                                            Thread.Sleep(500);
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Account is locked for security purposes");
                                    }
                                }
                                pw = Console.ReadLine();
                                Thread.Sleep(500);
                            }

                            if (user == user_signup && pw == pw_signup)
                            {
                                Console.WriteLine("Successfully Login");
                                Thread.Sleep(2000);
                                wrongpass = false;
                            }
                        } while (wrongpass);
                    }
                }
            }
          
        }
    }
}
