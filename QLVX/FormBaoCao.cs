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
    public partial class FormBaoCao : Form
    {
        public FormBaoCao()
        {
            
            InitializeComponent();
        }

        private void FormBaoCao_Load(object sender, EventArgs e)
        {
            gbngay.Hide();
            gbthang.Hide();
          
            gbtuyen.Hide();

            this.reportViewer1.RefreshReport();
        }
       
        private void thốngKêTấtCảToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbngay.Hide();
            gbthang.Hide();
           
            gbtuyen.Hide();
            VXDbcontext context = new VXDbcontext();
            List<VeXe> listve = context.VeXes.ToList();
            List<ClassBaoCao1> listreport = new List<ClassBaoCao1>();
            foreach (VeXe s in listve)
            {
                ClassBaoCao1 temp = new ClassBaoCao1();
                temp.mave = s.MaVe;
                temp.machuyen = s.MaChuyen;
                temp.masoghe = s.MaSoGhe;


                temp.makh = s.MaKH;
                temp.tennhanvien = s.NhanVien.TenNV;
                temp.diadiemdi = s.ChuyenXe.TuyenXe.DiaDiem1.TenDiaDiem;
                temp.diadiemden = s.ChuyenXe.TuyenXe.DiaDiem.TenDiaDiem;
                temp.thoigiandat = s.ThoiGianDat.ToShortDateString();
                temp.giodi = s.ChuyenXe.GioDi;
                temp.giave = s.ChuyenXe.GiaVe;




                listreport.Add(temp);
            }
            reportViewer1.LocalReport.ReportPath = "ReportBaoCao1.rdlc";
            var source = new ReportDataSource("DataSet1", listreport);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }

        private void theoNgàyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbngay.Show();
            gbthang.Hide();
            
            gbtuyen.Hide();
            //this.reportViewer1.Refresh();
        }

       

        private void theoTuyếnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbngay.Hide();
            gbthang.Hide();
            VXDbcontext context = new VXDbcontext();
            gbtuyen.Show();
            List<TuyenXe> listtuyen = context.TuyenXes.ToList();
            Filltuyen(listtuyen);
        }

        private void bttimngay_Click(object sender, EventArgs e)
        {
            VXDbcontext context = new VXDbcontext();
            

            List<VeXe> listve = context.VeXes.Where(p => p.ThoiGianDat >= txttimngay.Value && p.ThoiGianDat <= txtngaycuoi.Value).ToList();
           
            List<ClassBaoCao1> listreport = new List<ClassBaoCao1>();
           
            foreach (VeXe s in listve)
            {
                ClassBaoCao1 temp = new ClassBaoCao1();
                temp.mave = s.MaVe;
                temp.machuyen = s.MaChuyen;
                temp.masoghe = s.MaSoGhe;
                temp.makh = s.MaKH;
                temp.tennhanvien = s.NhanVien.TenNV;
                temp.diadiemdi = s.ChuyenXe.TuyenXe.DiaDiem1.TenDiaDiem;
                temp.diadiemden = s.ChuyenXe.TuyenXe.DiaDiem.TenDiaDiem;
                temp.thoigiandat = s.ThoiGianDat.ToShortDateString();
                temp.giodi = s.ChuyenXe.GioDi;
                temp.giave = s.ChuyenXe.GiaVe;
                listreport.Add(temp);
            }
            reportViewer1.LocalReport.ReportPath = "ReportBaoCao1.rdlc";
            var source = new ReportDataSource("DataSet1", listreport);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();

        }
        private void Filltuyen(List<TuyenXe> listDiaDiemDi)
        {
            listDiaDiemDi.Insert(0, new TuyenXe() { MaTuyen = "" });
            this.cbtuyen.DataSource = listDiaDiemDi;
            this.cbtuyen.DisplayMember = "MaTuyen";
            this.cbtuyen.ValueMember = "MaTuyen";
        }
        private void Fillchuyen(List<ChuyenXe> listDiaDiemDi)
        {
            listDiaDiemDi.Insert(0, new ChuyenXe() { MaChuyen = "" });
            this.cbchuyen.DataSource = listDiaDiemDi;
            this.cbchuyen.DisplayMember = "MaChuyen";
            this.cbchuyen.ValueMember = "MaChuyen";
        }



        private void bttimtuyen_Click(object sender, EventArgs e)
        {
            gbngay.Hide();
            gbthang.Hide();

            
            VXDbcontext context = new VXDbcontext();
            List<VeXe> listve = context.VeXes.Where(p=>p.ChuyenXe.MaTuyen == cbtuyen.Text).ToList();
           
            List<ClassBaoCao1> listreport = new List<ClassBaoCao1>();
            foreach (VeXe s in listve)
            {
                ClassBaoCao1 temp = new ClassBaoCao1();
                temp.mave = s.MaVe;
                temp.machuyen = s.MaChuyen;
                temp.masoghe = s.MaSoGhe;


                temp.makh = s.MaKH;
                temp.tennhanvien = s.NhanVien.TenNV;
                temp.diadiemdi = s.ChuyenXe.TuyenXe.DiaDiem1.TenDiaDiem;
                temp.diadiemden = s.ChuyenXe.TuyenXe.DiaDiem.TenDiaDiem;
                temp.thoigiandat = s.ThoiGianDat.ToShortDateString();
                temp.giodi = s.ChuyenXe.GioDi;
                temp.giave = s.ChuyenXe.GiaVe;




                listreport.Add(temp);
            }
            reportViewer1.LocalReport.ReportPath = "ReportBaoCao1.rdlc";
            var source = new ReportDataSource("DataSet1", listreport);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }

        private void btnchuyen_Click(object sender, EventArgs e)
        {
            gbngay.Hide();
            gbtuyen.Hide();


            VXDbcontext context = new VXDbcontext();
            List<VeXe> listve = context.VeXes.Where(p => p.MaChuyen == cbchuyen.Text).ToList();

            List<ClassBaoCao1> listreport = new List<ClassBaoCao1>();
            foreach (VeXe s in listve)
            {
                ClassBaoCao1 temp = new ClassBaoCao1();
                temp.mave = s.MaVe;
                temp.machuyen = s.MaChuyen;
                temp.masoghe = s.MaSoGhe;


                temp.makh = s.MaKH;
                temp.tennhanvien = s.NhanVien.TenNV;
                temp.diadiemdi = s.ChuyenXe.TuyenXe.DiaDiem1.TenDiaDiem;
                temp.diadiemden = s.ChuyenXe.TuyenXe.DiaDiem.TenDiaDiem;
                temp.thoigiandat = s.ThoiGianDat.ToShortDateString();
                temp.giodi = s.ChuyenXe.GioDi;
                temp.giave = s.ChuyenXe.GiaVe;




                listreport.Add(temp);
            }
            reportViewer1.LocalReport.ReportPath = "ReportBaoCao1.rdlc";
            var source = new ReportDataSource("DataSet1", listreport);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(source);
            this.reportViewer1.RefreshReport();
        }

        private void theoChuyếnXeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbngay.Hide();
            gbthang.Show();
            VXDbcontext context = new VXDbcontext();
            gbtuyen.Hide();
            List<ChuyenXe> listchuyen = context.ChuyenXes.ToList();
            Fillchuyen(listchuyen);
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }

}
