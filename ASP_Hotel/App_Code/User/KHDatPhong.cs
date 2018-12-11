using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Threading;
using System.Timers;

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
		CreatingNewThreadTimer();
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
		string sql = "Select * From rooms, room_types where rooms.room_type_id=room_types.room_type_id ORDER BY room_id DESC";
		con.Open();
		SqlCommand cmd = new SqlCommand(sql, con);
		SqlDataReader rd = cmd.ExecuteReader();
		while (rd.Read())
		{
			rooms room = new rooms();
			room.room_id = (int)rd["room_id"];
			room.room_name = (string)rd["room_name"];
			room.room_status = (Boolean)rd["room_status"];
			room.room_type_name = (string)rd["room_type_name"];
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

	// Cập nhật room_status của phòng là 0 (Phòng trống) sau khi thanh toán
	public void updateRoomFree(int room_id)
	{
		string sql = "Update rooms set room_status=0 where room_id=@room_id";
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
		float price_service = 0;
		string sql = "Insert Into bills (schedule_id, num_day, price_room, price_service, total_price) Values (@schedule_id, @num_day, @price_room, @price_service, @total_price)";
		con.Open();
		SqlCommand cmd = new SqlCommand(sql, con);
		cmd.Parameters.AddWithValue("schedule_id", schedule_id);
		cmd.Parameters.AddWithValue("num_day", num_day);
		cmd.Parameters.AddWithValue("price_room", price_room);
		cmd.Parameters.AddWithValue("price_service", price_service);
		cmd.Parameters.AddWithValue("total_price", price_room);
		cmd.ExecuteNonQuery();
		con.Close();
	}

	// Get ra danh sách đặt phòng đang ở vs schedule_id=0
	public List<schedules> getSchedules()
	{
		string sql = "Select * From schedules, rooms where schedules.room_id=rooms.room_id and schedules.schedule_status=0 ORDER BY schedule_id DESC";
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
			schedule.room_name = (string)rd["room_name"];
			schedule.date_in = (DateTime)rd["date_in"];
			schedule.date_out = (DateTime)rd["date_out"];
			schedule.schedule_status = (Boolean)rd["schedule_status"];

			li.Add(schedule);
		}
		con.Close();
		return li;
	}

	// Get ra danh sách đặt phòng đã đi vs schedule_id=0
	public List<schedules> getSchedules1()
	{
		string sql = "Select * From schedules, rooms where schedules.room_id=rooms.room_id and schedules.schedule_status=1 ORDER BY schedule_id DESC";
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
			schedule.room_name = (string)rd["room_name"];
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

	// Thêm phòng vào bảng rooms
	public void createRoom(rooms room)
	{
		string sql = "Insert Into rooms (room_name, room_status, room_type_id) Values (@room_name, @room_status, @room_type_id)";
		con.Open();
		SqlCommand cmd = new SqlCommand(sql, con);
		cmd.Parameters.AddWithValue("room_name", room.room_name);
		cmd.Parameters.AddWithValue("room_status", room.room_status);
		cmd.Parameters.AddWithValue("room_type_id", room.room_type_id);
		cmd.ExecuteNonQuery();
		con.Close();
	}


	// Hiển thị danh sách hóa đơn chưa thanh toán
	public List<bills> getBills()
	{
		List<bills> li = new List<bills>();
		string sql = "Select * From bills, schedules where bills.schedule_id=schedules.schedule_id AND bill_status=0 ORDER BY bill_id DESC";
		con.Open();
		SqlCommand cmd = new SqlCommand(sql, con);
		SqlDataReader rd = cmd.ExecuteReader();
		while (rd.Read())
		{
			bills bill = new bills();
			bill.bill_id = (int)rd["bill_id"];
			bill.schedule_id = (int)rd["schedule_id"];
			bill.num_day = (int)rd["num_day"];
			bill.price_room = Convert.ToDouble(rd["price_room"]);
			bill.price_service = Convert.ToDouble(rd["price_service"]);
			bill.total_price = Convert.ToDouble(rd["total_price"]);
			bill.bill_status = (Boolean)rd["bill_status"];
			bill.fullname = (string)rd["fullname"];
			li.Add(bill);
		}
		con.Close();
		return li;
	}

	// Hiển thị danh sách hóa đơn đã thanh toán
	public List<bills> getBills1()
	{
		List<bills> li = new List<bills>();
		string sql = "Select * From bills, schedules where bills.schedule_id=schedules.schedule_id AND bill_status=1 ORDER BY bill_id DESC";
		con.Open();
		SqlCommand cmd = new SqlCommand(sql, con);
		SqlDataReader rd = cmd.ExecuteReader();
		while (rd.Read())
		{
			bills bill = new bills();
			bill.bill_id = (int)rd["bill_id"];
			bill.schedule_id = (int)rd["schedule_id"];
			bill.num_day = (int)rd["num_day"];
			bill.price_room = Convert.ToInt32(rd["price_room"]);
			bill.price_service = Convert.ToInt32(rd["price_service"]);
			bill.total_price = Convert.ToInt32(rd["total_price"]);
			bill.bill_status = (Boolean)rd["bill_status"];
			bill.fullname = (string)rd["fullname"];
			bill.phone = (string)rd["phone"];
			li.Add(bill);
		}
		con.Close();
		return li;
	}

	// Xóa 1 phòng 
	public void deleteRoom(int room_id)
	{
		string sql = "Delete From rooms Where room_id=@room_id";
		con.Open();
		SqlCommand cmd = new SqlCommand(sql, con);
		cmd.Parameters.AddWithValue("room_id", room_id);
		cmd.ExecuteNonQuery();
		con.Close();
	}

	// Lấy phòng theo mã phòng room_id
	public rooms get1Room(int room_id)
	{
		string sql = "Select * From rooms, room_types where rooms.room_type_id=room_types.room_type_id And room_id=@room_id";
		con.Open();
		SqlCommand cmd = new SqlCommand(sql, con);
		cmd.Parameters.AddWithValue("room_id", room_id);
		SqlDataReader rd = cmd.ExecuteReader();
		rooms room = null;
		if (rd.Read())
		{
			room = new rooms();
			room.room_id = (int)rd["room_id"];
			room.room_name = (string)rd["room_name"];
			room.room_status = (Boolean)rd["room_status"];
			room.room_type_id = (int)rd["room_type_id"];
		}
		con.Close();
		return room;
	}

	// Cập nhật thông tin phòng
	public void updateRoom(rooms room)
	{
		string sql = "Update rooms Set room_name=@room_name, room_status=@room_status, room_type_id=@room_type_id Where room_id=@room_id";
		con.Open();
		SqlCommand cmd = new SqlCommand(sql, con);
		cmd.Parameters.AddWithValue("room_name", room.room_name);
		cmd.Parameters.AddWithValue("room_status", room.room_status);
		cmd.Parameters.AddWithValue("room_type_id", room.room_type_id);
		cmd.Parameters.AddWithValue("room_id", room.room_id);
		cmd.ExecuteNonQuery();
		con.Close();
	}

	// Thanh toán hóa đơn
	public void ThanhToanHoaDon(int bill_id)
	{
		// Cập nhật bill_status=1 là thành đã thanh toán
		con.Open();
		string sql = "Update bills Set bill_status=1 OUTPUT INSERTED.schedule_id Where bill_id=@bill_id";
		SqlCommand cmd = new SqlCommand(sql, con);
		cmd.Parameters.AddWithValue("bill_id", bill_id);
		// Get last schedule_id updated
		int schedule_id = Convert.ToInt32(cmd.ExecuteScalar());

		// Cập nhật schedule_status=1 là người đặt phòng đã đi
		string sql_schedule = "Update schedules Set schedule_status=1 Where schedule_id=@schedule_id";
		SqlCommand cmd_schedule = new SqlCommand(sql_schedule, con);
		cmd_schedule.Parameters.AddWithValue("schedule_id", schedule_id);
		cmd_schedule.ExecuteNonQuery();

		// Cập nhật room_status là 0 (Phòng trống) của room_id trong schedules
		string sql_room = "update rooms set room_status=0 where room_id=(select schedules.room_id From schedules, rooms where schedules.room_id=rooms.room_id and schedules.schedule_id=@schedule_id)";
		SqlCommand cmd_room = new SqlCommand(sql_room, con);
		cmd_room.Parameters.AddWithValue("schedule_id", schedule_id);
		cmd_room.ExecuteNonQuery();
		con.Close();
	}

	// Xóa 1 đặt phòng
	public void deleteSchedue(int schedule_id)
	{
		con.Open();
		// Cập nhật room_status là 0 (Phòng trống)
		string sql_room = "update rooms set room_status=0 where room_id=(select schedules.room_id From schedules, rooms where schedules.room_id=rooms.room_id and schedules.schedule_id=@schedule_id)";
		SqlCommand cmd_room = new SqlCommand(sql_room, con);
		cmd_room.Parameters.AddWithValue("schedule_id", schedule_id);
		cmd_room.ExecuteNonQuery();

		string sql = "Delete From schedules Where schedule_id=@schedule_id";
		SqlCommand cmd = new SqlCommand(sql, con);
		cmd.Parameters.AddWithValue("schedule_id", schedule_id);
		cmd.ExecuteNonQuery();

		con.Close();
	}

	// Get 1 schedule theo schedule_id
	public schedules get1Schedule(int schedule_id)
	{
		string sql = "Select * From schedules Where schedule_id=@schedule_id";
		con.Open();
		SqlCommand cmd = new SqlCommand(sql, con);
		cmd.Parameters.AddWithValue("schedule_id", schedule_id);
		SqlDataReader rd = cmd.ExecuteReader();
		schedules schedule = null;
		if (rd.Read())
		{
			schedule = new schedules();
			schedule.schedule_id = (int)rd["schedule_id"];
			schedule.fullname = (string)rd["fullname"];
			schedule.phone = (string)rd["phone"];
			schedule.email = (string)rd["email"];
			schedule.room_id = (int)rd["room_id"];
			schedule.date_in = (DateTime)rd["date_in"];
			schedule.date_out = (DateTime)rd["date_out"];
		}
		con.Close();
		return schedule;
	}

	// Update schedule 
	public void updateSchedule(schedules schedule)
	{
		string sql = "Update schedules Set fullname=@fullname, phone=@phone, email=@email, room_id=@room_id, date_in=@date_in, date_out=@date_out Where schedule_id=@schedule_id";
		con.Open();
		SqlCommand cmd = new SqlCommand(sql, con);
		cmd.Parameters.AddWithValue("schedule_id", schedule.schedule_id);
		cmd.Parameters.AddWithValue("fullname", schedule.fullname);
		cmd.Parameters.AddWithValue("phone", schedule.phone);
		cmd.Parameters.AddWithValue("email", schedule.email);
		cmd.Parameters.AddWithValue("room_id", schedule.room_id);
		cmd.Parameters.AddWithValue("date_in", schedule.date_in);
		cmd.Parameters.AddWithValue("date_out", schedule.date_out);
		cmd.ExecuteNonQuery();
		con.Close();
	}

	// Tự động cập nhật trạng thái phòng là trống sau khi đặt phòng hết hạn
	public void CreatingNewThreadTimer()
	{
		Thread thread = new Thread(new ThreadStart(MyTimer));
		thread.Start();
	}
	public void MyTimer()
	{
		DateTime time;
		while (true)
		{
			time = DateTime.Now;
			int hour = time.Hour;
			int minute = time.Minute;
			int second = time.Second;
			// Tự động chạy hàm kiểm tra date_out để set room_status=0 (phòng trống)
			if (hour == 21 && minute == 21 && second == 21)
			{
				testMethod();
			}
		}
	}
	public void testMethod()
	{
		con.Close();
		con.Open();
		DateTime today = DateTime.Today;
		// Cập nhật room_status là 0 (Phòng trống) của room_id trong schedules khi day_out bằng today
		string update_room = "update rooms set room_status=0 where room_id IN (select room_id from schedules where schedule_status=0 and date_out=@today)";
		SqlCommand cmd_room = new SqlCommand(update_room, con);
		cmd_room.Parameters.AddWithValue("today", today);
		cmd_room.ExecuteNonQuery();
		System.Diagnostics.Debug.WriteLine(today);
		con.Close();
	}
}