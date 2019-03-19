using System;
using System.Windows.Forms;
using BUS;

namespace QLBH
{
    public partial class FrmNcc : Form
    {
        public FrmNcc()
        {
            InitializeComponent();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var NCC = int.Parse(txt_mancc.Text);
            var TEN = txt_tenncc.Text;

            Ncc_BUS.Instance.Edit(dtgv_NCC, NCC, TEN);

            Ncc_BUS.Instance.Xem_Hang(dtgv_NCC);

            Clear();
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            var tenncc = txt_tenncc.Text;
            Ncc_BUS.Instance.Them(dtgv_NCC, tenncc);
            Ncc_BUS.Instance.Xem_Hang(dtgv_NCC);
            Clear();
        }

        private void btn_thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var mancc = int.Parse(dtgv_NCC.SelectedCells[0].OwningRow.Cells["Mã_Nhà_Cung_Cấp"].Value.ToString());
            Ncc_BUS.Instance.Xoa(dtgv_NCC, mancc);
            if (Ncc_BUS.Instance.Xoa(dtgv_NCC, mancc))
                MessageBox.Show("Xóa Thành công");
            else
                MessageBox.Show("Không thể xóa!!!");


            Ncc_BUS.Instance.Xem_Hang(dtgv_NCC);
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

        private void dtgv_NCC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dtgv_NCC.CurrentRow.Selected = true;
            txt_mancc.Text = dtgv_NCC.Rows[e.RowIndex].Cells["Mã_Nhà_Cung_Cấp"].FormattedValue.ToString();
            txt_tenncc.Text = dtgv_NCC.Rows[e.RowIndex].Cells["Tên_Nhà_Cung_Cấp"].FormattedValue.ToString();
        }

        private void NHACC_Load(object sender, EventArgs e)
        {
            Ncc_BUS.Instance.Xem_Hang(dtgv_NCC);
        }
    }
}