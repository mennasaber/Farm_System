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
    public partial class search : UserControl
    {
        DBConnection db = new DBConnection();
        public search()
        {
            InitializeComponent();
        }
        string s;
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            s = richTextBox1.Text;
            flowLayoutPanel1.Controls.Clear();
            db.connection.Open();
            string query = "search_farmer_";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("@name", richTextBox1.Text));
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {

                result_search r_search = new result_search();
                r_search.farmer_name((string)rdr["name"]);
                r_search.farmer_id((int)rdr["id_farmer"]);
                flowLayoutPanel1.Controls.Add(r_search);
            }
            db.connection.Close();

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (richTextBox1.Text != s)
                flowLayoutPanel1.Controls.Clear();
        }
    }
}
