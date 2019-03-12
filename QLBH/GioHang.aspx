<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="GioHang.aspx.cs" Inherits="QLBH.GioHang" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-xs-12" id="cart_msg">
            <!--Cart Message-->
        </div>

    </div>
    <div class="row">
        <div class="col-md-12">
            <div class="panel panel-primary">
                <div class="panel-heading">Cart Checkout</div>
                <div class="panel-body">
                    <div class="row">
                        <div class="col-md-2 col-xs-2">
                            <b>Hành động</b>
                        </div>
                        <div class="col-md-2 col-xs-2">
                            <b>Hình sản phẩm</b>
                        </div>
                        <div class="col-md-2 col-xs-2">
                            <b>Tên sản phẩm</b>
                        </div>
                        <div class="col-md-2 col-xs-2">
                            <b>Số lượng</b>
                        </div>
                        <div class="col-md-2 col-xs-2">
                            <b>Đơn giá</b>
                        </div>
                        <div class="col-md-2 col-xs-2">
                            <b>Tổng tiền</b>
                        </div>
                    </div>
                    <div id="cart_checkout">
                        <!--Ajãx-->
                    </div>

                </div>
            </div>
            <div class="panel-footer"></div>
        </div>
    </div>



</asp:Content>
