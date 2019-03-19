using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using BUS;
using DTO;
using MyUltilities;
using QLBH.HelpfulClasses;
using System.Web.Script.Serialization;
namespace QLBH
{
    public partial class Default : Page
    {
        private static string _truyCapTatCa;
        private static string _truyCapHienTai;
        private static List<Sp> _spList;
        private const int ProductOnPage = 9;
        public string LtrPages;

        [WebMethod]
        public static string AddToCart(FilterClass fc)
        {
            if (HttpContext.Current.Session["uid"] == null)
            {
                var gioHang = GioHangBus.GetAll()
                    .FirstOrDefault(m => m.DiaChiIp == Cart.IpAddress && m.MaSp == fc.ProductId);

                if (gioHang != null)
                    return @"<div class='alert alert-warning'>
							<a href='#' class='close' data-dismiss='alert' aria-label='close'>&times;</a>
							<b>Sản phẩm đã tồn tại trong giỏ hàng !</b>
					</div>";

                if (GioHangBus.Insert(new DTO.GioHang
                { MaSp = fc.ProductId, DiaChiIp = Cart.IpAddress, SoLuong = 1 }) != null)
                    return @"<div class='alert alert-success'>
						<a href='#' class='close' data-dismiss='alert' aria-label='close'>&times;</a>
						<b>Sản phẩm đã được thêm !</b>
					</div>";
            }
            else
            {
                var gioHang = GioHangBus.GetAll()
                    .FirstOrDefault(m =>
                        m.MaKh == int.Parse(HttpContext.Current.Session["uid"].ToString()) && m.MaSp == fc.ProductId);

                if (gioHang != null)
                    return @"<div class='alert alert-warning'>
							<a href='#' class='close' data-dismiss='alert' aria-label='close'>&times;</a>
							<b>Sản phẩm đã tồn tại trong giỏ hàng !</b>
					</div>";

                if (GioHangBus.Insert(new DTO.GioHang
                {
                    MaSp = fc.ProductId,
                    MaKh = int.Parse(HttpContext.Current.Session["uid"].ToString()),
                    SoLuong = 1
                }) != null)
                    return @"<div class='alert alert-success'>
						<a href='#' class='close' data-dismiss='alert' aria-label='close'>&times;</a>
						<b>Sản phẩm đã được thêm !</b>
					</div>";
            }

            return "OK";
        }


        [WebMethod]
        public static string CountItem()
        {
            if (HttpContext.Current.Session["uid"] == null)
                return GioHangBus.GetAll().Where(m => m.DiaChiIp == Cart.IpAddress).ToList().Count.ToString();
            return GioHangBus.GetAll().Where(m => m.MaKh == int.Parse(HttpContext.Current.Session["uid"].ToString()))
                .ToList().Count.ToString();
        }

        [WebMethod]
        public static string GetAppStatus()
        {
            var sb = new StringBuilder();
            sb.Append($@"Tổng truy cập:{_truyCapTatCa}</br>
                                      Tổng truy cập hiện tại:{_truyCapHienTai}</br>
                                      Địa chỉ ip:{Cart.IpAddress}");
            return sb.ToString();
        }

        [WebMethod]
        public static string GetBrands()
        {
            var sb = new StringBuilder();
            sb.Append(@"<div class='nav nav-pills nav-stacked'>
                      <li class='active'><a href = '#' ><h4> Thương hiệu </h4></a></li>");
            foreach (var ncc in Ncc_BUS.GetAll())
                sb.Append($"<li><a href='#' class='selectBrand' cid='{ncc.MaNcc}'>{ncc.TenNcc}</a></li>");

            sb.Append("</div>");

            return sb.ToString();
        }

        [WebMethod]
        public static string GetCartItems(FilterClass fc, ActionClass ac)
        {
            var sb = new StringBuilder();
            var result = HttpContext.Current.Session["uid"] == null
                ? from p in Sp_BUS.GetAll()
                  join g in GioHangBus.GetAll()
                      on p.MaSp equals g.MaSp
                  where g.DiaChiIp == Cart.IpAddress
                  select new
                  {
                      MaSanPham = p.MaSp,
                      TenSanPham = p.TenSp,
                      GiaSanPham = p.DonGia,
                      HinhSanPham = p.HinhSp,
                      g.MaGioHang,
                      g.SoLuong,
                      g.DiaChiIp,
                      g.MaKh
                  }
                : GioHangBus.GetAll().Join(Sp_BUS.GetAll(), c => c.MaSp, p => p.MaSp,
                    (gioHang, sanPham) => new
                    {
                        MaSanPham = sanPham.MaSp,
                        TenSanPham = sanPham.TenSp,
                        GiaSanPham = sanPham.DonGia,
                        HinhSanPham = sanPham.HinhSp,
                        gioHang.MaGioHang,
                        gioHang.SoLuong,
                        gioHang.DiaChiIp,
                        gioHang.MaKh
                    }).Where(m => m.MaKh == int.Parse(HttpContext.Current.Session["uid"].ToString()));

            var enumerable = result.ToList();
            if (ac.LaySanPhamGioHang)
            {
                var n = 0;
                foreach (var x in enumerable)
                    sb.Append($@"
                    <div class='row'>
                        <div class='col-md-3'>{++n}</div>
						<div class='col-md-3'><img class='img-responsive' src='product_images/{x.HinhSanPham}' /></div>
						<div class='col-md-3'>{x.TenSanPham}</div>
						<div class='col-md-3'>{x.GiaSanPham}</div>
					</div>
                    ");
                sb.Append(
                    "<a style='float:right; ' href='/GioHang' class='btn btn-warning'>Edit&nbsp;&nbsp;<span class='glyphicon glyphicon-edit'></span></a>");
            }

            if (ac.LaySanPhamGioHangCheckOut)
            {
                foreach (var x in enumerable)
                    sb.Append($@"<div class='row'>
                        <div class='col-md-2'>
                        <div class='btn-group'>
                        <a href = '#' remove_id='{x.MaSanPham}' class='btn btn-danger remove'><span class='glyphicon glyphicon-trash'></span></a>
                        <a href = '#' update_id='{x.MaSanPham}' class='btn btn-primary update'><span class='glyphicon glyphicon-ok-sign'></span></a>
                        </div>
                        </div>
                        <input type = 'hidden' name='product_id[]' value='{x.MaSanPham}'/>
                        <input type = 'hidden' name='' value='{x.MaGioHang}'/>
                        <div class='col-md-2'><img class='img-responsive' src='product_images/{x.HinhSanPham}'></div>
                        <div class='col-md-2'>{x.TenSanPham}</div>
                        <div class='col-md-2'><input type = 'text' class='form-control qty' value='{x.SoLuong}' ></div>
                        <div class='col-md-2'><input type = 'text' class='form-control price' value='{x.GiaSanPham}' readonly='readonly'></div>
                        <div class='col-md-2'><input type = 'text' class='form-control total' value='{x.GiaSanPham}' readonly='readonly'></div>
                        </div>");
                sb.Append(@"<div class='row'>
                    <div class='col-md-8'></div>
                    <div class='col-md-4'>
                    <b class='net_total' style='font-size:20px;'> </b>
                    </div>");

                if (HttpContext.Current.Session["uid"] == null)
                {
                    sb.Append(
                        "<input type='submit' style='float:right; ' name='login_user_with_product' onclick='submit()' class='btn btn-info btn-lg' value='Ready to Checkout' >");
                }
                else
                {
                    sb.Append(@"
                        <input type = 'hidden' name = 'cmd' value='_cart'>
                        <input type = 'hidden' name = 'business' value = 'toilati123vn@gmail.com' >
                        <input type = 'hidden' name = 'upload' value = '1' > ");

                    var collections = from p in Sp_BUS.GetAll()
                                      join g in GioHangBus.GetAll()
                                          on p.MaSp equals g.MaSp
                                      where g.MaKh == int.Parse(HttpContext.Current.Session["uid"].ToString())
                                      select new
                                      {
                                          MaSanPham = p.MaSp,
                                          TenSanPham = p.TenSp,
                                          GiaSanPham = p.DonGia,
                                          HinhSanPham = p.HinhSp,
                                          g.MaGioHang,
                                          g.SoLuong,
                                          g.DiaChiIp,
                                          g.MaKh
                                      };
                    var i = 0;
                    foreach (var x in collections)
                    {
                        i++;
                        sb.Append($@"
                            <input type='hidden' name='item_name_{i}' value='{x.TenSanPham}'>
                            <input type = 'hidden' name = 'item_number_{i}' value = '{i}' >
                            <input type = 'hidden' name = 'amount_{i}' value = '{x.GiaSanPham}' >
                            <input type = 'hidden' name = 'quantity_{i}' value = '{x.SoLuong}' > ");
                    }

                    sb.Append(
                        $@"<input type='hidden' name='return' value='/GiaoDichThanhCong'/>

                        <input type = 'hidden' name = 'notify_url' value = '/GiaoDichThanhCong' >
     
                        <input type = 'hidden' name = 'cancel_return' value = '/GiaoDichThatBai' />
          
                        <input type = 'hidden' name = 'currency_code' value = 'USD' />
               
                        <input type = 'hidden' name = 'custom' value = '{HttpContext.Current.Session["uid"]}' />
                      
                        <input style = 'float:right;margin-right:80px;' type = 'image' name = 'submit'

                    src = 'https://www.paypalobjects.com/webstatic/en_US/i/btn/png/blue-rect-paypalcheckout-60px.png' alt = 'PayPal Checkout'

                    alt = 'PayPal - The safer, easier way to pay online' > ");
                }
            }


            return sb.ToString();
        }

        [WebMethod]
        public static string GetLeftMenus()
        {
            var sbNhom = new StringBuilder();

            foreach (var spNhom in SpNhom_BUS.GetAll())
            {
                var sbLoai = new StringBuilder();

                foreach (var spLoai in SpLoaiBus.GetAll().Where(spLoai => spLoai.MaNhomSp == spNhom.MaNhomSp))
                    sbLoai.Append(string.Format(@"<tr>
                                                <td>
                                                    <span class='text-primary'></span><a class='category' cid='{0}' href='{1}'>{2}</a>
                                                </td>
                                            </tr>", spLoai.MaLoaiSp, "#", spLoai.TenLoaiSp));


                sbNhom.Append(string.Format(@"<div class='panel-group' id='accordion'>
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

                        </div> ", spNhom.MaNhomSp, spNhom.TenNhomSp, sbLoai));
            }


            return sbNhom.ToString();
        }

        [WebMethod]
        public static string GetPages()
        {
            var sbTrang = new StringBuilder();
            decimal kq = (_spList ?? Sp_BUS.GetAll()).Count / (ProductOnPage == 0 ? 1 : ProductOnPage) + 1;
            var pageNo = Math.Ceiling(kq);
            if (pageNo != 1)
                for (var i = 1; i <= pageNo; i++)
                    sbTrang.Append(string.Format(@"<li><a href='#' page='{0}' id='page'>{0}</a></li>", i));
            return sbTrang.ToString();
        }

        [WebMethod]
        public static string GetProducts(FilterClass fc)
        {
            var sb = new StringBuilder();
            _spList = Sp_BUS.GetAll();
            if (!string.IsNullOrEmpty(fc.CatId.ToString()))
                _spList = _spList.Where(sp => sp.MaLoaiSp == fc.CatId).ToList();
            if (!string.IsNullOrEmpty(fc.BrandId.ToString()))
                _spList = _spList.Where(sp => sp.MaNcc == fc.BrandId).ToList();
            if (!string.IsNullOrEmpty(fc.SearchKey))
                _spList = _spList.Where(sp => sp.TenSp.Contains(fc.SearchKey)).ToList();
            var spListPaged = _spList.Skip(ProductOnPage * ((fc.PageId ?? 1) - 1)).Take(ProductOnPage).ToList();


            foreach (var sp in spListPaged)
                sb.Append($@"
            <div class='col-md-4'>
							<div class='panel panel-info'>
								<div class='panel-heading'>{sp.TenSp}</div>
								<div class='panel-body'>
									<img src='/product_images/{sp.HinhSp}' style='width:160px; height:250px;'/>
								</div>
								<div class='panel-heading'>{sp.DonGia}
									<button pid='{sp.MaSp}' style='float:right;' id='product' class='btn btn-danger btn-xs'>Thêm giở hàng</button>
								</div>
							</div>
						</div>

            ");


            return string.IsNullOrEmpty(sb.ToString()) ? "Không có sản phẩm" : sb.ToString();
        }
        [WebMethod]
        public static string GetProductsAdmin()
        {
            JavaScriptSerializer jsonSerialiser = new JavaScriptSerializer();
            var json = jsonSerialiser.Serialize(Sp_BUS.GetAll());
            return json;
        }

        [WebMethod]
        public static string Login(FilterClass fc)
        {
            var email = fc.Email;
            string password;
            using (var md5Hash = MD5.Create())
            {
                password = SecurityHelper.GetMd5Hash(md5Hash, fc.Password);
            }

            var kh = KhBus.GetAll().FirstOrDefault(m => m.Email == email && m.MatKhau == password);
            if (kh != null)
            {
                HttpContext.Current.Session["uid"] = kh.MaKh;
                HttpContext.Current.Session["name"] = kh.TenKh;
                return "Thành công";
            }

            return "<span style='color:red;'>Đăng ký nếu chưa có tài khoản!</span>";
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                _truyCapTatCa = Application["TruyCapTatCa"].ToString();
                _truyCapHienTai = Application["TruyCapHienTai"].ToString();
            }
        }

        [WebMethod]
        public static string ProductsClick(FilterClass fc)
        {
            return AddToCart(fc);
        }
    }
}