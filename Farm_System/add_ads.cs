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
    public partial class add_ads : UserControl
    {
        DBConnection db = new DBConnection();
        public add_ads()
        {
            InitializeComponent();
        }

        private void bunifuMetroTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        
      

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            db.connection.Open();
            string query = "add_ads";
            MySqlCommand cmd = new MySqlCommand(query, db.connection);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new MySqlParameter("@name", bunifuMetroTextbox1.Text));
            cmd.Parameters.Add(new MySqlParameter("@price", bunifuMetroTextbox2.Text));
            cmd.Parameters.Add(new MySqlParameter("@quality", bunifuMetroTextbox3.Text));
            cmd.Parameters.Add(new MySqlParameter("@id_supplier", Form1.id_user));
            MessageBox.Show("Advertisement was submitted successfully");
            bunifuMetroTextbox1.Text = "";
            bunifuMetroTextbox2.Text = "";
            bunifuMetroTextbox3.Text = "";
            cmd.ExecuteNonQuery();
            db.connection.Close();
        }
    }
}
