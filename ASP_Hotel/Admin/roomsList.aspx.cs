using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_rooms : System.Web.UI.Page
{
	KHDatPhong data = new KHDatPhong();
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!IsPostBack)
		DanhSachDatPhong();
		
	}

	private void DanhSachDatPhong()
	{
		grvDSDatPhong.DataSource = data.getAllRooms();
		DataBind();
	}

	protected void Xoa_Click(object sender, CommandEventArgs e)
	{
		if (e.CommandName == "xoa")
		{
			int room_id = Convert.ToInt16(e.CommandArgument);
			data.deleteRoom(room_id);
			DanhSachDatPhong();
		}
	}

	protected void Sua_Click(object sender, CommandEventArgs e)
	{
		if (e.CommandName == "sua")
		{
			int room_id = Convert.ToInt16(e.CommandArgument);
			rooms room = data.get1Room(room_id);
			Session["room"] = room;
			Response.Redirect("roomsEdit.aspx");
		}
	}


}