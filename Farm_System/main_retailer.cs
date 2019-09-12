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
   
    public partial class main_retailer : Form
    {
        
        public main_retailer()
        {
            InitializeComponent();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            search1.Visible = false;
            offers1.Visible = false;
            //av_crops1.Visible = false;
            av_crops1.load_crops();
            bunifuTransition1.ShowSync(av_crops1);
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            search1.Visible = false;
            //offers1.Visible = false;
            av_crops1.Visible = false;
            offers1.load_offers();
            bunifuTransition1.ShowSync(offers1);
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            //search1.Visible = false;
            offers1.Visible = false;
            av_crops1.Visible = false;          
            bunifuTransition1.ShowSync(search1);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void main_retailer_Load(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
