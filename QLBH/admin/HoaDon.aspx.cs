using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Script.Serialization;
using System.Web.Services;
using System.Web.UI;
using BUS;
using DTO;

namespace QLBH.admin
{
    public partial class HoaDon : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        [WebMethod]
        public static string LapHoaDon(string data)
        {
            JavaScriptSerializer json = new JavaScriptSerializer();
            List<string[]> mystring = json.Deserialize<List<string[]>>(data);

            PhieuHd phd = new PhieuHd()
            {
                NgayTaoHd = DateTime.Now
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
                PhieuHdChiTiet_BUS.Insert(phd_ct);
            }

            return "";
        }
    }
}