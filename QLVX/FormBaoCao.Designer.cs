
namespace QLVX
{
    partial class FormBaoCao
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thốngKêTấtCảToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoNgàyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoTuyếnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.theoChuyếnXeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gbngay = new System.Windows.Forms.GroupBox();
            this.txtngaycuoi = new System.Windows.Forms.DateTimePicker();
            this.txttimngay = new System.Windows.Forms.DateTimePicker();
            this.bttimngay = new System.Windows.Forms.Button();
            this.gbtuyen = new System.Windows.Forms.GroupBox();
            this.bttimtuyen = new System.Windows.Forms.Button();
            this.cbtuyen = new System.Windows.Forms.ComboBox();
            this.gbthang = new System.Windows.Forms.GroupBox();
            this.btnchuyen = new System.Windows.Forms.Button();
            this.cbchuyen = new System.Windows.Forms.ComboBox();
            this.ClassBaoCao1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.gbngay.SuspendLayout();
            this.gbtuyen.SuspendLayout();
            this.gbthang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClassBaoCao1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClassBaoCao1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLVX.ReportBaoCao1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 170);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1101, 476);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêTấtCảToolStripMenuItem,
            this.theoNgàyToolStripMenuItem,
            this.theoTuyếnToolStripMenuItem,
            this.theoChuyếnXeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1101, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thốngKêTấtCảToolStripMenuItem
            // 
            this.thốngKêTấtCảToolStripMenuItem.Name = "thốngKêTấtCảToolStripMenuItem";
            this.thốngKêTấtCảToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.thốngKêTấtCảToolStripMenuItem.Text = "Thống kê tất cả";
            this.thốngKêTấtCảToolStripMenuItem.Click += new System.EventHandler(this.thốngKêTấtCảToolStripMenuItem_Click);
            // 
            // theoNgàyToolStripMenuItem
            // 
            this.theoNgàyToolStripMenuItem.Name = "theoNgàyToolStripMenuItem";
            this.theoNgàyToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.theoNgàyToolStripMenuItem.Text = "Theo ngày";
            this.theoNgàyToolStripMenuItem.Click += new System.EventHandler(this.theoNgàyToolStripMenuItem_Click);
            // 
            // theoTuyếnToolStripMenuItem
            // 
            this.theoTuyếnToolStripMenuItem.Name = "theoTuyếnToolStripMenuItem";
            this.theoTuyếnToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.theoTuyếnToolStripMenuItem.Text = "Theo tuyến";
            this.theoTuyếnToolStripMenuItem.Click += new System.EventHandler(this.theoTuyếnToolStripMenuItem_Click);
            // 
            // theoChuyếnXeToolStripMenuItem
            // 
            this.theoChuyếnXeToolStripMenuItem.Name = "theoChuyếnXeToolStripMenuItem";
            this.theoChuyếnXeToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.theoChuyếnXeToolStripMenuItem.Text = "Theo chuyến xe";
            this.theoChuyếnXeToolStripMenuItem.Click += new System.EventHandler(this.theoChuyếnXeToolStripMenuItem_Click);
            // 
            // gbngay
            // 
            this.gbngay.BackColor = System.Drawing.Color.LightPink;
            this.gbngay.Controls.Add(this.txtngaycuoi);
            this.gbngay.Controls.Add(this.txttimngay);
            this.gbngay.Controls.Add(this.bttimngay);
            this.gbngay.Location = new System.Drawing.Point(41, 52);
            this.gbngay.Margin = new System.Windows.Forms.Padding(2);
            this.gbngay.Name = "gbngay";
            this.gbngay.Padding = new System.Windows.Forms.Padding(2);
            this.gbngay.Size = new System.Drawing.Size(370, 104);
            this.gbngay.TabIndex = 2;
            this.gbngay.TabStop = false;
            this.gbngay.Text = "Tìm theo ngày";
            // 
            // txtngaycuoi
            // 
            this.txtngaycuoi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtngaycuoi.Location = new System.Drawing.Point(150, 41);
            this.txtngaycuoi.Margin = new System.Windows.Forms.Padding(2);
            this.txtngaycuoi.Name = "txtngaycuoi";
            this.txtngaycuoi.Size = new System.Drawing.Size(101, 20);
            this.txtngaycuoi.TabIndex = 7;
            // 
            // txttimngay
            // 
            this.txttimngay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txttimngay.Location = new System.Drawing.Point(4, 41);
            this.txttimngay.Margin = new System.Windows.Forms.Padding(2);
            this.txttimngay.Name = "txttimngay";
            this.txttimngay.Size = new System.Drawing.Size(101, 20);
            this.txttimngay.TabIndex = 6;
            // 
            // bttimngay
            // 
            this.bttimngay.Location = new System.Drawing.Point(286, 37);
            this.bttimngay.Margin = new System.Windows.Forms.Padding(2);
            this.bttimngay.Name = "bttimngay";
            this.bttimngay.Size = new System.Drawing.Size(56, 29);
            this.bttimngay.TabIndex = 4;
            this.bttimngay.Text = "tìm kiếm ";
            this.bttimngay.UseVisualStyleBackColor = true;
            this.bttimngay.Click += new System.EventHandler(this.bttimngay_Click);
            // 
            // gbtuyen
            // 
            this.gbtuyen.BackColor = System.Drawing.Color.LightPink;
            this.gbtuyen.Controls.Add(this.bttimtuyen);
            this.gbtuyen.Controls.Add(this.cbtuyen);
            this.gbtuyen.Location = new System.Drawing.Point(437, 52);
            this.gbtuyen.Margin = new System.Windows.Forms.Padding(2);
            this.gbtuyen.Name = "gbtuyen";
            this.gbtuyen.Padding = new System.Windows.Forms.Padding(2);
            this.gbtuyen.Size = new System.Drawing.Size(280, 104);
            this.gbtuyen.TabIndex = 3;
            this.gbtuyen.TabStop = false;
            this.gbtuyen.Text = "Tìm theo tuyến";
            // 
            // bttimtuyen
            // 
            this.bttimtuyen.Location = new System.Drawing.Point(160, 28);
            this.bttimtuyen.Margin = new System.Windows.Forms.Padding(2);
            this.bttimtuyen.Name = "bttimtuyen";
            this.bttimtuyen.Size = new System.Drawing.Size(56, 29);
            this.bttimtuyen.TabIndex = 5;
            this.bttimtuyen.Text = "tìm kiếm ";
            this.bttimtuyen.UseVisualStyleBackColor = true;
            this.bttimtuyen.Click += new System.EventHandler(this.bttimtuyen_Click);
            // 
            // cbtuyen
            // 
            this.cbtuyen.FormattingEnabled = true;
            this.cbtuyen.Location = new System.Drawing.Point(31, 34);
            this.cbtuyen.Margin = new System.Windows.Forms.Padding(2);
            this.cbtuyen.Name = "cbtuyen";
            this.cbtuyen.Size = new System.Drawing.Size(92, 21);
            this.cbtuyen.TabIndex = 1;
            // 
            // gbthang
            // 
            this.gbthang.BackColor = System.Drawing.Color.LightPink;
            this.gbthang.Controls.Add(this.btnchuyen);
            this.gbthang.Controls.Add(this.cbchuyen);
            this.gbthang.Location = new System.Drawing.Point(765, 52);
            this.gbthang.Margin = new System.Windows.Forms.Padding(2);
            this.gbthang.Name = "gbthang";
            this.gbthang.Padding = new System.Windows.Forms.Padding(2);
            this.gbthang.Size = new System.Drawing.Size(280, 104);
            this.gbthang.TabIndex = 6;
            this.gbthang.TabStop = false;
            this.gbthang.Text = "Tìm theo chuyến";
            // 
            // btnchuyen
            // 
            this.btnchuyen.Location = new System.Drawing.Point(160, 28);
            this.btnchuyen.Margin = new System.Windows.Forms.Padding(2);
            this.btnchuyen.Name = "btnchuyen";
            this.btnchuyen.Size = new System.Drawing.Size(56, 29);
            this.btnchuyen.TabIndex = 5;
            this.btnchuyen.Text = "tìm kiếm ";
            this.btnchuyen.UseVisualStyleBackColor = true;
            this.btnchuyen.Click += new System.EventHandler(this.btnchuyen_Click);
            // 
            // cbchuyen
            // 
            this.cbchuyen.FormattingEnabled = true;
            this.cbchuyen.Location = new System.Drawing.Point(31, 34);
            this.cbchuyen.Margin = new System.Windows.Forms.Padding(2);
            this.cbchuyen.Name = "cbchuyen";
            this.cbchuyen.Size = new System.Drawing.Size(92, 21);
            this.cbchuyen.TabIndex = 1;
            // 
            // ClassBaoCao1BindingSource
            // 
            this.ClassBaoCao1BindingSource.DataSource = typeof(QLVX.ClassBaoCao1);
            // 
            // FormBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1101, 648);
            this.Controls.Add(this.gbthang);
            this.Controls.Add(this.gbtuyen);
            this.Controls.Add(this.gbngay);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormBaoCao";
            this.Text = "FormBaoCao";
            this.Load += new System.EventHandler(this.FormBaoCao_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbngay.ResumeLayout(false);
            this.gbtuyen.ResumeLayout(false);
            this.gbthang.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClassBaoCao1BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thốngKêTấtCảToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoNgàyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem theoTuyếnToolStripMenuItem;
        private System.Windows.Forms.GroupBox gbngay;
        private System.Windows.Forms.GroupBox gbtuyen;
        private System.Windows.Forms.ComboBox cbtuyen;
        private System.Windows.Forms.Button bttimngay;
        private System.Windows.Forms.BindingSource ClassBaoCao1BindingSource;
        private System.Windows.Forms.Button bttimtuyen;
        private System.Windows.Forms.DateTimePicker txttimngay;
        private System.Windows.Forms.DateTimePicker txtngaycuoi;
        private System.Windows.Forms.GroupBox gbthang;
        private System.Windows.Forms.Button btnchuyen;
        private System.Windows.Forms.ComboBox cbchuyen;
        private System.Windows.Forms.ToolStripMenuItem theoChuyếnXeToolStripMenuItem;
    }
}