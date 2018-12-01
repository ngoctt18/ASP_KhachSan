using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;

/// <summary>
/// Summary description for KHDatPhong
/// </summary>
public class KHDatPhong
{
	SqlConnection con;
	public KHDatPhong()
	{
		string strConnect = @"Data Source=.\sqlexpress;Initial Catalog=qlkhachsan;Integrated Security=True";
		con = new SqlConnection(strConnect);
	}

	// Get ra danh sách các phòng trống từ bảng rooms
	public List<rooms> getRooms()
	{
		List<rooms> li = new List<rooms>();
		// Phòng có room_status = 0 là phòng trống chưa có người
		string sql = "Select * From rooms where room_status = 0";
		con.Open();
		SqlCommand cmd = new SqlCommand(sql, con);
		SqlDataReader rd = cmd.ExecuteReader();
		while (rd.Read())
		{
			rooms room = new rooms();
			room.room_id = (int)rd["room_id"];
			room.room_name = (string)rd["room_name"];
			room.avatar = (string)rd["avatar"];
			room.room_status = (Boolean)rd["room_status"];
			room.room_type_id = (int)rd["room_type_id"];
			li.Add(room);
		}
		con.Close();
		return li;
	}

	// Khách hàng Thêm 1 đặt phòng
	public int ThemDatPhong(schedules schedule)
	{
		string sql = "Insert Into schedules (fullname, phone, email, room_id, date_in, date_out) output INSERTED.schedule_id Values (@fullname, @phone, @email, @room_id, @date_in, @date_out)";
		con.Open();
		SqlCommand cmd = new SqlCommand(sql, con);
		cmd.Parameters.AddWithValue("fullname", schedule.fullname);
		cmd.Parameters.AddWithValue("phone", schedule.phone);
		cmd.Parameters.AddWithValue("email", schedule.email);
		cmd.Parameters.AddWithValue("room_id", schedule.room_id);
		cmd.Parameters.AddWithValue("date_in", schedule.date_in);
		cmd.Parameters.AddWithValue("date_out", schedule.date_out);
		int schedule_id = Convert.ToInt32(cmd.ExecuteScalar());
		con.Close();
		return schedule_id;
	}

	// Cập nhật room_status của phòng là 1 (Đã dùng) sau khi phòng đó được đặt
	public void updateRoomUsed(int room_id)
	{
		string sql = "Update rooms set room_status=1 where room_id=@room_id";
		con.Open();
		SqlCommand cmd = new SqlCommand(sql, con);
		cmd.Parameters.AddWithValue("room_id", room_id);
		cmd.ExecuteNonQuery();
		con.Close();
	}

	// Tạo hóa đơn bills cho khách vừa đặt phòng
	public void createBills(int schedule_id)
	{
		string sql = "Insert Into bills (schedule_id) Values (@schedule_id)";
		con.Open();
		SqlCommand cmd = new SqlCommand(sql, con);
		cmd.Parameters.AddWithValue("schedule_id", schedule_id);
		cmd.ExecuteNonQuery();
		con.Close();
	}
}