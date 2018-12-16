<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="newsAdd.aspx.cs" Inherits="Admin_newsAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Thêm một tin tức
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
    	<h2>Thêm tin tức</h2>
<asp:Table ID="tableThemSV" runat="server" class="table table-bordered">
   <asp:TableRow>
      <asp:TableCell>Tiêu đề: </asp:TableCell>
      <asp:TableCell>
         <asp:TextBox ID="news_title" runat="server" required="" />
      </asp:TableCell>
   </asp:TableRow>

    <asp:TableRow>
      <asp:TableCell>Mô tả: </asp:TableCell>
      <asp:TableCell>
         <asp:TextBox ID="news_description" runat="server" required="" />
      </asp:TableCell>
   </asp:TableRow>

    <asp:TableRow>
      <asp:TableCell>Nội Dung: </asp:TableCell>
      <asp:TableCell>
         <asp:TextBox ID="news_content" runat="server" required="" />
      </asp:TableCell>
   </asp:TableRow>

    <asp:TableRow>
      <asp:TableCell>Ảnh: </asp:TableCell>
      <asp:TableCell>
         <%--<asp:TextBox ID="news_avatar" runat="server" required="" />--%>
         <asp:FileUpload ID="FileUpload1" runat="server" Width="220px" Height="27px" />
      </asp:TableCell>
   </asp:TableRow>

   <asp:TableRow>
      <asp:TableCell>Trạng thái: </asp:TableCell>
      <asp:TableCell>
		  <asp:DropDownList ID="news_status" class="ddlAdd" runat="server">
			  <asp:ListItem Value="false" Text="Đã ẩn"></asp:ListItem>
			  <asp:ListItem Value="true" Text="Đã đăng"></asp:ListItem>
		  </asp:DropDownList>
      </asp:TableCell>
   </asp:TableRow>

   <asp:TableRow>
      <asp:TableCell>Loại tin tức: </asp:TableCell>
      <asp:TableCell>
		  <asp:DropDownList ID="news_cat_id" class="ddlAdd" runat="server"></asp:DropDownList>
      </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
      <asp:TableCell></asp:TableCell>
      <asp:TableCell>
		  <asp:Button ID="btnThemTin" class="btn btn-success" runat="server" Text="Thêm tin" OnClick="btnThemTin_Click" />
      </asp:TableCell>
   </asp:TableRow>
</asp:Table>
<br />
<asp:Label ID="err_msg" class="alert alert-success" runat="server" ForeColor="Red" />
	<p></p>
</asp:Content>

