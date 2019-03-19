#region

using System;
using System.Windows.Forms;
using BUS;
using DTO;
using ExtensionMethods;
using QLBH.Properties;

#endregion

namespace QLBH
{
    public partial class FrmDangNhap : Form
    {
        private readonly Nv _nv;

        public FrmDangNhap()
        {
            _nv = new Nv();
            InitializeComponent();
            CenterInForm();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            _nv.MaNv = txtTenDangNhap.Text.ToInt32();
            _nv.Mk = txtMatKhau.Text;


            if (NvBus.NhanVien_KiemTraDangNhap(_nv))
            {
                LuuSessionDangNhap();
                XuLyNhoTaiKhoan();
                MessageBox.Show("Đăng nhập thành công");

                var frm = new FrmChinh();
                if (frm.ShowDialog() == DialogResult.OK)
                {
                }

                Close();
            }
            else
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CenterInForm()
        {
            //tableDangNhap.Location = new Point(
            //    this.ClientSize.Width / 2 - tableDangNhap.Size.Width / 2,
            //    this.ClientSize.Height / 2 - tableDangNhap.Size.Height / 2);
            //tableDangNhap.Anchor = AnchorStyles.None;
        }

        private void frmDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode == Keys.F4)
                Close();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtTenDangNhap.Text = Settings.Default.user;
            txtMatKhau.Text = Settings.Default.pass;
        }

        private void LuuSessionDangNhap()
        {
            MySessions.Sessions.Add("user", _nv);
        }

        private void tableDangNhap_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
        }

        private void XuLyNhoTaiKhoan()
        {
            if (chkRemember.Checked)
            {
                Settings.Default.user = txtTenDangNhap.Text;
                Settings.Default.pass = txtMatKhau.Text;
            }
            else
            {
                Settings.Default.user = "";
                Settings.Default.pass = "";
            }

            Settings.Default.Save();
        }
    }
}