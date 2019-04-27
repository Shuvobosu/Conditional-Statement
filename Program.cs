using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditional_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter the mathscore: ");
            int mathscore=Convert.ToInt32(Console.ReadLine()); //here i input a interger number from user

            if(mathscore < 0 || mathscore > 100)
            {
                Console.WriteLine("plz enter valid score.!");
            }
            else if(mathscore>=40) // checked the condition
            {
                Console.WriteLine("passed");
            }
            else
            {
                Console.WriteLine("failed");
            }
            Console.ReadKey();
        }
    }
}
