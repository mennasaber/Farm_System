using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_System
{
    public partial class result_search : UserControl
    {
        int id_farmer;
        public result_search()
        {
            InitializeComponent();
        }

        private void result_search_Load(object sender, EventArgs e)
        {

        }
        public void farmer_name(string n)
        {
            label1.Text = n;
        }
        public void farmer_id(int i)
        {
            id_farmer = i;
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            search_av_crops av_crops = new search_av_crops(id_farmer);
            av_crops.Show();
        }
    }

}
