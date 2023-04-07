
namespace QLVX
{
    partial class frmTuyenXe
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
            this.dtgvTuyenXe = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMaTuyen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxDiemDen = new System.Windows.Forms.ComboBox();
            this.cbxDiemDi = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTuyenXe)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtgvTuyenXe
            // 
            this.dtgvTuyenXe.AllowUserToAddRows = false;
            this.dtgvTuyenXe.AllowUserToDeleteRows = false;
            this.dtgvTuyenXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTuyenXe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTuyenXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgvTuyenXe.Location = new System.Drawing.Point(493, 179);
            this.dtgvTuyenXe.Name = "dtgvTuyenXe";
            this.dtgvTuyenXe.ReadOnly = true;
            this.dtgvTuyenXe.RowHeadersWidth = 51;
            this.dtgvTuyenXe.Size = new System.Drawing.Size(466, 186);
            this.dtgvTuyenXe.TabIndex = 0;
            this.dtgvTuyenXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvTuyenXe_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã Tuyến";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Địa điểm đi";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Địa điểm đến";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // txtMaTuyen
            // 
            this.txtMaTuyen.Enabled = false;
            this.txtMaTuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaTuyen.Location = new System.Drawing.Point(127, 46);
            this.txtMaTuyen.Name = "txtMaTuyen";
            this.txtMaTuyen.Size = new System.Drawing.Size(105, 22);
            this.txtMaTuyen.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mã Tuyến";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Điểm đi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Điểm đến";
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImage = global::QLVX.Properties.Resources.themicon;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.Location = new System.Drawing.Point(381, 422);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(89, 38);
            this.btnThem.TabIndex = 8;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightPink;
            this.groupBox1.Controls.Add(this.cbxDiemDen);
            this.groupBox1.Controls.Add(this.cbxDiemDi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaTuyen);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(193, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 213);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin tuyến";
            // 
            // cbxDiemDen
            // 
            this.cbxDiemDen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDiemDen.FormattingEnabled = true;
            this.cbxDiemDen.Location = new System.Drawing.Point(124, 149);
            this.cbxDiemDen.Name = "cbxDiemDen";
            this.cbxDiemDen.Size = new System.Drawing.Size(108, 24);
            this.cbxDiemDen.TabIndex = 8;
            // 
            // cbxDiemDi
            // 
            this.cbxDiemDi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxDiemDi.FormattingEnabled = true;
            this.cbxDiemDi.Location = new System.Drawing.Point(124, 97);
            this.cbxDiemDi.Name = "cbxDiemDi";
            this.cbxDiemDi.Size = new System.Drawing.Size(108, 24);
            this.cbxDiemDi.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockstone", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(309, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(488, 66);
            this.label4.TabIndex = 11;
            this.label4.Text = "Quản Lý Tuyến Xe";
            // 
            // btnLuu
            // 
            this.btnLuu.BackgroundImage = global::QLVX.Properties.Resources.suaicon;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLuu.Location = new System.Drawing.Point(289, 422);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(89, 38);
            this.btnLuu.TabIndex = 12;
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackgroundImage = global::QLVX.Properties.Resources.TKIM;
            this.btntimkiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btntimkiem.Location = new System.Drawing.Point(493, 380);
            this.btntimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(70, 43);
            this.btntimkiem.TabIndex = 13;
            this.btntimkiem.UseVisualStyleBackColor = true;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.BackColor = System.Drawing.Color.Pink;
            this.txttimkiem.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txttimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(567, 408);
            this.txttimkiem.Margin = new System.Windows.Forms.Padding(2);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(164, 15);
            this.txttimkiem.TabIndex = 14;
            // 
            // btnXoa
            // 
            this.btnXoa.BackgroundImage = global::QLVX.Properties.Resources.xoaicon1;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.Location = new System.Drawing.Point(193, 422);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(89, 38);
            this.btnXoa.TabIndex = 7;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(567, 422);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 1);
            this.panel1.TabIndex = 16;
            // 
            // frmTuyenXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1101, 648);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.dtgvTuyenXe);
            this.Name = "frmTuyenXe";
            this.Text = "frmTuyenXe";
            this.Load += new System.EventHandler(this.frmTuyenXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTuyenXe)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgvTuyenXe;
        private System.Windows.Forms.TextBox txtMaTuyen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxDiemDen;
        private System.Windows.Forms.ComboBox cbxDiemDi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Panel panel1;
    }
}