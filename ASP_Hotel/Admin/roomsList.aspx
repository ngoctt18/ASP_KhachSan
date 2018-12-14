<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="roomsList.aspx.cs" Inherits="Admin_rooms" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
	Quản lý phòng
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
	<h2>Quản lý phòng</h2>
	<asp:GridView class="table table-bordered" ID="grvDSDatPhong" runat="server" AutoGenerateColumns="False"> 
		<Columns>
			<asp:BoundField DataField="room_id" HeaderText="Mã phòng" />
			<asp:BoundField DataField="room_name" HeaderText="Tên phòng" />
			<asp:BoundField DataField="getRoom_status" HeaderText="Trạng thái" />
			<asp:BoundField DataField="room_type_name" HeaderText="Loại phòng" />
			<asp:TemplateField HeaderText="Chức năng">
				<ItemTemplate>
					<asp:Button ID="xoa" class="btn btn-danger" CommandName="xoa" CommandArgument='<%#Bind("room_id") %>'
						OnCommand="Xoa_Click" runat="server" Text="Xóa" 
						OnClientClick="return confirm('Bạn có chắc muốn xóa phòng này?')" />
				
					<asp:Button ID="sua" class="btn btn-info" CommandName="sua" CommandArgument='<%#Bind("room_id") %>'
						OnCommand="Sua_Click" runat="server" Text="Sửa"/>
				</ItemTemplate>
			</asp:TemplateField>
		</Columns>
	</asp:GridView>
	<p></p>
	<asp:Button ID="btnRoomAdd" class="float-right btn btn-success" runat="server" Text="Thêm phòng" PostBackUrl="~/Admin/roomsAdd.aspx" />
</asp:Content>



