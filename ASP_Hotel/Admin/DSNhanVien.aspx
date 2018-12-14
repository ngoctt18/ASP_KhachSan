<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="DSNhanVien.aspx.cs" Inherits="Admin_DSNhanVien" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Danh Sách Nhân Viên
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
    <asp:GridView ID="grdDsnv" runat="server" AutoGenerateColumns="false" class="table-bordered table">
        <Columns>
            <asp:BoundField DataField="employee_id" HeaderText="Employee_id" />
            <asp:BoundField DataField="phone" HeaderText="Phone" />
            <asp:BoundField DataField="password" HeaderText="Password" />
            <asp:BoundField DataField="email" HeaderText="Email" />
            <asp:BoundField DataField="address" HeaderText="Address" />
            <asp:BoundField DataField="department_id" HeaderText="Department_id" />
            <asp:BoundField DataField="avatar" HeaderText="Avatar" />
            <asp:TemplateField HeaderText="Xoa">
                <ItemTemplate>
                    <asp:Button ID="xoa" CommandName="xoa" 
                        CommandArgument='<%#Bind("employee_id")%>' Text="xoa" 
                        OnCommand="Xoa_Click" runat="server"
                        OnClientClick =" return confirm (' Ban co chac chan muon xoa nhan vien nay khong?')" />
                </ItemTemplate>
               
            </asp:TemplateField>
             <asp:TemplateField HeaderText="Sua">
                <ItemTemplate>
                    <asp:Button ID="sua" CommandName="sua" 
                        CommandArgument='<%#Bind("employee_id")%>' Text="sua" 
                        OnCommand="Sua_Click" runat="server"
                         />
                </ItemTemplate>
               
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <p></p>
    <asp:Button  ID="bthem" runat="server" PostBackUrl="~/Admin/Themnv.aspx" Text="Them nhan vien"
/></asp:Content>

