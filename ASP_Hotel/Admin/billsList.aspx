<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="billsList.aspx.cs" Inherits="Admin_billsList" %>

<asp:Content ID="title" ContentPlaceHolderID="title" Runat="Server">
	Danh sách hóa đơn
</asp:Content>
<asp:Content ID="tableTable" ContentPlaceHolderID="contentTable" Runat="Server">
	<asp:GridView class="table table-bordered" ID="grvDSHoaDon" runat="server" AutoGenerateColumns="False"> 
		<Columns>
			<asp:BoundField DataField="bill_id" HeaderText="Mã hóa đơn" />
			<asp:BoundField DataField="schedule_id" HeaderText="Mã đặt phòng" />
			<asp:BoundField DataField="num_day" HeaderText="Số ngày thuê" />
			<asp:BoundField DataField="price_room" HeaderText="Tiền phòng" />
			<asp:BoundField DataField="price_service" HeaderText="Tiền dịch vụ" />
			<asp:BoundField DataField="total_price" HeaderText="Tổng tiền" />
			<asp:BoundField DataField="getBill_status" HeaderText="Trạng thái" />
		</Columns>
	</asp:GridView>
</asp:Content>

