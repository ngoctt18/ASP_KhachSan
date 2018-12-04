<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="updateCategory.aspx.cs" Inherits="Admin_updateCategory" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Cập nhật danh mục
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
<h2>Cập nhật danh mục</h2>

    <asp:Table runat="server" ID="tblupdateCategory">
        <asp:TableRow>
            <asp:TableCell>Tên danh mục</asp:TableCell>
            <asp:TableCell><asp:TextBox id="txtcat_name" runat="server"/></asp:TableCell></asp:TableRow></asp:Table><br />
    <asp:Button class="btn btn-success" ID="btnupdatecategory" runat="server" Text="Cập nhật" OnClick="btnupdatecategory_Click"/>
    <asp:Button class="btn btn-info" runat="server" Text="Quản lí danh mục" PostBackUrl="~/Admin/Categories.aspx" />
    <br /><br />
    <p><asp:Label ID="msgudpatecategory" runat="server" ForeColor="Red"/></p>

</asp:Content>

