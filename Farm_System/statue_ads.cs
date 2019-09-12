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
    public partial class statue_ads : Form
    {
        DBConnection db = new DBConnection();
        int id_a;
        public statue_ads(int i)
        {
            InitializeComponent();
            id_a = i;
        }

        private void statue_ads_Load(object sender, EventArgs e)
        {
            db.connection.Open();
            string query = "select * from ads_farmer where id_ads='" + id_a + "'";
           
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            MySqlDataReader rdr = cmd.ExecuteReader();
           
            while (rdr.Read())
            {
                
                farmer_ads f_a = new farmer_ads();
                f_a.read_id((int)rdr["id_farmer"]);
                f_a.statue((string)rdr["statue"]);
                flowLayoutPanel1.Controls.Add(f_a);
            }
            db.connection.Close();
            
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
