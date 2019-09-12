using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farm_System
{
    public partial class main_supplier : Form
    {
        public main_supplier()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            requested_crops1.Visible = false;
            view_ads1.Visible = false;
            bunifuTransition1.ShowSync(add_ads1);
        }

        private void requested_crops1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            requested_crops1.Visible = false;
            add_ads1.Visible = false;
            view_ads1.load_ads();
            bunifuTransition1.ShowSync(view_ads1);
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            view_ads1.Visible = false;
            add_ads1.Visible = false;
            requested_crops1.load_r_crops();
            bunifuTransition1.ShowSync(requested_crops1);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
