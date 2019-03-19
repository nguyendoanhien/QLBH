#region

using System;
using System.Windows.Forms;

#endregion

namespace QLBH
{
    public partial class FrmChinh : Form
    {
        public FrmChinh()
        {
            InitializeComponent();
            sttTime.Text = Get_Day();
        }

        private void btnOpenForm_Combo_Click(object sender, EventArgs e)
        {
            var frmCombo = new FrmCombo();
            frmCombo.Show();
        }

        private void btnOpenForm_HoaDon_Click(object sender, EventArgs e)
        {
            var frmHoaDon = new FrmHoaDon();
            frmHoaDon.Show();
        }

        private void btnOpenForm_Ncc_Click(object sender, EventArgs e)
        {
            var frmNcc = new FrmNcc();
            frmNcc.Show();
        }

        private void btnOpenForm_QLSP_Click(object sender, EventArgs e)
        {
            var frmQuanLySanPham = new FrmQuanLySanPham();
            frmQuanLySanPham.Show();
        }

        private void btnOpenForm_SanPham_Click(object sender, EventArgs e)
        {
            var frmSanPham = new FrmSanPham();
            frmSanPham.Show();
        }


        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ret = MessageBox.Show("Hỏi thoát", "Bạn có muốn thoát?", MessageBoxButtons.OKCancel,
                MessageBoxIcon.Warning);
            if (ret == DialogResult.OK) Close();
        }


        public string Get_Day()
        {
            var ngay = DateTime.Now.Day.ToString();
            var thang = DateTime.Now.Month.ToString();
            var nam = DateTime.Now.Year.ToString();
            var gio = DateTime.Now.Hour.ToString();
            var phut = DateTime.Now.Minute.ToString();
            var giay = DateTime.Now.Second.ToString();
            return ngay + "/" + thang + "/" + nam + " " + gio + ":" + phut + ":" + giay;
        }
    }
}