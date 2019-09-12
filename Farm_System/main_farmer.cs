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
    public partial class main_farmer : Form
    {
        public main_farmer()
        {
            InitializeComponent();
        }

        private void main_farmer_Load(object sender, EventArgs e)
        {
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            subcomplaints1.Visible = false;
            viewcomplaints1.Visible = false;
            viewreqcrops1.Visible = false;
            view_tips1.Visible = false;
            viewoffers1.Visible = false;
            view_ads1.Visible = false;
            requestcrops1.Visible = false;
            bunifuTransition1.ShowSync(addavcrops1);
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            addavcrops1.Visible = false;
            viewcomplaints1.Visible = false;
            viewreqcrops1.Visible = false;
            view_tips1.Visible = false;
            viewoffers1.Visible = false;
            view_ads1.Visible = false;
            requestcrops1.Visible = false;
            bunifuTransition1.ShowSync(subcomplaints1);
        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            addavcrops1.Visible = false;
            viewcomplaints1.Visible = false;
            viewreqcrops1.Visible = false;
            view_tips1.Visible = false;
            viewoffers1.Visible = false;
            view_ads1.Visible = false;
            subcomplaints1.Visible = false;
            bunifuTransition1.ShowSync(requestcrops1);
        }

        private void bunifuThinButton27_Click(object sender, EventArgs e)
        {
            addavcrops1.Visible = false;
            viewcomplaints1.Visible = false;
            viewreqcrops1.Visible = false;
            requestcrops1.Visible = false;
            viewoffers1.Visible = false;
            view_ads1.Visible = false;
            subcomplaints1.Visible = false;
            view_tips1.load_tips();
            bunifuTransition1.ShowSync(view_tips1);
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            addavcrops1.Visible = false;
            viewcomplaints1.Visible = false;
            viewreqcrops1.Visible = false;
            requestcrops1.Visible = false;
            view_tips1.Visible = false;
            view_ads1.Visible = false;
            subcomplaints1.Visible = false;
            viewoffers1.load_offers();
            bunifuTransition1.ShowSync(viewoffers1);
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            addavcrops1.Visible = false;
            viewoffers1.Visible = false;
            viewreqcrops1.Visible = false;
            requestcrops1.Visible = false;
            view_tips1.Visible = false;
            view_ads1.Visible = false;
            subcomplaints1.Visible = false;
            viewcomplaints1.load_complaints();
            bunifuTransition1.ShowSync(viewcomplaints1);
        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            addavcrops1.Visible = false;
            viewcomplaints1.Visible = false;
            view_ads1.Visible = false;
            viewoffers1.Visible = false;
            view_tips1.Visible = false;
            requestcrops1.Visible = false;
            subcomplaints1.Visible = false;
            viewreqcrops1.load_ads();       
            bunifuTransition1.ShowSync(viewreqcrops1);
        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
