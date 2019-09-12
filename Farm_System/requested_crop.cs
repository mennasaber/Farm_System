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
    public partial class requested_crop : UserControl
    {
        DBConnection db = new DBConnection();
        public requested_crop()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void requested_crop_Load(object sender, EventArgs e)
        {

        }
        public void farmer_id(int id)
        {
            db.connection.Open();
            string query = "select name from farmer where id_farmer ='" + id + "'";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            label1.Text = (string)cmd.ExecuteScalar();
            db.connection.Close();
        }
        public void crop_name(string name)
        {
            label2.Text = name;
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
