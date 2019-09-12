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
    public partial class view_ads : UserControl
    {
        DBConnection db = new DBConnection();
        public view_ads()
        {
            InitializeComponent();
        }

        private void view_ads_Load(object sender, EventArgs e)
        {

        }
        public void load_ads()
        {
            db.connection.Open();
            flowLayoutPanel1.Controls.Clear();
            string query = "read_ad";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("@sup_id", Form1.id_user));
            MySqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                ad ad = new ad();
                ad.name_crop((string)rdr["name"]);
                ad.price((int)rdr["price"]);
                ad.quality((string)rdr["quality"]);
                ad.read_id((int)rdr["id_advertisement"]);
                flowLayoutPanel1.Controls.Add(ad);

            }
            db.connection.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
