using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_schedulesEdit : System.Web.UI.Page
{
	KHDatPhong data = new KHDatPhong();
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!IsPostBack)
		{
			schedules schedule = (schedules)Session["schedule"];
			schedule_id.Text = schedule.schedule_id.ToString();
			fullname.Text = schedule.fullname;
			phone.Text = schedule.phone;
			email.Text = schedule.email;

			date_in.Text = schedule.date_in.ToString("yyyy-MM-dd");
			date_out.Text = schedule.date_out.ToString("yyyy-MM-dd");


			room_id.DataSource = data.getAllRooms();
			room_id.DataValueField = "room_id";
			room_id.DataTextField = "room_name";
			DataBind();
			room_id.SelectedValue = schedule.room_id.ToString();
			old_room_id.Text = schedule.room_id.ToString();
		}
	}
	protected void btnSuaDatPhong_Click(object sender, EventArgs e)
	{
		try
		{
			schedules schedule = new schedules();
			schedule.schedule_id = int.Parse(schedule_id.Text);
			schedule.fullname = fullname.Text;
			schedule.phone = phone.Text;
			schedule.email = email.Text;
			schedule.date_in = DateTime.Parse(date_in.Text);
			schedule.date_out = DateTime.Parse(date_out.Text);
			schedule.room_id = int.Parse(room_id.Text);

			data.updateSchedule(schedule);
			// Cập nhật room_status phòng vừa đặt là 1 (Đã dùng)
			data.updateRoomUsed(schedule.room_id);

			err_msg.ForeColor = System.Drawing.Color.Green;
			err_msg.Text = "Cập nhật đặt phòng thành công!";
		}
		catch (Exception ex)
		{
			err_msg.ForeColor = System.Drawing.Color.Red;
			err_msg.Text = "Da xay ra loi: " + ex.Message;
		}
	}
}