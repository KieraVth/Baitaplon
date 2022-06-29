
namespace Baitaplon
{
    partial class frmMonTQ
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
            this.btnupdate = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.quanlyDKTCDataSet1 = new Baitaplon.QuanlyDKTCDataSet1();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHuyloc = new System.Windows.Forms.Button();
            this.btnLoc = new System.Windows.Forms.Button();
            this.comGt = new System.Windows.Forms.ComboBox();
            this.comTenTruong = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrv = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.mONHOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.mONHOCTableAdapter = new Baitaplon.QuanlyDKTCDataSet1TableAdapters.MONHOCTableAdapter();
            this.sINHVIENBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanlyDKTCDataSet = new Baitaplon.QuanlyDKTCDataSet();
            this.txtMAMONTQ = new System.Windows.Forms.TextBox();
            this.txtMAMON = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btndel = new System.Windows.Forms.Button();
            this.btnedit = new System.Windows.Forms.Button();
            this.sINHVIENTableAdapter = new Baitaplon.QuanlyDKTCDataSetTableAdapters.SINHVIENTableAdapter();
            this.btnadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grdMONTQ = new System.Windows.Forms.DataGridView();
            this.mONTIENQUYETBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.mONTIENQUYETTableAdapter = new Baitaplon.QuanlyDKTCDataSet1TableAdapters.MONTIENQUYETTableAdapter();
            this.qLQKTCDataSet = new Baitaplon.QLQKTCDataSet();
            this.mONTIENQUYETBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mONTIENQUYETTableAdapter1 = new Baitaplon.QLQKTCDataSetTableAdapters.MONTIENQUYETTableAdapter();
            this.MAMON = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAMONTQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyDKTCDataSet1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyDKTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMONTQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONTIENQUYETBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQKTCDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONTIENQUYETBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnupdate
            // 
            this.btnupdate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnupdate.Location = new System.Drawing.Point(833, 596);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(129, 33);
            this.btnupdate.TabIndex = 155;
            this.btnupdate.Text = "Cập nhật";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(695, 89);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(306, 30);
            this.textBox5.TabIndex = 153;
            // 
            // quanlyDKTCDataSet1
            // 
            this.quanlyDKTCDataSet1.DataSetName = "QuanlyDKTCDataSet1";
            this.quanlyDKTCDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.groupBox1.Location = new System.Drawing.Point(598, 151);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(511, 148);
            this.groupBox1.TabIndex = 156;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc dữ liệu";
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
            // btnHuyloc
            // 
            this.btnHuyloc.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnHuyloc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHuyloc.Location = new System.Drawing.Point(190, 108);
            this.btnHuyloc.Name = "btnHuyloc";
            this.btnHuyloc.Size = new System.Drawing.Size(315, 34);
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
            this.comGt.Size = new System.Drawing.Size(315, 33);
            this.comGt.TabIndex = 3;
            // 
            // comTenTruong
            // 
            this.comTenTruong.FormattingEnabled = true;
            this.comTenTruong.Items.AddRange(new object[] {
            "SOTC",
            "MAMON",
            "TENMON"});
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
            // btnFirst
            // 
            this.btnFirst.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(14, 642);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(95, 33);
            this.btnFirst.TabIndex = 160;
            this.btnFirst.Text = "Đầu";
            this.btnFirst.UseVisualStyleBackColor = false;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrv
            // 
            this.btnPrv.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPrv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrv.Location = new System.Drawing.Point(162, 642);
            this.btnPrv.Name = "btnPrv";
            this.btnPrv.Size = new System.Drawing.Size(84, 33);
            this.btnPrv.TabIndex = 159;
            this.btnPrv.Text = "Trước";
            this.btnPrv.UseVisualStyleBackColor = false;
            this.btnPrv.Click += new System.EventHandler(this.btnPrv_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(299, 642);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(93, 33);
            this.btnNext.TabIndex = 158;
            this.btnNext.Text = "Sau";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnLast
            // 
            this.btnLast.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(445, 642);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(95, 33);
            this.btnLast.TabIndex = 157;
            this.btnLast.Text = "Cuối";
            this.btnLast.UseVisualStyleBackColor = false;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // mONHOCBindingSource
            // 
            this.mONHOCBindingSource.DataMember = "MONHOC";
            this.mONHOCBindingSource.DataSource = this.quanlyDKTCDataSet1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(1007, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 33);
            this.button1.TabIndex = 154;
            this.button1.Text = "Tìm";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // mONHOCTableAdapter
            // 
            this.mONHOCTableAdapter.ClearBeforeFill = true;
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
            // txtMAMONTQ
            // 
            this.txtMAMONTQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAMONTQ.Location = new System.Drawing.Point(777, 375);
            this.txtMAMONTQ.Name = "txtMAMONTQ";
            this.txtMAMONTQ.Size = new System.Drawing.Size(332, 30);
            this.txtMAMONTQ.TabIndex = 151;
            // 
            // txtMAMON
            // 
            this.txtMAMON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMAMON.Location = new System.Drawing.Point(777, 330);
            this.txtMAMON.Name = "txtMAMON";
            this.txtMAMON.Size = new System.Drawing.Size(332, 30);
            this.txtMAMON.TabIndex = 150;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(593, 380);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(178, 25);
            this.label18.TabIndex = 149;
            this.label18.Text = "Mã môn tiên quyết:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label13.Location = new System.Drawing.Point(593, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(126, 25);
            this.label13.TabIndex = 147;
            this.label13.Text = "Mã môn học:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(30, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(335, 31);
            this.label2.TabIndex = 146;
            this.label2.Text = "Thông tin môn tiên quyết";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btndel
            // 
            this.btndel.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btndel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndel.Location = new System.Drawing.Point(968, 596);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(121, 33);
            this.btndel.TabIndex = 145;
            this.btndel.Text = "Xóa";
            this.btndel.UseVisualStyleBackColor = false;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnedit
            // 
            this.btnedit.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnedit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnedit.Location = new System.Drawing.Point(695, 596);
            this.btnedit.Name = "btnedit";
            this.btnedit.Size = new System.Drawing.Size(132, 33);
            this.btnedit.TabIndex = 144;
            this.btnedit.Text = "Sửa";
            this.btnedit.UseVisualStyleBackColor = false;
            this.btnedit.Click += new System.EventHandler(this.btnedit_Click);
            // 
            // sINHVIENTableAdapter
            // 
            this.sINHVIENTableAdapter.ClearBeforeFill = true;
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadd.Location = new System.Drawing.Point(573, 596);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(116, 33);
            this.btnadd.TabIndex = 143;
            this.btnadd.Text = "Thêm ";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(599, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 25);
            this.label1.TabIndex = 142;
            this.label1.Text = "Từ khóa:";
            // 
            // grdMONTQ
            // 
            this.grdMONTQ.AutoGenerateColumns = false;
            this.grdMONTQ.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdMONTQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMONTQ.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAMON,
            this.MAMONTQ});
            this.grdMONTQ.DataSource = this.mONTIENQUYETBindingSource1;
            this.grdMONTQ.Location = new System.Drawing.Point(14, 89);
            this.grdMONTQ.MultiSelect = false;
            this.grdMONTQ.Name = "grdMONTQ";
            this.grdMONTQ.RowHeadersWidth = 51;
            this.grdMONTQ.RowTemplate.Height = 24;
            this.grdMONTQ.Size = new System.Drawing.Size(526, 540);
            this.grdMONTQ.TabIndex = 141;
            this.grdMONTQ.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMONTQ_CellClick);
            this.grdMONTQ.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMONTQ_CellContentClick);
            // 
            // mONTIENQUYETBindingSource
            // 
            this.mONTIENQUYETBindingSource.DataMember = "MONTIENQUYET";
            this.mONTIENQUYETBindingSource.DataSource = this.quanlyDKTCDataSet1;
            // 
            // mONTIENQUYETTableAdapter
            // 
            this.mONTIENQUYETTableAdapter.ClearBeforeFill = true;
            // 
            // qLQKTCDataSet
            // 
            this.qLQKTCDataSet.DataSetName = "QLQKTCDataSet";
            this.qLQKTCDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mONTIENQUYETBindingSource1
            // 
            this.mONTIENQUYETBindingSource1.DataMember = "MONTIENQUYET";
            this.mONTIENQUYETBindingSource1.DataSource = this.qLQKTCDataSet;
            // 
            // mONTIENQUYETTableAdapter1
            // 
            this.mONTIENQUYETTableAdapter1.ClearBeforeFill = true;
            // 
            // MAMON
            // 
            this.MAMON.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MAMON.DataPropertyName = "MAMON";
            this.MAMON.HeaderText = "Mã môn học";
            this.MAMON.MinimumWidth = 6;
            this.MAMON.Name = "MAMON";
            this.MAMON.Width = 114;
            // 
            // MAMONTQ
            // 
            this.MAMONTQ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MAMONTQ.DataPropertyName = "MAMONTQ";
            this.MAMONTQ.HeaderText = "Mã môn tiên quyết";
            this.MAMONTQ.MinimumWidth = 6;
            this.MAMONTQ.Name = "MAMONTQ";
            this.MAMONTQ.Width = 109;
            // 
            // frmMonTQ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1122, 700);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnPrv);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtMAMONTQ);
            this.Controls.Add(this.txtMAMON);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnedit);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdMONTQ);
            this.Name = "frmMonTQ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMonTQ";
            this.Load += new System.EventHandler(this.frmMonTQ_Load);
            ((System.ComponentModel.ISupportInitialize)(this.quanlyDKTCDataSet1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mONHOCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sINHVIENBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanlyDKTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdMONTQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONTIENQUYETBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLQKTCDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mONTIENQUYETBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.TextBox textBox5;
        private QuanlyDKTCDataSet1 quanlyDKTCDataSet1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHuyloc;
        private System.Windows.Forms.Button btnLoc;
        private System.Windows.Forms.ComboBox comGt;
        private System.Windows.Forms.ComboBox comTenTruong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrv;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.BindingSource mONHOCBindingSource;
        private System.Windows.Forms.Button button1;
        private QuanlyDKTCDataSet1TableAdapters.MONHOCTableAdapter mONHOCTableAdapter;
        private System.Windows.Forms.BindingSource sINHVIENBindingSource;
        private QuanlyDKTCDataSet quanlyDKTCDataSet;
        private System.Windows.Forms.TextBox txtMAMONTQ;
        private System.Windows.Forms.TextBox txtMAMON;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnedit;
        private QuanlyDKTCDataSetTableAdapters.SINHVIENTableAdapter sINHVIENTableAdapter;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdMONTQ;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.BindingSource mONTIENQUYETBindingSource;
        private QuanlyDKTCDataSet1TableAdapters.MONTIENQUYETTableAdapter mONTIENQUYETTableAdapter;
        private QLQKTCDataSet qLQKTCDataSet;
        private System.Windows.Forms.BindingSource mONTIENQUYETBindingSource1;
        private QLQKTCDataSetTableAdapters.MONTIENQUYETTableAdapter mONTIENQUYETTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMON;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAMONTQ;
    }
}