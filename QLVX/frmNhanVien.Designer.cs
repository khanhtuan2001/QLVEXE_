
namespace QLVX
{
    partial class frmNhanVien
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
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtSĐT = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSNV = new System.Windows.Forms.DataGridView();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SĐT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPhanQuyen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CalendarMonthBackground = System.Drawing.Color.Pink;
            this.dtpNgaySinh.CalendarTitleBackColor = System.Drawing.Color.Pink;
            this.dtpNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinh.Location = new System.Drawing.Point(119, 144);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(174, 24);
            this.dtpNgaySinh.TabIndex = 62;
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.Pink;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(479, 357);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Multiline = true;
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(164, 20);
            this.txtTimKiem.TabIndex = 61;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnTimKiem.BackgroundImage = global::QLVX.Properties.Resources.TKIM;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.Location = new System.Drawing.Point(399, 336);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(76, 45);
            this.btnTimKiem.TabIndex = 60;
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 149);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 59;
            this.label7.Text = "Ngày sinh";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Rockstone", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(294, 32);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(520, 66);
            this.label6.TabIndex = 58;
            this.label6.Text = "Quản Lý Nhân viên";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtTenNV
            // 
            this.txtTenNV.BackColor = System.Drawing.Color.Pink;
            this.txtTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenNV.Location = new System.Drawing.Point(119, 100);
            this.txtTenNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(174, 24);
            this.txtTenNV.TabIndex = 53;
            // 
            // txtSĐT
            // 
            this.txtSĐT.BackColor = System.Drawing.Color.Pink;
            this.txtSĐT.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSĐT.Location = new System.Drawing.Point(119, 184);
            this.txtSĐT.Margin = new System.Windows.Forms.Padding(2);
            this.txtSĐT.Name = "txtSĐT";
            this.txtSĐT.Size = new System.Drawing.Size(174, 24);
            this.txtSĐT.TabIndex = 52;
            this.txtSĐT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSĐT_KeyPress);
            // 
            // txtMaNV
            // 
            this.txtMaNV.BackColor = System.Drawing.Color.Pink;
            this.txtMaNV.Enabled = false;
            this.txtMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaNV.Location = new System.Drawing.Point(119, 51);
            this.txtMaNV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(174, 24);
            this.txtMaNV.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Mã NV";
            // 
            // dgvDSNV
            // 
            this.dgvDSNV.AllowUserToAddRows = false;
            this.dgvDSNV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSNV.BackgroundColor = System.Drawing.Color.LightPink;
            this.dgvDSNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSNV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.SĐT,
            this.NgaySinh,
            this.Column1});
            this.dgvDSNV.Location = new System.Drawing.Point(399, 132);
            this.dgvDSNV.Margin = new System.Windows.Forms.Padding(2);
            this.dgvDSNV.Name = "dgvDSNV";
            this.dgvDSNV.RowHeadersWidth = 51;
            this.dgvDSNV.RowTemplate.Height = 24;
            this.dgvDSNV.Size = new System.Drawing.Size(670, 179);
            this.dgvDSNV.TabIndex = 49;
            this.dgvDSNV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNV_CellClick);
            this.dgvDSNV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSNV_CellContentClick);
            // 
            // MaNV
            // 
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.MinimumWidth = 6;
            this.MaNV.Name = "MaNV";
            // 
            // TenNV
            // 
            this.TenNV.HeaderText = "Tên NV";
            this.TenNV.MinimumWidth = 6;
            this.TenNV.Name = "TenNV";
            // 
            // SĐT
            // 
            this.SĐT.HeaderText = "SĐT";
            this.SĐT.MinimumWidth = 6;
            this.SĐT.Name = "SĐT";
            // 
            // NgaySinh
            // 
            this.NgaySinh.HeaderText = "Ngày Sinh";
            this.NgaySinh.MinimumWidth = 6;
            this.NgaySinh.Name = "NgaySinh";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Phân Quyền";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 191);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 18);
            this.label4.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 188);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 47;
            this.label3.Text = "SĐT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 46;
            this.label2.Text = "Tên NV";
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSua.BackgroundImage = global::QLVX.Properties.Resources.suaicon;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Location = new System.Drawing.Point(177, 446);
            this.btnSua.Margin = new System.Windows.Forms.Padding(2);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(76, 45);
            this.btnSua.TabIndex = 45;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoa.BackgroundImage = global::QLVX.Properties.Resources.xoaicon;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Location = new System.Drawing.Point(289, 446);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(76, 45);
            this.btnXoa.TabIndex = 44;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BackgroundImage = global::QLVX.Properties.Resources.themicon;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Location = new System.Drawing.Point(58, 446);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(76, 45);
            this.btnThem.TabIndex = 43;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 16);
            this.label5.TabIndex = 64;
            this.label5.Text = "Chức vụ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightPink;
            this.groupBox1.Controls.Add(this.txtPhanQuyen);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtTenNV);
            this.groupBox1.Controls.Add(this.txtSĐT);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(60, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 293);
            this.groupBox1.TabIndex = 66;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(479, 378);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 1);
            this.panel1.TabIndex = 67;
            // 
            // txtPhanQuyen
            // 
            this.txtPhanQuyen.BackColor = System.Drawing.Color.Pink;
            this.txtPhanQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtPhanQuyen.FormattingEnabled = true;
            this.txtPhanQuyen.Items.AddRange(new object[] {
            "",
            "Admin"});
            this.txtPhanQuyen.Location = new System.Drawing.Point(119, 230);
            this.txtPhanQuyen.Name = "txtPhanQuyen";
            this.txtPhanQuyen.Size = new System.Drawing.Size(174, 26);
            this.txtPhanQuyen.TabIndex = 66;
            // 
            // frmNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1101, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgvDSNV);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Name = "frmNhanVien";
            this.Text = "frmNhanVien";
            this.Load += new System.EventHandler(this.frmNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSNV)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtSĐT;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSNV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SĐT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox txtPhanQuyen;
    }
}