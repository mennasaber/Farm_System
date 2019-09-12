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
    public partial class subcomplaints : UserControl
    {
        DBConnection db = new DBConnection();
        public subcomplaints()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            db.connection.Open();
            string query = "add_comp_";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("@topic",richTextBox1.Text));
            cmd.Parameters.Add(new MySqlParameter("@id_f",Form1.id_user));
            cmd.ExecuteNonQuery();
            db.connection.Close();
            MessageBox.Show("Complaint is added successfully");
            richTextBox1.Text = "";
        }
    }
}
