<%@ Page Language="C#" MasterPageFile="~/admin/Site.Master" AutoEventWireup="true" CodeBehind="DonHang.aspx.cs" Inherits="QLBH.admin.HoaDon" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript">
       
    </script>
</asp:Content>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="MaPhieuHd"  ForeColor="#333333" GridLines="None" AllowPaging="True" AllowSorting="True" OnRowDeleting="GridView1_RowDeleting" AutoGenerateSelectButton="True" CssClass="table" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:CommandField ShowDeleteButton="True" />
            <asp:TemplateField HeaderText="Mã hóa đơn" SortExpression="MaPhieuHd">
                <EditItemTemplate>
                    <asp:Label ID="Label1" runat="server" Text='<%# Eval("MaPhieuHd") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="maHoaDon" runat="server" Text='<%# Bind("MaPhieuHd") %>'></asp:Label>
                </ItemTemplate>
                <HeaderStyle HorizontalAlign="Right" />
                <ItemStyle HorizontalAlign="Right" />
            </asp:TemplateField>
            <asp:BoundField DataField="MaKh" HeaderText="Mã khách hàng" SortExpression="MaKh" />
            <asp:BoundField DataField="MaNv" HeaderText="Mã nhân viên" SortExpression="MaNv" />
            <asp:BoundField DataField="NgayLap" HeaderText="Ngày lập" SortExpression="NgayLap" />
            <asp:BoundField DataField="PhanTramGiam" HeaderText="Phần trăm giảm" SortExpression="PhanTramGiam" >
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="TienGiam" HeaderText="Tiền giảm" SortExpression="TienGiam" />
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
    <asp:EntityDataSource ID="EntityDataSource1" runat="server" ConnectionString="name=QLBH_WinDBContext" DefaultContainerName="QLBH_WinDBContext" EnableFlattening="False" EnableInsert="True" EnableUpdate="True" EntitySetName="PhieuHds" EnableDelete="True">
    </asp:EntityDataSource>

    <asp:GridView ID="GridView2" runat="server" CellPadding="4" CssClass="table" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
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

</asp:Content>
