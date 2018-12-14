<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="Services.aspx.cs" Inherits="Admin_Services" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Quản lí dịch vụ
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
    <h2>Danh sách dịch vụ</h2>
    <br />
    <p>
        Chọn danh mục:
    <asp:DropDownList class=ddlAdd ID="drpcategory" runat="server" OnSelectedIndexChanged="drpcategory_SelectedIndexChanged">

    </asp:DropDownList>
    
    <asp:Button ID="btnhienthi" class="btn btn-info" runat="server" OnClick="btnhienthi_Click" Text="Hiển thị" />
    <asp:Button runat="server" class="btn btn-success" Text="Thêm dịch vụ" PostBackUrl="~/Admin/addService.aspx" />
    </p>
    <br />
    <asp:GridView ID="grdservices" runat="server" AutoGenerateColumns="false" class="table table-bordered">
        <Columns>
            <asp:BoundField DataField="service_id" HeaderText="ID" />
            <asp:BoundField DataField="service_name" HeaderText="Tên dịch vụ" />
            <asp:BoundField DataField="price" HeaderText="Giá" />
            <asp:BoundField DataField="cat_name" HeaderText="Danh mục" />
            <asp:BoundField DataField="service_description" HeaderText="Mô tả" />
            <asp:TemplateField HeaderText="Xóa">
                <ItemTemplate>
                    <asp:Button class="btn btn-danger" ID="deleteservices" CommandName="deleteservices" CommandArgument='<%#Bind("service_id") %>' Text="Xóa" OnCommand="deleteservices_Command" runat="server" OnClientClick="return confirm('Chắc chắn xóa ?')"/>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField HeaderText="Sửa">
                <ItemTemplate>
                    <asp:Button class="btn btn-info" ID="updateservices" CommandName="updateservices" CommandArgument='<%#Bind("service_id") %>' Text="Cập nhật" OnCommand="updateservices_Command" runat="server" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>

