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
    public partial class farmer_ads : UserControl
    {
        DBConnection db = new DBConnection();
        public farmer_ads()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void farmer_ads_Load(object sender, EventArgs e)
        {

        }
        public void read_id(int id)
        {
            db.connection.Open();
            string query = "select name from farmer where id_farmer ='"+id+"'";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            label2.Text = (string)cmd.ExecuteScalar();
            db.connection.Close();
        }
        public void statue(string st)
        {
            label4.Text = st;
        }
    }
}
