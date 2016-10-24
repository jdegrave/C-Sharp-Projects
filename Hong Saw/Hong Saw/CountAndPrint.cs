using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hong_Saw
{
    ///	Public class Count And Print performs the Hong Saw calculations as follows:
    /// Any number divisible by 3, it appends the word "Hong"to the results string
    /// Any number divisible by 5, it appends the word "Saw" to the results string
    /// Any number divisible by 3 and 5, it appends the word "Hong Saw" to the results string.
    /// If the number is divisible neither 3 nor 5, it appends the value of the number to the results string.
    /// 
    /// <author>Jodi A DeGrave</author> 
    /// <version>1.0.0</version> 
    /// <param name="">there are several constructors which initialize the starting and end numbers for a CountAndPrint object</param>
    /// <returns>A String containing the results of the calculations</returns>

    public class CountAndPrint
    {



        private int _startNum;
        private int _endNum;
        private String Hong = "Hong";
        private String Saw = "Saw";
        private String HongSaw = "HongSaw";

        //This is a constructor
        public CountAndPrint()
        {
            _startNum = 0;
            _endNum = 0;
            
        
        }

        public CountAndPrint(int NumberStart, int NumberEnd)
        {
            
            _startNum = NumberStart;
            _endNum = NumberEnd;

        }


        public int startNum
        {  // manually implemented Property
            get
            {
                return this._startNum;
            }
            set
            {
                _startNum = value;
            }
        }

        public int endNum // automatically implemented Property
        {
            get;
            set;
        }


        public String getResult()
        {

            String FinalOutput = "";

            for (int i = startNum; i <= endNum; i++)
            {
                if (((i % 3) == 0) & ((i % 5) == 0))
                    FinalOutput = FinalOutput + " " + HongSaw;
                else if ((i % 3) == 0)
                    FinalOutput = FinalOutput + " " + Hong;
                else if ((i % 5) == 0)
                    FinalOutput = FinalOutput + " " + Saw;
                else
                    FinalOutput = FinalOutput + " " + i;

                if (i != endNum)
                    FinalOutput = FinalOutput + ", ";
            }

            return FinalOutput;

        }


    }
}   //end class

