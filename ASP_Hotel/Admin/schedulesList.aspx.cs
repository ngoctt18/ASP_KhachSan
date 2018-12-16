using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_schedulesList : System.Web.UI.Page
{
    KHDatPhong data = new KHDatPhong();

	protected void Page_Load(object sender, EventArgs e)
	{
		if (!IsPostBack)
			DanhSachDatPhong();
	}

	private void DanhSachDatPhong()
	{
		grvSchedules.DataSource = data.getSchedules();
		DataBind();
	}

	protected void Xoa_Click(object sender, CommandEventArgs e)
	{
		if (e.CommandName == "xoa")
		{
			int schedule_id = Convert.ToInt16(e.CommandArgument);
			data.deleteSchedue(schedule_id);
			DanhSachDatPhong();
		}
	}

	protected void Sua_Click(object sender, CommandEventArgs e)
	{
		if (e.CommandName == "sua")
		{
			int schedule_id = Convert.ToInt16(e.CommandArgument);
			schedules schedule = data.get1Schedule(schedule_id);
			Session["schedule"] = schedule;
			Response.Redirect("schedulesEdit.aspx");
		}
	}
}