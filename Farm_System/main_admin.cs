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
    public partial class main_admin : Form
    {
        public main_admin()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            complaints1.Visible = false;
            view_tips1.Visible = false;
            bunifuTransition1.ShowSync(tips1);
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            complaints1.Visible = false;
            tips1.Visible = false;
            view_tips1.load_tips();
            bunifuTransition1.ShowSync(view_tips1);
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            view_tips1.Visible = false;
            tips1.Visible = false;
            complaints1.view_complaints();
            bunifuTransition1.ShowSync(complaints1);
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
