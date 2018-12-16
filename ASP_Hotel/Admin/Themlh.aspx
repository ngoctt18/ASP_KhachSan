<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="Themlh.aspx.cs" Inherits="Admin_Themlh" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Thêm Liên Hệ
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
     <asp:Table runat="server" ID="t1">
                    <asp:TableRow>
                    <asp:TableCell> fullname</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtfullname" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                    <asp:TableRow>
                    <asp:TableCell>phone</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtphone" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                 <asp:TableRow>
                    <asp:TableCell> email </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                 <asp:TableRow>
                    <asp:TableCell> massage </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtmassage" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                

            </asp:Table>
            <asp:Button ID="btnthem" runat="server" Text="Them" OnClick="btnthem_Click" />
             <asp:Button ID="btnboqua" runat="server" Text="Bo qua" />
            <p></p>
            <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label>
            <p></p>
            <asp:Button ID="bds" runat="server" PostBackUrl="~/Admin/Lienhe.aspx"  Text="Danh sach lien he" />
</asp:Content>

