using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_statement_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Add num 1 ");
            string one = Console.ReadLine();

            if (one == "3")
            {
                Console.WriteLine("Correct");

            }
            else
            {
                Console.WriteLine("Game Over");
                Console.ReadKey();
                Environment.Exit(0);
            }

            Console.Write("\nAdd num 2 ");
            string two = Console.ReadLine();

            if (two == "3")
            {
                Console.WriteLine("Correct");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Game Over");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
