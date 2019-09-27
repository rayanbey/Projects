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
    public partial class admin : Form
    {
        DbUtil dbUtil = new DbUtil();
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {

            // this.reportViewer1.RefreshReport();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            using (SqlConnection Connection = dbUtil.GetSqlConnection(dbUtil.GetConnectionString()))
            {

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
                         
                                    if(c>0)
                                    {
                                        
                                MessageBox.Show("Login Success");
                                home h1 = new home();
                                this.Hide();
                                h1.Show();
                            }
                               
                    

                                
                            else
                            {
                                MessageBox.Show("Incorrect login");
                                userNameTextbox.Text = "";
                                passwordTexbox.Text="";

                            }
                      

                    }
                }
            }



        }

      
    }
}

