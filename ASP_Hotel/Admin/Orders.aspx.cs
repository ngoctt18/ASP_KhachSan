using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Orders : System.Web.UI.Page
{
    OrderServices ord = new OrderServices();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            hienthi();
        }
    }
    public void hienthi()
    {
        grdOrderlistAdmin.DataSource = ord.getOrder();
        DataBind();
    }

    protected void btnodered_Command1(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "btnorderred")
        {
            int x = Convert.ToInt16(e.CommandArgument);
            ord.deleteOrder(x);
            hienthi();
        }
    }
}