using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            pictureBox2.Width += 20;
            if (pictureBox2.Width == 300 || pictureBox2.Width > 300)
            {
                this.Visible = false;
                timer1.Stop();
                frmTrangChu frm = new frmTrangChu();
                frm.Show();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
