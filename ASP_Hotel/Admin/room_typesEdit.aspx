<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="room_typesEdit.aspx.cs" Inherits="Admin_room_typesEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Cập nhật loại phòng
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
    <h2>Cập nhật loại phòng</h2>
    <asp:Table runat="server" ID="tbl">
        <asp:TableRow>
            <asp:TableCell>ID</asp:TableCell>
            <asp:TableCell><asp:TextBox id="txtroom_type_id" runat="server" Enabled="false"/></asp:TableCell></asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Tên loại phòng</asp:TableCell>
            <asp:TableCell><asp:TextBox id="txtroom_type_name" runat="server" required="" /></asp:TableCell></asp:TableRow>
        </asp:Table>

    <br />
    <asp:Button class="btn btn-success" ID="btneditroom_types" runat="server" Text="Sửa" OnClick="btnSua_Click"/>
    <%--<asp:Button class="btn btn-info" runat="server" Text="Quản lí loại phòng" PostBackUrl="~/Admin/room_typesList.aspx" />--%>
    <br /><br />
    <p><asp:Label ID="msg" runat="server" ForeColor="Red"/></p>
</asp:Content>