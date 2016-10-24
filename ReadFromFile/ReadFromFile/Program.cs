using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace ReadFromFile
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
            int fileLineCounter = 0;

            FileStream infile = new FileStream(FILENAME, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(infile);

            string recordIn = "";
            string[] employee;

            recordIn = reader.ReadLine();   //priming read

            while (recordIn != null)
            {
                employee = recordIn.Split(Convert.ToChar(DELIM));
                empNum = Convert.ToInt32(employee[0]);
                empName = employee[1];
                empSalary = Convert.ToDecimal(employee[2]);

                Console.WriteLine(String.Format("Line #{0} Employe Number#: {1}", fileLineCounter, empNum));
                Console.WriteLine(String.Format("Line #{0} Name: {1}", fileLineCounter, empName));
                Console.WriteLine(String.Format("Line #{0} Salary: {1:C2} \n", fileLineCounter, empSalary));

                fileLineCounter++;
                recordIn = reader.ReadLine();
            }

            reader.Close();
            infile.Close();

            Console.WriteLine("Please press Enter to Continue...");
            Console.ReadLine();
        }
    }
}
