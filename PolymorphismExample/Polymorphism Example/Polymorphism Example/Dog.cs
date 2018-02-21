using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Example
{
    /// <summary>
    /// This is a derived concrete class which inherits from the abstract parent class "Animal" 
    /// </summary>
    /// <author>Jodi A. DeGrave </author>
    /// <version> 1.0.0. </version>
    /// <remarks> 
    /// This Dog class provides the polymorphic implementation of the MakeNoise method 
    /// from the abstract class "Animal" and prints out the Dog sound.
    /// </remarks>
    /// <param name=" ">Does not take any parameters - empty</param>
    /// <returns> Nothing - since the return type is void</returns>
    
    public class Dog : Animal
    {
        public override void MakeNoise()
        {
            Console.WriteLine("Bark!");
        }
    }
}
