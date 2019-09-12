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
    public partial class av_crops : UserControl
    {
        DBConnection db = new DBConnection();
        public av_crops()
        {
            InitializeComponent();
        }

        private void av_crops_Load(object sender, EventArgs e)
        {

        }
        public void load_crops()
        {
            db.connection.Open();
            string query = "av_crops";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            MySqlDataReader rdr = cmd.ExecuteReader();
            flowLayoutPanel1.Controls.Clear();
            while(rdr.Read())
            {
                av_crop av_crop = new av_crop();
                av_crop.farmer_id((int)rdr["id_farmer"]);
                av_crop.crop_id((int)rdr["id_crop"]);
                av_crop.crop_name((string)rdr["name"]);
                av_crop.crop_kind((string)rdr["kind"]);
                av_crop.crop_quantity((int)rdr["quantity"]);
                flowLayoutPanel1.Controls.Add(av_crop); 
            }
            db.connection.Close();
        }
    }
}
