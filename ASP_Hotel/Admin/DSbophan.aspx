<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="DSbophan.aspx.cs" Inherits="Admin_DSbophan" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Danh sách bộ phận
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
    <asp:GridView ID="grdDsbp" runat="server" AutoGenerateColumns="false" class="table-bordered table" >
        <Columns>
            <asp:BoundField DataField="department_id" HeaderText="Department_id" />
            <asp:BoundField DataField="department_name" HeaderText="Department_name" />
          
           
                 <asp:TemplateField HeaderText="Chức năng">
            	<ItemTemplate>
					<asp:Button ID="xoa" class="btn btn-danger" CommandName="xoa" CommandArgument='<%#Bind("department_id") %>'
						OnCommand="Xoa_Click" runat="server" Text="Xóa" 
						OnClientClick="return confirm('Bạn có chắc muốn xóa phòng này?')" />
				
					<asp:Button ID="sua" class="btn btn-info" CommandName="sua" CommandArgument='<%#Bind("department_id") %>'
						OnCommand="Sua_Click" runat="server" Text="Sửa"/>
				</ItemTemplate>
			</asp:TemplateField>
        </Columns>
    </asp:GridView>
    <p></p>
    <asp:Button class="btn btn-success" ID="bthem" runat="server" PostBackUrl="~/Admin/Thembp.aspx" Text="Thêm bộ phận" />
</asp:Content>

