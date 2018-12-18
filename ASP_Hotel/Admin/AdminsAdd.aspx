<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="AdminsAdd.aspx.cs" Inherits="Admin_AdminsAdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Thêm Admin
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
        <h2>Thêm admin</h2>
    <asp:Table runat="server" ID="t1" class="table table-bordered">
        <asp:TableRow>
            <asp:TableCell>Phone</asp:TableCell>
            <asp:TableCell><asp:TextBox ID="txtphone" runat="server" required=""/></asp:TableCell></asp:TableRow><asp:TableRow>
            <asp:TableCell>Password</asp:TableCell><asp:TableCell><asp:TextBox ID="txtpassword" runat="server" required=""/></asp:TableCell></asp:TableRow><asp:TableRow>
            <asp:TableCell>Email</asp:TableCell><asp:TableCell><asp:TextBox ID="txtemail" runat="server" required=""/></asp:TableCell></asp:TableRow><asp:TableRow>
            <asp:TableCell>Address</asp:TableCell><asp:TableCell><asp:TextBox ID="txtaddress" runat="server" required=""/></asp:TableCell></asp:TableRow><asp:TableRow>
            <asp:TableCell>Avatar</asp:TableCell><asp:TableCell>
                <%--<asp:TextBox ID="txtavartar" runat="server"/>--%>
                <asp:FileUpload ID="FileUpload3" runat="server" Width="220px" Height="27px" />

             </asp:TableCell></asp:TableRow></asp:Table>
       <asp:TableRow>
      <asp:TableCell>
		  <asp:Button ID="btnThem" class="btn btn-success" runat="server" Text="Thêm" OnClick="btnThem_Click" />
      </asp:TableCell>
     </asp:TableRow>
    <%--<asp:Button ID="btnBoqua" runat="server" Text="Bỏ qua" PostBackUrl="~/Admin/AdminsList.aspx"/>--%>
    <p></p>
    <asp:Label ID="msg" runat="server" ForeColor="Red" />
</asp:Content>

