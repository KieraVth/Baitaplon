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
    public partial class frmSinhvien : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        string sql, constr;
        int i;
        public frmSinhvien()
        {
            InitializeComponent();
        }

        private void frmSinhvien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dKTCDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            // this.sINHVIENTableAdapter.Fill(this.dKTCDataSet.SINHVIEN);
            constr = "Data Source=LAPTOP-83OJ99HI\\SQLEXPRESS;Initial Catalog=DKTC;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = "select MASV, HOTEN, GIOITINH, NGAYSINH, QUEQUAN, NAMHOC, MATKHAU, TENLOP from SINHVIEN, LOPCN where SINHVIEN.MALCN= LOPCN.MALCN";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdSinhVien.DataSource = dt;
            NapCT();

        }

        private void grdSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void NapCT()
        {
         i = grdSinhVien.CurrentRow.Index;
            txtmsv.Text = grdSinhVien.Rows[i].Cells["MASV"].Value.ToString();
            txtmk.Text = grdSinhVien.Rows[i].Cells["MATKHAU"].Value.ToString();
            txthoten.Text = grdSinhVien.Rows[i].Cells["HOTEN"].Value.ToString();
            txtns.Text = grdSinhVien.Rows[i].Cells["NGAYSINH"].Value.ToString();
            txtgioitinh.Text = grdSinhVien.Rows[i].Cells["GIOITINH"].Value.ToString();
            txtquequan.Text = grdSinhVien.Rows[i].Cells["QUEQUAN"].Value.ToString();
            txtnamhoc.Text = grdSinhVien.Rows[i].Cells["NAMHOC"].Value.ToString();
            txtlopcn.Text = grdSinhVien.Rows[i].Cells["TENLOP"].Value.ToString();


        }
    }
}
