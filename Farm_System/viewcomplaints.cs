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
    public partial class viewcomplaints : UserControl
    {
        DBConnection db = new DBConnection();

        public viewcomplaints()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void viewcomplaints_Load(object sender, EventArgs e)
        {

        }
        public void load_complaints()
        {          
            flowLayoutPanel1.Controls.Clear();
            db.connection.Open();           
            string query = "select * from grivance where id_farmer='" + Form1.id_user+"'";
         
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
       
            MySqlDataReader rdr = cmd.ExecuteReader();
           
            while (rdr.Read())
            {                
                viewcomplaint v_c = new viewcomplaint();
                v_c.topic((string)rdr["topic"]);
                if (rdr["statue"] == DBNull.Value)
                    v_c.statue("Not Respond");
                else
                    v_c.statue((string)rdr["statue"]);
                flowLayoutPanel1.Controls.Add(v_c);
            }
            db.connection.Close();
        }
    }
}
