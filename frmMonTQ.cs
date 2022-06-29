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
    public partial class frmMonTQ : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
        Boolean AddnewFlag = false;
        public frmMonTQ()
        {
            InitializeComponent();
        }

        private void grdMONTQ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdMONTQ_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();
        }

        private void comTenTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = " select distinct " + comTenTruong.Text + " from MONTIENQUYET ";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGt.DataSource = comdt;
            comGt.DisplayMember = comTenTruong.Text;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            sql = " select * from MONTIENQUYET where " + comTenTruong.Text + "='" + comGt.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdMONTQ.DataSource = dt;
            NapCT();
        }

        private void btnHuyloc_Click(object sender, EventArgs e)
        {
            sql = " select * from MONTIENQUYET ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdMONTQ.DataSource = dt;
            NapCT();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không ?(Y/N)", "Xác nhận yêu cầu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Bạn vừa chọn nút Yes, tôi sẽ xóa ngay đây!");
                sql = "delete from MONTIENQUYET where MAMON='" + txtMAMON.Text + "'";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                i = grdMONTQ.CurrentRow.Index;
                grdMONTQ.Rows.RemoveAt(i);
                NapCT();

            }
            else
            {
                MessageBox.Show("Bạn đã chọn No, vậy chào nhé!");
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            i = grdMONTQ.RowCount;
            grdMONTQ.CurrentCell = grdMONTQ[0, i - 1];
            NapCT();

        }

        private void btnFirst_Click(object sender, EventArgs e)
        {

            grdMONTQ.CurrentCell = grdMONTQ[0, 0];
            NapCT();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdMONTQ.CurrentRow.Index;
            if (i == grdMONTQ.RowCount - 1)
            {
                grdMONTQ.CurrentCell = grdMONTQ[0, 0];
            }
            else
            {
                grdMONTQ.CurrentCell = grdMONTQ[0, i + 1];
            }
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = grdMONTQ.CurrentRow.Index;
            if (i == 0)
            {
                grdMONTQ.CurrentCell = grdMONTQ[0, grdMONTQ.RowCount - 1];
            }
            else
            {
                grdMONTQ.CurrentCell = grdMONTQ[0, i - 1];
            }
            NapCT();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddnewFlag = true;
            int i = grdMONTQ.RowCount;
            grdMONTQ.CurrentCell = grdMONTQ[0, i - 1];
            NapCT();
            txtMAMON.Focus();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy sửa trực tiếp vào ô lưới và kết thúc bằng việc ấn nút cập nhật");
        }

        private void frmMonTQ_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLQKTCDataSet.MONTIENQUYET' table. You can move, or remove it, as needed.
            this.mONTIENQUYETTableAdapter1.Fill(this.qLQKTCDataSet.MONTIENQUYET);
            // TODO: This line of code loads data into the 'quanlyDKTCDataSet1.MONTIENQUYET' table. You can move, or remove it, as needed.
            //this.mONTIENQUYETTableAdapter.Fill(this.quanlyDKTCDataSet1.MONTIENQUYET);
            constr = "Data Source=LAPTOP-83OJ99HI\\SQLEXPRESS;Initial Catalog=QLQKTC;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " select * from MONTIENQUYET ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdMONTQ.DataSource = dt;
            NapCT();

        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (AddnewFlag == true)
            {
                MessageBox.Show("Bạn vừa thêm mới đúng không. Giờ tôi sẽ chạy lệnh insert into");
                AddnewFlag = false;
                sql = "insert into MONTIENQUYET ( MAMON, MAMONTQ )" +
                    "values ('" + txtMAMON.Text + "' , N'" + txtMAMONTQ.Text + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            }
            else
            {

                MessageBox.Show("Bạn vừa sửa chữa bản ghi đúng không. Giờ tôi sẽ chạy lệnh update");
                cmd.Connection = conn;
                for (i = 0; i <= grdMONTQ.RowCount - 2; i++)
                {

                    txtMAMON.Text = grdMONTQ.Rows[i].Cells["MAMON"].Value.ToString();
                    txtMAMONTQ.Text = grdMONTQ.Rows[i].Cells["MAMONTQ"].Value.ToString();
                    


                    sql = "update MONTIENQUYET set MAMONTQ= N'" + txtMAMONTQ.Text +"' where MAMON= '" + txtMAMON.Text + "'";
                    
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }

            }
        }

        private void NapCT()
        {

            i = grdMONTQ.CurrentRow.Index;
            txtMAMON.Text = grdMONTQ.Rows[i].Cells["MAMON"].Value.ToString();
            txtMAMONTQ.Text = grdMONTQ.Rows[i].Cells["MAMONTQ"].Value.ToString();
            




        }
    }
}
