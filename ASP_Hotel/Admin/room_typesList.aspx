<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="room_typesList.aspx.cs" Inherits="Admin_room_typesList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Danh sách loại phòng
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
    <h2>Danh sách loại phòng</h2>
    <asp:GridView class="table table-bordered" runat="server" ID="grdroom_types" AutoGenerateColumns="false">
        <Columns>
            <asp:BoundField DataField="room_type_id" HeaderText="ID" />
            <asp:BoundField DataField="room_type_name" HeaderText="Tên loại phòng" />

            <asp:TemplateField HeaderText="Xóa">
                <ItemTemplate>
                    <asp:Button class="btn btn-danger" ID="xoa" CommandName="xoa" CommandArgument='<%#Bind("room_type_id") %>' Text="Xóa" OnCommand="Xoa_Click" runat="server" OnClientClick="return confirm('Bạn Chắc chắn xóa ?')"/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:templatefield headertext="Cập nhật">
                <itemtemplate>
                    <asp:button class="btn btn-info" id="sua" commandname="sua" commandargument='<%#Bind("room_type_id") %>' text="cập nhật" oncommand="Sua_Click" runat="server" />
                </itemtemplate>
            </asp:templatefield>
        </Columns>
    </asp:GridView>
    <br />
    <asp:Button ID="addroom_types" class="btn btn-success" runat="server" Text="Thêm loại phòng" PostBackUrl="~/Admin/room_typesAdd.aspx" />
</asp:Content>

