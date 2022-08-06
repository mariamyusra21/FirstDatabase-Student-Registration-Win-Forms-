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
                    connection.Open();
                    string query = "INSERT INTO StudentInfo(Name, Email) VALUES(@Name,@Email)";
                    using (SqlCommand sqlCommand = new SqlCommand(query,connection))
                    {
                        // sqlCommand.CommandType = CommandType.StoredProcedure;

                        // Parameters for StudentInsetDetails

                        // sqlCommand.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value = NameTextBox.Text;
                        sqlCommand.Parameters.AddWithValue("@Name", NameTextBox.Text);
                        sqlCommand.Parameters.AddWithValue("@Email", EmailTextBox.Text);

                        // Open the database connection
                        // connection.Open();

                        /*  ExecuteReader   =>>>    For Select Statements.
                         *  ExecuteScalar   =>>>    For Select Statements.
                         *  ExecuteNonQuery  =>>>    For Insert, Updat, and Delete Statements.
                        */

                        // Execute Insert Statement
                        sqlCommand.ExecuteNonQuery();

                        connection.Close();

                        MessageBox.Show("Studnet Details are added to the System", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            
        }

    }
}