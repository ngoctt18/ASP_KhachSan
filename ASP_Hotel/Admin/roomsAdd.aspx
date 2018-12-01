<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="roomsAdd.aspx.cs" Inherits="Admin_roomsAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
	Thêm phòng
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
<asp:Table ID="tableThemSV" runat="server" class="table table-bordered">
   <asp:TableRow>
      <asp:TableCell>Tên phòng: </asp:TableCell>
      <asp:TableCell>
         <asp:TextBox ID="room_name" runat="server" />
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
         <asp:Button ID="btnThemPhong" runat="server" Text="Thêm phòng" />
      </asp:TableCell>
   </asp:TableRow>
</asp:Table>
<br />
<asp:Label ID="err_msg" runat="server" ForeColor="Red" />
</asp:Content>

