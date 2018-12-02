<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="schedulesList.aspx.cs" Inherits="Admin_schedulesList" %>

<asp:Content ID="title" ContentPlaceHolderID="title" Runat="Server">
	Danh sách đặt phòng
</asp:Content>
<asp:Content ID="contentTable" ContentPlaceHolderID="contentTable" Runat="Server">
		<asp:GridView class="table table-bordered" ID="grvSchedules" runat="server" AutoGenerateColumns="False"> 
		<Columns>
			<asp:BoundField DataField="schedule_id" HeaderText="Mã đặt phòng" />
			<asp:BoundField DataField="fullname" HeaderText="Họ và tên" />
			<asp:BoundField DataField="phone" HeaderText="Điện thoại" />
			<asp:BoundField DataField="email" HeaderText="Email" />
			<asp:BoundField DataField="room_name" HeaderText="Tên phòng" />
			<asp:BoundField DataField="date_in" HeaderText="Ngày đặt phòng" />
			<asp:BoundField DataField="date_out" HeaderText="Ngày trả phòng" />
			<asp:BoundField DataField="schedule_status" HeaderText="Trạng thái" />
		</Columns>
	</asp:GridView>
</asp:Content>

