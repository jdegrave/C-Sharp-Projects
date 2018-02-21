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
        /// This Main () method receives a string from the console and first compares it to a string constant,
        /// and prints the results to the console. Then, it converts the user's input to each of the following data types:
        ///  -- int 
        ///  -- long 
        ///  -- float 
        ///  -- double 
        ///  -- decimal
        ///  
        ///  
        /// </summary>
        /// <author> Jodi A. DeGrave </author>
        /// <version> 1.0.0 </version>
        /// <remarks>  Here are some remarks </remarks>
        /// <param name="args">Is a string array from the command line arguments. </param>
        /// <returns> Nothing -- since void is specified. </returns>


        static void Main(string[] args)
        {

            //Declare a constant for comparison
            const string MYSTRINGTOCOMPARE = "salacious";

            //Declare variable for Console input. Console input is always treated as a string
            string myStringInput = "";    
              
            
            //Declare variables for conversion values     
  
            double myDouble1;       //holds the converted myStringInput value
            Boolean isANumber = false;
            object myInt1 = null;
            myInt1 = 0;
            //myString2 = "";
                       
            Console.WriteLine("My Lesson 2 Homework in C#");
            Console.WriteLine("This program checks what is entered, and if possible, converts"); 
            Console.WriteLine("whatever you enter to each of the following datatypes:");
            Console.WriteLine();
            Console.WriteLine("--int");
            Console.WriteLine("--long");
            Console.WriteLine("--float");
            Console.WriteLine("--double");
            Console.WriteLine("--decimal");
            Console.WriteLine();
            Console.WriteLine("If the value can't be converted to a number, a message displays.");
            Console.WriteLine("And then the string is compared to a Mystery Word and indicates if it's a match or not.");
            Console.WriteLine();

            Console.Write("Enter a string of at least one character:  ");
            myStringInput = Console.ReadLine();
            Console.WriteLine();
            

            //Convert to char. Uses substring method to ensure a string of only 1 character; also checks if no characters were entered
            try
            {
                Console.WriteLine("Your char value via 'Convert.ToChar(string).Substring(0,1)' method: " + Convert.ToChar(myStringInput.Substring(0, 1)));
                Console.WriteLine("Your char value via 'Char.Parse(string)' method: " + Char.Parse(myStringInput.Substring(0,1)));
                Console.WriteLine();              
            }
            catch
            {
                Console.WriteLine("You didn't enter any characters!");
            }
            Console.WriteLine();

            //Attempt to convert to boolean value
            try
            {
                Console.WriteLine("boolean via 'Convert.ToBoolean' method: " + Convert.ToBoolean(myStringInput));
                Console.WriteLine("boolean via 'Boolean.Parse' method: " + Boolean.Parse(myStringInput));
                Console.WriteLine("boolean via 'bool.Parse' method: " + bool.Parse(myStringInput));
            }
            catch
            {
                Console.WriteLine("Your entry can't be converted to a boolean value.");
                Console.WriteLine();
            }



            //Check to see if the entry is valid for conversion (i.e., it's a number of some kind)        
            try
            {
                myDouble1 = double.Parse(myStringInput);
                isANumber = true;                 
            }
            catch
            {
                Console.WriteLine("This string isn't 100% numeric, so numeric conversion isn't possible.");
                Console.WriteLine("Instead, I'll check it against the Mystery Word.");
                Console.WriteLine();
            }

            //Perform conversions
            if (isANumber)
            {
                myDouble1 = double.Parse(myStringInput);
                Console.WriteLine("Your value of " + myStringInput + " converted to: ");

                //Convert to integer via casting, Int32.Parse, and Convert.ToInt32 methods
                Console.WriteLine("int via casting a numerica value '(int)<numeric variable>': " + (int)myDouble1);
                try
                {
                    Console.WriteLine("int: " + Convert.ToInt32(myStringInput) + " (using the 'Convert.ToInt32(string)' method.");
                    Console.WriteLine("int: " + Int32.Parse(myStringInput) + "(using the 'Int32.Parse(string)' method.");
                        
                }

                catch
                {
                    Console.WriteLine("This number (" + myStringInput + ") can't be coverted to an integer using the 'Convert.ToInt32' method");
                    Console.WriteLine("or the 'Int32.Parse(string)' method.");
                }
                Console.WriteLine();


                //Convert to long via casting, Convert.ToInt64, long.Parse
                Console.WriteLine("long value using the casting method '(long)<numeric variable>': " + (long)myDouble1);
                try
                {
                    Console.WriteLine("long: " + Convert.ToInt64(myStringInput) + " using the 'Convert.ToInt64(string)' method.");
                    Console.WriteLine("long: " + long.Parse(myStringInput) + "using the 'long.Parse(string)' method.");
                   
                }
                catch
                {
                    Console.WriteLine("This number cant be converted to a long integer using the 'Convert.ToInt64(string)' method ");
                    Console.WriteLine("the 'long.Parse(string)' method. ");
                }
                Console.WriteLine();


                //Convert to float/single precision floating point via casting, Convert.ToSingle, and Single.Parse methods and float.Parse methods, 
                Console.WriteLine("float/single precision via cast '(float)<number variable>': " + (float)myDouble1);
                Console.WriteLine("float/single precision via 'Convert.ToSingle(string)' method: " + Convert.ToSingle(myStringInput));
                Console.WriteLine("float/single precision via 'float.Parse(string)' method: " + float.Parse(myStringInput));
                Console.WriteLine("float/single precision via 'Single.Parse(string)' method: " + Single.Parse(myStringInput));    
                Console.WriteLine();

                //Convert to double via Convert.ToDouble and double.Parse methods (casting not used because string was converted to double variable already
                Console.WriteLine("double via 'Convert.ToDouble(string)' method: " + Convert.ToDouble(myStringInput));
                Console.WriteLine("double via 'double.Parse(string)' method: " + double.Parse(myStringInput));
                Console.WriteLine("double via 'Double.Parse(string)' method: " + Double.Parse(myStringInput));
                Console.WriteLine();

                //Convert to decimal via casting, Convert.ToDecimal, and decimal.Parse methods
                Console.WriteLine("decimal via 'Convert.ToDecimal(string)' method: " + Convert.ToDecimal(myStringInput));
                Console.WriteLine("decimal via 'decimal.Parse(string)' method: " + decimal.Parse(myStringInput));
                Console.WriteLine("decimal via 'Decimal.Parse(string)' method: " + Decimal.Parse(myStringInput));
                Console.WriteLine();
              
            }

           
            if (myStringInput == MYSTRINGTOCOMPARE)
            {
                Console.WriteLine("Your entry, '" + myStringInput + "', matches the Mystery Word'" + MYSTRINGTOCOMPARE + "'.");
            }
            else
            {
                Console.WriteLine("Your entry, '" + myStringInput + "', doesn't match the Mystery Word.");
            }

            Console.ReadLine();

        }
    }

        
    }
