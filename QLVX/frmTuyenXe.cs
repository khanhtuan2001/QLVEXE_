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
    public partial class frmTuyenXe : Form
    {
        public frmTuyenXe()
        {
            InitializeComponent();
        }

        VXDbcontext DBcontext = new VXDbcontext();

        private void frmTuyenXe_Load(object sender, EventArgs e)
        {
            List<TuyenXe> listtuyen = DBcontext.TuyenXes.ToList();
            BindGrid(listtuyen);
            List<DiaDiem> listDiaDiem = DBcontext.DiaDiems.ToList();
            List<DiaDiem> listDiaDiemDi = DBcontext.DiaDiems.ToList();
            FillDiaDiemDi(listDiaDiemDi);
            FillDiaDiemDen(listDiaDiem);
            SetGridViewStyle(dtgvTuyenXe);

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
        private void BindGrid(List<TuyenXe> listtuyen)
        {
            List<DiaDiem> listDiaDiem = DBcontext.DiaDiems.ToList();
            dtgvTuyenXe.Rows.Clear();
            foreach (var item in listtuyen)
            {
                int index = dtgvTuyenXe.Rows.Add();
                dtgvTuyenXe.Rows[index].Cells[0].Value = item.MaTuyen;
                dtgvTuyenXe.Rows[index].Cells[1].Value = item.DiaDiem1.TenDiaDiem;
                dtgvTuyenXe.Rows[index].Cells[2].Value = item.DiaDiem.TenDiaDiem;
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


        private void dtgvTuyenXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgvTuyenXe.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    dtgvTuyenXe.CurrentRow.Selected = true;
                    txtMaTuyen.Text = dtgvTuyenXe.Rows[e.RowIndex].Cells[0].FormattedValue.ToString();
                    cbxDiemDi.Text = dtgvTuyenXe.Rows[e.RowIndex].Cells[1].FormattedValue.ToString();
                    cbxDiemDen.Text = dtgvTuyenXe.Rows[e.RowIndex].Cells[2].FormattedValue.ToString();    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int GetSelectedRow(string matuyen)
        {
            for (int i = 0; i < dtgvTuyenXe.Rows.Count; i++)
            {
                if (dtgvTuyenXe.Rows[i].Cells[0].Value != null)
                {
                    if (dtgvTuyenXe.Rows[i].Cells[0].Value.ToString() == matuyen)
                    {
                        return i;
                    }
                }

            }
            return -1;
        }
       
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (cbxDiemDen.Text == "" || cbxDiemDi.Text == "")
            {
                MessageBox.Show("Phải chọn địa điểm !.", "Thông báo ", MessageBoxButtons.OK);
            }
            if(cbxDiemDen.Text == cbxDiemDi.Text)
            {
                MessageBox.Show("Địa điểm đến và địa điểm đi không được trùng !.", "Thông báo ", MessageBoxButtons.OK);
            }    

            else

          if (GetSelectedRow(txtMaTuyen.Text) == -1)
            {
                int count = 0;
                count = dtgvTuyenXe.Rows.Count;
                string chuoi = "";
                int chuoi2 = 0;
                chuoi = Convert.ToString(dtgvTuyenXe.Rows[count-1].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 2)));
                if (chuoi2 + 1 < 10)
                {
                    txtMaTuyen.Text = "MT00" + (chuoi2 + 1).ToString();
                }   
                else if (chuoi2 + 1 < 100)
                {
                    txtMaTuyen.Text = "MT0" + (chuoi2 + 1).ToString();
                }
                else if (chuoi2 + 1 < 1000)
                {
                    txtMaTuyen.Text = "MT" + (chuoi2 + 1).ToString();
                }

                TuyenXe listTuyen = DBcontext.TuyenXes.FirstOrDefault(p => p.DiaDiem.TenDiaDiem == cbxDiemDi.Text && p.DiaDiem1.TenDiaDiem == cbxDiemDen.Text);
                if (listTuyen == null)
                {
                    TuyenXe s = new TuyenXe()
                    {
                        MaTuyen = txtMaTuyen.Text,
                        DiaDiemDi = cbxDiemDi.SelectedValue.ToString(),
                        DiaDiemden = cbxDiemDen.SelectedValue.ToString()
                    };
                    DBcontext.TuyenXes.Add(s);
                    DBcontext.SaveChanges();
                    reload();
                    refresh();
                    MessageBox.Show("Thêm dữ liệu thành công", "Thông báo ", MessageBoxButtons.OK);
                    BindGrid(DBcontext.TuyenXes.ToList());
                    txtMaTuyen.Clear();
                }
                else
                {
                    MessageBox.Show("Tuyến này đã tôn tại!.", "Thông báo ", MessageBoxButtons.OK);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (cbxDiemDen.Text == cbxDiemDi.Text)
            {
                MessageBox.Show("Địa điểm đến và địa điểm đi không được trùng !.", "Thông báo ", MessageBoxButtons.OK);
            }

            else
            {
                TuyenXe listTuyenXe = DBcontext.TuyenXes.FirstOrDefault(p => p.MaTuyen == txtMaTuyen.Text);
                if (listTuyenXe != null)
                {
                    listTuyenXe.MaTuyen = txtMaTuyen.Text;
                    listTuyenXe.DiaDiemDi = cbxDiemDi.SelectedValue.ToString();
                    listTuyenXe.DiaDiemden = cbxDiemDen.SelectedValue.ToString();

                    DBcontext.TuyenXes.AddOrUpdate(listTuyenXe);
                    DBcontext.SaveChanges();

                    BindGrid(DBcontext.TuyenXes.ToList());
                    txtMaTuyen.Clear();
                    //loadForm();

                    MessageBox.Show($"Sửa thông tin tuyến {listTuyenXe.MaTuyen} thành công", "THÔNG BÁO");
                }
            }
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            if (txttimkiem.Text.Trim() == "")
            {
                BindGrid(DBcontext.TuyenXes.ToList());
            }
            else
            {
                List<TuyenXe> list = (from ele in DBcontext.TuyenXes
                                      where ele.MaTuyen.ToLower().Contains(txttimkiem.Text.Trim().ToLower())
                         || ele.DiaDiem.TenDiaDiem.ToLower().Contains(txttimkiem.Text.Trim().ToLower())
                         || ele.DiaDiem1.TenDiaDiem.ToLower().Contains(txttimkiem.Text.Trim().ToLower())

                                      select ele).ToList();
                BindGrid(list);
                txttimkiem.Clear();
            }
        }
        private void refresh()
        {
            txtMaTuyen.Text = "";

            cbxDiemDi.Text = "";
            cbxDiemDen.Text = "";

        }
        private void reload()
        {
            List<TuyenXe> listtuyen = DBcontext.TuyenXes.ToList();
            BindGrid(listtuyen);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                TuyenXe dbDelete = DBcontext.TuyenXes.FirstOrDefault(p => p.MaTuyen == txtMaTuyen.Text);
                if (dbDelete != null)
                {
                    DialogResult r = MessageBox.Show("Bạn có muốn xóa ?", "THÔNG BÁO", MessageBoxButtons.YesNo);
                    if (r == DialogResult.Yes)
                    {
                        DBcontext.TuyenXes.Remove(dbDelete);
                        DBcontext.SaveChanges();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
                    }
                }
                BindGrid(DBcontext.TuyenXes.ToList());
                refresh();
            }
            catch
            {
                MessageBox.Show("Tuyến này đang được sử dụng", "Lỗi", MessageBoxButtons.OK);
            }
        }
    }
 }

