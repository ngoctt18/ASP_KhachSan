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
	public List<rooms> getEmptyRooms()
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

	// Get danh sách tất cả các phòng 
	public List<rooms> getAllRooms()
	{
		List<rooms> li = new List<rooms>();
		// Phòng có room_status = 0 là phòng trống chưa có người
		string sql = "Select * From rooms";
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
		// Get last schedule_id insert
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
	public void createBills(int schedule_id, double num_day)
	{
		double price_room = num_day * 100;
		string sql = "Insert Into bills (schedule_id, num_day, price_room) Values (@schedule_id, @num_day, @price_room)";
		con.Open();
		SqlCommand cmd = new SqlCommand(sql, con);
		cmd.Parameters.AddWithValue("schedule_id", schedule_id);
		cmd.Parameters.AddWithValue("num_day", num_day);
		cmd.Parameters.AddWithValue("price_room", price_room);
		cmd.ExecuteNonQuery();
		con.Close();
	}

	// Get ra danh sách đặt phòng
	public List<schedules> getSchedules()
	{
		string sql = "Select * From schedules";
		con.Open();
		SqlCommand cmd = new SqlCommand(sql, con);
		SqlDataReader rd = cmd.ExecuteReader();
		List<schedules> li = new List<schedules>();
		while (rd.Read())
		{
			schedules schedule = new schedules();
			schedule.schedule_id = (int)rd["schedule_id"];
			schedule.fullname = (string)rd["fullname"];
			schedule.phone = (string)rd["phone"];
			schedule.email = (string)rd["email"];
			schedule.room_id = (int)rd["room_id"];
			schedule.date_in = (DateTime)rd["date_in"];
			schedule.date_out = (DateTime)rd["date_out"];
			schedule.schedule_status = (Boolean)rd["schedule_status"];

			li.Add(schedule);
		}
		con.Close();
		return li;
	}

	// Get danh sách loại phòng room_types
	public List<room_types> getRoomTypes()
	{
		List<room_types> li = new List<room_types>();
		string sql = "Select * From room_types";
		con.Open();
		SqlCommand cmd = new SqlCommand(sql, con);
		SqlDataReader rd = cmd.ExecuteReader();
		while (rd.Read())
		{
			room_types room_type = new room_types();
			room_type.room_type_id = (int)rd["room_type_id"];
			room_type.room_type_name = (string)rd["room_type_name"];
			li.Add(room_type);
		}
		con.Close();
		return li;
	}
}