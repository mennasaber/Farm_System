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
    public partial class addavcrops : UserControl
    {
        DBConnection db = new DBConnection();
        public addavcrops()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            db.connection.Open();
            string query = "add_av_crops";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("@name", textBox1.Text));
            cmd.Parameters.Add(new MySqlParameter("@kind", textBox2.Text));
            cmd.Parameters.Add(new MySqlParameter("@quantity", textBox3.Text));
            cmd.Parameters.Add(new MySqlParameter("@id_f", Form1.id_user));
            cmd.ExecuteNonQuery();
            db.connection.Close();
            MessageBox.Show("Crop is added successfully");
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";            
        }
    }
}
