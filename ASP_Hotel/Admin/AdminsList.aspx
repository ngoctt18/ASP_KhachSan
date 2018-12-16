<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="AdminsList.aspx.cs" Inherits="Admin_AdminList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Quản lí tài khoản admin
</asp:Content> 
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
        <h2>Danh sách admin</h2>
            <asp:GridView ID="grdDs" runat="server" AutoGenerateColumns="false" class="table table-bordered" >
                <Columns>
                    <asp:BoundField DataField="admin_id" HeaderText="Mã quản trị viên" />
                    <asp:BoundField DataField="phone" HeaderText="Số điện thoại" />
                    <asp:BoundField DataField="password" HeaderText="Mật khẩu" />
                    <asp:BoundField DataField="email" HeaderText="Email" />
                    <asp:BoundField DataField="address" HeaderText="Địa chỉ" />
                    <%--<asp:BoundField DataField="avatar" HeaderText="Ảnh" />--%>
                    <asp:TemplateField runat="server" HeaderText="Ảnh">
                                    <ItemTemplate>
                                        <asp:Image ID="img" runat="server" ImageUrl='<%# "images/"+Eval("avatar") %>' Width="80px" Height="80px"/>
                                    </ItemTemplate>
                    </asp:TemplateField>
             <asp:TemplateField HeaderText="Chức năng">
				<ItemTemplate>
					<asp:Button ID="xoa" class="btn btn-danger" CommandName="xoa" CommandArgument='<%#Bind("admin_id") %>'
						OnCommand="Xoa_Click" runat="server" Text="Xóa" 
						OnClientClick="return confirm('Bạn có chắc muốn xóa phòng này?')" />
				
					<asp:Button ID="sua" class="btn btn-info" CommandName="sua" CommandArgument='<%#Bind("admin_id") %>'
						OnCommand="Sua_Click" runat="server" Text="Sửa"/>
				</ItemTemplate>
			</asp:TemplateField>
                </Columns>
            </asp:GridView>
    <p></p>
	<asp:Button ID="btnThem" class="float-right btn btn-success" runat="server" Text="Thêm Admin" PostBackUrl="~/Admin/AdminsAdd.aspx" />
</asp:Content>

