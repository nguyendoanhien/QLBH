using System;
using System.Windows.Forms;
using BUS;

namespace QLBH
{
    public partial class FrmSanPham : Form
    {
        private bool ok;

        public FrmSanPham()
        {
            InitializeComponent();
            dtgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var masp = int.Parse(txt_masp.Text);
            var tensp = txt_tensp.Text;
            var loaisp = int.Parse(txt_loaisp.Text);
            var ncc = int.Parse(txt_mancc.Text);
            var dongia = int.Parse(txt_gia.Text);

            Sp_BUS.Instance.Sua(dtgv, masp, tensp, loaisp, ncc, dongia);

            Sp_BUS.Instance.Xem_Hang(dtgv);
            Clear();
            //ok = false;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var tensp = txt_tensp.Text;
            var loaisp = int.Parse(txt_loaisp.Text);
            var ncc = int.Parse(txt_mancc.Text);
            var dongia = int.Parse(txt_gia.Text);

            Sp_BUS.Instance.Them(dtgv, tensp, loaisp, ncc, dongia);
            Sp_BUS.Instance.Xem_Hang(dtgv);
            Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var sp = int.Parse(dtgv.SelectedCells[0].OwningRow.Cells["Mã_Sản_Phẩm"].Value.ToString());
            Sp_BUS.Instance.Xoa(dtgv, sp);
            if (Sp_BUS.Instance.Xoa(dtgv, sp))
                MessageBox.Show("Xóa Thành công");
            else
                MessageBox.Show("Không thể xóa!!!");
            Sp_BUS.Instance.Xem_Hang(dtgv);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Sp_BUS.Instance.Timkiem(dtgv, txt_tk.Text);
        }

        private void Clear()
        {
            Action<Control.ControlCollection> function = null;
            function = controls =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        function(control.Controls);
            };
            function(Controls);
        }

        private void dtgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // if (dtgv.Rows[0].Cells[e.ColumnIndex].Value != null)
            //{
            dtgv.CurrentRow.Selected = true;
            txt_masp.Text = dtgv.Rows[e.RowIndex].Cells["Mã_Sản_Phẩm"].FormattedValue.ToString();
            txt_tensp.Text = dtgv.Rows[e.RowIndex].Cells["Tên_Sản_Phẩm"].FormattedValue.ToString();
            txt_loaisp.Text = dtgv.Rows[e.RowIndex].Cells["Mã_Loại_Sản_Phẩm"].FormattedValue.ToString();
            txt_mancc.Text = dtgv.Rows[e.RowIndex].Cells["Mã_NhaCC"].FormattedValue.ToString();
            txt_gia.Text = dtgv.Rows[e.RowIndex].Cells["Đơn_Giá"].FormattedValue.ToString();
            //}
        }


        private void dtgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void SANPHAM_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLBH_WinDataSet.Sp' table. You can move, or remove it, as needed.


            Sp_BUS.Instance.Xem_Hang(dtgv);
        }

        private void txt_mancc_TextChanged(object sender, EventArgs e)
        {
        }
    }
}