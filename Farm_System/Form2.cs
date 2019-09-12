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

    public partial class Form2 : Form
    {
        DBConnection db = new DBConnection();
        public Form2()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "Name")
                bunifuMaterialTextbox1.Text = "";
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "")
                bunifuMaterialTextbox1.Text = "Name";
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

        private void bunifuMaterialTextbox4_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox4.Text == "Answer question")
                bunifuMaterialTextbox4.Text = "";
        }

        private void bunifuMaterialTextbox4_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox4.Text == "")
                bunifuMaterialTextbox4.Text = "Answer question";
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Farmer ")
            {
                string query2 = "insert into farmer (name,email,password,security_question,answer_question,gender) VALUES" +
               "(@name,@email,@password,@security_question,@answer_question,@gender)";
                db.connection.Open();
                MySqlCommand cmd2 = new MySqlCommand(query2, db.connection);
                cmd2.Parameters.AddWithValue("@name", bunifuMaterialTextbox1.Text);
                cmd2.Parameters.AddWithValue("@email", bunifuMaterialTextbox2.Text);
                cmd2.Parameters.AddWithValue("@password", bunifuMaterialTextbox3.Text);
                cmd2.Parameters.AddWithValue("@security_question", comboBox4.Text);
                cmd2.Parameters.AddWithValue("@answer_question", bunifuMaterialTextbox4.Text);
                cmd2.Parameters.AddWithValue("@gender", gender);
                cmd2.ExecuteNonQuery();
                db.connection.Close();
            }
            else if (comboBox1.Text == "Supplier ")
            {
                string query3 = "insert into supplier (name,email,password,security_question,answer_question,gender) VALUES" +
               "(@name,@email,@password,@security_question,@answer_question,@gender)";
                db.connection.Open();
                MySqlCommand cmd3 = new MySqlCommand(query3, db.connection);
                cmd3.Parameters.AddWithValue("@name", bunifuMaterialTextbox1.Text);
                cmd3.Parameters.AddWithValue("@email", bunifuMaterialTextbox2.Text);
                cmd3.Parameters.AddWithValue("@password", bunifuMaterialTextbox3.Text);
                cmd3.Parameters.AddWithValue("@security_question", comboBox4.Text);
                cmd3.Parameters.AddWithValue("@answer_question", bunifuMaterialTextbox4.Text);
                cmd3.Parameters.AddWithValue("@gender", gender);
                cmd3.ExecuteNonQuery();
                db.connection.Close();
            }
            else if (comboBox1.Text == "Retailer ")
            {
                string query4 = "insert into retailer (name,email,password,security_question,answer_question,gender) VALUES" +
               "(@name,@email,@password,@security_question,@answer_question,@gender)";
                db.connection.Open();
                MySqlCommand cmd4 = new MySqlCommand(query4, db.connection);
                cmd4.Parameters.AddWithValue("@name", bunifuMaterialTextbox1.Text);
                cmd4.Parameters.AddWithValue("@email", bunifuMaterialTextbox2.Text);
                cmd4.Parameters.AddWithValue("@password", bunifuMaterialTextbox3.Text);
                cmd4.Parameters.AddWithValue("@security_question", comboBox4.Text);
                cmd4.Parameters.AddWithValue("@answer_question", bunifuMaterialTextbox4.Text);
                cmd4.Parameters.AddWithValue("@gender", gender);
                cmd4.ExecuteNonQuery();
                db.connection.Close();
            }
            MessageBox.Show("Sign Up successfully");
            bunifuMaterialTextbox1.Text = "Name";
            bunifuMaterialTextbox2.Text = "Email";
            bunifuMaterialTextbox3.isPassword = false;
            bunifuMaterialTextbox3.Text = "Password";
            comboBox4.Text = "Choose";
            comboBox1.Text = "Choose";
            bunifuMaterialTextbox4.Text = "Answer question";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        string gender;
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = radioButton1.Text;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            gender = radioButton2.Text;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
