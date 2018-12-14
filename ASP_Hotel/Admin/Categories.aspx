<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="Categories.aspx.cs" Inherits="Admin_Categories" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Quản lí danh mục
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
<h2>Danh sách danh mục</h2>
    <asp:GridView class="table table-bordered" runat="server" ID="grdcategories" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="cat_id" HeaderText="ID" />
            <asp:BoundField DataField="cat_name" HeaderText="Tên danh mục" />
            <asp:TemplateField HeaderText="Xóa">
                <ItemTemplate>
                    <asp:Button class="btn btn-danger" ID="deleteCategories" CommandName="deletecategories" CommandArgument='<%#Bind("cat_id") %>' Text="Xóa" OnCommand="deleteCategories_Command" runat="server" OnClientClick="return confirm('Chắc chắn xóa ?')"/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Cập nhật">
                <ItemTemplate>
                    <asp:Button class="btn btn-info" ID="updateCategories" CommandName="updatecategories" CommandArgument='<%#Bind("cat_id") %>' Text="Cập nhật" OnCommand="updateCategories_Command" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="addcategory" class="btn btn-success" runat="server" Text="Thêm danh mục" OnClick="addcategory_Click" PostBackUrl="~/Admin/addCategory.aspx" />
</asp:Content>

