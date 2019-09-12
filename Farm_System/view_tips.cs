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
    public partial class view_tips : UserControl
    {
        DBConnection db = new DBConnection();
        public view_tips()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void load_tips()
        {
            flowLayoutPanel1.Controls.Clear();
            db.connection.Open();
            string query = "view_tips";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                view_tip tip = new view_tip();
                tip.tip_topic((string)rdr["topic"]);
                flowLayoutPanel1.Controls.Add(tip);
            }
            db.connection.Close();
        }

        private void view_tips_Load(object sender, EventArgs e)
        {

        }
    }
}
