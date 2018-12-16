<%--<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="newsList1.aspx.cs" Inherits="Admin_newsList1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Danh sách tin đã ẩn
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
        <h2>Danh sách tin</h2>
		<asp:Button ID="btnNews1" class="float-right btn btn-primary marL15" runat="server" Text="DS tin ẩn" PostBackUrl="~/Admin/newsList1.aspx" />
		<asp:Button ID="btnNews0" class="float-right btn btn-success " runat="server" Text="DS tin hiện" PostBackUrl="~/Admin/newsList.aspx" />
		<br />
		<br />	
		<asp:GridView class="table table-bordered tdStatus" ID="grvNews" runat="server" AutoGenerateColumns="False"> 
		<Columns>
			<asp:BoundField DataField="news_id" HeaderText="Mã tin tức" />
			<asp:BoundField DataField="news_title" HeaderText="Tiêu đề tin tức" />
			<asp:BoundField DataField="news_description" HeaderText="Mô tả tin tức" />
			<asp:BoundField DataField="news_content" HeaderText="Nội dung tin" />
			<asp:BoundField DataField="news_avatar" HeaderText="Hình Ảnh Tin" />
			<asp:BoundField DataField="news_cat_name" HeaderText="Tên danh mục tin" />
			<asp:BoundField DataField="getNews_status" HeaderText="Trạng thái" />
		</Columns>
	</asp:GridView>
</asp:Content>--%>

