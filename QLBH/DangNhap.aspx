<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DangNhap.aspx.cs" Inherits="QLBH.DangNhap" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-2"></div>
        <div class="col-md-8" id="signup_msg">
            <!--Alert from signup form-->
        </div>
        <div class="col-md-2"></div>
    </div>
    <div class="row">
        <div class="col-md-4"></div>
        <div class="col-md-4">
            <div class="panel panel-primary">
                <div class="panel-heading">Customer Login Form</div>
                <div class="panel-body">
                    <!--User Login Form-->

                    <label for="email">Email</label>
                    <input type="email" class="form-control" name="email" id="email" required/>
                    <label for="email">Mật khẩu</label>
                    <input type="password" class="form-control" name="password" id="password" required/>
                    <p>
                        <br/>
                    </p>
                    <a href="#" style="color: #333; list-style: none;">Quên mật khẩu</a><input type="submit" id="login" class="btn btn-success" style="float: right;" value="Login">
                    <!--If user dont have an account then he/she will click on create account button-->
                    <div>
                        <a href="customer_registration.php?register=1">Tạo mật khẩu?</a>
                    </div>

                </div>
                <div class="panel-footer">
                    <div id="e_msg"></div>
                </div>
            </div>
        </div>
        <div class="col-md-4"></div>
    </div>
</asp:Content>