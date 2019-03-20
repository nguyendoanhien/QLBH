using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using DTO;

namespace QLBH.admin
{
    public partial class HoaDon : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                this.BindGrid();
            }
        }

        [WebMethod]
        public static string LapHoaDon(string data, int phanTram, string tienGiam)
        {
            JavaScriptSerializer json = new JavaScriptSerializer();
            List<string[]> mystring = json.Deserialize<List<string[]>>(data);

            PhieuHd phd = new PhieuHd()
            {
                NgayLap = DateTime.Now,
                PhanTramGiam = phanTram,
                TienGiam = tienGiam
            };
            PhieuHd_BUS.Insert(phd);
            int maPhieuHd = PhieuHd_BUS.GetAll().ToList().Last().MaPhieuHd;
            for (int i = 0; i < mystring.Count; i++)
            {
                int maSp = int.Parse(mystring[i][0]);
                int sL = int.Parse(mystring[i][1]);
                PhieuHdChiTiet phd_ct = new PhieuHdChiTiet();
                phd_ct.MaPhieuHd = maPhieuHd;
                phd_ct.MaSp = maSp;
                phd_ct.SoLuong = sL;
                phd_ct.ThanhTien = maSp * sL;
                Sp sp = Sp_BUS.GetById(maSp);
                sp.SoLuongTonKho -= sL;
                if (sp.SoLuongTonKho < 0) sp.SoLuongTonKho = 0;
                Sp_BUS.Update(sp);
                PhieuHdChiTiet_BUS.Insert(phd_ct);
            }

            return "";
        }

        protected void GridView1_RowDeleting(object sender, System.Web.UI.WebControls.GridViewDeleteEventArgs e)
        {
            GridViewRow row = (GridViewRow)GridView1.Rows[e.RowIndex];
            int maHoaDon = int.Parse(((Label)row.FindControl("maHoaDon")).Text);
            PhieuHd del = PhieuHd_BUS.GetAll().Where(m => m.MaPhieuHd == maHoaDon).FirstOrDefault();
            PhieuHd_BUS.Delete(del);
            this.BindGrid();
        }
        private void BindGrid()
        {
            GridView1.DataSource = PhieuHd_BUS.GetAll();
            GridView1.DataBind();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow row = GridView1.SelectedRow;
            int maHoaDon = int.Parse(((Label)row.FindControl("maHoaDon")).Text);
            List<PhieuHdChiTiet> list = PhieuHdChiTiet_BUS.GetAll().Where(m => m.MaPhieuHd == maHoaDon).ToList();
            GridView2.DataSource = list;
            GridView2.DataBind();
        }
    }
}