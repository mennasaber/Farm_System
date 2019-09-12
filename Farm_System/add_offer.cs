using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Farm_System
{   
    public partial class add_offer : Form
    {
        DBConnection db = new DBConnection();
        public int id_crop;
        public add_offer(int i)
        {
            InitializeComponent();
            id_crop = i;
        }

        private void add_offer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.connection.Open();
            string query = "inse_offer";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("@id_r", Form1.id_user));
            cmd.Parameters.Add(new MySqlParameter("@p", textBox2.Text));
            cmd.Parameters.Add(new MySqlParameter("@q", textBox3.Text));
            cmd.Parameters.Add(new MySqlParameter("@id_c", id_crop));            
            cmd.ExecuteNonQuery();
            db.connection.Close();
            MessageBox.Show("Offer was submitted successfully");
            textBox2.Text = "";
            textBox3.Text = "";
            button1.Enabled = false; 
        }
    }
}
