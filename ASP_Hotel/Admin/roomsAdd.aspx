<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="roomsAdd.aspx.cs" Inherits="Admin_roomsAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
	Thêm phòng
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
	<h2>Thêm phòng</h2>
<asp:Table ID="tableThemSV" runat="server" class="table table-bordered">
   <asp:TableRow>
      <asp:TableCell>Tên phòng: </asp:TableCell>
      <asp:TableCell>
         <asp:TextBox ID="room_name" runat="server" required="" />
      </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
      <asp:TableCell>Trạng thái: </asp:TableCell>
      <asp:TableCell>
		  <asp:DropDownList ID="room_status" class="ddlAdd" runat="server">
			  <asp:ListItem Value="false" Text="Còn trống"></asp:ListItem>
			  <asp:ListItem Value="true" Text="Đã thuê"></asp:ListItem>
		  </asp:DropDownList>
      </asp:TableCell>
   </asp:TableRow>
   <asp:TableRow>
      <asp:TableCell>Loại phòng: </asp:TableCell>
      <asp:TableCell>
		  <asp:DropDownList ID="room_type_id" class="ddlAdd" runat="server"></asp:DropDownList>
      </asp:TableCell>
   </asp:TableRow>

   <asp:TableRow>
      <asp:TableCell></asp:TableCell>
      <asp:TableCell>
		  <asp:Button ID="btnThemPhong" class="btn btn-success" runat="server" Text="Thêm phòng" OnClick="btnThemPhong_Click1" />
      </asp:TableCell>
   </asp:TableRow>
</asp:Table>
<br />
<asp:Label ID="err_msg" class="alert alert-success" runat="server" ForeColor="Red" />
	<p></p>
</asp:Content>

