<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="schedulesList.aspx.cs" Inherits="Admin_schedulesList" %>

<asp:Content ID="title" ContentPlaceHolderID="title" Runat="Server">
	Danh sách đặt phòng
</asp:Content>
<asp:Content ID="contentTable" ContentPlaceHolderID="contentTable" Runat="Server">
	<h2>Danh sách đặt phòng</h2>
		<asp:Button ID="btnSchedules1" class="float-right btn btn-primary marL15" runat="server" Text="DS đặt phòng đã trả" PostBackUrl="~/Admin/schedulesList1.aspx" />
		<asp:Button ID="btnSchedules0" class="float-right btn btn-success " runat="server" Text="DS đặt phòng" PostBackUrl="~/Admin/schedulesList.aspx" />
		<br />
		<br />	
		<asp:GridView class="table table-bordered" ID="grvSchedules" runat="server" AutoGenerateColumns="False"> 
		<Columns>
			<asp:BoundField DataField="schedule_id" HeaderText="Mã đặt phòng" />
			<asp:BoundField DataField="fullname" HeaderText="Họ và tên" />
			<asp:BoundField DataField="phone" HeaderText="Điện thoại" />
			<asp:BoundField DataField="email" HeaderText="Email" />
			<asp:BoundField DataField="room_name" HeaderText="Tên phòng" />
			<asp:BoundField DataField="getDate_in" HeaderText="Ngày đặt phòng" />
			<asp:BoundField DataField="getDate_out" HeaderText="Ngày trả phòng" />
			<asp:BoundField DataField="getSchedule_status" HeaderText="Trạng thái" />
			<asp:TemplateField HeaderText="Chức năng">
				<ItemTemplate>
					<asp:Button ID="xoa" class="btn btn-danger" CommandName="xoa" CommandArgument='<%#Bind("schedule_id") %>'
						OnCommand="Xoa_Click" runat="server" Text="Xóa" 
						OnClientClick="return confirm('Bạn có chắc muốn xóa đặt phòng này?')" />
				
					<asp:Button ID="sua" class="btn btn-info marT10" CommandName="sua" CommandArgument='<%#Bind("schedule_id") %>'
						OnCommand="Sua_Click" runat="server" Text="Sửa"/>
				</ItemTemplate>
			</asp:TemplateField>
		</Columns>
	</asp:GridView>
</asp:Content>

