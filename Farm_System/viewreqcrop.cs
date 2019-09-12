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
    public partial class viewreqcrop : UserControl
    {
        DBConnection db = new DBConnection();
        public viewreqcrop()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void viewreqcrop_Load(object sender, EventArgs e)
        {

        }
        int a_id;
        int d;
        public void ad_id(int i)
        {
            a_id = i;
            db.connection.Open();
            string query1 = "select count(*) from ads_farmer where id_ads = '" + a_id + "' and id_farmer = '" + Form1.id_user + "'";
            MySqlCommand cmd1 = new MySqlCommand(query1, db.connection);

            d = (int)cmd1.ExecuteScalar();
            db.connection.Close();
            if (d != 0)
            {
                db.connection.Open();
                string query = "select statue from ads_farmer where id_ads = '" + a_id + "' and id_farmer = '" + Form1.id_user + "'";
                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                string f = (string)cmd.ExecuteScalar();
                db.connection.Close();
                if (f == "Accept    ")
                {
                    radioButton1.Checked = true;
                }
                else if (f == "Reject    ")
                {
                    radioButton2.Checked = true;
                }
            }
        }
        public void st()
        {


        }
        public void c_name(string n)
        {
            label1.Text = n;
        }
        public void quality(string q)
        {
            label4.Text = q;
        }
        public void price(int p)
        {
            label6.Text = p.ToString();
        }
        public void s_name(int i)
        {
            db.connection.Open();
            string query = "select name from supplier where id_supplier ='" + i + "'";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            label7.Text = (string)cmd.ExecuteScalar();
            db.connection.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

            db.connection.Open();
            string query1 = "select count(*) from ads_farmer where id_ads = '" + a_id + "' and id_farmer = '" + Form1.id_user + "'";
            MySqlCommand cmd1 = new MySqlCommand(query1, db.connection);
            if ((int)cmd1.ExecuteScalar() == 0)
            {
                string query = "insert into ads_farmer (id_ads,id_farmer,statue) values (@id_ads,@id_farmer,@statue)";
                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.Parameters.AddWithValue("@id_ads", a_id);
                cmd.Parameters.AddWithValue("@id_farmer", Form1.id_user);
                cmd.Parameters.AddWithValue("@statue", radioButton1.Text);
                cmd.ExecuteNonQuery();
            }
            else
            {
                string query = "update ads_farmer set statue='" + radioButton1.Text + "' where id_ads = '" + a_id + "' and id_farmer = '" + Form1.id_user + "'";
                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.ExecuteNonQuery();
            }
            db.connection.Close();
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            db.connection.Open();
            string query1 = "select count(*) from ads_farmer where id_ads = '" + a_id + "' and id_farmer = '" + Form1.id_user + "'";
            MySqlCommand cmd1 = new MySqlCommand(query1, db.connection);
            if ((int)cmd1.ExecuteScalar() == 0)
            {
                string query = "insert into ads_farmer (id_ads,id_farmer,statue) values (@id_ads,@id_farmer,@statue)";
                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.Parameters.AddWithValue("@id_ads", a_id);
                cmd.Parameters.AddWithValue("@id_farmer", Form1.id_user);
                cmd.Parameters.AddWithValue("@statue", radioButton2.Text);
                cmd.ExecuteNonQuery();
            }
            else
            {
                string query = "update ads_farmer set statue='" + radioButton2.Text + "' where id_ads = '" + a_id + "' and id_farmer = '" + Form1.id_user + "'";
                MySqlCommand cmd = new MySqlCommand(query, db.connection);
                cmd.ExecuteNonQuery();
            }
            db.connection.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
