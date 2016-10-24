using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ErrorHandlingConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //throw new Exception("My error!");    //if you comment this out, the finally block will catch the error
                //throw new DivideByZeroException("My Error!");
                int z = 0;
                int i = 5 / z;
                
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("In Divide By Zero Block");
            }

            catch(Exception e) {
                Console.WriteLine("In catch block.");
                Console.ReadLine();
           }

           finally
           {
               Console.WriteLine("In finally block.");
               Console.ReadLine();
           }

         }
       }
}
