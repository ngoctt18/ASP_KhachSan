<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="DSNhanVien.aspx.cs" Inherits="Admin_DSNhanVien" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Danh Sách Nhân Viên
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
	<h2>Danh Sách Nhân Viên</h2>
    <asp:GridView ID="grdDsnv" runat="server" AutoGenerateColumns="false" class="table-bordered table">
        <Columns>
            <asp:BoundField DataField="employee_id" HeaderText="Employee_id" />
            <asp:BoundField DataField="phone" HeaderText="Phone" />
            <asp:BoundField DataField="password" HeaderText="Password" />
            <asp:BoundField DataField="email" HeaderText="Email" />
            <asp:BoundField DataField="address" HeaderText="Address" />
            <asp:BoundField DataField="department_id" HeaderText="Department_id" />
           <%-- <asp:BoundField DataField="avatar" HeaderText="Avatar" />--%>
          <asp:TemplateField runat="server" HeaderText="Anh">
              <ItemTemplate>
                  <asp:Image ID="img" runat="server" ImageUrl='<%# "images/" +Eval("avatar")  %>' Width="80px" Height="80px" />
              </ItemTemplate>
          </asp:TemplateField>
            <asp:TemplateField HeaderText="Chức năng">
            	<ItemTemplate>
					<asp:Button ID="xoa" class="btn btn-danger" CommandName="xoa" CommandArgument='<%#Bind("employee_id") %>'
						OnCommand="Xoa_Click" runat="server" Text="Xóa" 
						OnClientClick="return confirm('Bạn có chắc muốn xóa phòng này?')" />
				
					<asp:Button ID="sua" class="btn btn-info" CommandName="sua" CommandArgument='<%#Bind("employee_id") %>'
						OnCommand="Sua_Click" runat="server" Text="Sửa"/>
				</ItemTemplate>
			</asp:TemplateField>
        </Columns>
    </asp:GridView>
    <p></p>
    <asp:Button class="btn btn-success" ID="bthem" runat="server" PostBackUrl="~/Admin/Themnv.aspx" Text="Thêm Nhân Viên"/>
</asp:Content>

