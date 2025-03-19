using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace The_For_Loop_Test_No._1 // This is honestly a terrible name, I don't know what I was thinking way back when :/
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Test No. 1";
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Enter the number of rows: "); 

            int puser_ = Convert.ToInt32(Console.ReadLine()); // Storing number of rows user wants to print

            for (int i = 1; i <= puser_; i++) // This for loop is to print the top half of the diamond
            {
                for (int j = puser_; j > i; j--) 
                /*
                    If you consider the top half of a diamond, it is shaped almost like a pyramid - with more blank spaces than solid spaces at the top (e.g. " " as opposed to the solid "*").
                    As such, we are setting the minimum condition to the higher value "puser_" and having it run against the number of solid spaces that the user has indicated they want.
                    By doing this, we ensure that more spaces and less solids are written INITIALLY, and that this ratio flips as the loop nears its end condition.
                */
                {
                    Console.Write(" ");
                }

                for (int k = i; k > 0; k--) 
                /* 
                    The logic for this is flipped in that we are ensuring that less solids are written INITIALLY, and that the amount of solids increase with each
                    row. So, by the end, there will be more solids than spaces, rounding out the diamond's top half.
                */
                {
                    Console.Write("* ");
                }

                Console.WriteLine();
            }

            for (int i = puser_ - 1; i >= 1; i--)
            {
                /* 
                    Essentially the "reverse" logic of the first nested loop. 
                */
                for (int l = puser_; l > i; l--) // Less spaces and more solids at the beginning, but ratio flips as end condition is reached
                {
                    Console.Write(" ");
                }

                for (int n = i; n > 0; n--) // Vice versa, more solids and less spaces at the beginning, but ratio flips as end condition is reached
                {
                    Console.Write("* ");
                }
                
                Console.WriteLine();
            }

            
        }
    }
}
