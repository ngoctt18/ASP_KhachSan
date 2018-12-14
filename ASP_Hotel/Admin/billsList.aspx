<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="billsList.aspx.cs" Inherits="Admin_billsList" %>

<asp:Content ID="title" ContentPlaceHolderID="title" Runat="Server">
	Danh sách hóa đơn
</asp:Content>
<asp:Content ID="tableTable" ContentPlaceHolderID="contentTable" Runat="Server">
	<h2>Danh sách hóa đơn</h2>
	<asp:Button ID="btnBills1" class="float-right btn btn-primary marL15" runat="server" Text="DS hóa đơn đã thanh toán" PostBackUrl="~/Admin/billsList1.aspx" />
	<asp:Button ID="btnBills0" class="float-right btn btn-success " runat="server" Text="DS hóa đơn" PostBackUrl="~/Admin/billsList.aspx" />
	<br />
	<br />	
	<asp:GridView class="table table-bordered" ID="grvDSHoaDon" runat="server" AutoGenerateColumns="False"> 
		<Columns>
			<asp:BoundField DataField="bill_id" HeaderText="Mã HĐ" />
			<asp:BoundField DataField="schedule_id" HeaderText="Mã đặt phòng" />
			<asp:BoundField DataField="fullname" HeaderText="Tên KH" />
			<asp:BoundField DataField="num_day" HeaderText="Số ngày thuê" />
			<asp:BoundField DataField="price_room" HeaderText="Tiền phòng" />
			<asp:BoundField DataField="price_service" HeaderText="Tiền dịch vụ" />
			<asp:BoundField DataField="total_price" HeaderText="Tổng tiền" />
			<%--<asp:BoundField DataField="getBill_status" HeaderText="Trạng thái" />--%>
			<asp:TemplateField HeaderText="Thanh toán">
				<ItemTemplate>
					<asp:Button ID="ThanhToan" class="btn btn-info" CommandName="ThanhToan" CommandArgument='<%#Bind("bill_id") %>'
						OnCommand="ThanhToan_Click" runat="server" Text="Thanh toán" 
						OnClientClick="return confirm('Bạn có muốn thanh toán hóa đơn này?')" />
				</ItemTemplate>
			</asp:TemplateField>
		</Columns>
	</asp:GridView>
</asp:Content>

