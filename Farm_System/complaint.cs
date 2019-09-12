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
    public partial class complaint : UserControl
    {
        DBConnection db = new DBConnection();
        public complaint()
        {
            InitializeComponent();
        }

        private void complaint_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        int id;
        public void id_g(int g)
        {
            string s = "";
            id = g;
            db.connection.Open();
            string Query = "select statue from grivance where id_grivance=" + id;
            MySqlCommand cmd = new MySqlCommand(Query, db.connection);
            if (cmd.ExecuteScalar() != DBNull.Value)
                s = (string)cmd.ExecuteScalar();
            db.connection.Close();
            if (s != "")
            {
                if (s == "Accept")
                    radioButton1.Checked = true;
                else
                    radioButton2.Checked = true;
            }

        }
        public void topic(string t)
        {
            label8.Text = t.ToString();
        }
        public void id_f(int f)
        {
            db.connection.Open();
            string Query = "select name from farmer where id_farmer=" + f;
            MySqlCommand cmd = new MySqlCommand(Query, db.connection);
            label2.Text = (string)cmd.ExecuteScalar();

            db.connection.Close();
        }



        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            string query = "update grivance set statue='" + radioButton1.Text + "'where id_grivance='" + id + "'";
            db.connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
            db.connection.Close();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string query = "update grivance set statue='" + radioButton2.Text + "'where id_grivance='" + id + "'";
            db.connection.Open();
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.ExecuteNonQuery();
            db.connection.Close();
        }
    }
}
