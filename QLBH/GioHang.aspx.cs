using System;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using BUS;
using MyUltilities;
using QLBH.HelpfulClasses;

namespace QLBH
{
    public partial class GioHang : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var form = (HtmlForm) Master.FindControl("form1");
                if (Session["uid"] != null)
                    form.Action = "https://www.sandbox.paypal.com/cgi-bin/webscr";
                else form.Action = "/DangNhap";
                form.Method = "POST";
            }
        }

        [WebMethod]
        public static string RemoveItemFromCart(FilterClass fc)
        {
            DTO.GioHang gh;
            if (HttpContext.Current.Session["uid"] != null)
            {
                gh = GioHangBus.GetAll().FirstOrDefault(m =>
                    m.MaSp == fc.RemoveId && m.MaKh == int.Parse(HttpContext.Current.Session["uid"].ToString()));
                GioHangBus.Delete(gh);
            }
            else
            {
                gh = GioHangBus.GetAll().FirstOrDefault(m =>
                    m.MaSp == fc.RemoveId && m.DiaChiIp == Cart.IpAddress);
                GioHangBus.Delete(gh);
            }

            return @"<div class='alert alert-danger'>
                   <a href = '#' class='close' data-dismiss='alert' aria-label='close'>&times;</a>
                <b>Sản phẩm đã được xóa</b>
                </div>";
        }

        [WebMethod]
        public static string UpdateItemFromCart(FilterClass fc)
        {
            DTO.GioHang gh;
            gh = HttpContext.Current.Session["uid"] != null
                ? GioHangBus.GetAll().FirstOrDefault(m =>
                    m.MaSp == fc.UpdateId && m.MaKh == int.Parse(HttpContext.Current.Session["uid"].ToString()))
                : GioHangBus.GetAll().FirstOrDefault(m =>
                    m.MaSp == fc.UpdateId && m.DiaChiIp == Cart.IpAddress);

            if (gh != null)
            {
                gh.SoLuong = fc.Quantity;
                GioHangBus.Update(gh);
            }

            return @"<div class='alert alert-danger'>
                   <a href = '#' class='close' data-dismiss='alert' aria-label='close'>&times;</a>
                <b>Sản phẩm đã được sửa</b>
                </div>";
        }
    }
}