using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Farm_System
{
    public partial class viewoffer : UserControl
    {
        DBConnection db = new DBConnection();
        public viewoffer()
        {
            InitializeComponent();
        }

        private void viewoffer_Load(object sender, EventArgs e)
        {

        }
        public void id_r(int r)
        {
            db.connection.Open();
            string query = "select name from retailer where id_retailer = '" +r +"'";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            label1.Text = (string)cmd.ExecuteScalar();
            db.connection.Close();
        }
        public void id_c(int c)
        {
            db.connection.Open();
            string query = "select name from crop where id_crop = '" + c + "'";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            label2.Text = (string)cmd.ExecuteScalar();
            db.connection.Close();
        }
        public void price(int p)
        {
            label6.Text = p.ToString();
        }
        public void quantity(int q)
        {
            label8.Text = q.ToString();
        }
        public void statue(string s)
        {
            if (s == "Accept    ")
                radioButton1.Checked= true;
            else
                radioButton2.Checked = true;
        }
        int id;
        public void id_o(int i)
        {
            id = i;
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            db.connection.Open();
            string query = "update offer set statue='" + radioButton1.Text + "' where id_offer = '"+id+"'";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
            db.connection.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            db.connection.Open();
            string query = "update offer set statue='" + radioButton2.Text + "' where id_offer = '" + id + "'";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
            db.connection.Close();
        }
    }
}
