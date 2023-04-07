
namespace QLVX
{
    partial class FormReportVeXe
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
            this.ClassReportVeXeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.txtmave = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ClassReportVeXeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ClassReportVeXeBindingSource
            // 
            this.ClassReportVeXeBindingSource.DataSource = typeof(QLVX.ClassReportVeXe);
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ClassReportVeXeBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QLVX.ReportVeXe.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(11, 45);
            this.reportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(894, 531);
            this.reportViewer1.TabIndex = 0;
            // 
            // txtmave
            // 
            this.txtmave.Location = new System.Drawing.Point(-1, 10);
            this.txtmave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtmave.Name = "txtmave";
            this.txtmave.Size = new System.Drawing.Size(76, 20);
            this.txtmave.TabIndex = 1;
            // 
            // FormReportVeXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 597);
            this.Controls.Add(this.txtmave);
            this.Controls.Add(this.reportViewer1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormReportVeXe";
            this.Text = "FormReportVeXe";
            this.Load += new System.EventHandler(this.FormReportVeXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClassReportVeXeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.TextBox txtmave;
        private System.Windows.Forms.BindingSource ClassReportVeXeBindingSource;
    }
}