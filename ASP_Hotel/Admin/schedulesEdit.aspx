<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="schedulesEdit.aspx.cs" Inherits="Admin_schedulesEdit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
	Cập nhật thông tin đặt phòng
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
	<h2>Cập nhật thông tin đặt phòng</h2>
	<asp:Table ID="tableThemSV" runat="server" class="table table-bordered">
      <asp:TableRow>
         <asp:TableCell>Mã đặt phòng: </asp:TableCell>
         <asp:TableCell>
            <asp:TextBox ID="schedule_id" Enabled="false" runat="server" />
         </asp:TableCell>
      </asp:TableRow>
      <asp:TableRow>
         <asp:TableCell>Họ và tên: </asp:TableCell>
         <asp:TableCell>
            <asp:TextBox ID="fullname" runat="server" required="" />
         </asp:TableCell>
      </asp:TableRow>
      <asp:TableRow>
         <asp:TableCell>Số điện thoại: </asp:TableCell>
         <asp:TableCell>
            <asp:TextBox ID="phone" runat="server" required="" />
         </asp:TableCell>
      </asp:TableRow>
      <asp:TableRow>
         <asp:TableCell>Email: </asp:TableCell>
         <asp:TableCell>
            <asp:TextBox ID="email" runat="server" required="" />
         </asp:TableCell>
      </asp:TableRow>
      <asp:TableRow>
         <asp:TableCell>Chọn phòng: </asp:TableCell>
         <asp:TableCell>
            <asp:DropDownList class="ddlAdd" ID="room_id" runat="server"></asp:DropDownList>
            <asp:TextBox ID="old_room_id" runat="server"  />
         </asp:TableCell>
      </asp:TableRow>
      <asp:TableRow>
         <asp:TableCell>Ngày đặt phòng: </asp:TableCell>
         <asp:TableCell>
            <asp:TextBox ID="date_in" runat="server" type="date" required="" />
         </asp:TableCell>
      </asp:TableRow>
      <asp:TableRow>
         <asp:TableCell>Ngày trả phòng: </asp:TableCell>
         <asp:TableCell>
            <asp:TextBox ID="date_out" runat="server" type="date" required="" />
         </asp:TableCell>
      </asp:TableRow>
   <asp:TableRow>
      <asp:TableCell></asp:TableCell>
      <asp:TableCell>
		  <asp:Button ID="btnSuaDatPhong" class="btn btn-success" runat="server" Text="Cập nhật" OnClick="btnSuaDatPhong_Click" />
      </asp:TableCell>
   </asp:TableRow>
   </asp:Table>
   <br />
<asp:Label ID="err_msg" class="alert alert-success" runat="server"/>
   <p></p>
</asp:Content>

