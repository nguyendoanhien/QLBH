<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/admin/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QLBH.admin.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
    

    </script>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="lead text-primary text-center text-uppercase">Combo</div>
    <div class="row">
        <div class="form-group col-xs-4">
            <label for="moneybefore">Tổng tiền (gốc)</label>
            <input type="number" disabled class="form-control" id="moneybefore">
        </div>
        <div class="form-group col-xs-4">
            <label for="percent">Phần trăm giảm</label>
            <input type="number" min="0" max="100" value="0" class="form-control" id="percent">
        </div>
        <div class="form-group col-xs-4">
            <label for="moneyafter">Tổng tiền (đã giảm)</label>
            <input type="number" disabled class="form-control" id="moneyafter">
        </div>
        <div class="col-xs-12 text-right">
            <button class="btn btn-primary" id="btnlaphoadon">Lập hóa đơn</button>
        </div>
    </div>
    <div class="row">
        <div class="col-xs-5">

            <div class="input-group">
                <input type="text" class="form-control" id="inputComboSearch" onkeyup="myFunction()" placeholder="Tên sản phẩm..." title="Type in a name">
                <div class="input-group-btn">
                    <button class="btn" id="btnInputThem" type="button">Thêm</button>
                </div>
            </div>
            <table id="inputCombo" class="table">
                <thead>
                    <tr>
                        <th class="fit">Chọn</th>
                        <th class="fit">Hình</th>
                        <th class="fit">Tên sản phẩm</th>
                        <th class="fit">Đơn giá</th>

                    </tr>
                </thead>
                <tbody>
                    <!-- Ajax here -->
                </tbody>
            </table>


        </div>

        <div class="col-xs-6 col-xs-offset-1">

            <div class="input-group">
                <div class="input-group-btn">
                    <button class="btn btn-danger" id="btnOutputXoa" type="button">Xóa</button>
                </div>
                <input type="text" class="form-control" id="outputComboSearch" onkeyup="myFunction()" placeholder="Tên sản phẩm..." title="Type in a name">
            </div>
            <table id="outputCombo" class="table">
                <thead>
                    <tr>
                        <th class="fit">Chọn</th>
                        <th class="fit">Hình</th>
                        <th class="fit">Tên sản phẩm</th>
                        <th class="fit">Đơn giá</th>
                        <th class="fit">Số lượng</th>
                    </tr>
                </thead>
                <tbody>
                </tbody>
            </table>


        </div>
    </div>
    <div id="xxx">
        <p>Hello World</p>
    </div>
</asp:Content>
