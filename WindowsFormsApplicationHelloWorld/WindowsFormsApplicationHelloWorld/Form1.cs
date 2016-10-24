using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplicationHelloWorld
{
    public partial class frmHelloWorld : Form
    {
        public frmHelloWorld()
        {
            InitializeComponent();
        }

        private void frmHelloWorld_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World! Hello, " + txtName.Text + "!", "Hello World!",
                MessageBoxButtons.OK);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNewWindow_Click(object sender, EventArgs e)
        {
            NewForm frmNewForm = new NewForm();
            frmNewForm.Show();
        }
    } 
}
