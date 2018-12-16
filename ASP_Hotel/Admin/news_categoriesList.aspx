<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="news_categoriesList.aspx.cs" Inherits="Admin_news_categoriesList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Danh mục tin tức
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
    <h2>Danh mục tin tức</h2>
            <asp:GridView ID="grdDs" runat="server" AutoGenerateColumns="false" class="table table-bordered" >
                <Columns>
                    <asp:BoundField DataField="news_cat_id" HeaderText="Mã quản danh mục tin tức" />
                    <asp:BoundField DataField="news_cat_name" HeaderText="Tên danh mục" />
                    <asp:BoundField DataField="news_cat_description" HeaderText="Mô tả danh mục" />

             <asp:TemplateField HeaderText="Chức năng">
				<ItemTemplate>
					<asp:Button ID="xoa" class="btn btn-danger" CommandName="xoa" CommandArgument='<%#Bind("news_cat_id") %>'
						OnCommand="Xoa_Click" runat="server" Text="Xóa" 
						OnClientClick="return confirm('Bạn có chắc muốn xóa phòng này?')" />
				
					<asp:Button ID="sua" class="btn btn-info" CommandName="sua" CommandArgument='<%#Bind("news_cat_id") %>'
						OnCommand="Sua_Click" runat="server" Text="Sửa"/>
				</ItemTemplate>
			</asp:TemplateField>

            </Columns>
            </asp:GridView>
    <p></p>
	<asp:Button ID="btnThem" class="float-right btn btn-success" runat="server" Text="Thêm danh mục tin tức" PostBackUrl="~/Admin/news_categoriesAdd.aspx" />
</asp:Content>

