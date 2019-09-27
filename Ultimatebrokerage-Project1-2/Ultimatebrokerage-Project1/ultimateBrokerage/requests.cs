using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace ultimateBrokerage
{
    public partial class requests : Form
    {
        public requests()
        {
            InitializeComponent();
            fill();
        }
        UltimatebrockrageDataClassesDataContext db = new UltimatebrockrageDataClassesDataContext();

        private void logOffLabel_MouseHover(object sender, EventArgs e)
        {
            logOffLabel.BackColor = Color.Blue;
        }

        private void logOffLabel_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            this.Hide();
            a.Show();
        }

        private void homeLabel_Click(object sender, EventArgs e)
        {
            home h = new home();
            this.Hide();
            h.Show();
        }

        private void listingsLabel_Click(object sender, EventArgs e)
        {
            listings l = new listings();
            this.Hide();
            l.Show();
        }

        private void addPropertyLabel_Click(object sender, EventArgs e)
        {
            AddProperty a = new AddProperty();
            this.Hide();
            a.Show();
        }
        public void fill()
        {
            var namequery =
                from req in db.Requestsses
                join prop in db.properties on req.refernces equals prop.reference
                select new
                {
                    req.request_Id,
                    requestInfo = new { req.refernces, req.name, req.phone },
                    PropertyInfo = new { prop.price, prop.size, prop.exchange, prop.areaname, prop.bathrooms, prop.bedrooms }
                };


            dataGridView1.DataSource = namequery;
        }
    
    }
}
