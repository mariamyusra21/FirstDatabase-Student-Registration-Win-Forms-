using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace FirstDatabase
{
    public partial class StudentInfoForm : Form
    {
        public StudentInfoForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            String connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (SqlConnection connection = new SqlConnection(connString))
            {
                if (PhNumberTextBox.TextLength == 11)
                {
                    connection.Open();

                    //string query = "INSERT INTO StudentInfo(Name, Email) VALUES(@Name,@Email)";

                    string storedInsertProc = @"dbo.[userproc_StudentInsertDetail]";

                    using (SqlCommand sqlCommand = new SqlCommand(storedInsertProc, connection))
                    {
                        sqlCommand.CommandType = CommandType.StoredProcedure;
                       
                        // Parameters for StudentInsetDetails

                        // sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value = NameTextBox.Text;
                        sqlCommand.Parameters.AddWithValue("@Name", NameTextBox.Text);
                        sqlCommand.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                        sqlCommand.Parameters.AddWithValue("@PhoneNumber", PhNumberTextBox.Text);
                        sqlCommand.Parameters.AddWithValue("@IsInterestedInCSharp", IsCSharpCheckBox.Checked);
                        sqlCommand.Parameters.AddWithValue("@IsInterestedInFlutter", IsFlutterCheckBox.Checked);
                        sqlCommand.Parameters.AddWithValue("@IsInterestedInJava", IsJavaCheckBox.Checked);


                        // Open the database connection
                        // connection.Open();

                        /*  ExecuteReader   =>>>    For Select Statements.
                         *  ExecuteScalar   =>>>    For Select Statements.
                         *  ExecuteNonQuery  =>>>    For Insert, Updat, and Delete Statements.
                        */

                        // Execute Insert Statement
                        sqlCommand.ExecuteNonQuery();

                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Phone Number is Mandatory and it should contains 11 Numeric characters.", "Student details are Incomplete", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }

                MessageBox.Show("Studnet Details are added to the System", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void PhNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Error! A phone Number cannot contains letters./nPlease Enter 11 digit Number.", "Enter A Valid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PhNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            if (PhNumberTextBox.TextLength == 11)
            {
                PhNumberTextBox.ForeColor = Color.Black;
            }
            else
            {
                PhNumberTextBox.ForeColor = Color.Red;
            }
        }

        private void PhValidatorButton_Click(object sender, EventArgs e)
        {
            if (PhNumberTextBox.TextLength == 11)
            {
                MessageBox.Show("Phone Number is successfully validated.");
            }
            else
            {
                MessageBox.Show("Phone Number should contain 11 digits.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }

}