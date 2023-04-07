using QLVX.Model;
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

namespace QLVX
{
    public partial class frmNhanVien : Form
    {
        VXDbcontext DBcontext = new VXDbcontext();
        public frmNhanVien()
        {
            InitializeComponent();
        }
        


        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            

               
                List<NhanVien> listNV = DBcontext.NhanViens.ToList();
                fillDGV(listNV);
                SetGridViewStyle(dgvDSNV);



        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (txtTimKiem.Text.Trim() == "")
            {
                fillDGV(DBcontext.NhanViens.ToList());
            }
            else
            {
                List<NhanVien> list = (from ele in DBcontext.NhanViens
                                       where ele.TenNV.ToLower().Contains(txtTimKiem.Text.Trim().ToLower())
                                          || ele.MaNV.ToLower().Contains(txtTimKiem.Text.Trim().ToLower())
                                          || ele.Sdt.ToString().Contains(txtTimKiem.Text.Trim().ToLower())
                                          || ele.NgaySinh.ToString().Contains(txtTimKiem.Text.Trim().ToLower())

                                       select ele).ToList();
                fillDGV(list);
                txtTimKiem.Clear();
            }

        }

        private void fillDGV(List<NhanVien> list)
        {
            dgvDSNV.Rows.Clear();
            foreach (var item in list)
            {
                int newRow = dgvDSNV.Rows.Add();
                dgvDSNV.Rows[newRow].Cells[0].Value = item.MaNV;
                dgvDSNV.Rows[newRow].Cells[1].Value = item.TenNV;
                dgvDSNV.Rows[newRow].Cells[2].Value = item.Sdt;
                dgvDSNV.Rows[newRow].Cells[3].Value = item.NgaySinh.ToShortDateString();
                dgvDSNV.Rows[newRow].Cells[4].Value = item.PhanQuyen;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            if (  txtTenNV.Text == " " || txtSĐT.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin !.", "Thông báo", MessageBoxButtons.OK);
            }
            if (txtSĐT.Text.Length > 10 || txtSĐT.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 ", "Thông báo", MessageBoxButtons.OK);
            }
            else
            if (checkIdNV(txtMaNV.Text) == -1)
            {
                int count = 0;
                count = dgvDSNV.Rows.Count;
                string chuoi = "";
                int chuoi2 = 0;
                chuoi = Convert.ToString(dgvDSNV.Rows[count - 1].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                if (chuoi2 + 1 < 10)
                    txtMaNV.Text = "NV" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtMaNV.Text = "NV" + (chuoi2 + 1).ToString();

                NhanVien s = new NhanVien()
                {
                    MaNV = txtMaNV.Text,
                    TenNV = txtTenNV.Text,
                    Sdt = txtSĐT.Text,
                    NgaySinh = DateTime.Parse(dtpNgaySinh.Text),
                    PhanQuyen = txtPhanQuyen.Text
                   
                };
                DBcontext.NhanViens.Add(s);
                DBcontext.SaveChanges();
                loadDGV();
                loadForm();
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
            }
        }

        private int checkIdNV(string text)
        {

            for (int i = 0; i < dgvDSNV.Rows.Count; i++)
            {
                if (dgvDSNV.Rows[i].Cells[0].Value != null)
                {
                    if (dgvDSNV.Rows[i].Cells[0].Value.ToString() == text)
                    {
                        return 1;
                    }
                }
            }
            return -1;
        }

        private void loadForm()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();

            txtSĐT.Clear();
        }

        private void loadDGV()
        {
            List<NhanVien> newlistNV = DBcontext.NhanViens.ToList();
            fillDGV(newlistNV);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkOutput() == true)
            {

                NhanVien SuaNhanVien = DBcontext.NhanViens.FirstOrDefault(p => p.MaNV == txtMaNV.Text);
                if (SuaNhanVien != null)
                {
                    SuaNhanVien.TenNV = txtTenNV.Text;
                    SuaNhanVien.NgaySinh = DateTime.Parse (dtpNgaySinh.Text);
                    SuaNhanVien.Sdt = txtSĐT.Text;


                    DBcontext.NhanViens.AddOrUpdate(SuaNhanVien);
                    DBcontext.SaveChanges();

                    loadDGV();
                    loadForm();

                    MessageBox.Show($"Sửa thông tin nhân viên {SuaNhanVien.TenNV} thành công", "THÔNG BÁO");
                }
            }
        }

        private bool checkOutput()
        {

            if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtSĐT.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (txtSĐT.Text.Length > 10 || txtSĐT.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 ", "Thông báo", MessageBoxButtons.OK);
            }

            return true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                NhanVien SuaNV = DBcontext.NhanViens.FirstOrDefault(p => p.MaNV == txtMaNV.Text);
                if (SuaNV != null)
                {
                    DialogResult temp = MessageBox.Show($"Bạn có đồng ý xóa thông tin nhân viên {SuaNV.TenNV}", "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (temp == DialogResult.OK)
                    {

                        DBcontext.NhanViens.Remove(SuaNV);
                        DBcontext.SaveChanges();

                        loadDGV();
                        loadForm();
                        MessageBox.Show($"Xóa thông tin nhân viên {SuaNV.TenNV} thành công", "THÔNG BÁO");

                    }

                    loadDGV();
                    loadForm();
                }
                else
                {
                    MessageBox.Show($"Không có thông tin nhân viên  mã số {txtMaNV.Text}", "THÔNG BÁO");
                }
            }
            catch
            {
                MessageBox.Show("Nhân viên này đã bán vé", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvDSNV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDSNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvDSNV.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvDSNV.CurrentRow.Selected = true;
                    txtMaNV.Text = dgvDSNV.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtTenNV.Text = dgvDSNV.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtSĐT.Text = dgvDSNV.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    txtPhanQuyen.Text = dgvDSNV.Rows[e.RowIndex].Cells[4].FormattedValue.ToString();
                    dtpNgaySinh.Text = dgvDSNV.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            dgview.BackgroundColor = Color.LightPink;
            dgview.EnableHeadersVisualStyles = false;
            dgview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgview.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dgview.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgview.AllowUserToDeleteRows = false;
            dgview.AllowUserToAddRows = false;
            dgview.AllowUserToOrderColumns = true;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtSĐT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
