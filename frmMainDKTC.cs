using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Baitaplon
{
    public partial class frmMainDKTC : Form
    {
        public frmMainDKTC()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            statustime.Text = System.DateTime.Now.ToString();
        }

        private void HethongToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void frmMainDKTC_Load(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.ShowDialog();
            
        }

        private void svToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSinhVien f = new frmSinhVien();
            f.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMONHOC f = new frmMONHOC();
            f.Show();
        }

        private void danhMụcLớpHọcPhầnToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmLopHP f = new frmLopHP();
            f.Show();
        }

        private void danhMụcLớpHọcPhầnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLopcn f = new frmLopcn();
            f.Show();
        }

        private void danhMụcDanhSáchĐăngKýToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMonTQ f = new frmMonTQ();
            f.Show();
        }

        private void mhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQUANLY f = new frmQUANLY();
            f.Show();
        }

        private void gvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmID f = new frmID();
            f.Show();
        }
    }
}
