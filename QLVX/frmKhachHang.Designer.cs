
namespace QLVX
{
    partial class frmKhachHang
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
            this.dgvKH = new System.Windows.Forms.DataGridView();
            this.dgvMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSdt = new System.Windows.Forms.TextBox();
            this.dtpNgaySinhKH = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btTimKiem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvKH
            // 
            this.dgvKH.AllowUserToAddRows = false;
            this.dgvKH.AllowUserToOrderColumns = true;
            this.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvMaKH,
            this.dgvHoTen,
            this.dgvSDT,
            this.dgvNgaySinh});
            this.dgvKH.Location = new System.Drawing.Point(453, 148);
            this.dgvKH.Name = "dgvKH";
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.Size = new System.Drawing.Size(536, 280);
            this.dgvKH.TabIndex = 0;
            this.dgvKH.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKH_CellClick);
            // 
            // dgvMaKH
            // 
            this.dgvMaKH.HeaderText = "Mã KH";
            this.dgvMaKH.MinimumWidth = 6;
            this.dgvMaKH.Name = "dgvMaKH";
            // 
            // dgvHoTen
            // 
            this.dgvHoTen.HeaderText = "Họ Tên KH";
            this.dgvHoTen.MinimumWidth = 6;
            this.dgvHoTen.Name = "dgvHoTen";
            // 
            // dgvSDT
            // 
            this.dgvSDT.HeaderText = "SĐT";
            this.dgvSDT.MinimumWidth = 6;
            this.dgvSDT.Name = "dgvSDT";
            // 
            // dgvNgaySinh
            // 
            this.dgvNgaySinh.HeaderText = "Ngày Sinh";
            this.dgvNgaySinh.MinimumWidth = 6;
            this.dgvNgaySinh.Name = "dgvNgaySinh";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Enabled = false;
            this.txtMaKH.Location = new System.Drawing.Point(125, 54);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(119, 22);
            this.txtMaKH.TabIndex = 1;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(125, 104);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(119, 22);
            this.txtTenKH.TabIndex = 2;
            // 
            // txtSdt
            // 
            this.txtSdt.Location = new System.Drawing.Point(125, 154);
            this.txtSdt.Name = "txtSdt";
            this.txtSdt.Size = new System.Drawing.Size(119, 22);
            this.txtSdt.TabIndex = 3;
            this.txtSdt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSdt_KeyPress);
            // 
            // dtpNgaySinhKH
            // 
            this.dtpNgaySinhKH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgaySinhKH.Location = new System.Drawing.Point(125, 204);
            this.dtpNgaySinhKH.Name = "dtpNgaySinhKH";
            this.dtpNgaySinhKH.Size = new System.Drawing.Size(119, 22);
            this.dtpNgaySinhKH.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mã KH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "SĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 206);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Ngày sinh";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightPink;
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dtpNgaySinhKH);
            this.groupBox1.Controls.Add(this.txtSdt);
            this.groupBox1.Controls.Add(this.txtTenKH);
            this.groupBox1.Controls.Add(this.txtMaKH);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(143, 148);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 280);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockstone", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(266, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(580, 66);
            this.label5.TabIndex = 13;
            this.label5.Text = "QUẢN LÝ KHÁCH HÀNG";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.BackColor = System.Drawing.Color.Pink;
            this.txtTimKiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(567, 470);
            this.txtTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(164, 15);
            this.txtTimKiem.TabIndex = 16;
            // 
            // btTimKiem
            // 
            this.btTimKiem.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btTimKiem.BackgroundImage = global::QLVX.Properties.Resources.TKIM;
            this.btTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btTimKiem.Location = new System.Drawing.Point(489, 456);
            this.btTimKiem.Margin = new System.Windows.Forms.Padding(2);
            this.btTimKiem.Name = "btTimKiem";
            this.btTimKiem.Size = new System.Drawing.Size(74, 41);
            this.btTimKiem.TabIndex = 15;
            this.btTimKiem.UseVisualStyleBackColor = false;
            this.btTimKiem.Click += new System.EventHandler(this.btTimKiem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnSua.BackgroundImage = global::QLVX.Properties.Resources.suaicon;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.Location = new System.Drawing.Point(366, 456);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(74, 41);
            this.btnSua.TabIndex = 12;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnXoa.BackgroundImage = global::QLVX.Properties.Resources.xoaicon;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Location = new System.Drawing.Point(254, 456);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(74, 41);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnThem.BackgroundImage = global::QLVX.Properties.Resources.themicon;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Location = new System.Drawing.Point(147, 456);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(74, 41);
            this.btnThem.TabIndex = 10;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(567, 488);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 1);
            this.panel1.TabIndex = 17;
            // 
            // frmKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1101, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.btTimKiem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvKH);
            this.Name = "frmKhachHang";
            this.Text = "frmKhachHang";
            this.Load += new System.EventHandler(this.frmKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKH;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSdt;
        private System.Windows.Forms.DateTimePicker dtpNgaySinhKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvNgaySinh;
        private System.Windows.Forms.Button btTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Panel panel1;
    }
}