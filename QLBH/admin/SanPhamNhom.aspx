<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/admin/Site.Master" AutoEventWireup="true" CodeBehind="SanPhamNhom.aspx.cs" Inherits="QLBH.admin.SanPhamNhom" %>


<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">






    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="MaNhomSP" DataSourceID="EntityDataSource1" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="MaNhomSP" HeaderText="MaNhomSP" ReadOnly="True" SortExpression="MaNhomSP" />
            <asp:BoundField DataField="TenNhomSP" HeaderText="TenNhomSP" SortExpression="TenNhomSP" />
            <asp:TemplateField HeaderText="SPLoai">
                <ItemTemplate>
                    <asp:GridView ID="GridView2" runat="server" DataSource='<%# Eval("SPLoais") %>'>
                    </asp:GridView>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <FooterStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#990000" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#FFCC66" ForeColor="#333333" HorizontalAlign="Center" />
        <RowStyle BackColor="#FFFBD6" ForeColor="#333333" />
        <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="Navy" />
        <SortedAscendingCellStyle BackColor="#FDF5AC" />
        <SortedAscendingHeaderStyle BackColor="#4D0000" />
        <SortedDescendingCellStyle BackColor="#FCF6C0" />
        <SortedDescendingHeaderStyle BackColor="#820000" />
    </asp:GridView>
    <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=QLBHDBContext" DefaultContainerName="QLBHDBContext" EnableFlattening="False" EntitySetName="SPNhoms" Include="SPLoais">
    </asp:EntityDataSource>






</asp:Content>
