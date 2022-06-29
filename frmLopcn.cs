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
    public partial class frmLopcn : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
        Boolean AddnewFlag = false;
        public frmLopcn()
        {
            InitializeComponent();
        }

        private void frmLopcn_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLQKTCDataSet.LOPCN' table. You can move, or remove it, as needed.
            //this.lOPCNTableAdapter1.Fill(this.qLQKTCDataSet.LOPCN);
            // TODO: This line of code loads data into the 'quanlyDKTCDataSet1.LOPCN' table. You can move, or remove it, as needed.
            //this.lOPCNTableAdapter.Fill(this.quanlyDKTCDataSet1.LOPCN);
            constr = "Data Source=LAPTOP-83OJ99HI\\SQLEXPRESS;Initial Catalog=QLQKTC;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " select * from LOPCN ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdLOPCN.DataSource = dt;
            NapCT();


        }

        private void comTenTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = " select distinct " + comTenTruong.Text + " from LOPCN ";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGt.DataSource = comdt;
            comGt.DisplayMember = comTenTruong.Text;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            sql = " select * from LOPCN where " + comTenTruong.Text + "='" + comGt.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdLOPCN.DataSource = dt;
            NapCT();
        }

        private void btnHuyloc_Click(object sender, EventArgs e)
        {
            sql = " select * from LOPCN ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdLOPCN.DataSource = dt;
            NapCT();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không ?(Y/N)", "Xác nhận yêu cầu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Bạn vừa chọn nút Yes, tôi sẽ xóa ngay đây!");
                sql = "delete from LOPCN where MALCN='" + txtMALCN.Text + "'";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                i = grdLOPCN.CurrentRow.Index;
                grdLOPCN.Rows.RemoveAt(i);
                NapCT();

            }
            else
            {
                MessageBox.Show("Bạn đã chọn No, vậy chào nhé!");
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            i = grdLOPCN.RowCount;
            grdLOPCN.CurrentCell = grdLOPCN[0, i - 1];
            NapCT();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdLOPCN.CurrentCell = grdLOPCN[0, 0];
            NapCT();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {

            i = grdLOPCN.CurrentRow.Index;
            if (i == grdLOPCN.RowCount - 1)
            {
                grdLOPCN.CurrentCell = grdLOPCN[0, 0];
            }
            else
            {
                grdLOPCN.CurrentCell = grdLOPCN[0, i + 1];
            }
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = grdLOPCN.CurrentRow.Index;
            if (i == 0)
            {
                grdLOPCN.CurrentCell = grdLOPCN[0, grdLOPCN.RowCount - 1];
            }
            else
            {
                grdLOPCN.CurrentCell = grdLOPCN[0, i - 1];
            }
            NapCT();
        }

        private void btnFirst_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (AddnewFlag == true)
            {
                MessageBox.Show("Bạn vừa thêm mới đúng không. Giờ tôi sẽ chạy lệnh insert into");
                AddnewFlag = false;
                sql = "insert into LOPCN ( MALCN, TENLOP, KHOA )" +
                    "values ('" + txtMALCN.Text + "' , N'" + txtTENLCN.Text + "', '" + txtKHOA.Text + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            }
            else
            {

                MessageBox.Show("Bạn vừa sửa chữa bản ghi đúng không. Giờ tôi sẽ chạy lệnh update");
                cmd.Connection = conn;
                for (i = 0; i <= grdLOPCN.RowCount - 2; i++)
                {

                    txtMALCN.Text = grdLOPCN.Rows[i].Cells["MALCN"].Value.ToString();
                    txtTENLCN.Text = grdLOPCN.Rows[i].Cells["TENLOP"].Value.ToString();
                    txtKHOA.Text = grdLOPCN.Rows[i].Cells["KHOA"].Value.ToString();


                    sql = "update LOPCN set TENLOP= N'" + txtTENLCN.Text + "', KHOA= '" + txtKHOA.Text +
                    "' where MALCN= '" + txtMALCN.Text + "'";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }

            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddnewFlag = true;
            int i = grdLOPCN.RowCount;
            grdLOPCN.CurrentCell = grdLOPCN[0, i - 1];
            NapCT();
            txtMALCN.Focus();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy sửa trực tiếp vào ô lưới và kết thúc bằng việc ấn nút cập nhật");
        }

        private void grdLOPCN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }
        private void NapCT()
        {

            i = grdLOPCN.CurrentRow.Index;
            txtMALCN.Text = grdLOPCN.Rows[i].Cells["MALCN"].Value.ToString();
            txtTENLCN.Text = grdLOPCN.Rows[i].Cells["TENLOP"].Value.ToString();
            txtKHOA.Text = grdLOPCN.Rows[i].Cells["KHOA"].Value.ToString();




        }
    }
}
