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
    public partial class frmLopHP : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
        Boolean AddnewFlag = false;
        public frmLopHP()
        {
            InitializeComponent();
        }

        private void frmLopHP_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLQKTCDataSet.LOPHP' table. You can move, or remove it, as needed.
            //this.lOPHPTableAdapter1.Fill(this.qLQKTCDataSet.LOPHP);
            // TODO: This line of code loads data into the 'quanlyDKTCDataSet1.LOPHP' table. You can move, or remove it, as needed.
            //this.lOPHPTableAdapter.Fill(this.quanlyDKTCDataSet1.LOPHP);
            constr = "Data Source=LAPTOP-83OJ99HI\\SQLEXPRESS;Initial Catalog=QLQKTC;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " select * from LOPHP ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdLopHP.DataSource = dt;
            NapCT();

        }
        private void NapCT()
        {

            int i = grdLopHP.CurrentRow.Index;

            txtMAMON.Text = grdLopHP.Rows[i].Cells["MAMON"].Value.ToString();
            txtMALHP.Text = grdLopHP.Rows[i].Cells["MALHP"].Value.ToString();
            txtLICHHOC.Text = grdLopHP.Rows[i].Cells["LICHHOC"].Value.ToString();
            txtPHONGHOC.Text = grdLopHP.Rows[i].Cells["PHONGHOC"].Value.ToString();
            txtGIANGVIEN.Text = grdLopHP.Rows[i].Cells["GIANGVIEN"].Value.ToString();
            txtSOLUONGSV.Text = grdLopHP.Rows[i].Cells["SOLUONGSV"].Value.ToString();
           

        }

        private void comTenTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = " select distinct " + comTenTruong.Text + " from LOPHP ";
            da = new SqlDataAdapter(sql, conn);
            comdt = new DataTable();
            comdt.Clear();
            da.Fill(comdt);
            comGt.DataSource = comdt;
            comGt.DisplayMember = comTenTruong.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //btnloc

            sql = " select * from LOPHP where " + comTenTruong.Text + "='" + comGt.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdLopHP.DataSource = dt;
            NapCT();
        }

        private void bnhuyloc_Click(object sender, EventArgs e)
        {
            sql = " select * from LOPHP ";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdLopHP.DataSource = dt;
            NapCT();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không ?(Y/N)", "Xác nhận yêu cầu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Bạn vừa chọn nút Yes, tôi sẽ xóa ngay đây!");
                sql = "delete from LOPHP where MALHP='" + txtMALHP.Text + "'";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                i = grdLopHP.CurrentRow.Index;
                grdLopHP.Rows.RemoveAt(i);
                NapCT();

            }
            else
            {
                MessageBox.Show("Bạn đã chọn No, vậy chào nhé!");
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            i = grdLopHP.RowCount;
            grdLopHP.CurrentCell = grdLopHP[0, i - 1];
            NapCT();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdLopHP.CurrentCell = grdLopHP[0, 0];
            NapCT();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdLopHP.CurrentRow.Index;
            if (i == grdLopHP.RowCount - 1)
            {
                grdLopHP.CurrentCell = grdLopHP[0, 0];
            }
            else
            {
                grdLopHP.CurrentCell = grdLopHP[0, i + 1];
            }
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = grdLopHP.CurrentRow.Index;
            if (i == 0)
            {
                grdLopHP.CurrentCell = grdLopHP[0, grdLopHP.RowCount - 1];
            }
            else
            {
                grdLopHP.CurrentCell = grdLopHP[0, i - 1];
            }
            NapCT();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (AddnewFlag == true)
            {
                MessageBox.Show("Bạn vừa thêm mới đúng không. Giờ tôi sẽ chạy lệnh insert into");
                AddnewFlag = false;
                sql = " insert into LOPHP ( MAMON , MALHP , PHONGHOC , LICHHOC ,  GIANGVIEN , SOLUONGSV )"+
                    " values ('" + txtMAMON.Text + "', '" + txtMALHP.Text + "', N'" + txtPHONGHOC.Text + "', N'" + txtLICHHOC.Text + "', N'" + txtGIANGVIEN + "', '" + txtSOLUONGSV.Text +  "')" ;
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
           
            }
            else
            {
               
                MessageBox.Show("Bạn vừa sửa chữa bản ghi đúng không. Giờ tôi sẽ chạy lệnh update");
                cmd.Connection = conn;
                for (i = 0; i <= grdLopHP.RowCount - 2; i++)
                {
                    
                    txtMAMON.Text = grdLopHP.Rows[i].Cells["MAMON"].Value.ToString();
                    txtMALHP.Text = grdLopHP.Rows[i].Cells["MALHP"].Value.ToString();
                    txtPHONGHOC.Text = grdLopHP.Rows[i].Cells["PHONGHOC"].Value.ToString();
                    txtLICHHOC.Text = grdLopHP.Rows[i].Cells["LICHHOC"].Value.ToString();
                    txtGIANGVIEN.Text = grdLopHP.Rows[i].Cells["GIANGVIEN"].Value.ToString();
                    txtSOLUONGSV.Text = grdLopHP.Rows[i].Cells["SOLUONGSV"].Value.ToString();
                    

                    sql = " update LOPHP set PHONGHOC = N'" + txtPHONGHOC.Text + "', LICHHOC = '" + txtLICHHOC.Text +
                    "', GIANGVIEN = N'" + txtGIANGVIEN.Text + "', SOLUONGSV = N'" + txtSOLUONGSV + "'  where MALHP = '" + txtMALHP.Text + "'";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }
       
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddnewFlag = true;
            int i = grdLopHP.RowCount;
            grdLopHP.CurrentCell = grdLopHP[0, i - 1];
            NapCT();
            txtMAMON.Focus();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy sửa trực tiếp vào ô lưới và kết thúc bằng việc ấn nút cập nhật");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grdLopHP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapCT();

        }
    }
}
