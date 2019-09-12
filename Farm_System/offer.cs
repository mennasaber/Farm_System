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
    public partial class offer : UserControl
    {
        DBConnection db = new DBConnection();
        public offer()
        {
            InitializeComponent();
        }

        private void offer_Load(object sender, EventArgs e)
        {

        }
        public void farmer_name(int id_f)
        {
            string query = "select name from farmer where id_farmer = '" + id_f.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            label7.Text = (string)cmd.ExecuteScalar();
        }
        public void crop_name(int id_c)
        {
            db.connection.Open();
            string query = "select name from crop where id_crop = '" + id_c.ToString() + "'";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            label1.Text = (string)cmd.ExecuteScalar();
            string query2 = "select id_farmer from crop where id_crop = '" + id_c.ToString() + "'";
            MySqlCommand cmd2 = new MySqlCommand(query2, db.connection);
            int i = (int)cmd2.ExecuteScalar();
            farmer_name(i);
            db.connection.Close();
        }
        public void crop_quantity(int q)
        {
            label4.Text = q.ToString();
        }
        public void price(float p)
        {
            label6.Text = p.ToString();
        }
        public void offer_statue(string s)
        {
                label9.Text = s;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
