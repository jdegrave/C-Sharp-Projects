using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hong_Saw
{
    /// <summary>This application performs the Hong Saw functionality. It also uses a class specifically for calculating and printing the 
    /// results of the calculation. 	
    ///
    /// The use enter a starting number and and an ending number. Main checks to ensure that the ending number is larger than 
    /// the starting number; if not, it swaps the starting and ending numbers (no message is displayed). It also checks to ensure
    /// the user entered integers. If not, an error message displays in the text area where output displays. The message stays in
    /// the text area until the user enters the correct input. Main then calls a constructor from the CountAndPrint class and instantiates
    /// the CountAndPrint object.
    /// 
    /// The results of the CountAndPrint object is returned to the FinalOutput string and displayed in the text area.
    /// </summary>
    /// <author>Jodi A DeGrave</author>     
    /// <version>version 1.0.0</version>
    /// <return>Nothing since void is specified</return> 
    /// 
    


    public partial class frmHongSaw : Form
    {
        private int NumStart;
        private int NumEnd;
        private String FinalOutput = "";
        private int SwitchValues;
        public frmHongSaw()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textOutput.Text = "";
            textStartNumber.Text = "";
            textEndNumber.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                NumStart = Int32.Parse(textStartNumber.Text);
                NumEnd = Int32.Parse(textEndNumber.Text);

                //Switch Start and End values if the End value is less than the Start value
                if (NumEnd < NumStart)
                {
                    SwitchValues = NumStart;
                    NumStart = NumEnd;
                    NumEnd = SwitchValues;
                    textStartNumber.Text = Convert.ToString(NumStart);
                    textEndNumber.Text = Convert.ToString(NumEnd);
                }

                // CountAndPrint myResult = new CountAndPrint(NumStart, NumEnd); 
                CountAndPrint myResult = new CountAndPrint();
                myResult.startNum = NumStart;
                myResult.endNum = NumEnd;

                FinalOutput = myResult.getResult();
                textOutput.Text = FinalOutput;

            }
            catch (Exception wrongDataTypException)
            {
                textOutput.Text = "Please enter integers only for Start Number and End Number.";
                textStartNumber.Text = "";
                textEndNumber.Text ="";

            }
        }
    }
}