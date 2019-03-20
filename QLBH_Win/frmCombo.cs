using System;
using System.Windows.Forms;
using BUS;

namespace QLBH
{
    public partial class FrmCombo : Form
    {
        public FrmCombo()
        {
            InitializeComponent();
            Sp_BUS.Instance.Xem(dgvSanpham);
            PhieuHd_BUS.Instance.Laphd();
        }

        private int n=0;
        private void BtnChon_Click(object sender, EventArgs e)
        {
            var num = Convert.ToInt32(tbxSluong.Text);
            var id = Convert.ToInt32(dgvSanpham.SelectedCells[0].OwningRow.Cells["MaSp"].Value.ToString());
            var name = dgvSanpham.SelectedCells[0].OwningRow.Cells["TenSp"].Value.ToString();
            var cost = Convert.ToInt32(dgvSanpham.SelectedCells[0].OwningRow.Cells["Dongia"].Value.ToString());
            var numold = Convert.ToInt32(dgvSanpham.SelectedCells[0].OwningRow.Cells["SoLuong"].Value.ToString());
            if (numold > num)
            {
                dgvChon.Rows.Add(id, name, cost, num);
                PhieuHd_BUS.Instance.Laphdct(id, num, cost);
                tbxSluong.Clear();
                n++;
            }
            else
            {
                MessageBox.Show("Sản phẩm không đủ số lượng!");
                tbxSluong.Clear();
            }
        }

        private void BtnDhang_Click(object sender, EventArgs e)
        {
            var fmhd = new FrmHoaDon();
            fmhd.Loadcthd();
            fmhd.ShowDialog();
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnTim_Click(object sender, EventArgs e)
        {
            var name = tbxTim.Text;
            Sp_BUS.Instance.Tim(dgvSanpham, name);
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            dgvChon.Rows.RemoveAt(dgvChon.SelectedCells[0].OwningRow.Cells["MaSp"].RowIndex);
        }

        private void BtnXoahet_Click(object sender, EventArgs e)
        {
            dgvChon.Rows.Clear();
        }

        private void DgvSanpham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void FmCombo_Load(object sender, EventArgs e)
        {
        }

        private void tbxLoc_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tbxTim_TextChanged(object sender, EventArgs e)
        {
        }
    }
}