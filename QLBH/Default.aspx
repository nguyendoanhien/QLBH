<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="QLBH.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <div class="col-xs-12">

            <div class="form-group">
                <div class="input-group">
                    <input type="text" class="form-control" placeholder="Search" id="search">
                    <div class="input-group-btn">
                        <button type="submit" class="btn btn-primary" id="search_btn">
                            <span class="glyphicon glyphicon-search"></span>
                        </button>
                    </div>
                </div>
            </div>
        </div>

    </div>
    <div class="row">
        <div class="col-md-12 col-xs-12" id="product_msg">
        </div>
        <div class="col-xs-12">

            <div class="panel panel-info">
                <div class="panel-heading">
                    <a href="#" id="get_product_all">Sản phẩm</a>
                </div>
                <div class="panel-body">
                    <div id="get_product" runat="server">
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-xs-12">
            <center>

                <ul class="pagination" id="pageno" runat="server">
                </ul>

            </center>
        </div>
    </div>
</asp:Content>
