using System;
using System.Windows.Forms;
using BUS;

namespace QLBH
{
    public partial class FrmQuanLySanPham : Form
    {
        public FrmQuanLySanPham()
        {
            InitializeComponent();
            Sp_BUS.Instance.Xem(dgvList);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            /*string text = tbxEdit.Text;
            if(Sp_BUS.Instance.Edit(dgvList))
            {
                MessageBox.Show("ĐÃ SỬA THÀNH CÔNG!");
                Sp_BUS.Instance.Xem(dgvList);
            }
            else
            { MessageBox.Show("SỬA KHÔNG THÀNH CÔNG!"); }*/
        }

        private void tbxEdit_TextChanged(object sender, EventArgs e)
        {
            Text = dgvList.SelectedCells[0].OwningRow.Cells["Mã_Sản_Phẩm"].Value.ToString();
        }
    }
}