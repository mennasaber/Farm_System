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
    public partial class ad : UserControl
    {
        public ad()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        public void name_crop(string name)
        {
            label1.Text = name;
        }
        public void quality(string qual)
        {
            label4.Text = qual;
        }
        public void price(int pri)
        {
            label6.Text = pri.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            statue_ads statue = new statue_ads(id_a);
            statue.Show();
        }

        private void ad_Load(object sender, EventArgs e)
        {

        }
        int id_a;
        public void read_id(int id)
        {

            id_a = id;
        }
    }
}
