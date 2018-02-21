using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Example
{
    /// <summary>
    /// This is the Animal class. It is an abstract class, and the parent/super/base class to the following derived classes:
    /// --Cat.cs
    /// --Dog.cs
    /// </summary>
    /// <author> Jodi A DeGrave </author>
    /// <version> 1.0.0 </version>
    /// <remarks> The Animal class contains the following abstract methods: 
    ///            public abstract void MakeNoise(); <!--This method intends to prints out an animal sound in the derived classes-->   
    /// </remarks>
    /// <param name=" ">Does not take any parameters </param>
    /// <returns>Nothing - the return type is void</returns>
    public abstract class Animal
    {
        public abstract void MakeNoise();
    }
}
