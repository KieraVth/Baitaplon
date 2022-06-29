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
    public partial class frmQUANLY : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
        Boolean AddnewFlag = false;
        public frmQUANLY()
        {
            InitializeComponent();
        }

        private void frmQUANLY_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLQKTCDataSet.QUANLY' table. You can move, or remove it, as needed.
            this.qUANLYTableAdapter2.Fill(this.qLQKTCDataSet.QUANLY);

            constr = "Data Source=LAPTOP-83OJ99HI\\SQLEXPRESS;Initial Catalog=QLQKTC;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " select * from QUANLY ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdQUANLY.DataSource = dt;
            NapCT();
        }
        private void NapCT()
        {

            i = grdQUANLY.CurrentRow.Index;
            txtMAQL.Text = grdQUANLY.Rows[i].Cells["MAQL"].Value.ToString();
            txtHOTEN.Text = grdQUANLY.Rows[i].Cells["HOTEN"].Value.ToString();
            txtNGAYSINH.Text = grdQUANLY.Rows[i].Cells["NGAYSINH"].Value.ToString();
            txtGIOITINH.Text = grdQUANLY.Rows[i].Cells["GIOITINH"].Value.ToString();
            txtQUEQUAN.Text = grdQUANLY.Rows[i].Cells["QUEQUAN"].Value.ToString();
            

        }

        private void comTenTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = " select distinct " + comTenTruong.Text + " from QUANLY ";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGt.DataSource = comdt;
            comGt.DisplayMember = comTenTruong.Text;
        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            sql = " select * from QUANLY where " + comTenTruong.Text + "='" + comGt.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdQUANLY.DataSource = dt;
            NapCT();
        }

        private void btnHuyloc_Click(object sender, EventArgs e)
        {
            sql = " select * from QUANLY ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdQUANLY.DataSource = dt;
            NapCT();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không ?(Y/N)", "Xác nhận yêu cầu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Bạn vừa chọn nút Yes, tôi sẽ xóa ngay đây!");
                sql = "delete from QUANLY where MAQL='" + txtMAQL.Text + "'";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                i = grdQUANLY.CurrentRow.Index;
                grdQUANLY.Rows.RemoveAt(i);
                NapCT();

            }
            else
            {
                MessageBox.Show("Bạn đã chọn No, vậy chào nhé!");
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            i = grdQUANLY.RowCount;
            grdQUANLY.CurrentCell = grdQUANLY[0, i - 1];
            NapCT();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdQUANLY.CurrentCell = grdQUANLY[0, 0];
            NapCT();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdQUANLY.CurrentRow.Index;
            if (i == grdQUANLY.RowCount - 1)
            {
                grdQUANLY.CurrentCell = grdQUANLY[0, 0];
            }
            else
            {
                grdQUANLY.CurrentCell = grdQUANLY[0, i + 1];
            }
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = grdQUANLY.CurrentRow.Index;
            if (i == 0)
            {
                grdQUANLY.CurrentCell = grdQUANLY[0, grdQUANLY.RowCount - 1];
            }
            else
            {
                grdQUANLY.CurrentCell = grdQUANLY[0, i - 1];
            }
            NapCT();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddnewFlag = true;
            int i = grdQUANLY.RowCount;
            grdQUANLY.CurrentCell = grdQUANLY[0, i - 1];
            NapCT();
            txtMAQL.Focus();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy sửa trực tiếp vào ô lưới và kết thúc bằng việc ấn nút cập nhật");
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (AddnewFlag == true)
            {
                MessageBox.Show("Bạn vừa thêm mới đúng không. Giờ tôi sẽ chạy lệnh insert into");
                AddnewFlag = false;
                sql = "insert into MONTIENQUYET ( MAQL, HOTEN, NGAYSINH, GIOITINH, QUEQUAN )" +
                    "values ('" + txtMAQL.Text + "' , N'" + txtHOTEN.Text + "', '"+txtNGAYSINH.Text+
                    "', '"+txtGIOITINH.Text+"', '"+txtQUEQUAN.Text+"')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            }
            else
            {

                MessageBox.Show("Bạn vừa sửa chữa bản ghi đúng không. Giờ tôi sẽ chạy lệnh update");
                cmd.Connection = conn;
                for (i = 0; i <= grdQUANLY.RowCount - 2; i++)
                {

                    txtMAQL.Text = grdQUANLY.Rows[i].Cells["MAQL"].Value.ToString();
                    txtHOTEN.Text = grdQUANLY.Rows[i].Cells["HOTEN"].Value.ToString();
                    txtGIOITINH.Text = grdQUANLY.Rows[i].Cells["GIOITINH"].Value.ToString();
                    txtNGAYSINH.Text = grdQUANLY.Rows[i].Cells["NGAYSINH"].Value.ToString();
                    txtQUEQUAN.Text = grdQUANLY.Rows[i].Cells["QUEQUAN"].Value.ToString();

                    sql = "update QUANLY set HOTEN= N'" + txtHOTEN.Text + "', GIOITINH= '"+ txtGIOITINH.Text +
                        "', NGAYSINH = '"+ txtNGAYSINH.Text +"', QUEQUAN= '"+ txtQUEQUAN.Text +"' where MAQL= '" + txtMAQL.Text + "'";

                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }

            }
        }

        private void grdQUANLY_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();

        }
    }
}
