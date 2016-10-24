using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        /// <summary>
        /// This main method explores "if" statements, ternary if statements, for loops, while loops (pre-test loop), do-while loops (post-test loop),
        /// and the use of "break" and/or "continue" statements.  
        /// </summary>
        /// <author> Jodi A De Grave</author>
        /// <remarks> 
        /// Since this is an excercise in control structures, the code here is not as efficient as it could be;
        /// for example, using the mod(modulus) operator) instead of a step (increment) of += 2.
        /// </remarks>
        /// <version> 1.0.0 </version>
        /// <param name="args">This is a string array from the command line prompts.</param>
        /// <returns> Returns nothing -- since voide is specified. </returns>
        static void Main(string[] args)
        {
            //To Do:  Do the To-Do assignments below in C#, then convert the code to Java

            //To-Do:  Replace the if-else block below with a ternary statement

            int myInteger = 6;
            string myString = "";

            Console.Write("Using the if statement: ");
            if (myInteger >=5)
            {
                myString = "-ge 5";
            }
            else
            {
                myString = "-lt 5";
            }

           Console.WriteLine(myString);
           Console.WriteLine();

           myString = (myInteger >= 5) ? "-ge 5" : "-lt5";

           Console.WriteLine("The answer using a ternary statetment: " + myString);
           Console.WriteLine();

           Console.WriteLine("Printing odd integers 1 thru 20 using a for loop: ");     
           for (int i = 1; i <= 20; i++)
           {
                // To-Do: Use one of the special loop commands below with an if statemtn
                // to only print odd numbers (this means "continue" or "break")

                if((i % 2) != 0)
                {
                    Console.WriteLine("int: " + i);
                }
                else
                {
                    continue;
                }                
            }
            Console.WriteLine();
             
            //To Do: Do a pretest loop with a counter to mimic the loop above
            Console.WriteLine("With a 'while' loop (pretest): ");
            int j = 1;
            while (j <= 20)
            {
                if ((j % 2) != 0)
                {
                    Console.WriteLine("int: " + j);
                }
                j++;
            }
            Console.WriteLine();

            // To Do: Do a post-test with a counter to mimic the loops above
            Console.WriteLine("With a 'Do' loop (post-test): ");
            int k = 1;
            do
            {
                if ((k % 2) != 0)
                {
                    Console.WriteLine("int: " + k);
                }
                k++;
            } while (k <= 20);

            Console.WriteLine();
            Console.WriteLine("Press enter to continue...");
            Console.ReadLine();
        }
    }
}
