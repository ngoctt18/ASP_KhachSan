<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="news_categoriesEdit.aspx.cs" Inherits="Admin_news_categoriesEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Cập nhật thông tin danh mục
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
            <h2>Cập nhật thông tin danh mục</h2>
    <asp:Table runat="server" ID="t1" class="table table-bordered">
        <asp:TableRow>
            <asp:TableCell>ID</asp:TableCell>
            <asp:TableCell><asp:TextBox ID="txtid" runat="server" Enabled="false" /></asp:TableCell></asp:TableRow><asp:TableRow>
            <asp:TableCell>Phone</asp:TableCell><asp:TableCell><asp:TextBox ID="txtname" runat="server" required=""/></asp:TableCell></asp:TableRow><asp:TableRow>
            <asp:TableCell>Password</asp:TableCell><asp:TableCell><asp:TextBox ID="txtdescription" runat="server" required=""/></asp:TableCell></asp:TableRow>
    </asp:Table>
    </br>
    <asp:Button ID="btnSua" class="btn btn-success" runat="server" Text="Cập nhật" OnClick="btnSua_Click" />
    <p></p>
    <asp:Label ID="msg" runat="server" Font-Italic="true" />
</asp:Content>

