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
    public partial class complaints : UserControl
    {
        DBConnection db = new DBConnection();
        public complaints()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void view_complaints()
        {
            flowLayoutPanel1.Controls.Clear();
            db.connection.Open();
            string query = "select * from grivance ";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {

                complaint v_s = new complaint();
                v_s.id_g((int)rdr["id_grivance"]);
                v_s.topic((string)rdr["topic"]);
                v_s.id_f((int)rdr["id_farmer"]);

                flowLayoutPanel1.Controls.Add(v_s);


            }
            db.connection.Close();
        }

        private void complaints_Load(object sender, EventArgs e)
        {

        }
    }
}

