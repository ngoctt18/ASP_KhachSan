<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="Suabp.aspx.cs" Inherits="Admin_Suabp" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Sửa bộ phận
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
    <asp:Table runat="server" ID="t1">
                 <asp:TableRow>
                    <asp:TableCell> department_id</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtdeparment_id" runat="server" Enabled="false"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell> department_name</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtdepartment_name" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                   
            </asp:Table>
            <asp:Button ID="btnsua" runat="server" Text="Cap nhat" OnClick="btnsua_Click"  />
             <asp:Button ID="btnboqua" runat="server" Text="Bo qua" />
            <p></p>
            <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label>
            <p></p>
            <asp:Button ID="bds" runat="server" PostBackUrl="~/Admin/DSbophan.aspx"  Text="Danh sách bộ phận" />
</asp:Content>

