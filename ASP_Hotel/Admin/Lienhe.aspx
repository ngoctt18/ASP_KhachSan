<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="Lienhe.aspx.cs" Inherits="Admin_Lienhe" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Danh sach lien he
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
     <asp:GridView ID="grdDslh" runat="server" AutoGenerateColumns="false" class="table-bordered table" >
        <Columns>
            <asp:BoundField DataField="contact_id" HeaderText="Contact_id" />
            <asp:BoundField DataField="fullname" HeaderText="Fullname" />
            <asp:BoundField DataField="phone" HeaderText="Phone" />
            <asp:BoundField DataField="email" HeaderText="Email" />
            <asp:BoundField DataField="message" HeaderText="Message" />
           
                 <asp:TemplateField HeaderText="Chức năng">
            	<ItemTemplate>
					<asp:Button ID="xoa" class="btn btn-danger" CommandName="xoa" CommandArgument='<%#Bind("contact_id") %>'
						OnCommand="Xoa_Click" runat="server" Text="Xóa" 
						OnClientClick="return confirm('Bạn có chắc muốn xóa phòng này?')" />
				
					<asp:Button ID="sua" class="btn btn-info" CommandName="sua" CommandArgument='<%#Bind("contact_id") %>'
						OnCommand="Sua_Click" runat="server" Text="Sửa"/>
				</ItemTemplate>
			</asp:TemplateField>
        </Columns>
    </asp:GridView>
    <p></p>
</asp:Content>

