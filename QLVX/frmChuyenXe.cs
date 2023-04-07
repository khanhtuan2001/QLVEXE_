using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLVX.Model;

namespace QLVX
{
    public partial class frmChuyenXe : Form
    {
        public frmChuyenXe()
        {
            InitializeComponent();
        }
        VXDbcontext DBcontext = new VXDbcontext();

        private void frmChuyenXe_Load(object sender, EventArgs e)
        {
            List<ChuyenXe> listchuyenxe = DBcontext.ChuyenXes.ToList();
            List<TuyenXe> listtuyenxe = DBcontext.TuyenXes.ToList();
            BindGrid(listchuyenxe);
            List<DiaDiem> listDiaDiem = DBcontext.DiaDiems.ToList();
            List<DiaDiem> listDiaDiemDi = DBcontext.DiaDiems.ToList();
            FillDiaDiemDi(listDiaDiemDi);
            FillDiaDiemDen(listDiaDiem);
            SetGridViewStyle(dtgvChuyenXe);
        }
        private void BindGrid(List<ChuyenXe> listchuyenxe)
        {
            dtgvChuyenXe.Rows.Clear();
            foreach (var item in listchuyenxe)
            {
                int index = dtgvChuyenXe.Rows.Add();
                dtgvChuyenXe.Rows[index].Cells[0].Value = item.MaChuyen;
                dtgvChuyenXe.Rows[index].Cells[1].Value = item.MaTuyen;
                dtgvChuyenXe.Rows[index].Cells[2].Value = item.NgayDi.ToShortDateString().ToString();
                dtgvChuyenXe.Rows[index].Cells[3].Value = item.GioDi.ToString("hh':'mm");
                dtgvChuyenXe.Rows[index].Cells[4].Value = item.GiaVe;
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

        private void cbxDiemDen_SelectionChangeCommitted(object sender, EventArgs e)
        {
         
        }
        private int GetSelectedRow(string machuyen)
        {
            for (int i = 0; i < dtgvChuyenXe.Rows.Count; i++)
            {
                if (dtgvChuyenXe.Rows[i].Cells[0].Value != null)
                {
                    if (dtgvChuyenXe.Rows[i].Cells[0].Value.ToString() == machuyen)
                    {
                        return i;
                    }
                }

            }
            return -1;
        }

        private int ChuyenTrung(string matuyen, string ngaydi, string giodi)
        {
            for (int i = 0; i < dtgvChuyenXe.Rows.Count; i++)
            {
                if (dtgvChuyenXe.Rows[i].Cells[0].Value != null)
                {
                    if (dtgvChuyenXe.Rows[i].Cells[1].Value.ToString() == matuyen
                       && dtgvChuyenXe.Rows[i].Cells[2].Value.ToString() == ngaydi
                       && dtgvChuyenXe.Rows[i].Cells[3].Value.ToString() == giodi)
                    {
                        return i;
                    }
                }

            }
            return -1;
        }
        private void cbxDiemDen_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblMatuyen.Text = "";
            if (cbxDiemDen.Text == cbxDiemDi.Text && cbxDiemDi.Text != "")
            {
                MessageBox.Show("Điểm khởi hành và điểm đến không được trùng nhau! Xin vui lòng chọn lại!", "Thông báo", MessageBoxButtons.OK);
            }
            else
            if (cbxDiemDen.Text != "" && cbxDiemDi.Text != "" && cbxDiemDi.Text != cbxDiemDen.Text)
            {
                string parseok = cbxDiemDi.SelectedValue.ToString();
                string parseok1 = cbxDiemDen.SelectedValue.ToString();

                var matuyen = from st in DBcontext.TuyenXes
                              where st.DiaDiemDi.Equals(parseok) && st.DiaDiemden.Equals(parseok1)
                              select new { st.MaTuyen };
                foreach (var item in matuyen)
                {
                    lblMatuyen.Text = item.MaTuyen.ToString();
                }
                if (lblMatuyen.Text.Trim() == "")
                {
                    List<TuyenXe> listtuyenxxe = DBcontext.TuyenXes.ToList();
                    MessageBox.Show("Hiện tại nhà xe chưa có tuyến xe này! Vui lòng chọn lại!", "Thông báo", MessageBoxButtons.OK);
                }

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtGiave.Text == " " || txtGiave.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin !.", "Thông báo ", MessageBoxButtons.OK);
            }

            else

             if (GetSelectedRow(txtMachuyen.Text) == -1)
            {

                if (ChuyenTrung(lblMatuyen.Text, dateTimeNgayDi.Text, txtGioDi.Text) == -1)
                {
                    int count = 0;
                    count = dtgvChuyenXe.Rows.Count;
                    string chuoi = "";
                    int chuoi2 = 0;
                    chuoi = Convert.ToString(dtgvChuyenXe.Rows[count - 1].Cells[0].Value);
                    chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                    if (chuoi2 + 1 < 10)
                        txtMachuyen.Text = "MC00" + (chuoi2 + 1).ToString();
                    else if (chuoi2 + 1 < 100)
                    {
                        txtMachuyen.Text = "MC0" + (chuoi2 + 1).ToString();
                    }
                    ChuyenXe s = new ChuyenXe()
                    {
                        MaChuyen = txtMachuyen.Text,
                        MaTuyen = lblMatuyen.Text,
                        GioDi = TimeSpan.Parse(txtGioDi.Text),
                        NgayDi = DateTime.Parse(dateTimeNgayDi.Value.ToShortDateString()),
                        GiaVe = int.Parse(txtGiave.Text)
                    };
                    DBcontext.ChuyenXes.Add(s);
                    DBcontext.SaveChanges();
                    MessageBox.Show("Thêm chuyến xe thành công", "Thông báo ", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("Chuyến này đã tồn tại", "Thông báo", MessageBoxButtons.OK);
                }
            }

            BindGrid(DBcontext.ChuyenXes.ToList()); ;
        }
        public void ReLoad()
        {
            txtMachuyen.Clear();
            txtGioDi.Clear();
            txtGiave.Clear();
            dateTimeNgayDi.Value = DateTime.Now;
            lblMatuyen.Text = "";
            cbxDiemDen.Text = "";
            cbxDiemDi.Text = "";
        }
        private void dtgvChuyenXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgvChuyenXe.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dtgvChuyenXe.CurrentRow.Selected = true;
                    txtMachuyen.Text = dtgvChuyenXe.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    lblMatuyen.Text = dtgvChuyenXe.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    dateTimeNgayDi.Value = DateTime.Parse(dtgvChuyenXe.Rows[e.RowIndex].Cells[2].FormattedValue.ToString());
                    txtGioDi.Text = dtgvChuyenXe.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();
                    txtGiave.Text = dtgvChuyenXe.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    ChuyenXe diadiem = DBcontext.ChuyenXes.FirstOrDefault(p => p.MaChuyen == txtMachuyen.Text);
                    cbxDiemDi.Text = diadiem.TuyenXe.DiaDiem1.TenDiaDiem;
                    cbxDiemDen.Text = diadiem.TuyenXe.DiaDiem.TenDiaDiem;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                ChuyenXe dbDelete = DBcontext.ChuyenXes.FirstOrDefault(p => p.MaChuyen == txtMachuyen.Text);
                if (dbDelete != null)
                {
                    DialogResult r = MessageBox.Show("Bạn có muốn xóa ?", "THÔNG BÁO", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {
                        DBcontext.ChuyenXes.Remove(dbDelete);
                        DBcontext.SaveChanges();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                        ReLoad();
                    }
                }
                BindGrid(DBcontext.ChuyenXes.ToList());
            }
            catch
            {
                MessageBox.Show("Chuyến này đang được chạy", "Lỗi", MessageBoxButtons.OK);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                List<ChuyenXe> listXe = DBcontext.ChuyenXes.ToList();
                ChuyenXe find = DBcontext.ChuyenXes.FirstOrDefault(p => p.MaChuyen == txtMachuyen.Text);
                if (find != null)
                {
                    find.MaTuyen = lblMatuyen.Text;
                    find.GioDi = TimeSpan.Parse(txtGioDi.Text);
                    find.GiaVe = int.Parse(txtGiave.Text);
                    find.NgayDi = dateTimeNgayDi.Value;
                    DBcontext.SaveChanges();
                    MessageBox.Show("Sửa thành công!");
                    ReLoad();
                }
                else
                {
                    MessageBox.Show("Mã chuyến không tồn tại");
                }
                BindGrid(DBcontext.ChuyenXes.ToList());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void SetGridViewStyle(DataGridView dgview)
        {
            dgview.BorderStyle = BorderStyle.None;
            dgview.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239,
            249);
            dgview.DefaultCellStyle.SelectionBackColor = Color.Gray;
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

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "")
            {
                BindGrid(DBcontext.ChuyenXes.ToList());
            }
            else
            {
                List<ChuyenXe> list = (from ele in DBcontext.ChuyenXes
                                       where ele.MaChuyen.ToLower().Contains(txtTimKiem.Text.Trim().ToLower())
                                          || ele.MaTuyen.ToLower().Contains(txtTimKiem.Text.Trim().ToLower())
                                          || ele.GiaVe.ToString().Contains(txtTimKiem.Text.Trim().ToLower())
                                          || ele.GioDi.ToString().Contains(txtTimKiem.Text.Trim().ToLower())
                                           || ele.NgayDi.ToString().ToLower().Contains(txtTimKiem.Text.Trim().ToLower())

                                       select ele).ToList();
                BindGrid(list);
                txtTimKiem.Clear();
            }

        }
    }
}




