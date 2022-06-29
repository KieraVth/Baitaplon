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
    public partial class frmMONHOC : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
        Boolean AddnewFlag = false;
        public frmMONHOC()
        {
            InitializeComponent();
        }

        private void grdMONHOC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();

        }

        private void comTenTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = " select distinct " + comTenTruong.Text + " from MONHOC ";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGt.DataSource = comdt;
            comGt.DisplayMember = comTenTruong.Text;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            sql = " select * from MONHOC where " + comTenTruong.Text + "='" + comGt.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdMONHOC.DataSource = dt;
            NapCT();
        }

        private void btnHuyloc_Click(object sender, EventArgs e)
        {
            sql = " select * from MONHOC ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdMONHOC.DataSource = dt;
            NapCT();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không ?(Y/N)", "Xác nhận yêu cầu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Bạn vừa chọn nút Yes, tôi sẽ xóa ngay đây!");
                sql = "delete from MONHOC where MAMON='" + txtMAMON.Text + "'";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                i = grdMONHOC.CurrentRow.Index;
                grdMONHOC.Rows.RemoveAt(i);
                NapCT();

            }
            else
            {
                MessageBox.Show("Bạn đã chọn No, vậy chào nhé!");
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            i = grdMONHOC.RowCount;
            grdMONHOC.CurrentCell = grdMONHOC[0, i - 1];
            NapCT();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdMONHOC.CurrentCell = grdMONHOC[0, 0];
            NapCT();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdMONHOC.CurrentRow.Index;
            if (i == grdMONHOC.RowCount - 1)
            {
                grdMONHOC.CurrentCell = grdMONHOC[0, 0];
            }
            else
            {
                grdMONHOC.CurrentCell = grdMONHOC[0, i + 1];
            }
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = grdMONHOC.CurrentRow.Index;
            if (i == 0)
            {
                grdMONHOC.CurrentCell = grdMONHOC[0, grdMONHOC.RowCount - 1];
            }
            else
            {
                grdMONHOC.CurrentCell = grdMONHOC[0, i - 1];
            }
            NapCT();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (AddnewFlag == true)
            {
                MessageBox.Show("Bạn vừa thêm mới đúng không. Giờ tôi sẽ chạy lệnh insert into");
                AddnewFlag = false;
                sql = "insert into MONHOC ( MAMON, TENMON, SOTC )" +
                    "values ('" + txtMAMON.Text + "' , N'" + txtTENMON.Text + "', '" + txtSOTC.Text + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            }
            else
            {
                
                MessageBox.Show("Bạn vừa sửa chữa bản ghi đúng không. Giờ tôi sẽ chạy lệnh update");
                cmd.Connection = conn;
                for (i = 0; i <= grdMONHOC.RowCount - 2; i++)
                {
                    
                    txtMAMON.Text = grdMONHOC.Rows[i].Cells["MAMON"].Value.ToString();
                    txtTENMON.Text = grdMONHOC.Rows[i].Cells["TENMON"].Value.ToString();
                    txtSOTC.Text = grdMONHOC.Rows[i].Cells["SOTC"].Value.ToString();
                   

                    sql = "update MONHOC set TENMON= N'" + txtTENMON.Text + "', SOTC= '" + txtSOTC.Text +
                    "' where MAMON= '" + txtMAMON.Text + "'";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }

            }
        }

        private void frmMONHOC_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLQKTCDataSet.MONHOC' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter2.Fill(this.qLQKTCDataSet.MONHOC);

            constr = "Data Source=LAPTOP-83OJ99HI\\SQLEXPRESS;Initial Catalog=QLQKTC;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " select * from MONHOC ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdMONHOC.DataSource = dt;
            NapCT();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddnewFlag = true;
            int i = grdMONHOC.RowCount;
            grdMONHOC.CurrentCell = grdMONHOC[0, i - 1];
            NapCT();
            txtMAMON.Focus();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy sửa trực tiếp vào ô lưới và kết thúc bằng việc ấn nút cập nhật");
        }

        private void NapCT()
        {

            i = grdMONHOC.CurrentRow.Index;
            txtMAMON.Text = grdMONHOC.Rows[i].Cells["MAMON"].Value.ToString();
            txtTENMON.Text = grdMONHOC.Rows[i].Cells["TENMON"].Value.ToString();
            txtSOTC.Text = grdMONHOC.Rows[i].Cells["SOTC"].Value.ToString();
    



        }
    }
}
