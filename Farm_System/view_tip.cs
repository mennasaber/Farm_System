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
    public partial class view_tip : UserControl
    {

        public view_tip()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
           
        }
        public void tip_topic(string topic)
        {
            label2.Text = topic;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
