using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            *  Multi-line comment
            */

            string myName = "";     //Initialize a string variable to hold a name
            string myDOB = "";      //Initialize a string variable to hold a birthdate
            string myColor = "";    //Initialize a string variable to holda color

            Console.WriteLine("My Hello World Program...\n");
            Console.WriteLine();
            Console.Write("Enter your name:  ");
            myName = Console.ReadLine();

            Console.WriteLine("Hello, World! Hello, " + myName + "!");
            Console.WriteLine();

            Console.Write("What is your Date of Birth? Enter as DD/MM/YYYY:   ");
            myDOB = Console.ReadLine();
            Console.WriteLine("Your date of birth is"  + myDOB + ".");
            Console.WriteLine();

            Console.Write("What is your favorite color?   ");
            myColor = Console.ReadLine();
            Console.WriteLine("Your favorite color is " + myColor + ".");
            Console.WriteLine();

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();

        }
    }
}
