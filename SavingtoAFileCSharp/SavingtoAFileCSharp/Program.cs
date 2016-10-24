using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;   


namespace SavingtoAFileCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            const int END = 999;
            const string DELIM = ",";
            const string FILENAME = "EmployeeData.txt";

            int empNum = 0;
            string empName = "";
            decimal empSalary = 0.00M;


            FileStream outfile = new FileStream(FILENAME, FileMode.Append, FileAccess.Write);

            StreamWriter writer = new StreamWriter(outfile);

            Console.Write("Please enter employee number or "+ END + " to quit: ");
            empNum = Convert.ToInt32(Console.ReadLine());   //convert to int - reading from console is always a string

            //Note: normally would have try Parse statements to ensure correct data is being entered
            while (empNum != END)
            {
                Console.Write("Please enter the employee last name: ");
                empName = Console.ReadLine();

                Console.Write("Please enter the employee's salary ");
                empSalary = Convert.ToDecimal(Console.ReadLine());

                writer.WriteLine(empNum + DELIM + empName + DELIM + empSalary);

                Console.Write("Please enter next employee number or " + END + " to quit: ");
                empNum = Convert.ToInt32(Console.ReadLine());

            }
            //Close the writer
            writer.Close();     //closes the data stream
            outfile.Close();   //closes the file

            Console.WriteLine("Press Enter to Continue...");
            Console.ReadLine();

        }
    }
}
