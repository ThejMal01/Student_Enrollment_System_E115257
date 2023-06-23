using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.DomainUpDown;

namespace Student_Enrollment_System
{
    public partial class Registration : Form
    {
        bool changed = false;

        public Registration()
        {
            InitializeComponent();
        }

        private void btnAge_Click(object sender, EventArgs e)
        {
            int currentAge = DateTime.Today.Year - dateTimePicker1.Value.Year;

            if (currentAge >= 18)
            {
                txtAge.Text = currentAge.ToString();
            }
            else
            {
                MessageBox.Show("Cannot Enroll\nBelow 18 Years", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtRegNo_TextChanged(object sender, EventArgs e)
        {
            //Address of the DB
            string connectionString = "Data Source=DESKTOP-L3GR9BU\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True";

            //Establish Connection
            SqlConnection con = new SqlConnection(connectionString);

            //Open Connection
            con.Open();

            string regNo = txtRegNo.Text;

            if (System.Text.RegularExpressions.Regex.IsMatch(regNo, "[^0-9]"))
            {
                MessageBox.Show("Please Enter a Numeric Value", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegNo.Text = string.Empty;

            }
            else if (regNo != string.Empty)
            {

                SqlCommand cmd = new SqlCommand("SELECT * FROM Table_Student s, Table_Payment p WHERE s.RegNo = p.RegNo and s.RegNo = " + regNo + "", con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    btnDelete.Enabled = true;
                    btnInsert.Enabled = false;

                    //Display Details
                    txtStuName.Text = dr.GetValue(1).ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(dr.GetValue(2));
                    txtAge.Text = dr.GetValue(3).ToString();

                    if (dr.GetValue(4).ToString().Equals("M"))
                    {
                        checkBoxM.Checked = true;
                    }
                    else
                    {
                        checkBoxF.Checked = true;
                    }

                    txtCNo.Text = dr.GetValue(5).ToString();
                    domainUpDownSport.Text = dr.GetValue(6).ToString();
                    txtFee.Text = dr.GetValue(9).ToString();
                    txtDiscount.Text = dr.GetValue(10).ToString();
                    txtPay.Text = dr.GetValue(11).ToString();
                }
                else
                {
                    btnDelete.Enabled = false;
                    btnInsert.Enabled = true;

                    txtStuName.Text = string.Empty;
                    txtAge.Text = string.Empty;
                    dateTimePicker1.Text = string.Empty;
                    checkBoxM.Checked = false;
                    checkBoxF.Checked = false;
                    txtCNo.Text = string.Empty;
                    domainUpDownSport.Text = "Sport";
                    txtFee.Text = string.Empty;
                    txtDiscount.Text = "0";
                    txtPay.Text = string.Empty;
                }
                dr.Close();
            }
        }

        private void btnRegExit_Click(object sender, EventArgs e)
        {
            //going to the Login Page 
            Login Form2 = new Login();
            Form2.Show();
            this.Hide();
        }
        private void Registration_Load(object sender, EventArgs e)
        {
            DomainUpDownItemCollection list = this.domainUpDownSport.Items;
            list.Add("Badminton");
            list.Add("Swimming");
            list.Add("Chess");
            list.Add("Netball");
            list.Add("Football");

            domainUpDownSport.Text = "Select Sport";
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                //Address of the DB
                string connectionString = "Data Source=DESKTOP-L3GR9BU\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True";

                //Establish Connection
                SqlConnection con = new SqlConnection(connectionString);

                //Open Connection
                con.Open();

                string id = txtRegNo.Text;
                string regNo = txtRegNo.Text;
                string name = txtStuName.Text;
                string dob = dateTimePicker1.Text;
                string age = txtAge.Text;
                string gender;
                if (checkBoxM.Checked == true)
                {
                    gender = "M";
                }
                else if (checkBoxF.Checked == true)
                {
                    gender = "F";
                }
                else
                {
                    gender = string.Empty;
                }

                string contactNo = txtCNo.Text;
                string sport = domainUpDownSport.Text;
                string monthlyFee = txtFee.Text;
                string discount = txtDiscount.Text;
                string finalPayment = txtPay.Text;

                if (id != string.Empty && regNo != string.Empty && name != string.Empty && dob != string.Empty && age != string.Empty && gender != string.Empty && contactNo != string.Empty)
                {
                    SqlCommand cmd = new SqlCommand("SELECT * FROM Table_Student WHERE RegNo = " + regNo + "", con);
                    SqlCommand cmdSport = new SqlCommand("SELECT * FROM Table_Payment WHERE RegNo = " + regNo + "", con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();
                        MessageBox.Show("Already Registered");
                    }
                    else
                    {
                        if (domainUpDownSport.SelectedItem == null)
                        {
                            MessageBox.Show("Select The Sport");
                        }
                        else if (Int32.Parse(txtAge.Text) < 18)
                        {
                            MessageBox.Show("Cannot Enroll\nBelow 18 Years", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtAge.Clear();
                            dateTimePicker1.Value = DateTime.UtcNow;

                        }
                        else if (txtFee.Text == null || txtFee.Text == "" || txtFee.Text == "0")
                        {
                            MessageBox.Show("Monthly Fee cannot be 0 or null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else if (txtPay.Text == null || txtPay.Text == "" || txtPay.Text == "0")
                        {
                            MessageBox.Show("Final Payment cannot be 0 or null", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            //Close previous data reader
                            dr.Close();

                            //Insert Data
                            DateTime dobDateTime = DateTime.Parse(dob);
                            string insertQuery = "INSERT INTO Table_Student (RegNo, Name, DOB, Age, Gender, ContactNo, Sport) VALUES ('" + regNo + "', '" + name + "', '" + dobDateTime + "', '" + age + "', '" + gender + "','" + contactNo + "', '" + sport + "')";
                            string insertPaymentQuery = "INSERT INTO Table_Payment (RegNo, Sport, MonthlyFee, Discount, FinalPayment) VALUES ('" + regNo + "', '" + sport + "', '" + monthlyFee + "', '" + discount + "', '" + finalPayment + "')";

                            //Excute Query
                            SqlCommand sqlCmd = new SqlCommand(insertQuery, con);
                            SqlCommand sqlCmdSportPay = new SqlCommand(insertPaymentQuery, con);
                            sqlCmd.ExecuteNonQuery();
                            sqlCmdSportPay.ExecuteNonQuery();

                            //Close Connection
                            con.Close();

                            MessageBox.Show("New Student Registration Successful", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Complete All Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (Exception)
            {
                MessageBox.Show("Error While Saving Information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRegNo.Text = string.Empty;
            txtStuName.Text = string.Empty;
            txtAge.Text = string.Empty;
            dateTimePicker1.Value = DateTime.UtcNow;
            checkBoxM.Checked = false;
            checkBoxF.Checked = false;
            txtCNo.Text = string.Empty;
            domainUpDownSport.SelectedItem = string.Empty;
            txtFee.Text = "0";
            txtDiscount.Text = "0";
            txtPay.Text = string.Empty;
        }

        private void domainUpDownSport_SelectedItemChanged(object sender, EventArgs e)
        {
            if (domainUpDownSport.Text != "")
            {
                string sport = domainUpDownSport.Text.ToString();

                //Address of the DB
                string connectionString = "Data Source=DESKTOP-L3GR9BU\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True";

                //Establish Connection
                SqlConnection con = new SqlConnection(connectionString);

                //Open Connection
                con.Open();

                //Display Monthly Payment for the selected Sport
                SqlCommand cmdSport = new SqlCommand("SELECT MonthlyFee FROM Table_SportPayment WHERE Sport = '" + sport + "'", con);
                SqlDataReader dr = cmdSport.ExecuteReader();
                if (dr.Read())
                {
                    txtFee.Text = dr.GetValue(0).ToString();
                }
                else
                {
                    txtFee.Text = "0";
                }
                dr.Close();
            }
            else
            {
                MessageBox.Show("Select The Sport Again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
            float discount;

            if (txtDiscount.Text == "")
            {
                discount = 0;
            }
            else
            {
                discount = float.Parse(txtDiscount.Text);
            }

            if (discount > 40 || discount < 0)
            {
                MessageBox.Show("Discount Should Be Between 0 - 40%", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); ;
            }
            else
            {
                calculateFinalPayment(float.Parse(txtFee.Text), discount);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //Address of the DB
            string connectionString = "Data Source=DESKTOP-L3GR9BU\\SQLEXPRESS;Initial Catalog=StudentDB;Integrated Security=True";

            //Establish Connection
            SqlConnection con = new SqlConnection(connectionString);

            //Open Connection
            con.Open();

            string regNo = txtRegNo.Text;

            if (regNo != string.Empty)
            {

                SqlCommand cmdDelete = new SqlCommand("SELECT * FROM Table_Student WHERE RegNo = " + regNo + " ", con);
                SqlDataReader dr = cmdDelete.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();

                    //Confirm Delete
                    DialogResult result = MessageBox.Show("Are you sure you want to delete the User?", "User Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (result == DialogResult.Yes)
                    {
                        //Delete Data
                        string deleteQuery = "DELETE FROM Table_Student WHERE RegNo = " + regNo + " ";

                        //Excute Query
                        SqlCommand sqlCmd = new SqlCommand(deleteQuery, con);
                        sqlCmd.ExecuteNonQuery();

                        //Close Connection
                        con.Close();
                        MessageBox.Show("Student Deleted Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    MessageBox.Show("Enter Valid Regisration Id", "Done", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dr.Close();
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int currentAge = DateTime.Today.Year - dateTimePicker1.Value.Year;
            txtAge.Text = currentAge.ToString();
        }

        private void txtCNo_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtCNo.Text, "[^0-9]"))
            {
                MessageBox.Show("Please Enter a Valid Phone Number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCNo.Text = string.Empty;
            }
        }

        private void txtPay_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateFinalPayment(float fee, float discount)
        {
            txtPay.Text = (fee * ((100 - discount) / 100)).ToString();
        }

        private void txtFee_TextChanged(object sender, EventArgs e)
        {
            if (txtFee.Text == "")
            {
                txtFee.Text = "0";
            }
            calculateFinalPayment(float.Parse(txtFee.Text), float.Parse(txtDiscount.Text));
        }

        private void checkBoxM_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBoxM.Checked)
            {
                checkBoxF.Checked = false;
            }
        }

        private void checkBoxF_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxF.Checked)
            {
                checkBoxM.Checked = false;
            }
        }
    }
}
