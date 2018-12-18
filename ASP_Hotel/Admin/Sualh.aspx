<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="Sualh.aspx.cs" Inherits="Admin_Sualh" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Sửa liên hệ
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
    <asp:Table runat="server" ID="t1"  class="table table-bordered">
                 <asp:TableRow>
                    <asp:TableCell> Contact_id</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtcontact_id" runat="server" Enabled="false"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell> Fullname</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtfullname" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                    <asp:TableRow>
                    <asp:TableCell>Phone</asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtphone" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                 <asp:TableRow>
                    <asp:TableCell> Email </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                 <asp:TableRow>
                    <asp:TableCell> Message </asp:TableCell>
                    <asp:TableCell>
                        <asp:TextBox ID="txtmessage" runat="server"></asp:TextBox>
                    </asp:TableCell>
                </asp:TableRow>
                 
            </asp:Table>
            <asp:Button ID="btnsua"  class="btn btn-success" runat="server" Text="Cập Nhật" OnClick="btnsua_Click"  />
             
            <p></p>
            <asp:Label ID="msg" runat="server" ForeColor="Red"></asp:Label>
            <p></p>
</asp:Content>

