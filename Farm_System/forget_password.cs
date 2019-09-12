using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Farm_System
{
    public partial class forget_password : Form
    {
        static string sql = @"Data Source = DESKTOP-14KH0FM\SQLEXPRESS ; Initial Catalog = farm_system ; Integrated Security = True ; MultipleActiveResultSets = True ; User ID = '' ; Password = '' ";
        SqlConnection con = new SqlConnection(sql);
        public forget_password()
        {
            InitializeComponent();
        }
        static public int id;
        int f = 0, r = 0, s = 0;
        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            con.Open();
            if (bunifuFlatButton5.Text == "Check")
            {
                MessageBox.Show("hi");
                try
                {
                    string query1 = "SELECT count(*) FROM farmer where email = '" + bunifuMaterialTextbox2.Text + "' and security_question = '" + comboBox4.Text + "'and [answer_question]= '" + bunifuMaterialTextbox4.Text + "'";
                    SqlCommand cmd1 = new SqlCommand(query1, con);
                    f = (int)cmd1.ExecuteScalar();
                    string query2 = "SELECT count(*) FROM retailer where email = '" + bunifuMaterialTextbox2.Text + "' and security_question = '" + comboBox4.Text + "'and [answer_question]= '" + bunifuMaterialTextbox4.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(query2, con);
                    r = (int)cmd2.ExecuteScalar();
                    string query3 = "SELECT count(*) FROM supplier where email = '" + bunifuMaterialTextbox2.Text + "' and security_question = '" + comboBox4.Text + "'and [answer_question]= '" + bunifuMaterialTextbox4.Text + "'";
                    SqlCommand cmd3 = new SqlCommand(query3, con);
                    s = (int)cmd3.ExecuteScalar();


                    if (s != 0 || r != 0 || f != 0)
                    {
                        if (s != 0)
                        {

                            string query4 = "SELECT id_supplier FROM supplier where email = '" + bunifuMaterialTextbox2.Text + "' and security_question = '" + comboBox4.Text + "'and [answer_question]= '" + bunifuMaterialTextbox4.Text + "'";
                            SqlCommand cmd4 = new SqlCommand(query4, con);
                            id = (int)cmd4.ExecuteScalar();
                        }
                        if (r != 0)
                        {

                            string query4 = "SELECT id_retailer FROM retailer where email = '" + bunifuMaterialTextbox2.Text + "' and security_question = '" + comboBox4.Text + "'and [answer_question]= '" + bunifuMaterialTextbox4.Text + "'";
                            SqlCommand cmd4 = new SqlCommand(query4, con);
                            id = (int)cmd4.ExecuteScalar();
                        }
                        if (f != 0)
                        {

                            string query4 = "SELECT id_farmer FROM farmer where email = '" + bunifuMaterialTextbox2.Text + "' and security_question = '" + comboBox4.Text + "'and [answer_question]= '" + bunifuMaterialTextbox4.Text + "'";
                            SqlCommand cmd4 = new SqlCommand(query4, con);
                            id = (int)cmd4.ExecuteScalar();
                        }
                        bunifuMaterialTextbox2.Enabled = false;
                        bunifuMaterialTextbox4.Enabled = false;
                        comboBox4.Enabled = false;
                        bunifuMaterialTextbox1.Visible = true;
                        bunifuFlatButton5.Text = "Change";
                    }
                    else
                        MessageBox.Show("Incorrect Information");
                }
                catch
                {
                    MessageBox.Show("Incorrect Information");
                }
            }
            else
            {

                if (s != 0)
                {
                    string query = "update supplier set password ='" + bunifuMaterialTextbox1.Text + "'where id_supplier = '" + id + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
                if (r != 0)
                {
                    string query = "update retailer set password ='" + bunifuMaterialTextbox1.Text + "'where id_retailer = '" + id + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
                if (f != 0)
                {
                    string query = "update farmer set password ='" + bunifuMaterialTextbox1.Text + "'where id_farmer = '" + id + "'";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
                bunifuMaterialTextbox1.Enabled = false;
                MessageBox.Show("Password changed sucessfuly");
            }
            con.Close();
        }
        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text == "Email")
            {
                bunifuMaterialTextbox2.Text = "";
            }
        }

        private void bunifuMaterialTextbox2_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text == "")
            {
                bunifuMaterialTextbox2.Text = "Email";
            }
        }

        private void bunifuMaterialTextbox4_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox4.Text == "Answer question")
            {
                bunifuMaterialTextbox4.Text = "";
            }
        }

        private void bunifuMaterialTextbox4_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox4.Text == "")
            {
                bunifuMaterialTextbox4.Text = "Answer question";
            }
        }
        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "New Password")
            {
                bunifuMaterialTextbox1.Text = "";
                bunifuMaterialTextbox1.isPassword = true;
            }
        }

        private void forget_password_Load(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "")
            {
                bunifuMaterialTextbox1.Text = "New Password";
                bunifuMaterialTextbox1.isPassword = false;
            }
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
