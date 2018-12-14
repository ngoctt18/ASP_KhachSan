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
		if (!IsPostBack)
		{

			drporders.DataSource = ord.getRoom_namefordrp();
			drporders.DataValueField = "schedule_id";
			drporders.DataTextField = "room_name";
			DataBind();
		}
	}
	public void hienthi()
	{
		var schedule_id = int.Parse(drporders.SelectedValue);
		grdOrderlistAdmin.DataSource = ord.getOrder(schedule_id);
		DataBind();
	}

	protected void btnodered_Command1(object sender, CommandEventArgs e)
	{
		if (e.CommandName == "btnorderred")
		{
			int x = Convert.ToInt16(e.CommandArgument);
			ord.updateOrder(x);
			hienthi();
		}
	}
	protected void btnhienthiorders_Click(object sender, EventArgs e)
	{
		hienthi();
	}
}