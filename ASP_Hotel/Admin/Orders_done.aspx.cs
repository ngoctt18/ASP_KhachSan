using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Orders_done : System.Web.UI.Page
{
    OrderServices ord = new OrderServices();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            drporderdone.DataSource = ord.getRoom_namefordrp();
            drporderdone.DataValueField = "schedule_id";
            drporderdone.DataTextField = "room_name";
            DataBind();
        }
    }
    public void hienthi()
    {
        var schedule_id = int.Parse(drporderdone.SelectedValue);
        grdOrderdonelistAdmin.DataSource = ord.getOrderdone(schedule_id);
        DataBind();
    }
    protected void btnhienthiorderdone_Click(object sender, EventArgs e)
    {
        hienthi();
    }
}