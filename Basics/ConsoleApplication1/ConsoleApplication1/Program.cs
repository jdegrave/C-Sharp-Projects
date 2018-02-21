using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Java_Csharp_Lesson2
{
    class Program
    {
        /// <summary>
        /// This Main () method shows how to use different data types.
        /// This special type ofcomment precedes the item to be documented
        /// </summary>
        /// <author> Jodi A. DeGrave </author>
        /// <version> 1.0.0 </version>
        /// <remarks>  Here are some remarks </remarks>
        /// <param name="args">Is a string array from the command line arguments. </param>
        /// <returns> Nothing -- since void is specified. </returns>
        static void Main(string[] args)
        {



            //Declare some local constants
            const double MY_PI = 3.14159;
            const string SCHOOL_NAME = "Northwest Technical Institute";

            //Declare some variables of varying data types below.
            string myString1 = "Class Period";
            string myString2 = " # 2";
            string myString3;

            char myChar1 = 'a';
            char myChar2 = 'b';

            int myInt1 = 5;
            int myInt2 = 10;

            long myLong1 = 555555555555555;
            long myLong2 = 666666666666666;

            float myFloat2 = (float)23.001;     //  use parenthese to cast the floating point number to float
            float myFloat1 = 42.002f;            //  use the "f" appended suffix to cast to float

            double myDouble1 = 123.456;
            double myDouble2 = 654.321;

            decimal myDecimal1 = (decimal)500.00;    //  use parentheses to cast hte floating point number to decimal
            decimal myDecimal2 = 1000.50m;          //  use the "m" appended suffix to cast to decimal ("m" = money or the old currency format)

            bool myBool1 = true;
            bool myBool2 = false;

            double myRadius = 10.00;
            double myArea;
            
            //Start input and conversion section 
            String tempInput = "";              //setup a temporary variable for input 

            //Convert the first character of a string to char
            Console.Write("Please enter a char value: ");
            tempInput = Console.ReadLine();
            myChar1 = Convert.ToChar((tempInput.Trim()));
            Console.WriteLine("Your char value: " + tempInput);

            Console.Write("Please enter an integer value: ");
            tempInput = Console.ReadLine();
            myInt1 = Convert.ToInt32(tempInput);
            Console.WriteLine("Your int value: " + myInt1);

            Console.Write("Please enter a long integer value: ");
            tempInput = Console.ReadLine();
            myLong1 = Convert.ToInt64(tempInput);
            Console.WriteLine("Your long integer value:" + myLong1);

            Console.Write("Please enter a float (a.k.a. 'single' or 'single precision' or single precision floating point value: ");
            tempInput = Console.ReadLine();
            myFloat1 = Convert.ToSingle(tempInput);
            Console.WriteLine("Your float/single or single precision floating point value:" + myFloat1);

            Console.Write("Please enter a double value: ");
            tempInput = Console.ReadLine();
            myDouble1 = Convert.ToDouble(tempInput);
            Console.WriteLine("Your double value: " + myDouble1);

            Console.Write("Please enter a decimal value: ");
            tempInput = Console.ReadLine();
            myDecimal1 = Convert.ToDecimal(tempInput);
            Console.WriteLine("Your decimal value: " + myDecimal1);
            Console.WriteLine();



            Console.WriteLine("My Lesson 2 Examples in C#");
            myArea = MY_PI * Math.Pow(myRadius, 2.0);       //raise a number to a power
            myArea = Math.PI * Math.Pow(myRadius, 2.0);       //using the built-in PI constant of the Math calsss
            Console.WriteLine("My area is: " + myArea.ToString());

            Console.WriteLine("My chars are: " + myChar1 + myChar2);

            myString3 = myString1 + myString2;
            Console.WriteLine("My strings are: " + myString3);

            Console.WriteLine("The sum of my integers are: " + myInt1 + myInt2.ToString());

            Console.WriteLine("The sum of my longs are: " + (myLong1 + myLong2));

            Console.WriteLine("The sume of my floats / single precision floating points are: " + (myFloat1 + myFloat2));

            Console.WriteLine("The sum of my doubles / double precision floating points are: " + (myDouble1 + myDouble2));

            Console.WriteLine("The sum of my decimal / currency amounts are: " + (myDecimal1 + myDecimal2));

            Console.WriteLine("The result of myBool1 AND myBool2 is: " + (myBool1 && myBool2) + "\n");

            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
        }
    }
}
