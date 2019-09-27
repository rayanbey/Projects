using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace ultimateBrokerage
{
    public partial class ChangePassword : Form
    {
        DbUtil dbUtil = new DbUtil();
        public ChangePassword()
        {
            InitializeComponent();
        }
        public void Change() {
            using (SqlConnection Connection = dbUtil.GetSqlConnection(dbUtil.GetConnectionString()))
            {
                String user = userNameTextbox.Text.ToString();
                String pass = NewtextBox.Text.ToString();
                using (SqlCommand Command = new SqlCommand("UPDATE Users SET USERNAME=@username,PASSWORD=@password where USERNAME=@username", Connection))
                {
                    Command.Parameters.Add(new SqlParameter("@username", user));
                    Command.Parameters.Add(new SqlParameter("@password", pass));
                    Command.ExecuteNonQuery();
                    MessageBox.Show("Your Password has been sucessfully Changed");
                    admin h = new admin();
                    this.Hide();
                    h.Show();
                }
            }

        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = dbUtil.GetSqlConnection(dbUtil.GetConnectionString()))
            {
                String user = userNameTextbox.Text.ToString();
                String pass = passwordTexbox.Text.ToString();
                using (SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Users where username='" + userNameTextbox.Text + "'and password = '" + passwordTexbox.Text + "'", Connection))
                {

                    using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {

                        SqlDataReader read = sqlCommand.ExecuteReader();


                        int c = 0;
                        while (read.Read())
                        {
                            c++;
                        }

                        if (c > 0)
                        {
                            Change();
                            
                        }




                        else
                        {
                            MessageBox.Show("Incorrect Username or password");
                            userNameTextbox.Text = "";
                            passwordTexbox.Text = "";
                            NewtextBox.Text = "";

                        }


                    }
                }

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            home h = new home();
            this.Hide();
            h.Show();
        }
    }
}
