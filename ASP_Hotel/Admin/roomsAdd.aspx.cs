using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_roomsAdd : System.Web.UI.Page
{
	KHDatPhong data = new KHDatPhong();
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!IsPostBack)
		{
			room_type_id.DataSource = data.getRoomTypes();
			room_type_id.DataTextField = "room_type_name";
			room_type_id.DataValueField = "room_type_id";
			DataBind();
		}
	}

	protected void btnThemPhong_Click(object sender, EventArgs e)
	{
		
	}
}