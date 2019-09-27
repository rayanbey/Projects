using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;



namespace ultimateBrokerage
{
    public partial class home : Form
    {
        DbUtil dbUtil = new DbUtil();
        UltimatebrockrageDataClassesDataContext ub = new UltimatebrockrageDataClassesDataContext();
        public home()
        {
            InitializeComponent();

        }
        private void logOffLabel_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            this.Hide();
            a.Show();
        }
        private void listingsLabel_Click(object sender, EventArgs e)
        {
              listings a = new listings();
            this.Hide();
            a.Show();
        }
        private void AddPropertyLabel_Click(object sender, EventArgs e)
        {
            AddProperty a = new AddProperty();
            this.Hide();
            a.Show();
        }
        private void RequestsLabel_Click(object sender, EventArgs e)
        {
            requests a = new requests();
            this.Hide();
            a.Show();
        }

        private void logOffLabel_MouseHover(object sender, EventArgs e)
        {
            logOffLabel.BackColor = Color.Blue;
        }
        private void home_Load(object sender, EventArgs e)
        {
            var query = (from prop in ub.properties
                         where prop.areaname == "Achrafieh"
                         select prop).Count();
            achrafiehLabel.Text = query.ToString();
            using (SqlConnection Connection = dbUtil.GetSqlConnection(dbUtil.GetConnectionString()))
            {
                /*using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where areaname='" + "Achrafieh" + "' ", Connection))
                {
                    achrafiehLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }*/
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where areaname='" + "Ain El Tineh" + "' ", Connection))
                {
                    aineltinehLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where areaname='" + "Bir Hassan" + "' ", Connection))
                {
                    birHassanLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where areaname='" + "Borj Elmor" + "' ", Connection))
                {
                    borjElMorLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where areaname='" + "Down Town" + "' ", Connection))
                {
                    downtownLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where areaname='" + "Clemenceau" + "' ", Connection))
                {
                    downtownLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where areaname='" + "Gemmayze" + "' ", Connection))
                {
                    gemmayzeLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where areaname='" + "Hamra" + "' ", Connection))
                {
                    hamraLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where areaname='" + "Jnah" + "' ", Connection))
                {
                    jnahLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where areaname='" + "Kraytem" + "' ", Connection))
                {
                    kraytemLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where areaname='" + "Ain El Tineh" + "' ", Connection))
                {
                    aineltinehLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where areaname='" + "Manara" + "' ", Connection))
                {
                    manaraLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }

                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where areaname='" + "Ramlet El Baydah" + "' ", Connection))
                {
                    marliasLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where areaname='" + "Ramlet El Baydah" + "' ", Connection))
                {
                    ramleLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where areaname='" + "Rawche" + "' ", Connection))
                {
                    rawcheLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where areaname='" + "Spinneys" + "' ", Connection))
                {
                    spinneysLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where areaname='" + "Sodeco" + "' ", Connection))
                {
                    sodecoLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where areaname='" + "Summerland" + "' ", Connection))
                {
                    summerlandLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where areaname='" + "Unesco" + "' ", Connection))
                {
                    unescoLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where areaname='" + "Verdun" + "' ", Connection))
                {
                    verdunLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }

                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property", Connection))
                {
                    totalLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where exchange='" + "Sale" + "' ", Connection))
                {
                    saleLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where exchange='" + "Rent" + "' ", Connection))
                {
                    rentLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where type='" + "Office" + "'  or type='" + "Shop" + "'  or type='" + "Showroom" + "' ", Connection))
                {
                    commercialLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }
                using (SqlCommand sqlCommand = new SqlCommand("SELECT Count(*) from property where areaname='" + "Sodeco" + "' ", Connection))
                {
                    sodecoLabel.Text = (sqlCommand.ExecuteScalar().ToString());

                }

              

            }
        }

        private void homeLabel_Click(object sender, EventArgs e)
        {
            home a = new home();
            this.Hide();
            a.Show();
        }

        private void label30_Click(object sender, EventArgs e)
        {
            ChangePassword c = new ChangePassword();
            this.Hide();
            c.Show();
        }

        private void logOffLabel_Click_1(object sender, EventArgs e)
        {
            admin a = new admin();
            this.Hide();
            a.Show();
        }
     
    }
}
