<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Suanv1.aspx.cs" Inherits="Admin_Suanv" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <h2>Sua Nhan Vien </h2>
             <asp:Table runat="server" ID="t1">
                  <asp:TableRow>
                    <asp:TableCell> employee_id</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtemployee_id" runat="server" Enabled="false"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell> phone</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtphone" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                    <asp:TableRow>
                    <asp:TableCell>password</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                 <asp:TableRow>
                    <asp:TableCell> email </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                 <asp:TableRow>
                    <asp:TableCell> address </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtaddress" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                 <asp:TableRow>
                    <asp:TableCell> avatar </asp:TableCell>
                    <asp:TableCell>
                        <%--<asp:TextBox ID="txtavatar" runat="server"></asp:TextBox>--%>
                        <asp:Image ID="avatar" runat="server" ImageUrl="" />
                        <asp:FileUpload ID="FileUpload" runat="server" Width="80px" Height="80px" />
                    </asp:TableCell>
                </asp:TableRow>
                    <asp:TableRow>
                    <asp:TableCell>department_id</asp:TableCell>
                    <asp:TableCell>
                        <asp:DropDownList ID ="dddepartment_id" runat="server"></asp:DropDownList>
                    </asp:TableCell>
                </asp:TableRow>

            </asp:Table>
            <asp:Button ID="btnsua" runat="server" Text="Cap nhat" OnClick="btnsua_Click"  />
             <asp:Button ID="btnboqua" runat="server" Text="Bo qua" />
            <p></p>
            <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label>
            <p></p>
            <asp:Button ID="bds" runat="server" PostBackUrl="~/Admin/DSNhanVien.aspx"  Text="Danh sach nhan vien" />
        </div>
    
    </form>
</body>
</html>
