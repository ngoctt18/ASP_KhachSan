<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dangnhap.aspx.cs" Inherits="Admin_Dangnhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Đăng nhập</h2>
        <asp:Label runat="server">Tên tài khoản: </asp:Label>
        <asp:TextBox ID="txttentk" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Label runat="server">Mật khẩu: </asp:Label>
        <asp:TextBox ID="txtmatkhau" runat="server"></asp:TextBox>
        <br /><br />
        <asp:Button runat="server" ID="btnlogin" Text="Đăng nhập" Width="80px" OnClick="btnlogin_Click"/>
        <asp:Button runat="server" ID="btncancel" Text="Hủy" Width="80px" />
        <br /><br />
        <asp:Label ID="errmsg" runat="server" ForeColor="Red" Text="" />
        </div>
    </form>
</body>
</html>
