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


	protected void btnThemPhong_Click1(object sender, EventArgs e)
	{
		try
		{
			rooms room = new rooms();
			room.room_name = room_name.Text;
			room.room_status = Convert.ToBoolean(room_status.SelectedValue);
			room.room_type_id = Convert.ToInt32(room_type_id.SelectedValue);

			data.createRoom(room);

			err_msg.ForeColor = System.Drawing.Color.Green;
			err_msg.Text = "Thêm phòng thành công!";
		}
		catch (Exception ex)
		{
			err_msg.ForeColor = System.Drawing.Color.Red;
			err_msg.Text = "Đã xảy ra lỗi: " + ex.Message;
		}
	}
}