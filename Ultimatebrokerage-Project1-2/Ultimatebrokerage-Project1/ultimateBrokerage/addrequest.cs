using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.IO;

namespace ultimateBrokerage
{
    public partial class addrequest : Form
    {
        DbUtil dbUtil = new DbUtil();
        public addrequest()
        {
            InitializeComponent();
        }

        private void propertyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.propertyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ultimatebrockrageDataSet1);

        }

        private void addrequest_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ultimatebrockrageDataSet2.property' table. You can move, or remove it, as needed.
            this.propertyTableAdapter1.Fill(this.ultimatebrockrageDataSet2.property);
            // TODO: This line of code loads data into the 'ultimatebrockrageDataSet1.property' table. You can move, or remove it, as needed.
            this.propertyTableAdapter.Fill(this.ultimatebrockrageDataSet1.property);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog fop = new OpenFileDialog(); //create object of open file dialog
            fop.InitialDirectory = @"C:\"; //set Initial directory
            fop.Filter = "[JPG,JPEG]|*.jpg"; //set filter for select only .jpg files
            if (fop.ShowDialog() == DialogResult.OK) //display open file dialog to user and only user select a image enter to if block
            {
                FileStream FS = new FileStream(@fop.FileName, FileMode.Open, FileAccess.Read); //create a file stream object associate to user selected file 
                byte[] img = new byte[FS.Length]; //create a byte array with size of user select file stream length
                FS.Read(img, 0, Convert.ToInt32(FS.Length));
                MemoryStream ms = new MemoryStream(img);
                photoPictureBox.Image = Image.FromStream(ms);
            }
            else
            {
                MessageBox.Show("Please Select a Image to save!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//display message to force select a image 
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            InsertImage(photoPictureBox.Image);

        }
        public void InsertImage(Image image)
        {
            String refer = referenceTextBox.Text.ToString();
            String exchange = exchangeTextBox.Text.ToString();
            String stype = typeTextBox.Text.ToString();
            String sarea = areanameTextBox.Text.ToString();
            String ssize = sizeTextBox.Text.ToString();
            String bed = bedroomsTextBox.Text.ToString();
            String bath = bathroomsTextBox.Text.ToString();
            String floor = floorTextBox.Text.ToString();
            String parking = parkingTextBox.Text.ToString();
            String price = priceTextBox.Text.ToString();

            using (SqlConnection Connection = dbUtil.GetSqlConnection(dbUtil.GetConnectionString()))
            {


                using (MemoryStream memoryStream = new MemoryStream())
                {
                    image.Save(memoryStream, System.Drawing.Imaging.ImageFormat.Jpeg);

                    using (SqlCommand com = new SqlCommand("UPDATE [dbo].[property] SET REFERENCE=@reference,EXCHANGE=@exchange,TYPE=@type,AREANAME=@areaname,SIZE=@size,BEDROOMS=@bedrooms,BATHROOMS=@bathrooms,FLOOR=@floor,PARKING=@parking,PRICE=@price,PHOTO=@photoPictureBox WHERE REFERENCE=@reference ", Connection))
                    {
                        byte[] imageAsByte = memoryStream.GetBuffer();
                        com.Parameters.Add(new SqlParameter("@reference", refer));
                        com.Parameters.Add(new SqlParameter("@exchange", exchange));
                        com.Parameters.Add(new SqlParameter("@type", stype));
                        com.Parameters.Add(new SqlParameter("@areaname", sarea));
                        com.Parameters.Add(new SqlParameter("@size", ssize));
                        com.Parameters.Add(new SqlParameter("@bedrooms", bed));
                        com.Parameters.Add(new SqlParameter("@bathrooms", bath));
                        com.Parameters.Add(new SqlParameter("@floor", floor));
                        com.Parameters.Add(new SqlParameter("@parking", parking));
                        com.Parameters.Add(new SqlParameter("@price", price));
                        com.Parameters.AddWithValue("@photoPictureBox", imageAsByte);
                        com.ExecuteNonQuery();
                        image.Dispose();
                    }

                }
            }




        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog fop = new OpenFileDialog(); //create object of open file dialog
            fop.InitialDirectory = @"C:\"; //set Initial directory
            fop.Filter = "[JPG,JPEG]|*.jpg"; //set filter for select only .jpg files
            if (fop.ShowDialog() == DialogResult.OK) //display open file dialog to user and only user select a image enter to if block
            {
                FileStream FS = new FileStream(@fop.FileName, FileMode.Open, FileAccess.Read); //create a file stream object associate to user selected file 
                byte[] img = new byte[FS.Length]; //create a byte array with size of user select file stream length
                FS.Read(img, 0, Convert.ToInt32(FS.Length));
                MemoryStream ms = new MemoryStream(img);
                photoPictureBox.Image = Image.FromStream(ms);
            }
            else
            {
                MessageBox.Show("Please Select a Image to save!!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);//display message to force select a image 
            }
        }
    }
}
