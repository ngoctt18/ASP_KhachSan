<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/MasterPageAdmin.master" AutoEventWireup="true" CodeFile="Orders.aspx.cs" Inherits="Admin_Orders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="title" Runat="Server">
    Danh sách đặt dịch vụ của khách
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="contentTable" Runat="Server">
    <h2>Danh sách đặt dịch vụ của khách</h2>
    <p>Chọn phòng:
    <asp:DropDownList ID="drporders" runat="server" class="ddlAdd"></asp:DropDownList>
    <asp:Button ID="btnhienthiorders" runat="server" class="btn btn-info" Text="Hiển thị" OnClick="btnhienthiorders_Click" />
    <asp:Button runat="server" class="btn btn-success" Text="Danh sách dịch vụ đã hoàn thành" PostBackUrl="~/Admin/Orders_done.aspx" />
    </p>
    <asp:GridView class="table table-bordered" AutoGenerateColumns="false" ID="grdOrderlistAdmin" runat="server">
        <Columns>
            <asp:BoundField DataField="order_id" HeaderText="ID" />
            <asp:BoundField DataField="service_name" HeaderText="Tên dịch vụ" />
            <asp:BoundField DataField="quantity" HeaderText="Số lượng" />
            <asp:BoundField DataField="order_price" HeaderText="Đơn giá" />
            <asp:TemplateField HeaderText="Xác nhận">
                <ItemTemplate>
                    <asp:Button runat="server" class="btn btn-success" ID="btnodered" CommandName="btnorderred" CommandArgument='<%#Bind("order_id") %>' Text="Hoàn thành" OnCommand="btnodered_Command1" OnClientClick="return confirm('Đã hoàn thành yêu cầu của khách ?')" />
                 </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>

