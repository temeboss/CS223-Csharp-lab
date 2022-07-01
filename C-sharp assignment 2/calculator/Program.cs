using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String answ;
            do { 
                Console.Clear();
            int num1, num2, option;
            Console.WriteLine("Enter your first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("1. ADDITION");
            Console.WriteLine("2. DIFFRENCE");
            Console.WriteLine("3. MULTIPLICATION");
            Console.WriteLine("4. DIVISION");
            Console.WriteLine("CHOOSE YOUR OPTION: ");
            option = Convert.ToInt32(Console.ReadLine());


            if (option == 1)
            {
                Console.WriteLine("The addition between is numbers are: " + (num1 + num2));
            }
           else if (option == 2)
            {
                Console.WriteLine("The diffrence between is numbers are: " + (num1 - num2));
            }
           else if (option == 3)
            {
                Console.WriteLine("The multiplication between is numbers are: " + (num1 * num2));
            }
            
            else if (option == 4)
            {
                Console.WriteLine("The division between is numbers are: " + (num1 / num2));
            }
            else
                {
                    Console.WriteLine("WRONG INPUT");
                }
                Console.WriteLine("Do you want to contiune say yes if not press any key");
                  answ = Console.ReadLine();

            } while (answ == "yes" );

        }
    }
}
