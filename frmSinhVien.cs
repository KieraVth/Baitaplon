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
    public partial class frmSinhVien : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlDataAdapter da = new SqlDataAdapter();
        SqlCommand cmd = new SqlCommand();
        DataTable dt = new DataTable();
        DataTable comdt = new DataTable();
        string sql, constr;
        int i;
        Boolean AddnewFlag = false;
        public frmSinhVien()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLQKTCDataSet.SINHVIEN' table. You can move, or remove it, as needed.
            //this.sINHVIENTableAdapter2.Fill(this.qLQKTCDataSet.SINHVIEN);

            constr = "Data Source=LAPTOP-83OJ99HI\\SQLEXPRESS;Initial Catalog=QLQKTC;Integrated Security=True";
            conn.ConnectionString = constr;
            conn.Open();
            sql = " select * from SINHVIEN ";
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

        private void comTenTruong_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql = " select distinct " + comTenTruong.Text + " from SINHVIEN ";
            da = new SqlDataAdapter(sql, conn);
            comdt.Clear();
            da.Fill(comdt);
            comGt.DataSource = comdt;
            comGt.DisplayMember = comTenTruong.Text;

        }

        private void btnLoc_Click(object sender, EventArgs e)
        {
            sql = " select * from SINHVIEN where " + comTenTruong.Text + "='" + comGt.Text + "'";
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdSinhVien.DataSource = dt;
            NapCT();
        }

        private void btnHuyloc_Click(object sender, EventArgs e)
        {
            sql = " select * from SINHVIEN " ;
            da = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dt.Clear();
            da.Fill(dt);
            grdSinhVien.DataSource = dt;
            NapCT();
             
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //btnxoa
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa bản ghi này không ?(Y/N)", "Xác nhận yêu cầu", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Bạn vừa chọn nút Yes, tôi sẽ xóa ngay đây!");
                sql = "delete from SINHVIEN where MASV='" + txtMASV.Text + "'";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                i = grdSinhVien.CurrentRow.Index;
                grdSinhVien.Rows.RemoveAt(i);
                NapCT();

            }
            else
            {
                MessageBox.Show("Bạn đã chọn No, vậy chào nhé!");
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            i = grdSinhVien.RowCount;
            grdSinhVien.CurrentCell = grdSinhVien[0, i - 1];
            NapCT();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            grdSinhVien.CurrentCell = grdSinhVien[0, 0];
            NapCT();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            i = grdSinhVien.CurrentRow.Index;
            if(i==grdSinhVien.RowCount-1)
            {
                grdSinhVien.CurrentCell = grdSinhVien[0, 0];
            } 
            else
            {
                grdSinhVien.CurrentCell = grdSinhVien[0, i + 1];
            }
            NapCT();
        }

        private void btnPrv_Click(object sender, EventArgs e)
        {
            i = grdSinhVien.CurrentRow.Index;
            if (i == 0)
            {
                grdSinhVien.CurrentCell = grdSinhVien[0, grdSinhVien.RowCount - 1];
            }
            else
            {
                grdSinhVien.CurrentCell = grdSinhVien[0, i - 1];
            }
            NapCT();
        }
        

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (AddnewFlag == true)
            {
                MessageBox.Show("Bạn vừa thêm mới đúng không. Giờ tôi sẽ chạy lệnh insert into");
                AddnewFlag = false;
                sql = "insert into SINHVIEN ( MASV, MALCN, HOTEN, NGAYSINH,  GIOITINH, QUEQUAN, NAMHOC )" +
                    "values ('" + txtMASV.Text + "' , '" + txtMALCN.Text + "', N'" + txtHOTEN.Text + "', "+
                    "'" + txtNGAYSINH.Text + "', N'" + txtGIOITINH + "',  N'" + txtQUEQUAN.Text + "', '" + txtNAMHOC.Text + "')";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            }
            else
            {
                //cập nhật từng bản ghi một
                /*MessageBox.Show("Bạn vừa sửa chữa bản ghi đúng không. Giờ tôi sẽ chạy lệnh update");
                sql = "update tblDMHH set TenHH= N'" + txtTenHH.Text + "', Dvt= N'" + txtDvt.Text +
                "', DGvnd= " + txtDGvnd.Text + ", SanXuat= N'" + txtSanXuat.Text + "' where MaHH= '"+txtMaHH.Text+"'";
                cmd.Connection = conn;
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();*/
                // cập nhật nhiều bản ghi một lần

                //i = grdSinhVien.CurrentRow.Index;
                //i đọc giá trị hiện thời 
                MessageBox.Show("Bạn vừa sửa chữa bản ghi đúng không. Giờ tôi sẽ chạy lệnh update");
                cmd.Connection = conn;
                for (i = 0; i <= grdSinhVien.RowCount - 2; i++)
                {
                    //DateTime dt = new DateTime();
                    //String.Format("{0:MM/dd/yy}", dt);
                    DateTime NGAYSINH = DateTime.Parse(txtNGAYSINH.Value.ToString());
                    txtNGAYSINH.Text = NGAYSINH.ToString("dd/MM/yy");
                    txtMASV.Text = grdSinhVien.Rows[i].Cells["MASV"].Value.ToString();
                    txtMALCN.Text = grdSinhVien.Rows[i].Cells["MALCN"].Value.ToString();
                    txtHOTEN.Text = grdSinhVien.Rows[i].Cells["HOTEN"].Value.ToString();
                    txtNGAYSINH.Text = grdSinhVien.Rows[i].Cells["NGAYSINH"].Value.ToString();
                    txtGIOITINH.Text = grdSinhVien.Rows[i].Cells["GIOITINH"].Value.ToString();
                    txtQUEQUAN.Text = grdSinhVien.Rows[i].Cells["QUEQUAN"].Value.ToString();
                    txtNAMHOC.Text = grdSinhVien.Rows[i].Cells["NAMHOC"].Value.ToString();

                    sql = "update SINHVIEN set HOTEN= N'" + txtHOTEN.Text + "', NGAYSINH= '" + txtNGAYSINH.Text +
                    "', GIOITINH= N'" + txtGIOITINH.Text + "', QUEQUAN= N'" + txtQUEQUAN.Text + "', NAMHOC= '" + txtNAMHOC + "' where MASV= '" + txtMASV.Text + "'";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                }

            }

           
        } 
        

        private void NapCT()
        {

            i = grdSinhVien.CurrentRow.Index;
            txtMASV.Text = grdSinhVien.Rows[i].Cells["MASV"].Value.ToString();
            txtMALCN.Text = grdSinhVien.Rows[i].Cells["MALCN"].Value.ToString();
            txtHOTEN.Text = grdSinhVien.Rows[i].Cells["HOTEN"].Value.ToString();
            txtNGAYSINH.Text = grdSinhVien.Rows[i].Cells["NGAYSINH"].Value.ToString();
            txtGIOITINH.Text = grdSinhVien.Rows[i].Cells["GIOITINH"].Value.ToString();
            txtQUEQUAN.Text = grdSinhVien.Rows[i].Cells["QUEQUAN"].Value.ToString();
            txtNAMHOC.Text = grdSinhVien.Rows[i].Cells["NAMHOC"].Value.ToString();



        }
        

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            AddnewFlag = true;
            int i = grdSinhVien.RowCount;
            grdSinhVien.CurrentCell = grdSinhVien[0, i - 1];
            NapCT();
            txtMASV.Focus();
        }

        private void btnedit_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Hãy sửa trực tiếp vào ô lưới và kết thúc bằng việc ấn nút cập nhật");
        }

       
    }
}
