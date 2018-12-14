using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_roomsEdit : System.Web.UI.Page
{
	KHDatPhong data = new KHDatPhong();
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!IsPostBack)
		{
			rooms room = (rooms)Session["room"];
			room_id.Text = room.room_id.ToString();
			room_name.Text = room.room_name;

			room_type_id.DataSource = data.getRoomTypes();
			room_type_id.DataValueField = "room_type_id";
			room_type_id.DataTextField = "room_type_name";
			DataBind();
			room_type_id.SelectedValue = room.room_type_id.ToString();
			
			room_status.Items.FindByValue(room.room_status.ToString()).Selected = true;
		}
	}

	protected void btnSuaPhong_Click(object sender, EventArgs e)
	{
		try
		{
			rooms room = new rooms();
			room.room_id = int.Parse(room_id.Text);
			room.room_name = room_name.Text;
			room.room_status = Convert.ToBoolean(room_status.SelectedValue);
			room.room_type_id = int.Parse(room_type_id.SelectedValue);

			data.updateRoom(room);

			err_msg.ForeColor = System.Drawing.Color.Green;
			err_msg.Text = "Cập nhật phòng thành công!";
		}
		catch (Exception ex)
		{
			err_msg.ForeColor = System.Drawing.Color.Red;
			err_msg.Text = "Da xay ra loi: " + ex.Message;
		}
	}
}