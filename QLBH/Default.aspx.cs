using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using BUS;
using DTO;
using QLBH.HelpfulClasses;
using MyUltilities;
using System.Web.UI.HtmlControls;
using System.Security.Cryptography;

namespace QLBH
{
    public partial class _Default : Page
    {
        private static string truyCapTatCa;
        private static string truyCapHienTai;
        private static string diaChiIp;
        private static Cart CART;
        public string LtrPages;
        private static List<Sp> spList;
        private static int productOnPage;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                productOnPage = 9;
                truyCapTatCa = Application["TruyCapTatCa"].ToString();
                truyCapHienTai = Application["TruyCapHienTai"].ToString();
                CART = Cart.GetCart;
            }

        }

        [WebMethod]
        public static string GetBrands()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"<div class='nav nav-pills nav-stacked'>
                      <li class='active'><a href = '#' ><h4> Thương hiệu </h4></a></li>");
            foreach (Ncc ncc in Ncc_BUS.GetAll())
            {
                sb.Append(String.Format("<li><a href='#' class='selectBrand' cid='{0}'>{1}</a></li>", ncc.MaNcc, ncc.TenNcc));
            }

            sb.Append("</div>");

            return sb.ToString();
        }

        [WebMethod]
        public static string ProductsClick(FilterClass fc)
        {
            StringBuilder sb = new StringBuilder();
            int p_id = fc.Product_id;
            string ip_add = Cart.IpAddress;
            if (Cart.IsSession(HttpContext.Current.Session["CartSession"]))
            {
                sb.Append("Your session id is " + ip_add);
            }
            return sb.ToString();
        }

        [WebMethod]
        public static string AddToCart(FilterClass fc)
        {
            return null;
        }
        [WebMethod]
        public static string GetLeftMenus()
        {
            StringBuilder sbNhom = new StringBuilder();

            foreach (SpNhom spNhom in SpNhom_BUS.GetAll())
            {
                StringBuilder sbLoai = new StringBuilder();

                foreach (SpLoai spLoai in SpLoai_BUS.GetAll().Where(spLoai => spLoai.MaNhomSp == spNhom.MaNhomSp))
                {
                    sbLoai.Append(String.Format(@"<tr>
                                                <td>
                                                    <span class='text-primary'></span><a class='category' cid='{0}' href='{1}'>{2}</a>
                                                </td>
                                            </tr>", spLoai.MaLoaiSp, "#", spLoai.TenLoaiSp));
                }




                sbNhom.Append(String.Format(@"<div class='panel-group' id='accordion'>
                            <div class='panel panel-default'>
                                <div class='panel-heading'>
                                    <h4 class='panel-title'>
                                        <a data-toggle='collapse' data-parent='#accordion' href='#{0}'>{1}</a>
                                    </h4>
                                </div>
                                <div id = '{0}' class='panel-collapse collapse in'>
                                    <div class='panel-body'>
                                        <table class='table'>
                                          {2}
                                        </table>
                                    </div>
                                </div>
                            </div>

                        </div> ", spNhom.MaNhomSp, spNhom.TenNhomSp, sbLoai.ToString()));


            }



            return sbNhom.ToString();
        }
        [WebMethod]
        public static string GetAppStatus()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(String.Format(@"Tổng truy cập:{0}</br>
                                      Tổng truy cập hiện tại:{1}</br>
                                      Địa chỉ ip:{2}",
                                     truyCapTatCa,
                                     truyCapHienTai,
                                     Cart.IpAddress));
            return sb.ToString();
        }
        [WebMethod]
        public static string GetPages()
        {
            StringBuilder sbTrang = new StringBuilder();
            decimal kq = (spList.Count / productOnPage) + 1;
            decimal pageNo = Math.Ceiling(kq);
            for (var i = 1; i <= pageNo; i++)
            {
                sbTrang.Append(String.Format(@"<li><a href='#' page='{0}' id='page'>{0}</a></li>", i));
            }
            return sbTrang.ToString();

        }


        [WebMethod]
        public static string GetProducts(FilterClass fc)
        {
            int limit = 9;
            int start = 0;


            StringBuilder sb = new StringBuilder();
            spList = Sp_BUS.GetAll();
            if (!String.IsNullOrEmpty(fc.Cat_id.ToString()))
                spList = spList.Where(sp => sp.MaLoaiSp == fc.Cat_id).ToList();
            if (!String.IsNullOrEmpty(fc.Brand_id.ToString()))
                spList = spList.Where(sp => sp.MaNcc == fc.Brand_id).ToList();
            if (!String.IsNullOrEmpty(fc.SearchKey))
                spList = spList.Where(sp => sp.TenSp.Contains(fc.SearchKey)).ToList();
            List<Sp> spListPaged = spList.Skip(productOnPage * ((fc.Page_id ?? 1) - 1)).Take(productOnPage).ToList();



            foreach (Sp sp in spListPaged)
            {
                sb.Append(String.Format(@"
            <div class='col-md-4'>
							<div class='panel panel-info'>
								<div class='panel-heading'>{0}</div>
								<div class='panel-body'>
									<img src='product_images/{1}' style='width:160px; height:250px;'/>
								</div>
								<div class='panel-heading'>{2}
									<button pid='{3}' style='float:right;' id='product' class='btn btn-danger btn-xs'>Thêm giở hàng</button>
								</div>
							</div>
						</div>

            ", sp.TenSp, sp.HinhSp, sp.DonGia, sp.MaSp));
            }


            return String.IsNullOrEmpty(sb.ToString()) ? "Không có sản phẩm" : sb.ToString();

        }
        [WebMethod]
        public static string Login(FilterClass fc)
        {
            string email = SecurityHelper.ToLiteral(fc.Email);
            string password;
            using (MD5 md5Hash = MD5.Create())
            {
                password = SecurityHelper.GetMd5Hash(md5Hash, fc.Password);
            }

            return "";
        }

    }
}