using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewPersonExample
{
    class TestPerson
    {
        static void Main(string[] args)
        {
            Person joe = new Person();
            joe.Name = "joe";
            Console.WriteLine(joe.Name);
            Console.ReadLine();
        }
    }

    public class Person
    {
        //Attributes
        private String strName;
        private String strAddress;

        //Methods
        public String Name
        {
            get { return strName; }
            set { strName = value; }
        }

        public String Address
        {
            get { return strAddress; }
            set { strAddress = value; }
        }
    } 
}
