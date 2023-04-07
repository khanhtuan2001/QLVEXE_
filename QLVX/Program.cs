using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLVX
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

           // Application.Run(new frmDatVe());
            //Application.Run(new frmTuyenXe());
           // Application.Run(new frmChuyenXe());
            //Application.Run(new frmTrangChu());
            //Application.Run(new FormBaoCao());
            Application.Run(new frmLogin());
            //Application.Run(new frmNhanVien());
           // Application.Run(new frmKhachHang());


        }
    }
}
