<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Dangnhap.aspx.cs" Inherits="Admin_Dangnhap" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Đăng nhập</title>
      <!-- css files -->
      <link rel="stylesheet" href="assets/css/dangnhap.css">
</head>
<body>
    <form id="form1" runat="server">
        <div class="login">
		<h1>Đăng nhập</h1>
			<asp:TextBox ID="txttentk" runat="server" placeholder="Phone" required="required"></asp:TextBox>
			
			<asp:TextBox ID="txtmatkhau" runat="server" type="password" placeholder="Password" required="required" ></asp:TextBox>
			
			<asp:Button runat="server" ID="btnlogin" class="btn btn-primary btn-block btn-large" Text="Đăng nhập" OnClick="btnlogin_Click"/>
			
			<a href="../index.aspx" class="btn btn-danger btn-block btn-large" style="margin-top: 15px;">Quay về trang chủ</a>

			<br /><br />
			<asp:Label ID="errmsg" runat="server" ForeColor="Red" Text="" />
	</div>
    </form>
</body>
</html>
