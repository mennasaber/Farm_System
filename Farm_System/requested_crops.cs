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
    public partial class requested_crops : UserControl
    {
        DBConnection db = new DBConnection();
        public requested_crops()
        {
            InitializeComponent();
        }

        private void requested_crops_Load(object sender, EventArgs e)
        {
            
        }

        public void load_r_crops()
        {
            flowLayoutPanel1.Controls.Clear();
            db.connection.Open();
            string query = "select * from r_crops";
            MySqlCommand cmd = new MySqlCommand(query,db.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                requested_crop rc = new requested_crop();
                rc.farmer_id((int)rdr["id_farmer"]);
                rc.crop_name((string)rdr["name"]);
                flowLayoutPanel1.Controls.Add(rc);
            }
            db.connection.Close();
        }
    }
}
