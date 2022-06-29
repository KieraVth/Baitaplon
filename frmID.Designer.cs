
namespace Baitaplon
{
    partial class frmID
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtMATKHAU = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btndel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.sINHVIENTableAdapter = new Baitaplon.QuanlyDKTCDataSetTableAdapters.SINHVIENTableAdapter();
            this.txtTAIKHOAN = new System.Windows.Forms.TextBox();
            this.btnadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lOPCNBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qLQKTCDataSet = new Baitaplon.QLQKTCDataSet();
            this.lOPCNBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlyDKTCDataSet1 = new Baitaplon.QuanlyDKTCDataSet1();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lOPCNTableAdapter = new Baitaplon.QuanlyDKTCDataSet1TableAdapters.LOPCNTableAdapter();
            this.lOPCNTableAdapter1 = new Baitaplon.QLQKTCDataSetTableAdapters.LOPCNTableAdapter();
            this.grdID = new System.Windows.Forms.DataGridView();
            this.quanlyDKTCDataSet = new Baitaplon.QuanlyDKTCDataSet();
            this.btnupdate = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHuyloc = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.comGt = new System.Windows.Forms.ComboBox();
            this.comTenTruong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mONHOCTableAdapter = new Baitaplon.QuanlyDKTCDataSet1TableAdapters.MONHOCTableAdapter();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrv = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtNHOM = new System.Windows.Forms.TextBox();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.iDTableAdapter = new Baitaplon.QLQKTCDataSetTableAdapters.IDTableAdapter();
            this.TAIKHOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATKHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NHOM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lOPCNBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQKTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPCNBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyDKTCDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyDKTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMATKHAU
            // 
            this.txtMATKHAU.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMATKHAU.Location = new System.Drawing.Point(715, 370);
            this.txtMATKHAU.Name = "txtMATKHAU";
            this.txtMATKHAU.Size = new System.Drawing.Size(298, 30);
            this.txtMATKHAU.TabIndex = 171;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(592, 375);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(99, 25);
            this.label18.TabIndex = 169;
            this.label18.Text = "Mật khẩu:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(592, 423);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 25);
            this.label14.TabIndex = 168;
            this.label14.Text = "Nhóm:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(592, 330);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(105, 25);
            this.label13.TabIndex = 167;
            this.label13.Text = "Tài khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(30, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(287, 31);
            this.label2.TabIndex = 166;
            this.label2.Text = "Thông tin người dùng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btndel.Location = new System.Drawing.Point(944, 596);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(121, 33);
            this.btndel.TabIndex = 165;
            this.btndel.Text = "Xóa";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnedit.Location = new System.Drawing.Point(671, 596);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(132, 33);
            this.btnedit.TabIndex = 164;
            this.btnedit.Text = "Sửa";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // txtTAIKHOAN
            // 
            this.txtTAIKHOAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTAIKHOAN.Location = new System.Drawing.Point(715, 325);
            this.txtTAIKHOAN.Name = "txtTAIKHOAN";
            this.txtTAIKHOAN.Size = new System.Drawing.Size(298, 30);
            this.txtTAIKHOAN.TabIndex = 170;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnadd.Location = new System.Drawing.Point(549, 596);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(116, 33);
            this.btnadd.TabIndex = 163;
            this.btnadd.Text = "Thêm ";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(604, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 162;
            this.label1.Text = "Từ khóa:";
            // 
            // lOPCNBindingSource1
            // 
            this.lOPCNBindingSource1.DataMember = "LOPCN";
            this.lOPCNBindingSource1.DataSource = this.qLQKTCDataSet;
            // 
            // qLQKTCDataSet
            // 
            this.qLQKTCDataSet.DataSetName = "QLQKTCDataSet";
            this.qLQKTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPCNBindingSource
            // 
            this.lOPCNBindingSource.DataMember = "LOPCN";
            this.lOPCNBindingSource.DataSource = this.quanlyDKTCDataSet1;
            // 
            // quanlyDKTCDataSet1
            // 
            this.quanlyDKTCDataSet1.DataSetName = "QuanlyDKTCDataSet1";
            this.quanlyDKTCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lOPCNTableAdapter
            // 
            this.lOPCNTableAdapter.ClearBeforeFill = true;
            // 
            // lOPCNTableAdapter1
            // 
            this.lOPCNTableAdapter1.ClearBeforeFill = true;
            // 
            // grdID
            // 
            this.grdID.AutoGenerateColumns = false;
            this.grdID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdID.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TAIKHOAN,
            this.MATKHAU,
            this.NHOM});
            this.grdID.DataSource = this.iDBindingSource;
            this.grdID.Location = new System.Drawing.Point(14, 89);
            this.grdID.MultiSelect = false;
            this.grdID.Name = "grdID";
            this.grdID.RowHeadersWidth = 51;
            this.grdID.RowTemplate.Height = 24;
            this.grdID.Size = new System.Drawing.Size(526, 540);
            this.grdID.TabIndex = 161;
            this.grdID.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdID_CellClick);
            // 
            // quanlyDKTCDataSet
            // 
            this.quanlyDKTCDataSet.DataSetName = "QuanlyDKTCDataSet";
            this.quanlyDKTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnupdate.Location = new System.Drawing.Point(809, 596);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(129, 33);
            this.btnupdate.TabIndex = 175;
            this.btnupdate.Text = "Cập nhật";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(700, 89);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(234, 30);
            this.textBox5.TabIndex = 173;
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.quanlyDKTCDataSet1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnHuyloc);
            this.groupBox1.Controls.Add(this.btnLoc);
            this.groupBox1.Controls.Add(this.comGt);
            this.groupBox1.Controls.Add(this.comTenTruong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(597, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 148);
            this.groupBox1.TabIndex = 176;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc dữ liệu";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(129, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "=";
            // 
            // btnHuyloc
            // 
            this.btnHuyloc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHuyloc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHuyloc.Location = new System.Drawing.Point(160, 108);
            this.btnHuyloc.Name = "btnHuyloc";
            this.btnHuyloc.Size = new System.Drawing.Size(250, 34);
            this.btnHuyloc.TabIndex = 5;
            this.btnHuyloc.Text = "Hủy lọc";
            this.btnHuyloc.UseVisualStyleBackColor = false;
            this.btnHuyloc.Click += new System.EventHandler(this.btnHuyloc_Click);
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoc.Location = new System.Drawing.Point(6, 108);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(117, 34);
            this.btnLoc.TabIndex = 4;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // comGt
            // 
            this.comGt.FormattingEnabled = true;
            this.comGt.Location = new System.Drawing.Point(160, 69);
            this.comGt.Name = "comGt";
            this.comGt.Size = new System.Drawing.Size(250, 33);
            this.comGt.TabIndex = 3;
            // 
            // comTenTruong
            // 
            this.comTenTruong.FormattingEnabled = true;
            this.comTenTruong.Items.AddRange(new object[] {
            "TAIKHOAN",
            "MATKHAU",
            "NHOM"});
            this.comTenTruong.Location = new System.Drawing.Point(6, 69);
            this.comTenTruong.Name = "comTenTruong";
            this.comTenTruong.Size = new System.Drawing.Size(117, 33);
            this.comTenTruong.TabIndex = 2;
            this.comTenTruong.SelectedIndexChanged += new System.EventHandler(this.comTenTruong_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(155, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Giá trị:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Lọc theo:";
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnFirst.Location = new System.Drawing.Point(14, 642);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(95, 33);
            this.btnFirst.TabIndex = 180;
            this.btnFirst.Text = "Đầu";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrv
            // 
            this.btnPrv.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrv.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrv.Location = new System.Drawing.Point(162, 642);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(84, 33);
            this.btnPrv.TabIndex = 179;
            this.btnPrv.Text = "Trước";
            this.btnPrv.UseVisualStyleBackColor = false;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNext.Location = new System.Drawing.Point(299, 642);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 33);
            this.btnNext.TabIndex = 178;
            this.btnNext.Text = "Sau";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLast.Location = new System.Drawing.Point(445, 642);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(95, 33);
            this.btnLast.TabIndex = 177;
            this.btnLast.Text = "Cuối";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(940, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 33);
            this.button1.TabIndex = 174;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtNHOM
            // 
            this.txtNHOM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNHOM.Location = new System.Drawing.Point(715, 415);
            this.txtNHOM.Name = "txtNHOM";
            this.txtNHOM.Size = new System.Drawing.Size(298, 30);
            this.txtNHOM.TabIndex = 172;
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.quanlyDKTCDataSet;
            // 
            // iDBindingSource
            // 
            this.iDBindingSource.DataMember = "ID";
            this.iDBindingSource.DataSource = this.qLQKTCDataSet;
            // 
            // iDTableAdapter
            // 
            this.iDTableAdapter.ClearBeforeFill = true;
            // 
            // TAIKHOAN
            // 
            this.TAIKHOAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.TAIKHOAN.DataPropertyName = "TAIKHOAN";
            this.TAIKHOAN.HeaderText = "Tài khoản";
            this.TAIKHOAN.MinimumWidth = 6;
            this.TAIKHOAN.Name = "TAIKHOAN";
            // 
            // MATKHAU
            // 
            this.MATKHAU.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MATKHAU.DataPropertyName = "MATKHAU";
            this.MATKHAU.HeaderText = "Mật khẩu";
            this.MATKHAU.MinimumWidth = 6;
            this.MATKHAU.Name = "MATKHAU";
            this.MATKHAU.Width = 95;
            // 
            // NHOM
            // 
            this.NHOM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NHOM.DataPropertyName = "NHOM";
            this.NHOM.HeaderText = "Nhóm";
            this.NHOM.MinimumWidth = 6;
            this.NHOM.Name = "NHOM";
            this.NHOM.Width = 74;
            // 
            // frmID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1075, 700);
            this.Controls.Add(this.txtMATKHAU);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.txtTAIKHOAN);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdID);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPrv);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNHOM);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmID";
            this.Text = "frmID";
            this.Load += new System.EventHandler(this.frmID_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOPCNBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQKTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOPCNBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyDKTCDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyDKTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iDBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMATKHAU;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnedit;
        private QuanlyDKTCDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.TextBox txtTAIKHOAN;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource lOPCNBindingSource1;
        private QLQKTCDataSet qLQKTCDataSet;
        private System.Windows.Forms.BindingSource lOPCNBindingSource;
        private QuanlyDKTCDataSet1 quanlyDKTCDataSet1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private QuanlyDKTCDataSet1TableAdapters.LOPCNTableAdapter lOPCNTableAdapter;
        private QLQKTCDataSetTableAdapters.LOPCNTableAdapter lOPCNTableAdapter1;
        private System.Windows.Forms.DataGridView grdID;
        private QuanlyDKTCDataSet quanlyDKTCDataSet;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHuyloc;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ComboBox comGt;
        private System.Windows.Forms.ComboBox comTenTruong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private QuanlyDKTCDataSet1TableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrv;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNHOM;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private System.Windows.Forms.BindingSource iDBindingSource;
        private QLQKTCDataSetTableAdapters.IDTableAdapter iDTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn TAIKHOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATKHAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn NHOM;
    }
}