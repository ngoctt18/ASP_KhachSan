<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="addCategory.aspx.cs" Inherits="Admin_addCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Thêm danh mục
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
    <h2>Thêm danh mục</h2>
    <asp:Table runat="server" ID="tbladdCategory">
        <asp:TableRow>
            <asp:TableCell>Tên danh mục</asp:TableCell>
            <asp:TableCell><asp:TextBox id="txtcat_name" runat="server"/></asp:TableCell></asp:TableRow></asp:Table><br />
    <asp:Button class="btn btn-success" ID="btnaddcategory" runat="server" Text="Thêm" OnClick="btnaddcategory_Click"/>
    <asp:Button class="btn btn-info" runat="server" Text="Quản lí danh mục" PostBackUrl="~/Admin/Categories.aspx" />
    <br /><br />
    <p><asp:Label ID="msgaddcategory" runat="server" ForeColor="Red"/></p>
</asp:Content>

