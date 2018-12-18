<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="ThemNV.aspx.cs" Inherits="Admin_ThemNV" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Thêm nhân viên
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
    <asp:Table runat="server" ID="t1" class="table table-bordered">
                    <asp:TableRow>
                    <asp:TableCell> Phone</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtphone" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                    <asp:TableRow>
                    <asp:TableCell>Password</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                 <asp:TableRow>
                    <asp:TableCell> Email </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                 <asp:TableRow>
                    <asp:TableCell> Address </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtaddress" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                 <asp:TableRow>
                    <asp:TableCell> Avatar </asp:TableCell>
                    <asp:TableCell>
                        <%--<asp:TextBox ID="txtavatar" runat="server"></asp:TextBox>--%>
                        <asp:FileUpload ID="FileUpload" runat="server" Width="80px" Height="80px" />
                    </asp:TableCell>
                </asp:TableRow>
                    <asp:TableRow>
                    <asp:TableCell>Department_id</asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID ="dddepartment_id" runat="server"></asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>

            </asp:Table>
            <asp:Button ID="btnthem" class="btn btn-success" runat="server" Text="Thêm" OnClick="btnthem_Click" />
           
            <p></p>
            <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label>
            <p></p>
	<asp:Button ID="back" runat="server" class="btn btn-info" PostBackUrl="~/Admin/DSNhanVien.aspx" Text="Danh sách nhân viên" />
          
</asp:Content>

