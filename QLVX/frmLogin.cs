using QLVX.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVX
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        VXDbcontext DBcontext = new VXDbcontext();
        private void panelBar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo);
            if (r == DialogResult.Yes)
            {
                Application.Exit();
            }   
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            NhanVien dbupdate = DBcontext.NhanViens.FirstOrDefault(p => p.MaNV == txtUser.Text);
            if (txtUser.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show(" Vui lòng nhập đầy đủ thông tin  !.", "Thông báo ", MessageBoxButtons.OK);
            }
            else
           if (dbupdate != null)
            {
                if (dbupdate.Sdt != txtPassword.Text)
                {
                    MessageBox.Show("Passsword sai vui lòng nhập lại!");
                }
                else
                {
                    this.Hide();
                    frmTrangChu child = new frmTrangChu(txtUser.Text,dbupdate.PhanQuyen);
                    frmTrangChu2 child2 = new frmTrangChu2(txtUser.Text, dbupdate.PhanQuyen);
                    child.Show();                                  
                }

            }
            else
            {
                MessageBox.Show("Nhập sai vui lòng nhập lại !.", "Thông báo ", MessageBoxButtons.OK);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblLogin_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            List<NhanVien> listnhanvien = DBcontext.NhanViens.ToList();
        }

        private void btnMini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
