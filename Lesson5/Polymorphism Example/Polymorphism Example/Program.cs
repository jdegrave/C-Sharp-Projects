using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable 1584,1711,1572,1581,1580

namespace Polymorphism_Example
{
    /// <summary>
    /// This Demo program seeks to provide insight and learning opportunities into the concept of polymorphism,
    /// inheritance, and encapsulation - the founding principles of OO design. 
    /// The Demo program creates two Animal objects instantiated in the form of a Cat object and a Dog object, and 
    /// then prints out the results of "MakeNoise" a polymorphic method.
    /// </summary>
    /// <author> Jodi A De Grave </author>
    /// <version> 1.0.0 </version>
    /// <remarks> 
    /// The Demo program contains the Main method. It uses the following classes from which it instantiates objects exhibiting
    /// polymorphism, inheritance, and encapsulation :
    ///   -- Animal.cs  - This file is the superclass/parent class/base class from which the derived class inherit. 
    ///   -- Dog.cs - This file is a child/sub class of the Animal class. It inherits a method from the parent class "Animal"
    ///   -- Cat.cs - This file is a child/sub class of the Animal class. It inherits a method from the parent class "Animal"
    /// </remarks>
    /// <param name= "args"> Is a string argument that takes command line arguments </param>
    /// <returns> Nothing since void is specified</returns>
    /// 
    public class Demo
    {
        
        static void Main(string[] args)
        {
            
            Animal a1 = new Cat();
            a1.MakeNoise();     //Prints a meow

            Animal a2 = new Dog();
            a2.MakeNoise();       //Prints bark

            Console.WriteLine();
            Console.WriteLine("Press Enter to continue ");
            Console.ReadLine();
        }
        
    } 
        
}
