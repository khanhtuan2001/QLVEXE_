
namespace QLVX
{
    partial class frmChuyenXe
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
            this.dtgvChuyenXe = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbxDiemDen = new System.Windows.Forms.ComboBox();
            this.cbxDiemDi = new System.Windows.Forms.ComboBox();
            this.dateTimeNgayDi = new System.Windows.Forms.DateTimePicker();
            this.txtMachuyen = new System.Windows.Forms.TextBox();
            this.txtGiave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtGioDi = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.lblMatuyen = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuyenXe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvChuyenXe
            // 
            this.dtgvChuyenXe.AllowUserToAddRows = false;
            this.dtgvChuyenXe.AllowUserToDeleteRows = false;
            this.dtgvChuyenXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvChuyenXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvChuyenXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dtgvChuyenXe.Location = new System.Drawing.Point(531, 120);
            this.dtgvChuyenXe.Name = "dtgvChuyenXe";
            this.dtgvChuyenXe.ReadOnly = true;
            this.dtgvChuyenXe.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dtgvChuyenXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvChuyenXe.Size = new System.Drawing.Size(471, 209);
            this.dtgvChuyenXe.TabIndex = 0;
            this.dtgvChuyenXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvChuyenXe_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã chuyến";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Mã tuyến";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày đi";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Giờ đi";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Giá vé";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // cbxDiemDen
            // 
            this.cbxDiemDen.FormattingEnabled = true;
            this.cbxDiemDen.Location = new System.Drawing.Point(184, 42);
            this.cbxDiemDen.Name = "cbxDiemDen";
            this.cbxDiemDen.Size = new System.Drawing.Size(121, 24);
            this.cbxDiemDen.TabIndex = 8;
            this.cbxDiemDen.SelectedIndexChanged += new System.EventHandler(this.cbxDiemDen_SelectedIndexChanged);
            this.cbxDiemDen.SelectionChangeCommitted += new System.EventHandler(this.cbxDiemDen_SelectionChangeCommitted);
            // 
            // cbxDiemDi
            // 
            this.cbxDiemDi.FormattingEnabled = true;
            this.cbxDiemDi.Location = new System.Drawing.Point(42, 42);
            this.cbxDiemDi.Name = "cbxDiemDi";
            this.cbxDiemDi.Size = new System.Drawing.Size(110, 24);
            this.cbxDiemDi.TabIndex = 7;
            // 
            // dateTimeNgayDi
            // 
            this.dateTimeNgayDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNgayDi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNgayDi.Location = new System.Drawing.Point(160, 188);
            this.dateTimeNgayDi.Name = "dateTimeNgayDi";
            this.dateTimeNgayDi.Size = new System.Drawing.Size(110, 22);
            this.dateTimeNgayDi.TabIndex = 10;
            // 
            // txtMachuyen
            // 
            this.txtMachuyen.Enabled = false;
            this.txtMachuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMachuyen.Location = new System.Drawing.Point(160, 64);
            this.txtMachuyen.Name = "txtMachuyen";
            this.txtMachuyen.Size = new System.Drawing.Size(100, 22);
            this.txtMachuyen.TabIndex = 11;
            // 
            // txtGiave
            // 
            this.txtGiave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiave.Location = new System.Drawing.Point(160, 147);
            this.txtGiave.Name = "txtGiave";
            this.txtGiave.Size = new System.Drawing.Size(100, 22);
            this.txtGiave.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Mã chuyến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Giờ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Giá vé";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightPink;
            this.groupBox1.Controls.Add(this.txtGioDi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtGiave);
            this.groupBox1.Controls.Add(this.dateTimeNgayDi);
            this.groupBox1.Controls.Add(this.txtMachuyen);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(172, 284);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 272);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chuyến";
            // 
            // txtGioDi
            // 
            this.txtGioDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGioDi.Location = new System.Drawing.Point(160, 103);
            this.txtGioDi.Mask = "00:00";
            this.txtGioDi.Name = "txtGioDi";
            this.txtGioDi.Size = new System.Drawing.Size(100, 22);
            this.txtGioDi.TabIndex = 25;
            this.txtGioDi.ValidatingType = typeof(System.DateTime);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ngày đi";
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::QLVX.Properties.Resources.xoaicon;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Location = new System.Drawing.Point(198, 564);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 37);
            this.btnXoa.TabIndex = 18;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackgroundImage = global::QLVX.Properties.Resources.suaicon;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Location = new System.Drawing.Point(309, 564);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 37);
            this.btnSua.TabIndex = 19;
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::QLVX.Properties.Resources.themicon;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Location = new System.Drawing.Point(414, 564);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 37);
            this.btnThem.TabIndex = 20;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // lblMatuyen
            // 
            this.lblMatuyen.AutoSize = true;
            this.lblMatuyen.Location = new System.Drawing.Point(117, 78);
            this.lblMatuyen.Name = "lblMatuyen";
            this.lblMatuyen.Size = new System.Drawing.Size(12, 16);
            this.lblMatuyen.TabIndex = 23;
            this.lblMatuyen.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Mã tuyến";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.Pink;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(629, 360);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(164, 15);
            this.txtTimKiem.TabIndex = 25;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackgroundImage = global::QLVX.Properties.Resources.TKIM;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.Location = new System.Drawing.Point(531, 348);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 37);
            this.btnTimKiem.TabIndex = 27;
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightPink;
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.lblMatuyen);
            this.groupBox2.Controls.Add(this.cbxDiemDen);
            this.groupBox2.Controls.Add(this.cbxDiemDi);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(170, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(337, 125);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tuyến đường";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockstone", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Gray;
            this.label7.Location = new System.Drawing.Point(288, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(531, 66);
            this.label7.TabIndex = 29;
            this.label7.Text = "QUẢN LÝ CHUYẾN XE";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(629, 379);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 1);
            this.panel1.TabIndex = 30;
            // 
            // frmChuyenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1101, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtgvChuyenXe);
            this.Name = "frmChuyenXe";
            this.Text = "frmChuyenXe";
            this.Load += new System.EventHandler(this.frmChuyenXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvChuyenXe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvChuyenXe;
        private System.Windows.Forms.ComboBox cbxDiemDen;
        private System.Windows.Forms.ComboBox cbxDiemDi;
        private System.Windows.Forms.DateTimePicker dateTimeNgayDi;
        private System.Windows.Forms.TextBox txtMachuyen;
        private System.Windows.Forms.TextBox txtGiave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label lblMatuyen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox txtGioDi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
    }
}