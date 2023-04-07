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
    public partial class frmTrangChu2 : Form
    {
        public frmTrangChu2()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        string Text;
        string PQ;
        public frmTrangChu2(string text, string phanquyen) : this()
        {
            Text = text;
            txtmanv.Text = Text;
            PQ = phanquyen;
            txtquanly.Text = PQ;

        }
        private void frmTrangChu2_Load(object sender, EventArgs e)
        {
           
        }
       
    }
}
