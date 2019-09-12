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
    public partial class offers : UserControl
    {
        DBConnection db = new DBConnection();
        public offers()
        {
            InitializeComponent();
        }

        private void offers_Load(object sender, EventArgs e)
        {

        }
        public void load_offers()
        {
            flowLayoutPanel1.Controls.Clear();
            db.connection.Open();
            string query = "all_offers";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("@id_r", Form1.id_user));
            MySqlDataReader rdr = cmd.ExecuteReader();
            while(rdr.Read())
            {
                offer offer = new offer();
                ////offer.farmer_name((int)rdr["id_farmer"]);
                offer.crop_name((int)rdr["id_crop"]);
                offer.crop_quantity((int)rdr["quantity"]);
                offer.price((int)rdr["price"]);
                if (rdr["statue"] == DBNull.Value)
                    offer.offer_statue("Not Respond");
                else
                    offer.offer_statue((string)rdr["statue"]);
                flowLayoutPanel1.Controls.Add(offer);
            }
            db.connection.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
