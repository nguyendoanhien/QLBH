<%@ Page Language="C#" MasterPageFile="Site.Master" AutoEventWireup="true" CodeBehind="DangKy.aspx.cs" Inherits="QLBH.DangKy" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-md-2"></div>
        <div class="col-md-8" id="signup_msg" runat="server">
            <!--Alert from signup form-->
        </div>
        <div class="col-md-2"></div>
    </div>
    <div class="row">
        <div class="col-md-2"></div>
        <div class="col-md-8">
            <div class="panel panel-primary">
                <div class="panel-heading">Thông tin đăng ký</div>
                <div class="panel-body">


                    <div class="row">
                        <div class="col-md-12">
                            <label for="f_name">Họ và tên</label>
                            <input type="text" id="f_name" name="f_name" class="form-control">
                        </div>

                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <label for="email">Email</label>
                            <input type="text" id="email" name="email"class="form-control">
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <label for="password">Mật khẩu</label>
                            <input type="password" id="password" name="password"class="form-control">
                        </div>
                    </div>
                    <div class="row">
                        <div class="col-md-12">
                            <label for="repassword">Nhập lại mật khẩu</label>
                            <input type="password" id="repassword" name="repassword"class="form-control">
                        </div>
                    </div>

                    <p>
                        <br/>
                    </p>
                    <div class="row">
                        <div class="col-md-12">
                            <input style="width: 100%;" id="btnDangKy" onclick="submit()" value="Đăng ký" type="submit" name="signup_button"class="btn btn-success btn-lg">
                        </div>
                    </div>

                </div>

                <div class="panel-footer"></div>
            </div>
        </div>
        <div class="col-md-2"></div>
    </div>
</asp:Content>