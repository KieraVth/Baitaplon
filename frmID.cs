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
    public partial class frmID : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
        Boolean AddnewFlag = false;
        public frmID()
        {
            InitializeComponent();
        }

        private void comTenTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = " select distinct " + comTenTruong.Text + " from ID ";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGt.DataSource = comdt;
            comGt.DisplayMember = comTenTruong.Text;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            sql = " select * from ID where " + comTenTruong.Text + "='" + comGt.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdID.DataSource = dt;
            NapCT();
        }

        private void btnHuyloc_Click(object sender, EventArgs e)
        {
            sql = " select * from ID ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdID.DataSource = dt;
            NapCT();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không ?(Y/N)", "Xác nhận yêu cầu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Bạn vừa chọn nút Yes, tôi sẽ xóa ngay đây!");
                sql = "delete from ID where TAIKHOAN='" + txtTAIKHOAN.Text + "'";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                i = grdID.CurrentRow.Index;
                grdID.Rows.RemoveAt(i);
                NapCT();

            }
            else
            {
                MessageBox.Show("Bạn đã chọn No, vậy chào nhé!");
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            i = grdID.RowCount;
            grdID.CurrentCell = grdID[0, i - 1];
            NapCT();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdID.CurrentCell = grdID[0, 0];
            NapCT();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdID.CurrentRow.Index;
            if (i == grdID.RowCount - 1)
            {
                grdID.CurrentCell = grdID[0, 0];
            }
            else
            {
                grdID.CurrentCell = grdID[0, i + 1];
            }
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = grdID.CurrentRow.Index;
            if (i == 0)
            {
                grdID.CurrentCell = grdID[0, grdID.RowCount - 1];
            }
            else
            {
                grdID.CurrentCell = grdID[0, i - 1];
            }
            NapCT();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (AddnewFlag == true)
            {
                MessageBox.Show("Bạn vừa thêm mới đúng không. Giờ tôi sẽ chạy lệnh insert into");
                AddnewFlag = false;
                sql = "insert into ID ( TAIKHOAN, MATKHAU, NHOM )" +
                    "values ('" + txtTAIKHOAN.Text + "' , N'" + txtMATKHAU.Text + "', '" + txtNHOM.Text + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            }
            else
            {

                MessageBox.Show("Bạn vừa sửa chữa bản ghi đúng không. Giờ tôi sẽ chạy lệnh update");
                cmd.Connection = conn;
                for (i = 0; i <= grdID.RowCount - 2; i++)
                {

                    txtTAIKHOAN.Text = grdID.Rows[i].Cells["TAIKHOAN"].Value.ToString();
                    txtMATKHAU.Text = grdID.Rows[i].Cells["MATKHAU"].Value.ToString();
                    txtNHOM.Text = grdID.Rows[i].Cells["NHOM"].Value.ToString();


                    sql = "update ID set MATKHAU= N'" + txtMATKHAU.Text + "', NHOM= '" + txtNHOM.Text +
                    "' where TAIKHOAN= '" + txtTAIKHOAN.Text + "'";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }

            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddnewFlag = true;
            int i = grdID.RowCount;
            grdID.CurrentCell = grdID[0, i - 1];
            NapCT();
            txtTAIKHOAN.Focus();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy sửa trực tiếp vào ô lưới và kết thúc bằng việc ấn nút cập nhật");
        }

        private void frmID_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLQKTCDataSet.ID' table. You can move, or remove it, as needed.
            // this.iDTableAdapter.Fill(this.qLQKTCDataSet.ID);
            constr = "Data Source=LAPTOP-83OJ99HI\\SQLEXPRESS;Initial Catalog=QLQKTC;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " select * from ID ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdID.DataSource = dt;
            NapCT();

        }

        private void grdID_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();

        }

        private void NapCT()
        {

            i = grdID.CurrentRow.Index;
            txtTAIKHOAN.Text = grdID.Rows[i].Cells["TAIKHOAN"].Value.ToString();
            txtMATKHAU.Text = grdID.Rows[i].Cells["MATKHAU"].Value.ToString();
            txtNHOM.Text = grdID.Rows[i].Cells["NHOM"].Value.ToString();




        }
    }
}
