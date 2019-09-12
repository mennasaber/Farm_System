using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Farm_System
{
    public partial class requestcrops : UserControl
    {
        static string sql = @"Data Source = DESKTOP-14KH0FM\SQLEXPRESS ; Initial Catalog = farm_system ; Integrated Security = True ; MultipleActiveResultSets = True ; User ID = '' ; Password = '' ";
        SqlConnection con = new SqlConnection(sql);
        public requestcrops()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into r_crops(id_farmer,name) values (@id_farmer,@name)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id_farmer", Form1.id_user);
            cmd.Parameters.AddWithValue("@name",textBox1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            textBox1.Text = "";
            MessageBox.Show("Crop is added successfully");
      
        }
    }
}
