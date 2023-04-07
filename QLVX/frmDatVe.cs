using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLVX.Model;

namespace QLVX
{
    public partial class frmDatVe : Form
    {
        public frmDatVe()
        {
            InitializeComponent();
        }
        VXDbcontext DBcontext = new VXDbcontext();
        string text;
        public frmDatVe(string text) : this()
        {
            Text = text;
            txtMaNV.Text = Text;

        }
        private void frmDatVe_Load_1(object sender, EventArgs e)
        {
            List<ChuyenXe> listChuyenXe = DBcontext.ChuyenXes.ToList();
            List<DiaDiem> listDiaDiem = DBcontext.DiaDiems.ToList();
            List<DiaDiem> listDiaDiemDi = DBcontext.DiaDiems.ToList();
            List<VeXe> listvexe = DBcontext.VeXes.ToList();
            FillDiaDiemDi(listDiaDiemDi);
            FillDiaDiemDen(listDiaDiem);
            BindGrid(listChuyenXe);
            //BindGridVeXe(listvexe);
            grbChiTietVe.Hide();
            grpChonGhe.Hide();
            dtgvChuyenxe.Hide();
            grbTimKiem.Hide();
            btnHuyVe.Enabled = false;
            btnSuaVe.Enabled = false;
            btninve.Enabled = false;
            SetGridViewStyle(dtgvChuyenxe); 
        }

        private int GetSelectedRow(string ma)
        {
            for (int i = 0; i < dtgvChuyenxe.Rows.Count; i++)
            {
                if (dtgvChuyenxe.Rows[i].Cells[0].Value != null)
                {
                    if (dtgvChuyenxe.Rows[i].Cells[0].Value.ToString() == ma)
                    {
                        return i;
                    }
                }

            }
            return -1;
        }
        private void BindGrid(List<ChuyenXe> listchuyenxe)
        {
            dtgvChuyenxe.Rows.Clear();
            foreach (var item in listchuyenxe)
            {
                int index = dtgvChuyenxe.Rows.Add();
                dtgvChuyenxe.Rows[index].Cells[0].Value = item.MaChuyen;
                dtgvChuyenxe.Rows[index].Cells[1].Value = item.MaTuyen;
                dtgvChuyenxe.Rows[index].Cells[2].Value = item.NgayDi.ToShortDateString();
                dtgvChuyenxe.Rows[index].Cells[3].Value = item.GioDi;
                dtgvChuyenxe.Rows[index].Cells[4].Value = item.GiaVe;
            }

        }
     

        private void FillDiaDiemDi(List<DiaDiem> listDiaDiemDi)
        {
            listDiaDiemDi.Insert(0, new DiaDiem() { TenDiaDiem = "" });
            this.cbxDiemDi.DataSource = listDiaDiemDi;
            this.cbxDiemDi.DisplayMember = "TenDiaDiem";
            this.cbxDiemDi.ValueMember = "MaDiaDiem";
        }

        private void FillDiaDiemDen(List<DiaDiem> listDiaDiem)
        {
            listDiaDiem.Insert(0, new DiaDiem() { TenDiaDiem = "" });
            this.cbxDiemDen.DataSource = listDiaDiem;
            this.cbxDiemDen.DisplayMember = "TenDiaDiem";
            this.cbxDiemDen.ValueMember = "MaDiaDiem";
        }      
        private void cbxDiemDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMaTuyen.Text = "";
            if (cbxDiemDen.Text == cbxDiemDi.Text && cbxDiemDi.Text != "")
            {
                MessageBox.Show("Điểm khởi hành và điểm đến không được trùng nhau! Xin vui lòng chọn lại!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            if (cbxDiemDen.Text != "" && cbxDiemDi.Text != "" && cbxDiemDi.Text != cbxDiemDen.Text)
            {
                string parseok = cbxDiemDi.SelectedValue.ToString();
                string parseok1 = cbxDiemDen.SelectedValue.ToString();

                var matuyen = from st in DBcontext.ChuyenXes
                              where st.TuyenXe.DiaDiemDi.Equals(parseok) && st.TuyenXe.DiaDiemden.Equals(parseok1)
                              select new { st.MaTuyen, st.NgayDi };
                foreach (var item in matuyen)
                {
                    lblMaTuyen.Text = item.MaTuyen.ToString();
                }

                if (lblMaTuyen.Text.Trim() == "")
                {
                    MessageBox.Show("Không có tuyến xe hợp lệ!", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {

                    List<ChuyenXe> list = (from ele in DBcontext.ChuyenXes
                                           where ele.MaTuyen.ToLower().Contains(lblMaTuyen.Text.Trim().ToLower())
                                           select ele).ToList();
                    BindGrid(list);
                    grbChiTietVe.Show();
                    grpChonGhe.Show();
                    dtgvChuyenxe.Show();
                    btnSuaVe.Enabled = false;
                }
                dtgvChuyenxe.Refresh();

            }
                     

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dtgvChuyenxe.Rows)
            {
                if (dateTimePicker1.Value.Date.ToShortDateString().ToString() == item.Cells[2].Value.ToString())
                {
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;

                }
            }
        }


   


        private void txtMaVe_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaGhe_TextChanged(object sender, EventArgs e)
        {

        }
        public void TinhTien()
        {
            string parseok = lblMaChuyen.Text;


            var giave = from st in DBcontext.ChuyenXes
                        where st.MaChuyen.Equals(parseok)
                        select new { st.GiaVe };

            if ((txtmv1.Text != "" && txtmv2.Text == "" && txtmv3.Text == "")
                || (txtmv1.Text == "" && txtmv2.Text != "" && txtmv3.Text == "")
                || (txtmv1.Text == "" && txtmv2.Text == "" && txtmv3.Text != ""))
            {
                foreach (var item in giave)
                {
                    txtThanhTien.Text = item.GiaVe.ToString();
                }
            }
            else if ((txtmv1.Text != "" && txtmv2.Text != "" && txtmv3.Text == "")
              || (txtmv1.Text != "" && txtmv2.Text == "" && txtmv3.Text != "")
              || (txtmv1.Text == "" && txtmv2.Text != "" && txtmv3.Text != "")
              )
            {
                foreach (var item in giave)
                {
                    txtThanhTien.Text = (item.GiaVe * 2).ToString();
                }
            }
            else if ((txtmv1.Text != "" && txtmv2.Text != "" && txtmv3.Text != ""))
            {
                foreach (var item in giave)
                {
                    txtThanhTien.Text = (item.GiaVe * 3).ToString();
                }
            }


        }

        public void GheTrung()
        {
            List<Button> listButton = new List<Button>();
            List<VeXe> listVeXe = DBcontext.VeXes.Where(p => p.MaChuyen == lblMaChuyen.Text).ToList();
            foreach (var item in listVeXe)
            {
                if (item.MaSoGhe == btg1.Text)
                {
                    btg1.Enabled = false;
                    btg1.BackColor = Color.Yellow;
                }
                if (item.MaSoGhe == btg2.Text)
                {
                    btg2.Enabled = false;
                    btg2.BackColor = Color.Yellow;
                }
                if (item.MaSoGhe == btg3.Text)
                {
                    btg3.Enabled = false;
                    btg3.BackColor = Color.Yellow;
                }
                if (item.MaSoGhe == btg4.Text)
                {
                    btg4.Enabled = false;
                    btg4.BackColor = Color.Yellow;
                }
                if (item.MaSoGhe == btg5.Text)
                {
                    btg5.Enabled = false;
                    btg5.BackColor = Color.Yellow;
                }
                if (item.MaSoGhe == btg6.Text)
                {
                    btg6.Enabled = false;
                    btg6.BackColor = Color.Yellow;
                }
                if (item.MaSoGhe == btg7.Text)
                {
                    btg7.Enabled = false;
                    btg7.BackColor = Color.Yellow;
                }
                if (item.MaSoGhe == btg8.Text)
                {
                    btg8.Enabled = false;
                    btg8.BackColor = Color.Yellow;
                }
            }
        }
        public void LamMoi()
        {
            btg1.Enabled = true;
            btg2.Enabled = true;
            btg3.Enabled = true;
            btg4.Enabled = true;
            btg5.Enabled = true;
            btg6.Enabled = true;
            btg7.Enabled = true;
            btg8.Enabled = true;

            btg1.BackColor = Color.White;
            btg2.BackColor = Color.White;
            btg3.BackColor = Color.White;
            btg4.BackColor = Color.White;
            btg5.BackColor = Color.White;
            btg6.BackColor = Color.White;
            btg7.BackColor = Color.White;
            btg8.BackColor = Color.White;
        }
        private void ReLoad()
        {
            txtDiemDen.Clear();
            txtDiemDi.Clear();
            txtHoTen.Clear();
            txtSDT.Clear();
            txtmv1.Clear();
            txtmv2.Clear();
            txtmv3.Clear();
            txtmg1.Clear();
            txtmg2.Clear();
            txtmg3.Clear();
            txtNgayDi.Clear();
            txtThoiGian.Clear();
            lblMaKH.Text = "";
            lblChuyenXe.Text = "";
            btnDatVe.Enabled = true;
            txtThanhTien.Text = "";
            dateTimePickerNgayDatVe.Value = DateTime.Now;
        }

        private void dtgvChuyenxe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //ReLoad();
                if (dtgvChuyenxe.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dtgvChuyenxe.CurrentRow.Selected = true;
                    lblMaChuyen.Text = dtgvChuyenxe.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtNgayDi.Text = dtgvChuyenxe.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtThoiGian.Text = dtgvChuyenxe.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    ChuyenXe diadiem = DBcontext.ChuyenXes.FirstOrDefault(p => p.MaChuyen == lblMaChuyen.Text);
                    cbxDiemDi.Text = diadiem.TuyenXe.DiaDiem1.TenDiaDiem;
                    cbxDiemDen.Text = diadiem.TuyenXe.DiaDiem.TenDiaDiem;
                    txtDiemDi.Text = diadiem.TuyenXe.DiaDiem1.TenDiaDiem;
                    txtDiemDen.Text = diadiem.TuyenXe.DiaDiem.TenDiaDiem;
                    //btnSuaVe.Enabled = true;
                    LamMoi();
                    GheTrung();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtMaNV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
            KhachHang kh = DBcontext.KhachHangs.FirstOrDefault(p => p.Sdt.ToString() == txtSDT.Text);
            if (kh != null)
            {
                if (kh.Sdt == txtSDT.Text)
                {
                    List<KhachHang> listKH = DBcontext.KhachHangs.ToList();
                    foreach (var item in listKH)
                    {
                        if (item.Sdt == txtSDT.Text)
                        {
                            lblMaKH.Text = item.MaKH;
                            txtHoTen.Text = item.TenKH;
                            datetpNgaySinh.Value = DateTime.Parse(item.NgaySinh.ToShortDateString());
                            txtHoTen.Enabled = false;
                            datetpNgaySinh.Enabled = false;
                        }
                    }
                }
            }
            else
            {
                string chuoi = "";
                List<KhachHang> listkh = DBcontext.KhachHangs.ToList();
                foreach (var item in listkh)
                {
                    chuoi = item.MaKH;
                }
                int chuoi2 = 0;
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                
                if (chuoi2 + 1 < 10)
                {
                    lblMaKH.Text = "KH00" + (chuoi2 + 1).ToString();
                }
                else if (chuoi2 + 1 < 100)
                {
                    lblMaKH.Text = "KH0" + (chuoi2 + 1).ToString();
                }
                else if (chuoi2 + 1 < 1000)
                {
                    lblMaKH.Text = "KH" + (chuoi2 + 1).ToString();
                }
                txtHoTen.Enabled = true;
                datetpNgaySinh.Enabled = true;
                txtHoTen.Clear();
            }     

        }
        public void ViTri1()
        {
            if (txtmg2.Text != "")
            {
                if (GetSelectedRow(txtmv1.Text) == -1)
                {
                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                    
                    if (chuoi2 + 1 < 10)
                    {

                        txtmv2.Text = "MV00" + (chuoi2 + 1).ToString();
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv2.Text = "MV0" + (chuoi2 + 1).ToString();
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv2.Text = "MV" + (chuoi2 + 1).ToString();
                    }
                }
                txtmv1.Text = txtmv2.Text;
                txtmg1.Text = txtmg2.Text;
                txtmg2.Clear();
                txtmv2.Clear();
            }
            if (txtmv3.Text != "")
            {
                if (GetSelectedRow(txtmv1.Text) == -1)
                {
                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                    
                    if (chuoi2 + 1 < 10)
                    {


                        txtmv3.Text = "MV00" + (chuoi2 + 2).ToString();
                    }

                    else if (chuoi2 + 1 < 100)
                    {

                        txtmv3.Text = "MV0" + (chuoi2 + 2).ToString();
                    }
                    else if (chuoi2 + 1 < 1000)
                    {

                        txtmv3.Text = "MV" + (chuoi2 + 2).ToString();
                    }
                    txtmv2.Text = txtmv3.Text;
                    txtmg2.Text = txtmg3.Text;
                    txtmv3.Clear();
                    txtmg3.Clear();
                }
            }
        }

        public void SuaViTri()
        {
            VeXe chongoi = DBcontext.VeXes.FirstOrDefault(p => p.MaVe == txtmv1.Text);
            if(chongoi != null)
            {
                txtmg1.Text = txtmg2.Text;
                txtmv2.Clear();
                txtmg2.Clear();
            }
        }
        public void ViTri2()
        {
            if (txtmg3.Text != "")
            {
                if (GetSelectedRow(txtmv1.Text) == -1)
                {
                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                    
                    if (chuoi2 + 1 < 10)
                    {

                        txtmv3.Text = "MV00" + (chuoi2 + 2).ToString();
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv3.Text = "MV0" + (chuoi2 + 2).ToString();
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv3.Text = "MV" + (chuoi2 + 2).ToString();
                    }
                }
                txtmv2.Text = txtmv3.Text;
                txtmg2.Text = txtmg3.Text;
                txtmv3.Clear();
                txtmg3.Clear();
            }
        }

        public void SetGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239,
            249);
            dgview.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dgview.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgview.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;

            dgview.BackgroundColor = Color.White;
            dgview.EnableHeadersVisualStyles = false;
            dgview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgview.AllowUserToDeleteRows = false;
            dgview.AllowUserToAddRows = false;
            dgview.AllowUserToOrderColumns = true;
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {
        
        }


        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            List<VeXe> list = (from ele in DBcontext.VeXes
                               where ele.MaVe.ToLower().Contains(txtMaVeSearch.Text.Trim().ToLower())
                  && ele.KhachHang.Sdt.ToString().ToLower().Contains(txtSDTSearch.Text.Trim().ToLower())
                               select ele).ToList();
            if (txtMaVeSearch.Text.Trim() == "" || txtSDTSearch.Text.Trim()=="" )
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            if(list.Count == 0 )
            {
                MessageBox.Show("Vé không tồn tại", "Thông báo", MessageBoxButtons.OK);
            }
            if (txtSDTSearch.Text.Length > 10 || txtSDTSearch.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 ", "Thông báo", MessageBoxButtons.OK) ;
            }
            else 
            if(list != null )
            {
                List<ChuyenXe> list1 = DBcontext.ChuyenXes.ToList();
               
                foreach (var item in list)
                {
                    txtmv1.Text = item.MaVe;
                    txtmg1.Text = item.MaSoGhe;
                    txtSDT.Text = item.KhachHang.Sdt.ToString();
                    txtHoTen.Text = item.KhachHang.TenKH;
                    lblMaKH.Text = item.MaKH;
                    txtNgayDi.Text = item.ChuyenXe.NgayDi.ToShortDateString();
                    txtThoiGian.Text = item.ChuyenXe.GioDi.ToString();
                    txtDiemDi.Text = item.ChuyenXe.TuyenXe.DiaDiem1.TenDiaDiem;
                    txtDiemDen.Text = item.ChuyenXe.TuyenXe.DiaDiem.TenDiaDiem;
                    txtThanhTien.Text = item.TongTien.ToString();
                    lblChuyenXe.Text = item.MaChuyen;
                    txtMaNV.Text = item.MaNV;
                    dateTimePickerNgayDatVe.Value = item.ThoiGianDat.Date;
                }
                grbChiTietVe.Show();
                dtgvChuyenxe.Show();
                grpChonGhe.Show();
                btnDatVe.Enabled = false;
                btnHuyVe.Enabled = true;
                btnSuaVe.Enabled = true;
                btninve.Enabled = true;
               
            }
        }

        private void btninve_Click(object sender, EventArgs e)
        {
            if( txtmv1.Text != "" && txtmv2.Text ==""&& txtmv3.Text == "" )
            {
                FormReportVeXe child = new FormReportVeXe(txtmv1.Text);

                child.Show();
            }else if (txtmv1.Text != "" && txtmv2.Text != "" && txtmv3.Text =="")
            {
                FormReportVeXe child = new FormReportVeXe(txtmv1.Text );

                child.Show();
                FormReportVeXe child2 = new FormReportVeXe(txtmv2.Text);

                child2.Show();

            }else if (txtmv1.Text != "" && txtmv2.Text != "" && txtmv3.Text != "")
            {
                FormReportVeXe child = new FormReportVeXe(txtmv1.Text);

                child.Show();
                FormReportVeXe child2 = new FormReportVeXe(txtmv2.Text);

                child2.Show();
                FormReportVeXe child3 = new FormReportVeXe(txtmv3.Text);

                child3.Show();

            }
            ReLoad();

           

        }

        private void cbxDiemDi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnDatVe_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSDT.Text == "" || txtHoTen.Text == "")
                {
                    MessageBox.Show("Phải điền đầy đủ thông tin!.", "Thông báo ", MessageBoxButtons.OK);
                }
                if (txtSDT.Text.Length > 10 || txtSDT.Text.Length < 10)
                {
                    MessageBox.Show("Số điện thoại phải đủ 10 ", "Thông báo", MessageBoxButtons.OK);
                }
                else
                {
                    string tien1ve = "";
                    string parseok = lblMaChuyen.Text;


                    var giave = from st in DBcontext.ChuyenXes
                                where st.MaChuyen.Equals(parseok)
                                select new { st.GiaVe };
                    foreach (var item in giave)
                    {
                        tien1ve = item.GiaVe.ToString();
                    }

                    if (txtmv1.Text != "" && txtmv2.Text == "" && txtmv3.Text == "")
                    {

                        KhachHang kh = DBcontext.KhachHangs.FirstOrDefault(p => p.MaKH == lblMaKH.Text);
                        if (kh != null)
                        {

                            VeXe s = new VeXe()
                            {
                                MaVe = txtmv1.Text,
                                MaChuyen = lblMaChuyen.Text,
                                MaKH = lblMaKH.Text,
                                MaNV = txtMaNV.Text,
                                MaSoGhe = txtmg1.Text,
                                ThoiGianDat = DateTime.Now,
                                TongTien = int.Parse(tien1ve)
                            };
                            DBcontext.VeXes.Add(s);
                            DBcontext.SaveChanges();
                        }
                        else
                        {
                            KhachHang KH = new KhachHang()
                            {
                                MaKH = lblMaKH.Text,
                                TenKH = txtHoTen.Text,
                                Sdt = txtSDT.Text,
                                NgaySinh = datetpNgaySinh.Value.Date

                            };
                            DBcontext.KhachHangs.Add(KH);
                            DBcontext.SaveChanges();

                            VeXe s = new VeXe()
                            {
                                MaVe = txtmv1.Text,
                                MaChuyen = lblMaChuyen.Text,
                                MaKH = lblMaKH.Text,
                                MaNV = txtMaNV.Text,
                                MaSoGhe = txtmg1.Text,
                                ThoiGianDat = DateTime.Now,
                                TongTien = int.Parse(tien1ve)
                            };
                            DBcontext.VeXes.Add(s);
                            DBcontext.SaveChanges();
                        }

                    }
                    else if (txtmv1.Text == "" && txtmv2.Text != "" && txtmv3.Text == "")
                    {
                        KhachHang KH = new KhachHang()
                        {
                            MaKH = lblMaKH.Text,
                            TenKH = txtHoTen.Text,
                            Sdt = txtSDT.Text,
                            NgaySinh = datetpNgaySinh.Value.Date

                        };
                        DBcontext.KhachHangs.Add(KH);

                        VeXe s = new VeXe()
                        {
                            MaVe = txtmv2.Text,
                            MaChuyen = lblMaChuyen.Text,
                            MaKH = lblMaKH.Text,
                            MaNV = txtMaNV.Text,
                            MaSoGhe = txtmg2.Text,
                            ThoiGianDat = DateTime.Now,
                            TongTien = int.Parse(tien1ve)
                        };
                        DBcontext.VeXes.Add(s);
                        DBcontext.SaveChanges();
                    }
                    else if (txtmv1.Text == "" && txtmv2.Text == "" && txtmv3.Text != "")
                    {
                        KhachHang KH = new KhachHang()
                        {
                            MaKH = lblMaKH.Text,
                            TenKH = txtHoTen.Text,
                            Sdt = txtSDT.Text,
                            NgaySinh = datetpNgaySinh.Value.Date

                        };
                        DBcontext.KhachHangs.Add(KH);

                        VeXe s = new VeXe()
                        {
                            MaVe = txtmv3.Text,
                            MaChuyen = lblMaChuyen.Text,
                            MaKH = lblMaKH.Text,
                            MaNV = txtMaNV.Text,
                            MaSoGhe = txtmg3.Text,
                            ThoiGianDat = DateTime.Now,
                            TongTien = int.Parse(tien1ve)
                        };
                        DBcontext.VeXes.Add(s);
                        DBcontext.SaveChanges();
                    }
                    else if (txtmv1.Text != "" && txtmv2.Text != "" && txtmv3.Text == "")
                    {
                        KhachHang KH = new KhachHang()
                        {
                            MaKH = lblMaKH.Text,
                            TenKH = txtHoTen.Text,
                            Sdt = txtSDT.Text,
                            NgaySinh = datetpNgaySinh.Value.Date

                        };
                        DBcontext.KhachHangs.Add(KH);

                        VeXe s = new VeXe()
                        {
                            MaVe = txtmv1.Text,
                            MaChuyen = lblMaChuyen.Text,
                            MaKH = lblMaKH.Text,
                            MaNV = txtMaNV.Text,
                            MaSoGhe = txtmg1.Text,
                            ThoiGianDat = DateTime.Now,
                            TongTien = int.Parse(tien1ve)
                        };
                        DBcontext.VeXes.Add(s);

                        VeXe s1 = new VeXe()
                        {
                            MaVe = txtmv2.Text,
                            MaChuyen = lblMaChuyen.Text,
                            MaKH = lblMaKH.Text,
                            MaNV = txtMaNV.Text,
                            MaSoGhe = txtmg2.Text,
                            ThoiGianDat = DateTime.Now,
                            TongTien = int.Parse(tien1ve)
                        };
                        DBcontext.VeXes.Add(s1);
                        DBcontext.SaveChanges();
                    }
                    else if (txtmv1.Text != "" && txtmv2.Text == "" && txtmv3.Text != "")
                    {
                        KhachHang KH = new KhachHang()
                        {
                            MaKH = lblMaKH.Text,
                            TenKH = txtHoTen.Text,
                            Sdt = txtSDT.Text,
                            NgaySinh = datetpNgaySinh.Value.Date

                        };
                        DBcontext.KhachHangs.Add(KH);

                        VeXe s = new VeXe()
                        {
                            MaVe = txtmv3.Text,
                            MaChuyen = lblMaChuyen.Text,
                            MaKH = lblMaKH.Text,
                            MaNV = txtMaNV.Text,
                            MaSoGhe = txtmg3.Text,
                            ThoiGianDat = DateTime.Now,
                            TongTien = int.Parse(tien1ve)
                        };
                        DBcontext.VeXes.Add(s);

                        VeXe s1 = new VeXe()
                        {
                            MaVe = txtmv1.Text,
                            MaChuyen = lblMaChuyen.Text,
                            MaKH = lblMaKH.Text,
                            MaNV = txtMaNV.Text,
                            MaSoGhe = txtmg1.Text,
                            ThoiGianDat = DateTime.Now,
                            TongTien = int.Parse(tien1ve)
                        };
                        DBcontext.VeXes.Add(s1);
                        DBcontext.SaveChanges();
                    }
                    else if (txtmv1.Text == "" && txtmv2.Text != "" && txtmv3.Text != "")
                    {
                        KhachHang KH = new KhachHang()
                        {
                            MaKH = lblMaKH.Text,
                            TenKH = txtHoTen.Text,
                            Sdt = txtSDT.Text,
                            NgaySinh = datetpNgaySinh.Value.Date

                        };
                        DBcontext.KhachHangs.Add(KH);

                        VeXe s = new VeXe()
                        {
                            MaVe = txtmv3.Text,
                            MaChuyen = lblMaChuyen.Text,
                            MaKH = lblMaKH.Text,
                            MaNV = txtMaNV.Text,
                            MaSoGhe = txtmg3.Text,
                            ThoiGianDat = DateTime.Now,
                            TongTien = int.Parse(tien1ve)
                        };
                        DBcontext.VeXes.Add(s);
                       // DBcontext.SaveChanges();

                        VeXe s1 = new VeXe()
                        {
                            MaVe = txtmv2.Text,
                            MaChuyen = lblMaChuyen.Text,
                            MaKH = lblMaKH.Text,
                            MaNV = txtMaNV.Text,
                            MaSoGhe = txtmg2.Text,
                            ThoiGianDat = DateTime.Now,
                            TongTien = int.Parse(tien1ve)
                        };
                        DBcontext.VeXes.Add(s1);
                        DBcontext.SaveChanges();
                    }
                    else if (txtmv1.Text != "" && txtmv2.Text != "" && txtmv3.Text != "")
                    {
                        KhachHang KH = new KhachHang()
                        {
                            MaKH = lblMaKH.Text,
                            TenKH = txtHoTen.Text,
                            Sdt = txtSDT.Text,
                            NgaySinh = datetpNgaySinh.Value.Date

                        };
                        DBcontext.KhachHangs.Add(KH);

                        VeXe s = new VeXe()
                        {
                            MaVe = txtmv3.Text,
                            MaChuyen = lblMaChuyen.Text,
                            MaKH = lblMaKH.Text,
                            MaNV = txtMaNV.Text,
                            MaSoGhe = txtmg3.Text,
                            ThoiGianDat = DateTime.Now,
                            TongTien = int.Parse(tien1ve)
                        };
                        DBcontext.VeXes.Add(s);
                       // DBcontext.SaveChanges();

                        VeXe s1 = new VeXe()
                        {
                            MaVe = txtmv2.Text,
                            MaChuyen = lblMaChuyen.Text,
                            MaKH = lblMaKH.Text,
                            MaNV = txtMaNV.Text,
                            MaSoGhe = txtmg2.Text,
                            ThoiGianDat = DateTime.Now,
                            TongTien = int.Parse(tien1ve)
                        };
                        DBcontext.VeXes.Add(s1);
                        //DBcontext.SaveChanges();

                        VeXe s2 = new VeXe()
                        {
                            MaVe = txtmv1.Text,
                            MaChuyen = lblMaChuyen.Text,
                            MaKH = lblMaKH.Text,
                            MaNV = txtMaNV.Text,
                            MaSoGhe = txtmg1.Text,
                            ThoiGianDat = DateTime.Now,
                            TongTien = int.Parse(tien1ve)
                        };
                        DBcontext.VeXes.Add(s2);
                        DBcontext.SaveChanges();
                    }
                    MessageBox.Show("Thêm dữ liệu thành công", "Thông báo ", MessageBoxButtons.OK);
                    btninve.Enabled = true;
                }
            }
            catch( Exception ex)
            {
                MessageBox.Show(ex.Message,"Lỗi",MessageBoxButtons.OK);
            }


        }
        private void btnHuyVe_Click(object sender, EventArgs e)
        {
            try
            {
                VeXe dbDelete = DBcontext.VeXes.FirstOrDefault(p => p.MaVe == txtmv1.Text);
                if (dbDelete != null)
                {
                    DialogResult r = MessageBox.Show("Bạn có muốn xóa ?", "THÔNG BÁO", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {
                        DBcontext.VeXes.Remove(dbDelete);
                        DBcontext.SaveChanges();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                        //grbChiTietVe.Hide();
                        ReLoad();

                    }
                }           
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btg1_Click(object sender, EventArgs e)
        {
            if (txtmg1.Text != "" && txtmg2.Text != "" && txtmg3.Text != "" && btg1.Text != txtmg1.Text && btg1.Text != txtmg2.Text && btg1.Text != txtmg3.Text)
            {
                MessageBox.Show(" Một khách hàng chỉ được đặt 3 vé  !", "Thông báo", MessageBoxButtons.OK);
            }
            else

            if (txtmv1.Text == "" && btg1.Text != txtmg2.Text && btg1.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv1.Text) == -1)
                {
                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));


                    if (chuoi2 + 1 < 10)
                    {
                        txtmv1.Text = "MV00" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg1.Text;
                        btg1.BackColor = Color.Blue;
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv1.Text = "MV0" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg1.Text;
                        btg1.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv1.Text = "MV" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg1.Text;
                        btg1.BackColor = Color.Blue;
                    }
                }
           
            }           
            else
            if (txtmg1.Text == btg1.Text)
            {
                txtmv1.Clear();
                txtmg1.Clear();
                txtThanhTien.Text = "";
                btg1.BackColor = Color.White;
                ViTri1();
            }

            else
            if (txtmv2.Text == "" && btg1.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv2.Text) == -1)
                {

                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));

                    if (chuoi2 + 1 < 10)
                    {
                        txtmv2.Text = "MV00" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg1.Text;
                        btg1.BackColor = Color.Blue;
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv2.Text = "MV0" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg1.Text;
                        btg1.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv2.Text = "MV" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg1.Text;
                        btg1.BackColor = Color.Blue;
                    }

                }
             SuaViTri();
            }
            else
            if (txtmg2.Text == btg1.Text)
            {
                txtmg2.Clear();
                txtmv2.Clear();
                txtThanhTien.Text = "";
                btg1.BackColor = Color.White;
                ViTri2();
            }
            else
                         if (txtmv3.Text == "" && btg1.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv3.Text) == -1)
                {

                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));

                    if (chuoi2 + 1 < 10)
                    {
                        txtmv3.Text = "MV00" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg1.Text;
                        btg1.BackColor = Color.Blue;
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv3.Text = "MV0" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg1.Text;
                        btg1.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv3.Text = "MV" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg1.Text;
                        btg1.BackColor = Color.Blue;
                    }

                }

            }
            else
                     if (txtmg3.Text == btg1.Text)
            {
                txtmg3.Clear();
                txtmv3.Clear();
                txtThanhTien.Text = "";
                btg1.BackColor = Color.White;
            }
            TinhTien();
        }

        private void btg2_Click(object sender, EventArgs e)
        {
            if (txtmg1.Text != "" && txtmg2.Text != "" && txtmg3.Text != "" && btg2.Text != txtmg1.Text && btg2.Text != txtmg2.Text && btg2.Text != txtmg3.Text)
            {
                MessageBox.Show(" Một khách hàng chỉ được đặt 3 vé  !", "Thông báo", MessageBoxButtons.OK);
            }
            else
            if (txtmv1.Text == "" && btg2.Text != txtmg2.Text && btg2.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv1.Text) == -1)
                {
                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                    if (chuoi2 + 1 < 10)
                    {
                        txtmv1.Text = "MV00" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg2.Text;
                        btg2.BackColor = Color.Blue;
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv1.Text = "MV0" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg2.Text;
                        btg2.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv1.Text = "MV" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg2.Text;
                        btg2.BackColor = Color.Blue;
                    }

                }
            }
            else
            if (txtmg1.Text == btg2.Text)
            {
                txtmv1.Clear();
                txtmg1.Clear();
                txtThanhTien.Text = "";
                btg2.BackColor = Color.White;
                ViTri1();
            }

            else
            if (txtmv2.Text == "" && btg2.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv2.Text) == -1)
                {
                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                    if (chuoi2 + 1 < 10)
                    {
                        txtmv2.Text = "MV00" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg2.Text;
                        btg2.BackColor = Color.Blue;
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv2.Text = "MV0" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg2.Text;
                        btg2.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv2.Text = "MV" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg2.Text;
                        btg2.BackColor = Color.Blue;
                    }
                }
            SuaViTri();
            }
            else
                        if (txtmg2.Text == btg2.Text)
            {
                txtmg2.Clear();
                txtmv2.Clear();
                txtThanhTien.Text = "";
                btg2.BackColor = Color.White;
                ViTri2();
            }
            else
                        if (txtmv3.Text == "" && btg2.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv3.Text) == -1)
                {
                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                    
                    if (chuoi2 + 1 < 10)
                    {
                        txtmv3.Text = "MV00" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg2.Text;
                        btg2.BackColor = Color.Blue;
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv3.Text = "MV0" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg2.Text;
                        btg2.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv3.Text = "MV" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg2.Text;
                        btg2.BackColor = Color.Blue;
                    }
                }

            }
            else
                        if (txtmg3.Text == btg2.Text)
            {
                txtmg3.Clear();
                txtmv3.Clear();
                txtThanhTien.Text = "";
                btg2.BackColor = Color.White;
            }
            TinhTien();
        }

        private void btg3_Click(object sender, EventArgs e)
        {
            if (txtmg1.Text != "" && txtmg2.Text != "" && txtmg3.Text != "" && btg3.Text != txtmg1.Text && btg3.Text != txtmg2.Text && btg3.Text != txtmg3.Text)
            {
                MessageBox.Show(" Một khách hàng chỉ được đặt 3 vé  !", "Thông báo", MessageBoxButtons.OK);
            }
            else
                                if (txtmv1.Text == "" && btg3.Text != txtmg2.Text && btg3.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv1.Text) == -1)
                {
                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                   
                    if (chuoi2 + 1 < 10)
                    {
                        txtmv1.Text = "MV00" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg3.Text;
                        btg3.BackColor = Color.Blue;
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv1.Text = "MV0" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg3.Text;
                        btg3.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv1.Text = "MV" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg3.Text;
                        btg3.BackColor = Color.Blue;
                    }
                }
            }
            else
            if (txtmg1.Text == btg3.Text)
            {
                txtmv1.Clear();
                txtmg1.Clear();
                txtThanhTien.Text = "";
                btg3.BackColor = Color.White;
                ViTri1();
            }

            else
            if (txtmv2.Text == "" && btg3.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv2.Text) == -1)
                {
                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                    
                    if (chuoi2 + 1 < 10)
                    {
                        txtmv2.Text = "MV00" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg3.Text;
                        btg3.BackColor = Color.Blue;
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv2.Text = "MV0" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg3.Text;
                        btg3.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv2.Text = "MV" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg3.Text;
                        btg3.BackColor = Color.Blue;
                    }
                }
             SuaViTri();
            }
            else
            if (txtmg2.Text == btg3.Text)
            {
                txtmg2.Clear();
                txtmv2.Clear();
                txtThanhTien.Text = "";
                btg3.BackColor = Color.White;
                ViTri2();
            }
            else
            if (txtmv3.Text == "" && btg3.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv3.Text) == -1)
                {

                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                   
                    if (chuoi2 + 1 < 10)
                    {
                        txtmv3.Text = "MV00" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg3.Text;
                        btg3.BackColor = Color.Blue;
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv3.Text = "MV0" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg3.Text;
                        btg3.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv3.Text = "MV" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg3.Text;
                        btg3.BackColor = Color.Blue;
                    }
                }

            }
            else
            if (txtmg3.Text == btg3.Text)
            {
                txtmg3.Clear();
                txtmv3.Clear();
                txtThanhTien.Text = "";
                btg3.BackColor = Color.White;
            }
            TinhTien();
        }

        private void btg4_Click(object sender, EventArgs e)
        {
            if (txtmg1.Text != "" && txtmg2.Text != "" && txtmg3.Text != "" && btg4.Text != txtmg1.Text && btg4.Text != txtmg2.Text && btg4.Text != txtmg3.Text)
            {
                MessageBox.Show(" Một khách hàng chỉ được đặt 3 vé  !", "Thông báo", MessageBoxButtons.OK);
            }
            else
                               if (txtmv1.Text == "" && btg4.Text != txtmg2.Text && btg4.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv1.Text) == -1)
                {
                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                   
                    if (chuoi2 + 1 < 10)
                    {
                        txtmv1.Text = "MV00" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg4.Text;
                        btg4.BackColor = Color.Blue;
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv1.Text = "MV0" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg4.Text;
                        btg4.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv1.Text = "MV" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg4.Text;
                        btg4.BackColor = Color.Blue;
                    }

                }
            }
            else
            if (txtmg1.Text == btg4.Text)
            {
                txtmv1.Clear();
                txtmg1.Clear();
                txtThanhTien.Text = "";
                btg4.BackColor = Color.White;
                ViTri1();
            }

            else
            if (txtmv2.Text == "" && btg4.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv2.Text) == -1)
                {
                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                    
                    if (chuoi2 + 1 < 10)
                    {
                        txtmv2.Text = "MV00" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg4.Text;
                        btg4.BackColor = Color.Blue;
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv2.Text = "MV0" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg4.Text;
                        btg4.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv2.Text = "MV" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg4.Text;
                        btg4.BackColor = Color.Blue;
                    }
                }
            SuaViTri();
            }
            else
            if (txtmg2.Text == btg4.Text)
            {
                txtmg2.Clear();
                txtmv2.Clear();
                txtThanhTien.Text = "";
                btg4.BackColor = Color.White;
                ViTri2();
            }
            else
            if (txtmv3.Text == "" && btg4.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv3.Text) == -1)
                {
                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                    
                    if (chuoi2 + 1 < 10)
                    {
                        txtmv3.Text = "MV00" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg4.Text;
                        btg4.BackColor = Color.Blue;
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv3.Text = "MV0" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg4.Text;
                        btg4.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv3.Text = "MV" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg4.Text;
                        btg4.BackColor = Color.Blue;
                    }
                }

            }
            else
            if (txtmg3.Text == btg4.Text)
            {
                txtmg3.Clear();
                txtmv3.Clear();
                txtThanhTien.Text = "";
                btg4.BackColor = Color.White;
            }
            TinhTien();
        }

        private void btg5_Click(object sender, EventArgs e)
        {
            if (txtmg1.Text != "" && txtmg2.Text != "" && txtmg3.Text != "" && btg5.Text != txtmg1.Text && btg5.Text != txtmg2.Text && btg5.Text != txtmg3.Text)
            {
                MessageBox.Show(" Một khách hàng chỉ được đặt 3 vé  !", "Thông báo", MessageBoxButtons.OK);
            }
            else
                                if (txtmv1.Text == "" && btg5.Text != txtmg2.Text && btg5.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv1.Text) == -1)
                {
                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                    
                    if (chuoi2 + 1 < 10)
                    {
                        txtmv1.Text = "MV00" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg5.Text;
                        btg5.BackColor = Color.Blue;
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv1.Text = "MV0" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg5.Text;
                        btg5.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv1.Text = "MV" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg5.Text;
                        btg5.BackColor = Color.Blue;
                    }
                }
            }
            else
            if (txtmg1.Text == btg5.Text)
            {
                txtmv1.Clear();
                txtmg1.Clear();
                txtThanhTien.Text = "";
                btg5.BackColor = Color.White;
                ViTri1();
            }

            else
            if (txtmv2.Text == "" && btg5.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv2.Text) == -1)
                {
                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                    
                    if (chuoi2 + 1 < 10)
                    {
                        txtmv2.Text = "MV00" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg5.Text;
                        btg5.BackColor = Color.Blue;
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv2.Text = "MV0" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg5.Text;
                        btg5.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv2.Text = "MV" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg5.Text;
                        btg5.BackColor = Color.Blue;
                    }
                }
            SuaViTri();
            }
            else
            if (txtmg2.Text == btg5.Text)
            {
                txtmg2.Clear();
                txtmv2.Clear();
                txtThanhTien.Text = "";
                btg5.BackColor = Color.White;
                ViTri2();
            }
            else
            if (txtmv3.Text == "" && btg5.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv3.Text) == -1)
                {
                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                    
                    if (chuoi2 + 1 < 10)
                    {
                        txtmv3.Text = "MV00" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg5.Text;
                        btg5.BackColor = Color.Blue;
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv3.Text = "MV0" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg5.Text;
                        btg5.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv3.Text = "MV" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg5.Text;
                        btg5.BackColor = Color.Blue;
                    }
                }

            }
            else
            if (txtmg3.Text == btg5.Text)
            {
                txtmg3.Clear();
                txtmv3.Clear();
                txtThanhTien.Text = "";
                btg5.BackColor = Color.White;
            }
            TinhTien();
        }

        private void btg6_Click(object sender, EventArgs e)
        {
            if (txtmg1.Text != "" && txtmg2.Text != "" && txtmg3.Text != "" && btg6.Text != txtmg1.Text && btg6.Text != txtmg2.Text && btg6.Text != txtmg3.Text)
            {
                MessageBox.Show(" Một khách hàng chỉ được đặt 3 vé  !", "Thông báo", MessageBoxButtons.OK);
            }
            else
            if (txtmv1.Text == "" && btg6.Text != txtmg2.Text && btg6.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv1.Text) == -1)
                {
                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                   
                    if (chuoi2 + 1 < 10)
                    {
                        txtmv1.Text = "MV00" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg6.Text;
                        btg6.BackColor = Color.Blue;
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv1.Text = "MV0" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg6.Text;
                        btg6.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv1.Text = "MV" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg6.Text;
                        btg6.BackColor = Color.Blue;
                    }

                }

            }
            else
            if (txtmg1.Text == btg6.Text)
            {
                txtmv1.Clear();
                txtmg1.Clear();
                txtThanhTien.Text = "";
                btg6.BackColor = Color.White;
                ViTri1();
            }

            else
            if (txtmv2.Text == "" && btg6.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv2.Text) == -1)
                {
                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                   
                    if (chuoi2 + 1 < 10)
                    {
                        txtmv2.Text = "MV00" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg6.Text;
                        btg6.BackColor = Color.Blue;
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv2.Text = "MV0" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg6.Text;
                        btg6.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv2.Text = "MV" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg6.Text;
                        btg6.BackColor = Color.Blue;
                    }
                }
            SuaViTri();
            }
            else
            if (txtmg2.Text == btg6.Text)
            {
                txtmg2.Clear();
                txtmv2.Clear();
                txtThanhTien.Text = "";
                btg6.BackColor = Color.White;
                ViTri2();
            }
            else
            if (txtmv3.Text == "" && btg6.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv3.Text) == -1)
                {
                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));

                    if (chuoi2 + 1 < 10)
                    {
                        txtmv3.Text = "MV00" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg6.Text;
                        btg6.BackColor = Color.Blue;
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv3.Text = "MV0" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg6.Text;
                        btg6.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv3.Text = "MV" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg6.Text;
                        btg6.BackColor = Color.Blue;
                    }
                }

            }
            else
            if (txtmg3.Text == btg6.Text)
            {
                txtmg3.Clear();
                txtmv3.Clear();
                txtThanhTien.Text = "";
                btg6.BackColor = Color.White;
            }
            TinhTien();
        }

        private void btg7_Click(object sender, EventArgs e)
        {
            if (txtmg1.Text != "" && txtmg2.Text != "" && txtmg3.Text != "" && btg7.Text != txtmg1.Text && btg7.Text != txtmg2.Text && btg7.Text != txtmg3.Text)
            {
                MessageBox.Show(" Một khách hàng chỉ được đặt 3 vé  !", "Thông báo", MessageBoxButtons.OK);
            }
            else
            if (txtmv1.Text == "" && btg7.Text != txtmg2.Text && btg7.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv1.Text) == -1)
                {
                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));

                    if (chuoi2 + 1 < 10)
                    {
                        txtmv1.Text = "MV00" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg7.Text;
                        btg7.BackColor = Color.Blue;
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv1.Text = "MV0" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg7.Text;
                        btg7.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv1.Text = "MV" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg7.Text;
                        btg7.BackColor = Color.Blue;
                    }
                }

            }
            else
            if (txtmg1.Text == btg7.Text)
            {
                txtmv1.Clear();
                txtmg1.Clear();
                txtThanhTien.Text = "";
                btg7.BackColor = Color.White;
                ViTri1();
            }

            else
            if (txtmv2.Text == "" && btg7.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv2.Text) == -1)
                {
                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));


                    if (chuoi2 + 1 < 10)
                    {
                        txtmv2.Text = "MV00" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg7.Text;
                        btg7.BackColor = Color.Blue;
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv2.Text = "MV0" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg7.Text;
                        btg7.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv2.Text = "MV" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg7.Text;
                        btg7.BackColor = Color.Blue;
                    }
                }
            SuaViTri();
            }
            else
            if (txtmg2.Text == btg7.Text)
            {
                txtmg2.Clear();
                txtmv2.Clear();
                txtThanhTien.Text = "";
                btg7.BackColor = Color.White;
                ViTri2();
            }
            else
            if (txtmv3.Text == "" && btg7.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv3.Text) == -1)
                {

                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));

                    if (chuoi2 + 1 < 10)
                    {
                        txtmv3.Text = "MV00" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg7.Text;
                        btg7.BackColor = Color.Blue;
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv3.Text = "MV0" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg7.Text;
                        btg7.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv3.Text = "MV" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg7.Text;
                        btg7.BackColor = Color.Blue;
                    }
                }

            }
            else
            if (txtmg3.Text == btg7.Text)
            {
                txtmg3.Clear();
                txtmv3.Clear();
                txtThanhTien.Text = "";
                btg7.BackColor = Color.White;
            }
            TinhTien();
        }

        private void btg8_Click(object sender, EventArgs e)
        {
            if (txtmg1.Text != "" && txtmg2.Text != "" && txtmg3.Text != "" && btg8.Text != txtmg1.Text && btg8.Text != txtmg2.Text && btg8.Text != txtmg3.Text)
            {
                MessageBox.Show(" Một khách hàng chỉ được đặt 3 vé  !", "Thông báo", MessageBoxButtons.OK);
            }
            else

            if (txtmv1.Text == "" && btg8.Text != txtmg2.Text && btg8.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv1.Text) == -1)
                {
                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                   
                    if (chuoi2 + 1 < 10)
                    {
                        txtmv1.Text = "MV00" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg8.Text;
                        btg8.BackColor = Color.Blue;
                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv1.Text = "MV0" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg8.Text;
                        btg8.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv1.Text = "MV" + (chuoi2 + 1).ToString();
                        txtmg1.Text = btg8.Text;
                        btg8.BackColor = Color.Blue;
                    }

                }
            }
            else
            if (txtmg1.Text == btg8.Text)
            {
                txtmv1.Clear();
                txtmg1.Clear();
                txtThanhTien.Text = "";
                btg8.BackColor = Color.White;
                ViTri1();
            }

            else
            if (txtmv2.Text == "" && btg8.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv2.Text) == -1)
                {
                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                    
                    if (chuoi2 + 1 < 10)
                    {
                        txtmv2.Text = "MV00" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg8.Text;
                        btg8.BackColor = Color.Blue;

                    }
                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv2.Text = "MV0" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg8.Text;
                        btg8.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 1000)
                    {
                        txtmv2.Text = "MV" + (chuoi2 + 2).ToString();
                        txtmg2.Text = btg8.Text;
                        btg8.BackColor = Color.Blue;
                    }

                }
            SuaViTri();
            }
            else
                                if (txtmg2.Text == btg8.Text)
            {
                txtmg2.Clear();
                txtmv2.Clear();
                txtThanhTien.Text = "";
                btg8.BackColor = Color.White;
                ViTri2();
            }
            else
            if (txtmv3.Text == "" && btg8.Text != txtmg3.Text)
            {
                if (GetSelectedRow(txtmv3.Text) == -1)
                {
                    string chuoi = "";
                    List<VeXe> listVeXe = DBcontext.VeXes.ToList();
                    foreach (var item in listVeXe)
                    {
                        chuoi = item.MaVe;
                    }
                    int chuoi2 = 0;
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                    
                    if (chuoi2 + 1 < 10)
                    {
                        txtmv3.Text = "MV00" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg8.Text;
                        btg8.BackColor = Color.Blue;

                    }

                    else if (chuoi2 + 1 < 100)
                    {
                        txtmv3.Text = "MV0" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg8.Text;
                        btg8.BackColor = Color.Blue;
                    }
                    else if (chuoi2 + 1 < 10)
                    {
                        txtmv3.Text = "MV" + (chuoi2 + 3).ToString();
                        txtmg3.Text = btg8.Text;
                        btg8.BackColor = Color.Blue;
                    }

                }

            }
            else
            if (txtmg3.Text == btg8.Text)
            {
                txtmg3.Clear();
                txtmv3.Clear();
                txtThanhTien.Text = "";
                btg8.BackColor = Color.White;
            }
            TinhTien();
        }

        private void btnSuaVe_Click(object sender, EventArgs e)
        {  
            VeXe listTuyenXe = DBcontext.VeXes.FirstOrDefault(p => p.MaVe == txtmv1.Text);           
            KhachHang kh = DBcontext.KhachHangs.FirstOrDefault(p => p.MaKH == lblMaKH.Text);
            if (txtSDT.Text.Length > 10 || txtSDT.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 ", "Thông báo", MessageBoxButtons.OK);
            }
            else
            if (kh != null)
            {
                if (listTuyenXe != null)
                {                  
                    listTuyenXe.MaVe = txtmv1.Text;
                    listTuyenXe.MaChuyen = lblChuyenXe.Text;
                    listTuyenXe.MaSoGhe = txtmg1.Text;
                    listTuyenXe.MaKH = lblMaKH.Text;
                    listTuyenXe.MaNV = txtMaNV.Text;
                    listTuyenXe.KhachHang.TenKH = txtHoTen.Text;
                    listTuyenXe.KhachHang.Sdt = txtSDT.Text;
                    listTuyenXe.KhachHang.NgaySinh = DateTime.Parse(datetpNgaySinh.Text);
                    listTuyenXe.ThoiGianDat = DateTime.Parse(dateTimePickerNgayDatVe.Text);
                    listTuyenXe.TongTien = int.Parse(txtThanhTien.Text);
                    DBcontext.VeXes.AddOrUpdate(listTuyenXe);
                    DBcontext.SaveChanges();
                    MessageBox.Show($"Sửa thông tin vé {listTuyenXe.MaVe} thành công", "THÔNG BÁO");
                }
            }else 
            if(kh == null)
            {
                KhachHang KH = new KhachHang()
                {
                    MaKH = lblMaKH.Text,
                    TenKH = txtHoTen.Text,
                    Sdt = txtSDT.Text,
                    NgaySinh = datetpNgaySinh.Value.Date
                };
                    DBcontext.KhachHangs.Add(KH);               

                if (listTuyenXe != null)
                {
                    SuaViTri();
                    listTuyenXe.MaVe = txtmv1.Text;
                    listTuyenXe.MaChuyen = lblChuyenXe.Text;
                    listTuyenXe.MaSoGhe = txtmg1.Text;
                    listTuyenXe.MaKH = lblMaKH.Text;
                    listTuyenXe.MaNV = txtMaNV.Text;
                   // listTuyenXe.KhachHang.TenKH = txtHoTen.Text;
                   // listTuyenXe.KhachHang.Sdt = txtSDT.Text;
                   // listTuyenXe.KhachHang.NgaySinh = DateTime.Parse(datetpNgaySinh.Text);
                    listTuyenXe.ThoiGianDat = DateTime.Parse(dateTimePickerNgayDatVe.Text);
                    listTuyenXe.TongTien = int.Parse(txtThanhTien.Text);
                    DBcontext.VeXes.AddOrUpdate(listTuyenXe);
                    DBcontext.SaveChanges();
                    MessageBox.Show($"Sửa thông tin vé {listTuyenXe.MaVe} thành công", "THÔNG BÁO");
                }
              
            }
            btninve.Enabled = true;
        }

        private void tìmVéToolStripMenuItem_Click(object sender, EventArgs e)
        {
            grbTimKiem.Show();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            frmDatVe_Load_1(sender, e);
            ReLoad();
        }

        private void grbChiTietVe_Enter(object sender, EventArgs e)
        {

        }

        private void grpChonGhe_Enter(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSDTSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtSDTSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;           
        }
    }
}

