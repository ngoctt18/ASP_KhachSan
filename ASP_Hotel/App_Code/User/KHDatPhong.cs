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

	// Get ra danh sách các phòng từ bảng rooms
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
	public void ThemDatPhong(schedules book)
	{
		string sql = "Insert Into schedules (fullname, phone, email, room_id, date_in, date_out) Values (@fullname, @phone, @email, @room_id, @date_in, @date_out)";
		con.Open();
		SqlCommand cmd = new SqlCommand(sql, con);
		cmd.Parameters.AddWithValue("fullname", book.fullname);
		cmd.Parameters.AddWithValue("phone", book.phone);
		cmd.Parameters.AddWithValue("email", book.email);
		cmd.Parameters.AddWithValue("room_id", book.room_id);
		cmd.Parameters.AddWithValue("date_in", book.date_in);
		cmd.Parameters.AddWithValue("date_out", book.date_out);
		cmd.ExecuteNonQuery();
		con.Close();
	}
}