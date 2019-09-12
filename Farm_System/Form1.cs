using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Farm_System
{

    public partial class Form1 : Form
    {
        static public string email = "admin";
        static public string password = "admin";
        static public int id_user;
        DBConnection db = new DBConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text == "Email")
                bunifuMaterialTextbox2.Text = "";
        }

        private void bunifuMaterialTextbox2_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text == "")
                bunifuMaterialTextbox2.Text = "Email";
        }

        private void bunifuMaterialTextbox3_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox3.Text == "Password")
            {
                bunifuMaterialTextbox3.Text = "";
                bunifuMaterialTextbox3.isPassword = true;
            }
        }

        private void bunifuMaterialTextbox3_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox3.Text == "")
            {
                bunifuMaterialTextbox3.Text = "Password";
                bunifuMaterialTextbox3.isPassword = false;
            }
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }
        int f = 0, s = 0, r = 0;
        //public int id;
        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text == email && bunifuMaterialTextbox2.Text == password)
            {
                main_admin m_a = new main_admin();
                m_a.Show();
            }
            else
            {
                db.connection.Open();
                string query1 = "SELECT count(*) FROM farmer where email = '" + bunifuMaterialTextbox2.Text + "' and password = '" + bunifuMaterialTextbox3.Text + "'";
                MySqlCommand cmd1 = new MySqlCommand(query1, db.connection);
                f = (int)cmd1.ExecuteScalar();
                string query2 = "SELECT count(*) FROM retailer where email = '" + bunifuMaterialTextbox2.Text + "' and password = '" + bunifuMaterialTextbox3.Text + "'";
                MySqlCommand cmd2 = new MySqlCommand(query2, db.connection);
                r = (int)cmd2.ExecuteScalar();
                string query3 = "SELECT count(*) FROM supplier where email = '" + bunifuMaterialTextbox2.Text + "' and password = '" + bunifuMaterialTextbox3.Text + "'";
                MySqlCommand cmd3 = new MySqlCommand(query3, db.connection);
                s = (int)cmd3.ExecuteScalar();
                if (s != 0 || r != 0 || f != 0)
                {
                    if (s != 0)
                    {
                        string query4 = "SELECT id_supplier FROM supplier where email = '" + bunifuMaterialTextbox2.Text + "' and password = '" + bunifuMaterialTextbox3.Text + "'";
                        MySqlCommand cmd4 = new MySqlCommand(query4, db.connection);
                        id_user = (int)cmd4.ExecuteScalar();
                        main_supplier main = new main_supplier();
                        main.Show();
                    }
                    if (r != 0)
                    {
                        string query4 = "SELECT id_retailer FROM retailer where email = '" + bunifuMaterialTextbox2.Text + "' and password = '" + bunifuMaterialTextbox3.Text + "'";
                        MySqlCommand cmd4 = new MySqlCommand(query4, db.connection);
                        id_user = (int)cmd4.ExecuteScalar();
                        main_retailer main = new main_retailer();
                        main.Show();
                    }
                    if (f != 0)
                    {
                        string query4 = "SELECT id_farmer FROM farmer where email = '" + bunifuMaterialTextbox2.Text + "' and password = '" + bunifuMaterialTextbox3.Text + "'";
                        MySqlCommand cmd4 = new MySqlCommand(query4, db.connection);
                        id_user = (int)cmd4.ExecuteScalar();
                        main_farmer main = new main_farmer();
                        main.Show();
                    }
                }
                else
                    MessageBox.Show("incorrect login");
                db.connection.Close();
            }
            bunifuMaterialTextbox2.Text = "Email";
            bunifuMaterialTextbox3.isPassword = false;
            bunifuMaterialTextbox3.Text = "Password";
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            forget_password forget_pass = new forget_password();
            forget_pass.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
