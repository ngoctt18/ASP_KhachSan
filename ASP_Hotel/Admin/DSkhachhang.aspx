<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="DSkhachhang.aspx.cs" Inherits="DSkhachhang" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Danh sách khách hàng
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
	<h2>Danh sách khách hàng</h2>
    <asp:GridView ID="grdDskh" runat="server" AutoGenerateColumns="false" class="table-bordered table" >
        <Columns>
            <asp:BoundField DataField="user_id" HeaderText="User_id" />
            <asp:BoundField DataField="phone" HeaderText="Phone" />
            <asp:BoundField DataField="password" HeaderText="Password" />
            <asp:BoundField DataField="email" HeaderText="Email" />
            <asp:BoundField DataField="address" HeaderText="Address" />
           
                 <asp:TemplateField HeaderText="Chức năng">
            	<ItemTemplate>
					<asp:Button ID="xoa" class="btn btn-danger" CommandName="xoa" CommandArgument='<%#Bind("user_id") %>'
						OnCommand="Xoa_Click" runat="server" Text="Xóa" 
						OnClientClick="return confirm('Bạn có chắc muốn xóa phòng này?')" />
				
					<asp:Button ID="sua" class="btn btn-info" CommandName="sua" CommandArgument='<%#Bind("user_id") %>'
						OnCommand="Sua_Click" runat="server" Text="Sửa"/>
				</ItemTemplate>
			</asp:TemplateField>
        </Columns>
    </asp:GridView>
    <p></p>
    <asp:Button class="btn btn-success" ID="bthem" runat="server" PostBackUrl="~/Admin/Themkh.aspx" Text="Thêm Khách Hàng" />
</asp:Content>

