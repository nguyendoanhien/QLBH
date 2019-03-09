<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/admin/Site.Master" AutoEventWireup="true" CodeBehind="SanPhamLoai.aspx.cs" Inherits="QLBH.admin.SanPhamLoai" %>

<%@ Register assembly="DevExpress.Web.v17.1, Version=17.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">



    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CssClass="table table-striped" DataKeyNames="MaLoaiSP" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:CommandField HeaderText="Tùy chỉnh" ShowDeleteButton="True" ShowEditButton="True" />
            <asp:BoundField DataField="MaLoaiSP" HeaderText="MaLoaiSP" ReadOnly="True" SortExpression="MaLoaiSP" InsertVisible="False" />
            <asp:BoundField DataField="MaNhomSP" HeaderText="MaNhomSP" SortExpression="MaNhomSP" />
            <asp:BoundField DataField="TenLoaiSP" HeaderText="TenLoaiSP" SortExpression="TenLoaiSP" />
            <asp:CommandField ShowSelectButton="True" />
        </Columns>
    </asp:GridView>
    <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateInsertButton="True" AutoGenerateRows="False" DataKeyNames="MaLoaiSP" DataSourceID="SqlDataSource1" DefaultMode="Insert" OnItemInserted="DetailsView1_ItemInserted">
        <Fields>
            <asp:BoundField DataField="MaLoaiSP" HeaderText="MaLoaiSP" ReadOnly="True" SortExpression="MaLoaiSP" InsertVisible="False" />
            <asp:BoundField DataField="MaNhomSP" HeaderText="MaNhomSP" SortExpression="MaNhomSP" />
            <asp:BoundField DataField="TenLoaiSP" HeaderText="TenLoaiSP" SortExpression="TenLoaiSP" />
        </Fields>
    </asp:DetailsView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:QLBHConnectionString %>" SelectCommand="SELECT * FROM [SPLoai]" DeleteCommand="DELETE FROM [SPLoai] WHERE [MaLoaiSP] = @MaLoaiSP" InsertCommand="INSERT INTO [SPLoai] ([MaNhomSP], [TenLoaiSP]) VALUES (@MaNhomSP, @TenLoaiSP)" UpdateCommand="UPDATE [SPLoai] SET [MaNhomSP] = @MaNhomSP, [TenLoaiSP] = @TenLoaiSP WHERE [MaLoaiSP] = @MaLoaiSP">
        <DeleteParameters>
            <asp:Parameter Name="MaLoaiSP" Type="Int32" />
        </DeleteParameters>
        <InsertParameters>
            <asp:Parameter Name="MaNhomSP" Type="Int32" />
            <asp:Parameter Name="TenLoaiSP" Type="String" />
        </InsertParameters>
        <UpdateParameters>
            <asp:Parameter Name="MaNhomSP" Type="Int32" />
            <asp:Parameter Name="TenLoaiSP" Type="String" />
            <asp:Parameter Name="MaLoaiSP" Type="Int32" />
        </UpdateParameters>
    </asp:SqlDataSource>



</asp:Content>
