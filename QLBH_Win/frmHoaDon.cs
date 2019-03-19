using System;
using System.Windows.Forms;
using BUS;

namespace QLBH
{
    public partial class FrmHoaDon : Form
    {
        public FrmHoaDon()
        {
            InitializeComponent();
        }
        public void Loadcthd()
        {
            PhieuHd_BUS.Loadct(dgvCTHD);
        }

        private void btnHuyhd_Click(object sender, EventArgs e)
        {
        }

        private void btnLaphd_Click(object sender, EventArgs e)
        {
            /*int maph = int.Parse(tbxSohd.Text);
            int makh = int.Parse(tbxMakh.Text);
            int manv = int.Parse(tbxManv.Text);
            if(PhieuhdBUS.Instance.Laphd(maph, makh, manv))
            { MessageBox.Show("Lập đơn hàng thành công!"); }
            else { MessageBox.Show("Lỗi!"); }*/
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}