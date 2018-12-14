using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
	KHDatPhong data = new KHDatPhong();
	protected void Page_Load(object sender, EventArgs e)
	{
		RandomSlide();
		if (!IsPostBack)
		{
			category.DataSource = data.getEmptyRooms();
			category.DataTextField = "room_name";
			category.DataValueField = "room_id";
			DataBind();
		}
	}

	protected void Timer1_Tick(object sender, EventArgs e)
	{
		RandomSlide();
	}

	private void RandomSlide()
	{
		Random r = new Random();
		int n = r.Next(1, 5);
		imgSlide.ImageUrl = "assets/images/ban" + n + ".jpg";
	}

	protected void btn_BookRoom_Click(object sender, EventArgs e)
	{
		try
		{
			schedules schedule = new schedules();
			schedule.fullname = txtFullname.Text;
			schedule.phone = txtPhone.Text;
			schedule.email = txtEmail.Text;
			schedule.date_in = DateTime.Parse(txtDateIn.Text);
			schedule.date_out = DateTime.Parse(txtDateOut.Text);
			schedule.room_id = int.Parse(category.Text);

			DateTime DateIn = (schedule.date_in);
			DateTime DateOut = (schedule.date_out);
			TimeSpan tmp_day = DateOut.Subtract(DateIn);
			double num_day = tmp_day.TotalDays + 1;


			// Thêm đặt phòng
			Int32 schedule_id = data.ThemDatPhong(schedule);

			// Cập nhật room_status phòng vừa đặt là 1 (Đã dùng)
			data.updateRoomUsed(schedule.room_id);

			// Tạo 1 bills cho KH này theo schedule_id
			data.createBills(schedule_id, num_day);

			err_msg.ForeColor = System.Drawing.Color.Aqua;
			err_msg.Text = "Bạn đã đặt phòng thành công!";
		}
		catch (Exception ex)
		{
			err_msg.ForeColor = System.Drawing.Color.Red;
			err_msg.Text = "Đã xảy ra lỗi: " + ex.Message;
		}
	}
}