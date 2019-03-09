using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLBH.admin
{
    public partial class SanPhamLoai : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //QLBHDBContext db = new QLBHDBContext();
            //GridView1.DataSource = db.SPLoais.Select(x => new
            //{
            //    MaLoaiSP = x.MaLoaiSP,
            //    MaNhomSP = x.SPNhom.TenNhomSP,
            //    TenLoaiSP = x.TenLoaiSP

            //}).ToList();
            //GridView1.DataBind();
        }

        protected void DetailsView1_ItemInserted(object sender, DetailsViewInsertedEventArgs e)
        {
            GridView1.DataBind();
        }
    }
}