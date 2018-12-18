<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="news_categoriesAdd.aspx.cs" Inherits="Admin_news_categoriesAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Them danh mục tin tức
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
            <h2> Them danh mục tin tức</h2>
    <asp:Table runat="server" ID="t1" class="table table-bordered">
        <asp:TableRow>
            <asp:TableCell>Name</asp:TableCell>
            <asp:TableCell><asp:TextBox ID="txtname" runat="server" required=""/></asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>Description</asp:TableCell><asp:TableCell><asp:TextBox ID="txtdescription" runat="server" required=""/></asp:TableCell>
        </asp:TableRow>
        </asp:Table>
    </br>
    <asp:Button ID="btnThem" class="btn btn-success" runat="server" Text="Thêm" OnClick="btnThem_Click" />
    <p></p>
    <asp:Label ID="msg" runat="server" ForeColor="Red" />
</asp:Content>

