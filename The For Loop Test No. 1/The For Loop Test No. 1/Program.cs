using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
/* 
Hello.
*/

namespace The_For_Loop_Test_No._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Test No. 1";
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Enter the number of rows: ");

            int puser_ = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= puser_; i++)
            {
                for (int j = puser_; j > i; j--)
                {
                    Console.Write(" ");
                }

                for (int k = i; k > 0; k--)
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            for (int i = puser_ - 1; i >= 1; i--)
            {
                for (int l = puser_; l > i; l--)
                {
                    Console.Write(" ");
                }

                for (int n = i; n > 0; n--)
                {
                    Console.Write("* ");
                }
                
                Console.WriteLine();
            }

            
        }
    }
}
