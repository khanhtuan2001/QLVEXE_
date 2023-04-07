using Microsoft.Reporting.WinForms;
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
    public partial class FormReportVeXe : Form
    {
        public FormReportVeXe()
        {
            InitializeComponent();
        }
        string Mv1;
        public FormReportVeXe(string mv1) : this()
        {
            Mv1 = mv1;
            txtmave.Text = Mv1;

        }

      

        private void FormReportVeXe_Load(object sender, EventArgs e)
        {
            txtmave.Hide();
            VXDbcontext context = new VXDbcontext();
            List<VeXe> listve = context.VeXes.Where(p => p.MaVe == txtmave.Text).ToList();
            List<ClassReportVeXe> listreport = new List<ClassReportVeXe>();
            foreach (VeXe s in listve)
            {
                ClassReportVeXe temp = new ClassReportVeXe();
                temp.mave = s.MaVe;
                temp.machuyen = s.MaChuyen;
                temp.masoghe = s.MaSoGhe;
           
               
                temp.tenkhachhang = s.KhachHang.TenKH;
                temp.tennv = s.NhanVien.TenNV;
                temp.diadiemdi = s.ChuyenXe.TuyenXe.DiaDiem1.TenDiaDiem;
                temp.diadiemden = s.ChuyenXe.TuyenXe.DiaDiem.TenDiaDiem;
                temp.ngaydi = s.ChuyenXe.NgayDi.ToShortDateString();
                temp.giodi = s.ChuyenXe.GioDi;
                temp.giave = s.ChuyenXe.GiaVe;
                temp.ngaydat = s.ThoiGianDat.ToShortDateString();
                


                listreport.Add(temp);
            }
            reportViewer1.LocalReport.ReportPath = "ReportVeXe.rdlc";
            var source = new ReportDataSource("DataSet1", listreport);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }
    }
}
