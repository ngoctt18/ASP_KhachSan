<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="room_typesAdd.aspx.cs" Inherits="Admin_room_typesAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Thêm một loại phòng
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
    <h2> Thêm một loại phòng</h2>
    <asp:Table runat="server" ID="tbl">
        <asp:TableRow>
            <asp:TableCell>Tên loại phòng</asp:TableCell>
            <asp:TableCell ><asp:TextBox id="txtroom_type_name" runat="server" required="" /></asp:TableCell></asp:TableRow>
    </asp:Table><br />
    <asp:Button class="btn btn-success" ID="btnaddroom_types" runat="server" Text="Thêm" OnClick="btnThem_Click"/>
    <%--<asp:Button class="btn btn-info" runat="server" Text="Quản lí loại phòng" PostBackUrl="~/Admin/room_typesList.aspx" />--%>
    <br /><br />
    <p><asp:Label ID="msg" runat="server" ForeColor="Red"/></p>
</asp:Content>
