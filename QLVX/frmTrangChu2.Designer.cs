
namespace QLVX
{
    partial class frmTrangChu2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtquanly = new System.Windows.Forms.TextBox();
            this.txtmanv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = global::QLVX.Properties.Resources.home;
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1117, 687);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // txtquanly
            // 
            this.txtquanly.Enabled = false;
            this.txtquanly.Location = new System.Drawing.Point(976, 40);
            this.txtquanly.Margin = new System.Windows.Forms.Padding(2);
            this.txtquanly.Name = "txtquanly";
            this.txtquanly.Size = new System.Drawing.Size(76, 20);
            this.txtquanly.TabIndex = 20;
            // 
            // txtmanv
            // 
            this.txtmanv.Enabled = false;
            this.txtmanv.Location = new System.Drawing.Point(987, 568);
            this.txtmanv.Name = "txtmanv";
            this.txtmanv.Size = new System.Drawing.Size(100, 20);
            this.txtmanv.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(849, 572);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "NV đăng nhập";
            // 
            // frmTrangChu2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 648);
            this.Controls.Add(this.txtmanv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtquanly);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmTrangChu2";
            this.Load += new System.EventHandler(this.frmTrangChu2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtquanly;
        private System.Windows.Forms.TextBox txtmanv;
        private System.Windows.Forms.Label label1;
    }
}