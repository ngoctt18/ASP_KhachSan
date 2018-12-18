<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="Thembp.aspx.cs" Inherits="Admin_Thembp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Thêm bộ phận
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
    <asp:Table runat="server" ID="t1" class="table table-bordered">
    <asp:TableRow>
                    <asp:TableCell> Department_name</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtdepartment_name" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
        </asp:Table>
    <asp:Button ID="btnthem" runat="server"  class="btn btn-success" Text="Thêm" OnClick="btnthem_Click" />
            
            <p></p>
            <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label>
            <p></p>
	<asp:Button ID="back" runat="server" class="btn btn-info" PostBackUrl="~/Admin/DSbophan.aspx" Text="Danh sách bộ phận" />
</asp:Content>

