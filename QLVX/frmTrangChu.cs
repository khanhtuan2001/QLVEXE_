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
    public partial class frmTrangChu : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public frmTrangChu()
        {
            InitializeComponent();
            random = new Random();
        }
        string Text;
        string PQ;
        public frmTrangChu(string text,string phanquyen):this() 
        {
            Text = text;
            txtmanv.Text = Text;
            PQ = phanquyen;
            txtquanly.Text = PQ;
          
        }

        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    //Color color = SelectThemeColor();
                   // currentButton = (Button)btnSender;
                   // currentButton.BackColor = color;
                    //currentButton.ForeColor = Color.White;
                   // currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //panelTitleBar.BackColor = color;
                   // panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                   // ThemeColor.PrimaryColor = color;
                   // ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    //btnCloseChildForm.Visible = true;
                }
            }
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.SkyBlue;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();         
        }
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }
        private void bntMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnQLNV_Click(object sender, EventArgs e)
        {           
            OpenChildForm(new frmNhanVien(), sender);
            panelLeft.Show();
            panelLeft.Top = btnQLNV.Top;
            panelLeft.Height = btnQLNV.Height;
        }


        private void frmTrangChu_Load(object sender, EventArgs e)
        {
            if (txtquanly.Text == "")
            {
                btnqlchuyen.Enabled = false;
                btnqlkh.Enabled = false;
                btnQLNV.Enabled = false;
                btnqltuyen.Enabled = false;
            }
            panelLeft.Hide();
        }

        private void btnqlkh_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKhachHang(), sender);
            panelLeft.Show();
            panelLeft.Top = btnqlkh.Top;
            panelLeft.Height = btnqlkh.Height;
        }

        private void btnqlchuyen_Click(object sender, EventArgs e)
        {           
            OpenChildForm(new frmChuyenXe(), sender);
            panelLeft.Show();
            panelLeft.Top = btnqlchuyen.Top;
            panelLeft.Height = btnqlchuyen.Height;
        }

        private void btnqltuyen_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new frmTuyenXe(), sender);
            panelLeft.Show();
            panelLeft.Top = btnqltuyen.Top;
            panelLeft.Height = btnqltuyen.Height;
        }

        private void btndatve_Click(object sender, EventArgs e)
        {
           
            OpenChildForm(new frmDatVe(txtmanv.Text), sender);
            panelLeft.Show();
            panelLeft.Top = btndatve.Top;
            panelLeft.Height = btndatve.Height;
        }

        private void btnbaocao_Click(object sender, EventArgs e)
        {
            
            OpenChildForm(new FormBaoCao(), sender);
            panelLeft.Show();
            panelLeft.Top = btnbaocao.Top;
            panelLeft.Height = btnbaocao.Height;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTrangChu2(txtmanv.Text, txtquanly.Text), sender);
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {

            DialogResult r = MessageBox.Show("Bạn có muốn đăng xuất ?", "Thông báo", MessageBoxButtons.YesNo);
            if( r == DialogResult.Yes)
            {
                this.Close();
                frmLogin login = new frmLogin();
                login.ShowDialog();
            }              
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
