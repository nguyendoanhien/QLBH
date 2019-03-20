using System;
using System.Linq;
using System.Windows.Forms;
using BUS;
using DTO;

namespace QLBH
{
    public partial class FrmHoaDon : Form
    {
        public FrmHoaDon()
        {
            InitializeComponent();
            tbxSohd.Text = idhd().ToString();
            //tbxThanhtien.Text = total().ToString();
        }
        public void Loadcthd()
        {
            PhieuHd_BUS.Loadct(dgvCTHD);
        }

        private void btnHuyhd_Click(object sender, EventArgs e)
        {
            int maHoaDon = Convert.ToInt32(tbxSohd.Text);
            PhieuHd del = PhieuHd_BUS.GetAll().Where(m => m.MaPhieuHd == maHoaDon).FirstOrDefault();
            PhieuHd_BUS.Delete(del);
            Close();
        }

        private void btnLaphd_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(tbxSohd.Text);
            int ck;
            if (tbxCK.Text == "") ck = 0;
            else
            {
                ck = Convert.ToInt32(tbxCK.Text);
            }
            int makh = Convert.ToInt32(tbxMakh.Text);
            int manv = Convert.ToInt32(tbxManv.Text);
            string tt = (tbxThanhtien.Text);
            if (PhieuHd_BUS.Instance.sua(id, makh, manv, ck, tt))
            {
                MessageBox.Show("Thành công!");
            }
            else
            {
                MessageBox.Show("Thất bại!");
            }

            Close();
        }

        public int idhd()
        {
            int maPhieuHd = PhieuHd_BUS.GetAll().ToList().Last().MaPhieuHd;
            return maPhieuHd;
        }

        public int total()
        {
            int maPhieuHd = PhieuHd_BUS.GetAll().ToList().Last().MaPhieuHd;
            int ck;
            if (tbxCK.Text == "") ck = 0;
            else
            {
                ck = Convert.ToInt32(tbxCK.Text);
            }
            int m = PhieuHdChiTiet_BUS.GetAll().ToList().Where(p=>p.MaPhieuHd==maPhieuHd).Sum(p => Convert.ToInt32(p.ThanhTien)) * (100 - ck)/100;
            return m;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvCTHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            tbxThanhtien.Text = total().ToString();
        }

        public void delete()
        {

        }
    }
}