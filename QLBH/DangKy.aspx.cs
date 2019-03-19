using System;
using System.Security.Cryptography;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using BUS;
using DTO;
using QLBH.HelpfulClasses;

namespace QLBH
{
    public partial class DangKy : Page
    {
        private void CheckEmptyValues()
        {
            for (var i = 0; i < Request.Form.AllKeys.Length; i++)
                if (string.IsNullOrEmpty(Request.Form.AllKeys[i]))
                {
                    signup_msg.InnerText = @"<div class='alert alert-warning'>
                                          <a href = '#' class='close' data-dismiss='alert' aria-label='close'>&times;</a><b>PLease Fill all fields..!</b>
                    </div>";
                    return;
                }

            if (Request.Form.AllKeys.Length == 0) return;
            ThemDangKy();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                var form = (HtmlForm) Master.FindControl("form1");
                form.ID = "signup_form";
                form.Action = "/DangKy";
                //form.Attributes.Add("onclick","return false");
                form.Method = "POST";
            }

            CheckEmptyValues();
        }

        private void ThemDangKy()
        {
            using (var md5Hash = MD5.Create())
            {
                var kh = new Kh
                {
                    Email = Request.Form["email"].Replace(",", ""),
                    MatKhau = SecurityHelper.GetMd5Hash(md5Hash, Request.Form["password"].Replace(",", "")),
                    TenKh = Request.Form["f_Name"].Replace(",", "")
                };
                KhBus.Insert(kh);
                Response.Redirect("/GioHang", false);
            }
        }

        [WebMethod]
        public static string XuLyDangKy()
        {
            return "";
        }
    }
}