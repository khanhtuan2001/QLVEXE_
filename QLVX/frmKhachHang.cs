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
    public partial class frmKhachHang : Form
    {
        VXDbcontext DBcontext = new VXDbcontext();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            List<KhachHang> listKH = DBcontext.KhachHangs.ToList();
            fillDGV(listKH);
            SetGridViewStyle(dgvKH);

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

        private void fillDGV(List<KhachHang> listKH)
        {
            dgvKH.Rows.Clear();
            foreach (var item in listKH)
            {
                int newRow = dgvKH.Rows.Add();
                dgvKH.Rows[newRow].Cells[0].Value = item.MaKH;
                dgvKH.Rows[newRow].Cells[1].Value = item.TenKH;
                dgvKH.Rows[newRow].Cells[2].Value = item.Sdt;
                dgvKH.Rows[newRow].Cells[3].Value = item.NgaySinh.ToShortDateString();
               
            }
        }

        private void dgvKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgvKH.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dgvKH.CurrentRow.Selected = true;
                    txtMaKH.Text = dgvKH.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    txtTenKH.Text = dgvKH.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    txtSdt.Text = dgvKH.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();
                    dtpNgaySinhKH.Text = dgvKH.Rows[e.RowIndex].Cells[3].FormattedValue.ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenKH.Text == " " || txtSdt.Text == "")
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin !.", "Thông báo ", MessageBoxButtons.OK);
            }
            if (txtSdt.Text.Length > 10 || txtSdt.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 ", "Thông báo", MessageBoxButtons.OK);
            }
            else
            if (checkIdNV(txtMaKH.Text) == -1)
            {
                int count = 0;
                count = dgvKH.Rows.Count;
                string chuoi = "";
                int chuoi2 = 0;
                chuoi = Convert.ToString(dgvKH.Rows[count - 1].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                if (chuoi2 + 1 < 10)
                    txtMaKH.Text = "KH00" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtMaKH.Text = "KH00" + (chuoi2 + 1).ToString();

                KhachHang s = new KhachHang()
                {
                    MaKH = txtMaKH.Text,
                    TenKH = txtTenKH.Text,
                    Sdt= txtSdt.Text,
                    NgaySinh = DateTime.Parse(dtpNgaySinhKH.Text),
                    

                };
                DBcontext.KhachHangs.Add(s);
                DBcontext.SaveChanges();
                loadDGV();
                loadForm();
                MessageBox.Show("Thêm thành công", "Thông báo ", MessageBoxButtons.OK);
            }
        }

        private void loadForm()
        {
            txtMaKH.Clear();
            txtTenKH.Clear();
            txtSdt.Clear();
        }

        private void loadDGV()
        {
            List<KhachHang> nlistKH = DBcontext.KhachHangs.ToList();
            fillDGV(nlistKH);
        }

        private int checkIdNV(string text)
        {

            for (int i = 0; i < dgvKH.Rows.Count; i++)
            {
                if (dgvKH.Rows[i].Cells[0].Value != null)
                {
                    if (dgvKH.Rows[i].Cells[0].Value.ToString() == text)
                    {
                        return 1;
                    }
                }
            }
            return -1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHang SuaKH = DBcontext.KhachHangs.FirstOrDefault(p => p.MaKH == txtMaKH.Text);
                if (SuaKH != null)
                {
                    DialogResult temp = MessageBox.Show($"Bạn có đồng ý xóa thông tin khách hàng {SuaKH.TenKH}",
                   "THÔNG BÁO", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (temp == DialogResult.OK)
                    {

                        DBcontext.KhachHangs.Remove(SuaKH);
                        DBcontext.SaveChanges();

                        loadDGV();
                        loadForm();
                        MessageBox.Show($"Xóa thông tin Khách hàng {SuaKH.TenKH} thành công", "THÔNG BÁO");

                    }

                    loadDGV();
                    loadForm();
                }
                else
                {
                    MessageBox.Show($"Không có thông tin Khách hàng  mã số {txtMaKH.Text}", "THÔNG BÁO");
                }
            }
            catch
            {
                MessageBox.Show("Khách hàng này đã mua vé", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkOutput() == true)
            {

                KhachHang SuaKH = DBcontext.KhachHangs.FirstOrDefault(p => p.MaKH == txtMaKH.Text);
                if (SuaKH != null)
                {
                    SuaKH.TenKH = txtTenKH.Text;
                    SuaKH.NgaySinh = DateTime.Parse(dtpNgaySinhKH.Text);
                    SuaKH.Sdt = txtSdt.Text;


                    DBcontext.KhachHangs.AddOrUpdate(SuaKH);
                    DBcontext.SaveChanges();

                    loadDGV();
                    loadForm();

                    MessageBox.Show($"Sửa thông tin Khách hàng {SuaKH.MaKH} thành công", "THÔNG BÁO");
                }
            }
        }

        private bool checkOutput()
        {
            if (txtMaKH.Text == "" || txtTenKH.Text == "" || txtSdt.Text == "" )
            {
                MessageBox.Show("Bạn chưa điền đầy đủ thông tin!", "THÔNG BÁO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            if (txtSdt.Text.Length > 10 || txtSdt.Text.Length < 10)
            {
                MessageBox.Show("Số điện thoại phải đủ 10 ", "Thông báo", MessageBoxButtons.OK);
            }

            return true;
        }

        private void btTimKiem_Click(object sender, EventArgs e)
        {

            if (txtTimKiem.Text.Trim() == "")
            {
                fillDGV(DBcontext.KhachHangs.ToList());
            }
            else
            {
                List<KhachHang> list = (from ele in DBcontext.KhachHangs
                                       where ele.TenKH.ToLower().Contains(txtTimKiem.Text.Trim().ToLower())
                                          || ele.MaKH.ToLower().Contains(txtTimKiem.Text.Trim().ToLower())
                                          || ele.Sdt.ToString().Contains(txtTimKiem.Text.Trim().ToLower())
                                          || ele.NgaySinh.ToString().Contains(txtTimKiem.Text.Trim().ToLower())

                                       select ele).ToList();
                fillDGV(list);
                txtTimKiem.Clear();

            }
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
