using System;
using System.Windows.Forms;

namespace Student_Enrollment_System
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnContinue_Click(object sender, EventArgs e)
        {
            //going to the Login Page 
            Login Form2 = new Login();
            Form2.Show();
            this.Hide();
        }
        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
