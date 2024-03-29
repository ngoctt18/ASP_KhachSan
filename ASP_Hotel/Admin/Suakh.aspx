﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="Suakh.aspx.cs" Inherits="Admin_Suakh" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Sua khach hang
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
    <asp:Table runat="server" ID="t1"  class="table table-bordered">
                 <asp:TableRow>
                    <asp:TableCell> User_id</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtuser_id" runat="server" Enabled="false"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
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
                 
            </asp:Table>
            <asp:Button ID="btnsua"  class="btn btn-success" runat="server" Text="Cập Nhật" OnClick="btnsua_Click"  />
             
            <p></p>
            <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label>
            <p></p>
	<asp:Button ID="back" runat="server" class="btn btn-info" PostBackUrl="~/Admin/DSkhachhang.aspx" Text="Danh sách khách hàng" />
</asp:Content>

