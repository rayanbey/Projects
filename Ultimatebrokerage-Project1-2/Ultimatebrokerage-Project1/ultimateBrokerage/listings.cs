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
    public partial class listings : Form
    {
        DbUtil dbUtil = new DbUtil();
        public listings()
        {
            InitializeComponent();
            fill();
        }

        private void propertyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.propertyBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.ultimatebrockrageDataSet1);

        }

        private void listings_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ultimatebrockrageDataSet1.property' table. You can move, or remove it, as needed.
            this.propertyTableAdapter1.Fill(this.ultimatebrockrageDataSet1.property);
            // TODO: This line of code loads data into the 'ultimatebrockrageDataSet1.property' table. You can move, or remove it, as needed.
            this.propertyTableAdapter1.Fill(this.ultimatebrockrageDataSet1.property);
            // TODO: This line of code loads data into the 'ultimatebrockrageDataSet.property' table. You can move, or remove it, as needed.
            //this.propertyTableAdapter.Fill(this.ultimatebrockrageDataSet1.property);

        }

        
        public void fill() {
            using (SqlConnection Connection = dbUtil.GetSqlConnection(dbUtil.GetConnectionString()))
            {

                using (SqlCommand sqlCommand = new SqlCommand("SELECT distinct areaname FROM Property;SELECT distinct type FROM Property;SELECT distinct bedrooms FROM Property", Connection)) 
                {
                  
                   using (SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand))
                    {
                       
                    
                        
                        SqlDataReader read = sqlCommand.ExecuteReader();

                        while (read.Read())
                       {
                          
                            
                            comboBox2.Items.Add(read.GetValue(0));
                           
                            
                            
                      }
                        read.NextResult();
                        while (read.Read())
                        {

                            comboBox3.Items.Add(read.GetValue(0));


                        }
                        read.NextResult();
                        while (read.Read())
                        {
                            comboBox4.Items.Add(read.GetValue(0));

                        }
                    } 
                }}
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Type")
            {
              
                this.propertyTableAdapter1.FillByType(this.ultimatebrockrageDataSet1.property, comboBox3.SelectedItem.ToString());
                MessageBox.Show(bindingNavigatorCountItem.ToString()+"  Items were found");
            }
            if (comboBox1.SelectedItem.ToString() == "Area")
            {
             
                this.propertyTableAdapter1.FillByareaname(this.ultimatebrockrageDataSet1.property, comboBox2.SelectedItem.ToString());
                MessageBox.Show(bindingNavigatorCountItem.ToString() + "  Items were found");
            }
            if (comboBox1.SelectedItem.ToString() == "Bedrooms")
            {
              
                this.propertyTableAdapter1.FillByBedrooms(this.ultimatebrockrageDataSet1.property, comboBox4.SelectedItem.ToString());
                MessageBox.Show(bindingNavigatorCountItem.ToString() + "  Items were found");
            }
        }

      

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "Type")
            {
                comboBox3.Enabled = true; comboBox2.Enabled = false; comboBox4.Enabled = false;
            }
            if (comboBox1.SelectedItem.ToString() == "Area")
            { comboBox2.Enabled = true; comboBox3.Enabled = false; comboBox4.Enabled = false; }
            if (comboBox1.SelectedItem.ToString() == "Bedrooms")
            { comboBox4.Enabled = true; comboBox2.Enabled = false; comboBox3.Enabled = false; }
        }

        private void logOffLabel_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            this.Hide();
            a.Show();
        }

        private void addPropertyLabel_Click(object sender, EventArgs e)
        {
            AddProperty a = new AddProperty();
            this.Hide();
            a.Show();
        }

        private void requestsLabel_Click(object sender, EventArgs e)
        {
            requests a = new requests();
            this.Hide();
            a.Show();
        }

        private void homeLabel_Click(object sender, EventArgs e)
        {
            home a = new home();
            this.Hide();
            a.Show();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.propertyBindingSource1.RemoveCurrent();
            this.Validate();
            this.propertyBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.ultimatebrockrageDataSet1);
            MessageBox.Show ( "Property has been deleted successfully");
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String sname = nameTextbox.Text.ToString();
            String sreference = referenceTextBox.Text.ToString();
            String sphone = PhonetextBox.Text.ToString();
            String sId = IdtextBox.Text.ToString();
            if (sname == "" || sreference == "" || sphone == "" || sId == "")
                MessageBox.Show("Please fill all the fields");
            else
            {
               
                using (SqlConnection Connection = dbUtil.GetSqlConnection(dbUtil.GetConnectionString()))
                {
                    using (SqlCommand com = new SqlCommand("INSERT INTO [dbo].[Requestss] VALUES(@request_Id,@name,@Phone,@reference)", Connection))
                    {
                        com.Parameters.Add(new SqlParameter("@request_Id", sId));
                        com.Parameters.Add(new SqlParameter("@name", sname));
                        com.Parameters.Add(new SqlParameter("@Phone", sphone));
                        com.Parameters.Add(new SqlParameter("@reference", sreference));
                        com.ExecuteNonQuery();
                        MessageBox.Show("A Request has been secessfully added");
                        nameTextbox.Text = "";
                        PhonetextBox.Text = "";
                        IdtextBox.Text = "";
                    }

                }
           }
         
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void listingsLabel_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ultimatebrockrageDataSet1.property' table. You can move, or remove it, as needed.
            this.propertyTableAdapter1.Fill(this.ultimatebrockrageDataSet1.property);
            // TODO: This line of code loads data into the 'ultimatebrockrageDataSet1.property' table. You can move, or remove it, as needed.
            this.propertyTableAdapter1.Fill(this.ultimatebrockrageDataSet1.property);
            comboBox2.Enabled = false; comboBox3.Enabled = false; comboBox4.Enabled = false;
        }

        private void addrequestButton_Click(object sender, EventArgs e)
        {
            AddrequesttabControl.SelectedIndex = 1;
        }

        
        }

       

      

      
    }
    

