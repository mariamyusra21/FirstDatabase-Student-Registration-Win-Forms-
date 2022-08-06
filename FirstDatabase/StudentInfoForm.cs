using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
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
                    using (SqlCommand sqlCommand = new SqlCommand())
                    {
                        sqlCommand.CommandType = System.Data.CommandType.StoredProcedure;

                        //Parameters for StudentInsetDetails

                        sqlCommand.Parameters.Add("@Name", System.Data.SqlDbType.NVarChar, 100).Value = NameTextBox.Text;
                        sqlCommand.Parameters.AddWithValue("Email", EmailTextBox.Text);

                        // Open the database connection
                        connection.Open();

                        /*  ExecuteReader   =>>>    For Select Statements.
                         *  ExecuteScalar   =>>>    For Select Statements.
                         *  ExecuteNonQuery  =>>>    For Insert, Updat, and Delete Statements.
                         */

                        // Execute Insert Statement
                        sqlCommand.ExecuteNonQuery();

                        MessageBox.Show("Studnet Details are added to the System", "User Added", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            
        }

    }
}