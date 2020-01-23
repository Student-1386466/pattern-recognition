using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pattern_recog_23_01_20
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nWelcome to 'MATHsQUIZ'");

            Console.WriteLine("\nLets Start the GAME... ...");

            Console.WriteLine("/nQ-01 : What is the square of 6?" +
                " Your Options are ::" +
                "  a) 12" +
                "  b) 36");
            string ansOne = Console.ReadLine();
           

            if (ansOne == "36")
          
            {
                Console.WriteLine("Correct Answer.... Your Score is 1");
                Console.WriteLine("Q-02 : What is 9*8=" +
                    " Your Options are ::" +
                    "  a) 81" +
                    "  b) 72");
                string ansTwo = Console.ReadLine();
                
                if( ansTwo == "72")
                {
                    Console.WriteLine("Correct Answer... Your Score is 2");
                    Console.WriteLine("Q-03 : What is 50 / 5 =" +
                        " Your Options are ::" +
                        "  a) 10" +
                        "  b) 9");
                    string ansThree = Console.ReadLine();
                    if( ansThree == "10")
                    {
                       Console.WriteLine("Correct Answer.... Your score is 3");
                        Console.WriteLine("Q-04 : what is 129 - 83=" +
                            " Your Options are ::" +
                            "  a) 46" +
                            "  b) 56");
                        string ansFour = Console.ReadLine();
                        if (ansFour == "46")
                        {
                            Console.WriteLine("Correct Answer ... Your Score is 4");
                            Console.WriteLine("Q-05 : What is 64 + 98 =" +
                                " Your Options are ::" +
                                "  a) 162" +
                                "  b) 172");
                            string ansFive = Console.ReadLine();
                            if (ansFive == "162")
                            {
                                Console.WriteLine("Correct Answer .... Your Score is 5");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect Answer.... GAME OVER.... Your Score is 4.... Better Luck Next Time");
                            }

                        }
                        else
                        {
                            Console.WriteLine("Incorrect Answer.... GAME OVER.... Your Score is 3.... Better Luck Next Time");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Incorrect Answer.... GAME OVER.... Your Score is 2.... Better Luck Next Time");
                    }
                }
                else
                {
                    Console.WriteLine("Incorrect Answer.... GAME OVER.... Your Score is 1.... Better Luck Next Time");
                }
            }
            else
            {
                Console.WriteLine("Incorrect Answer.... GAME OVER.... Your Score is 0.... Better Luck Next Time");
                Console.ReadKey();
            }
        }
    }
}
