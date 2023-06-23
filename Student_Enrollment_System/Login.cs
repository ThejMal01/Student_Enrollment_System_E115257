using System;
using System.Windows.Forms;

namespace Student_Enrollment_System
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string uN = txtUN.Text;
            string pw = txtPW.Text;

            if (uN == "admin" && pw == "123456")
            {
                MessageBox.Show("Successful Login", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //going to the Registration Form
                Registration Form3 = new Registration();
                Form3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                txtUN.Clear();
                txtPW.Clear();
                txtUN.Focus();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            //going to the Home Page (Form1)
            Form1 homePage = new Form1();
            homePage.Show();
            this.Hide();
        }

        private void txtPW_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
