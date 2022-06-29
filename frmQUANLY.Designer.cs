
namespace Baitaplon
{
    partial class frmQUANLY
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
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlyDKTCDataSet = new Baitaplon.QuanlyDKTCDataSet();
            this.txtNGAYSINH = new System.Windows.Forms.DateTimePicker();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.txtQUEQUAN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.sINHVIENTableAdapter = new Baitaplon.QuanlyDKTCDataSetTableAdapters.SINHVIENTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLoc = new System.Windows.Forms.Button();
            this.comGt = new System.Windows.Forms.ComboBox();
            this.comTenTruong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuyloc = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtGIOITINH = new System.Windows.Forms.TextBox();
            this.txtHOTEN = new System.Windows.Forms.TextBox();
            this.txtMAQL = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btndel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grdQUANLY = new System.Windows.Forms.DataGridView();
            this.qUANLYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlyDKTCDataSet1 = new Baitaplon.QuanlyDKTCDataSet1();
            this.btnPrv = new System.Windows.Forms.Button();
            this.qUANLYTableAdapter = new Baitaplon.QuanlyDKTCDataSet1TableAdapters.QUANLYTableAdapter();
            this.qLTCDataSet = new Baitaplon.QLTCDataSet();
            this.qUANLYBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYTableAdapter1 = new Baitaplon.QLTCDataSetTableAdapters.QUANLYTableAdapter();
            this.qLQKTCDataSet = new Baitaplon.QLQKTCDataSet();
            this.qUANLYBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.qUANLYTableAdapter2 = new Baitaplon.QLQKTCDataSetTableAdapters.QUANLYTableAdapter();
            this.MAQL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUEQUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyDKTCDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdQUANLY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyDKTCDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQKTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // sINHVIENBindingSource
            // 
            this.sINHVIENBindingSource.DataMember = "SINHVIEN";
            this.sINHVIENBindingSource.DataSource = this.quanlyDKTCDataSet;
            // 
            // quanlyDKTCDataSet
            // 
            this.quanlyDKTCDataSet.DataSetName = "QuanlyDKTCDataSet";
            this.quanlyDKTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNGAYSINH
            // 
            this.txtNGAYSINH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNGAYSINH.Location = new System.Drawing.Point(1168, 462);
            this.txtNGAYSINH.Name = "txtNGAYSINH";
            this.txtNGAYSINH.RightToLeftLayout = true;
            this.txtNGAYSINH.Size = new System.Drawing.Size(257, 30);
            this.txtNGAYSINH.TabIndex = 141;
            // 
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(219, 635);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(125, 33);
            this.btnFirst.TabIndex = 140;
            this.btnFirst.Text = "Đầu";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(481, 635);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(125, 33);
            this.btnNext.TabIndex = 138;
            this.btnNext.Text = "Sau";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(612, 635);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(125, 33);
            this.btnLast.TabIndex = 137;
            this.btnLast.Text = "Cuối";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // txtQUEQUAN
            // 
            this.txtQUEQUAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQUEQUAN.Location = new System.Drawing.Point(1168, 507);
            this.txtQUEQUAN.Name = "txtQUEQUAN";
            this.txtQUEQUAN.Size = new System.Drawing.Size(257, 30);
            this.txtQUEQUAN.TabIndex = 134;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(944, 512);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(105, 25);
            this.label9.TabIndex = 131;
            this.label9.Text = "Quê quán:";
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(1296, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 33);
            this.button1.TabIndex = 127;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(159, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 25);
            this.label6.TabIndex = 6;
            this.label6.Text = "=";
            // 
            // btnLoc
            // 
            this.btnLoc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnLoc.Location = new System.Drawing.Point(6, 108);
            this.btnLoc.Name = "btnLoc";
            this.btnLoc.Size = new System.Drawing.Size(147, 34);
            this.btnLoc.TabIndex = 4;
            this.btnLoc.Text = "Lọc";
            this.btnLoc.UseVisualStyleBackColor = false;
            this.btnLoc.Click += new System.EventHandler(this.btnLoc_Click);
            // 
            // comGt
            // 
            this.comGt.FormattingEnabled = true;
            this.comGt.Location = new System.Drawing.Point(190, 69);
            this.comGt.Name = "comGt";
            this.comGt.Size = new System.Drawing.Size(280, 33);
            this.comGt.TabIndex = 3;
            // 
            // comTenTruong
            // 
            this.comTenTruong.FormattingEnabled = true;
            this.comTenTruong.Items.AddRange(new object[] {
            "MAQL",
            "HOTEN",
            "GIOITINH",
            "NGAYSINH",
            "QUEQUAN"});
            this.comTenTruong.Location = new System.Drawing.Point(6, 69);
            this.comTenTruong.Name = "comTenTruong";
            this.comTenTruong.Size = new System.Drawing.Size(147, 33);
            this.comTenTruong.TabIndex = 2;
            this.comTenTruong.SelectedIndexChanged += new System.EventHandler(this.comTenTruong_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(185, 32);
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
            this.groupBox1.Location = new System.Drawing.Point(949, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 148);
            this.groupBox1.TabIndex = 130;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc dữ liệu";
            // 
            // btnHuyloc
            // 
            this.btnHuyloc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHuyloc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHuyloc.Location = new System.Drawing.Point(190, 108);
            this.btnHuyloc.Name = "btnHuyloc";
            this.btnHuyloc.Size = new System.Drawing.Size(280, 34);
            this.btnHuyloc.TabIndex = 5;
            this.btnHuyloc.Text = "Hủy lọc";
            this.btnHuyloc.UseVisualStyleBackColor = false;
            this.btnHuyloc.Click += new System.EventHandler(this.btnHuyloc_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(1184, 642);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(129, 33);
            this.btnupdate.TabIndex = 129;
            this.btnupdate.Text = "Cập nhật";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(944, 468);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 128;
            this.label3.Text = "Ngày sinh:";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(1046, 86);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(244, 30);
            this.textBox5.TabIndex = 126;
            // 
            // txtGIOITINH
            // 
            this.txtGIOITINH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGIOITINH.Location = new System.Drawing.Point(1168, 417);
            this.txtGIOITINH.Name = "txtGIOITINH";
            this.txtGIOITINH.Size = new System.Drawing.Size(257, 30);
            this.txtGIOITINH.TabIndex = 125;
            // 
            // txtHOTEN
            // 
            this.txtHOTEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHOTEN.Location = new System.Drawing.Point(1168, 372);
            this.txtHOTEN.Name = "txtHOTEN";
            this.txtHOTEN.Size = new System.Drawing.Size(257, 30);
            this.txtHOTEN.TabIndex = 124;
            // 
            // txtMAQL
            // 
            this.txtMAQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAQL.Location = new System.Drawing.Point(1168, 327);
            this.txtMAQL.Name = "txtMAQL";
            this.txtMAQL.Size = new System.Drawing.Size(257, 30);
            this.txtMAQL.TabIndex = 123;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(944, 377);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(101, 25);
            this.label18.TabIndex = 122;
            this.label18.Text = "Họ và tên:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label14.Location = new System.Drawing.Point(944, 422);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(88, 25);
            this.label14.TabIndex = 121;
            this.label14.Text = "Giới tính:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(944, 330);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(119, 25);
            this.label13.TabIndex = 120;
            this.label13.Text = "Mã quảm lý:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(28, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 31);
            this.label2.TabIndex = 119;
            this.label2.Text = "Thông tin quản lý";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(1319, 642);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(121, 33);
            this.btndel.TabIndex = 118;
            this.btndel.Text = "Xóa";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(1046, 642);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(132, 33);
            this.btnedit.TabIndex = 117;
            this.btnedit.Text = "Sửa";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(924, 642);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(116, 33);
            this.btnadd.TabIndex = 116;
            this.btnadd.Text = "Thêm ";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(950, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 115;
            this.label1.Text = "Từ khóa:";
            // 
            // grdQUANLY
            // 
            this.grdQUANLY.AutoGenerateColumns = false;
            this.grdQUANLY.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdQUANLY.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdQUANLY.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAQL,
            this.HOTEN,
            this.GIOITINH,
            this.NGAYSINH,
            this.QUEQUAN});
            this.grdQUANLY.DataSource = this.qUANLYBindingSource2;
            this.grdQUANLY.Location = new System.Drawing.Point(34, 89);
            this.grdQUANLY.MultiSelect = false;
            this.grdQUANLY.Name = "grdQUANLY";
            this.grdQUANLY.RowHeadersWidth = 51;
            this.grdQUANLY.RowTemplate.Height = 24;
            this.grdQUANLY.Size = new System.Drawing.Size(893, 540);
            this.grdQUANLY.TabIndex = 114;
            this.grdQUANLY.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdQUANLY_CellContentClick);
            // 
            // qUANLYBindingSource
            // 
            this.qUANLYBindingSource.DataMember = "QUANLY";
            this.qUANLYBindingSource.DataSource = this.quanlyDKTCDataSet1;
            // 
            // quanlyDKTCDataSet1
            // 
            this.quanlyDKTCDataSet1.DataSetName = "QuanlyDKTCDataSet1";
            this.quanlyDKTCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnPrv
            // 
            this.btnPrv.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrv.Location = new System.Drawing.Point(350, 635);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(125, 33);
            this.btnPrv.TabIndex = 139;
            this.btnPrv.Text = "Trước";
            this.btnPrv.UseVisualStyleBackColor = false;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // qUANLYTableAdapter
            // 
            this.qUANLYTableAdapter.ClearBeforeFill = true;
            // 
            // qLTCDataSet
            // 
            this.qLTCDataSet.DataSetName = "QLTCDataSet";
            this.qLTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qUANLYBindingSource1
            // 
            this.qUANLYBindingSource1.DataMember = "QUANLY";
            this.qUANLYBindingSource1.DataSource = this.qLTCDataSet;
            // 
            // qUANLYTableAdapter1
            // 
            this.qUANLYTableAdapter1.ClearBeforeFill = true;
            // 
            // qLQKTCDataSet
            // 
            this.qLQKTCDataSet.DataSetName = "QLQKTCDataSet";
            this.qLQKTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // qUANLYBindingSource2
            // 
            this.qUANLYBindingSource2.DataMember = "QUANLY";
            this.qUANLYBindingSource2.DataSource = this.qLQKTCDataSet;
            // 
            // qUANLYTableAdapter2
            // 
            this.qUANLYTableAdapter2.ClearBeforeFill = true;
            // 
            // MAQL
            // 
            this.MAQL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MAQL.DataPropertyName = "MAQL";
            this.MAQL.HeaderText = "Mã quản lý";
            this.MAQL.MinimumWidth = 6;
            this.MAQL.Name = "MAQL";
            this.MAQL.Width = 106;
            // 
            // HOTEN
            // 
            this.HOTEN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ và tên";
            this.HOTEN.MinimumWidth = 6;
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Width = 98;
            // 
            // GIOITINH
            // 
            this.GIOITINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.MinimumWidth = 6;
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.Width = 89;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.MinimumWidth = 6;
            this.NGAYSINH.Name = "NGAYSINH";
            // 
            // QUEQUAN
            // 
            this.QUEQUAN.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.QUEQUAN.DataPropertyName = "QUEQUAN";
            this.QUEQUAN.HeaderText = "Quê quán";
            this.QUEQUAN.MinimumWidth = 6;
            this.QUEQUAN.Name = "QUEQUAN";
            // 
            // frmQUANLY
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1468, 700);
            this.Controls.Add(this.txtNGAYSINH);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPrv);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.txtQUEQUAN);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtGIOITINH);
            this.Controls.Add(this.txtHOTEN);
            this.Controls.Add(this.txtMAQL);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdQUANLY);
            this.Name = "frmQUANLY";
            this.Text = "frmQUANLY";
            this.Load += new System.EventHandler(this.frmQUANLY_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyDKTCDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdQUANLY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyDKTCDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQKTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qUANLYBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private QuanlyDKTCDataSet quanlyDKTCDataSet;
        private System.Windows.Forms.DateTimePicker txtNGAYSINH;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrv;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.TextBox txtQUEQUAN;
        private System.Windows.Forms.Label label9;
        private QuanlyDKTCDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ComboBox comGt;
        private System.Windows.Forms.ComboBox comTenTruong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnHuyloc;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox txtGIOITINH;
        private System.Windows.Forms.TextBox txtHOTEN;
        private System.Windows.Forms.TextBox txtMAQL;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnedit;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdQUANLY;
        private QuanlyDKTCDataSet1 quanlyDKTCDataSet1;
        private System.Windows.Forms.BindingSource qUANLYBindingSource;
        private QuanlyDKTCDataSet1TableAdapters.QUANLYTableAdapter qUANLYTableAdapter;
        private QLTCDataSet qLTCDataSet;
        private System.Windows.Forms.BindingSource qUANLYBindingSource1;
        private QLTCDataSetTableAdapters.QUANLYTableAdapter qUANLYTableAdapter1;
        private QLQKTCDataSet qLQKTCDataSet;
        private System.Windows.Forms.BindingSource qUANLYBindingSource2;
        private QLQKTCDataSetTableAdapters.QUANLYTableAdapter qUANLYTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAQL;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUEQUAN;
    }
}