using System;
using System.Web.UI;

namespace QLBH
{
    public partial class SiteMaster : MasterPage
    {
        public static string LtrUserDropdownBody;

        private void Common()
        {
        }

        private void GetCartItem()
        {
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["uid"] == null)
                LtrUserDropdownBody = @"
<li>
                                    <div style='width: 300px; '>
                    <div class='panel panel-primary'>
                    <div class='panel-heading'>Login</div>
                    <div class='panel-heading'>

                    <label for='email'>Email</label>
                    <input type = 'email' class='form-control' name='email' id='email' required/>
                    <label for='email'>Mật khẩu</label>
                    <input type = 'password' class='form-control' name='password' id='password' required/>
                    <p>
                    <br/>
                    </p>
                    <a href = '#' style='color: white; list-style: none;'>Quên mật khẩu?</a><input type = 'submit' id='login' class='btn btn-success' style='float: right;'>
                    </div>
                    <div class='panel-footer' id='e_msg'></div>
                    </div>
                    </div>
                    </li>";
            else
                LtrUserDropdownBody = @"
<li><a href='/GioHang' style='text - decoration:none; color: blue; '><span class='glyphicon glyphicon-shopping - cart'>Cart</a></li>
                    <li class='divider'></li>
                    <li><a href = 'customer_order.php' style='text-decoration:none; color:blue;'>Orders</a></li>
                    <li class='divider'></li>
                    <li><a href = '' style='text-decoration:none; color:blue;'>Chnage Password</a></li>
                    <li class='divider'></li>
                    <li><a href = '/DangXuat' style='text-decoration:none; color:blue;'>Logout</a></li>
                ";
        }
    }
}