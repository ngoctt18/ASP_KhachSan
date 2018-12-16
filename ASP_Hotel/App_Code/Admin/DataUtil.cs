using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;

/// <summary>
/// Summary description for KHDatPhong
/// </summary>
public class DataUtil
{
    SqlConnection con;
    public DataUtil()
    {
        string strConnect = @"Data Source=.\SQLEXPRESS;Initial Catalog=qlkhachsan;Integrated Security=True";
        con = new SqlConnection(strConnect);
    }

    // Lấy ra danh sách  bảng admin
    public List<admins> getAdmins()
    {
        List<admins> li = new List<admins>();
        string strSql = "select*from admins";
        con.Open();
        SqlCommand cmd = new SqlCommand(strSql, con);
        SqlDataReader rd = cmd.ExecuteReader();
        while (rd.Read())
        {
            admins a = new admins();
            a.admin_id = (int)rd["admin_id"];
            a.phone = (string)rd["phone"];
            a.password = (string)rd["password"];
            a.email = (string)rd["email"];
            a.address = (string)rd["address"];
            a.avatar = (string)rd["avatar"];

            li.Add(a);
        }
        con.Close();
        return li;
    }

    //Thêm admin
    public void Themadmin(admins a)
    {
        con.Open();
        String strSql = "insert into admins values(@p,@pa,@e,@ad,@av)";
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("p", a.phone);
        cmd.Parameters.AddWithValue("pa", a.password);
        cmd.Parameters.AddWithValue("e", a.email);
        cmd.Parameters.AddWithValue("ad", a.address);
        cmd.Parameters.AddWithValue("av", a.avatar);

        cmd.ExecuteNonQuery();
        con.Close();
    }

    //Xóa admin
    public void Xoaadmin(int admin_id)
    {
        con.Open();
        String strSql = "delete from admins where admin_id=@admin_id";
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("admin_id", admin_id);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    //Lấy ra 1 Admin
    public admins Layra1admin(int admin_id)
    {
        List<admins> li = new List<admins>();
        string strSql = "select*from admins where admin_id=@admin_id";
        con.Open();
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("admin_id", admin_id);
        admins a = null;
        SqlDataReader rd = cmd.ExecuteReader();
        while (rd.Read())
        {
            a = new admins();
            a.admin_id = (int)rd["admin_id"];
            a.phone = (string)rd["phone"];
            a.password = (string)rd["password"];
            a.email = (string)rd["email"];
            a.address = (string)rd["address"];
            a.avatar = (string)rd["avatar"];

        }
        con.Close();
        return a;
    }

    //Cập nhật admin
    public void Capnhatadmin(admins a)
    {
        con.Open();
        string strSql = "update admins set phone=@p,password=@pa,email=@e,address=@ad,avatar=@av where admin_id=@admin_id";
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("p", a.phone);
        cmd.Parameters.AddWithValue("pa", a.password);
        cmd.Parameters.AddWithValue("e", a.email);
        cmd.Parameters.AddWithValue("ad", a.address);
        cmd.Parameters.AddWithValue("av", a.avatar);
        cmd.Parameters.AddWithValue("admin_id", a.admin_id);

        cmd.ExecuteNonQuery();
        con.Close();
    }

    //Phần danh mục tin tức -----------------------------------------------------------------------------------------

    // Lấy ra danh sách danh mục tin tức
    public List<news_categories> getNewsCategories()
    {
        List<news_categories> li = new List<news_categories>();
        string strSql = "select*from news_categories";
        con.Open();
        SqlCommand cmd = new SqlCommand(strSql, con);
        SqlDataReader rd = cmd.ExecuteReader();
        while (rd.Read())
        {
            news_categories n = new news_categories();
            n.news_cat_id = (int)rd["news_cat_id"];
            n.news_cat_name = (string)rd["news_cat_name"];
            n.news_cat_description = (string)rd["news_cat_description"];

            li.Add(n);
        }
        con.Close();
        return li;
    }

    //Thêm danh mục tin tức
    public void ThemNewCategories(news_categories n)
    {
        con.Open();
        String strSql = "insert into news_categories values(@name,@description)";
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("name", n.news_cat_name);
        cmd.Parameters.AddWithValue("description", n.news_cat_description);

        cmd.ExecuteNonQuery();
        con.Close();
    }

    //Xóa danh mục tin tức
    public void XoaNewCategories(int news_cat_id)
    {
        con.Open();
        String strSql = "delete from news_categories where news_cat_id=@news_cat_id";
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("news_cat_id", news_cat_id);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    //Lấy ra 1 danh mục tin tức
    public news_categories Layra1danhmuc(int news_cat_id)
    {
        List<news_categories> li = new List<news_categories>();
        string strSql = "select*from news_categories where news_cat_id=@news_cat_id";
        con.Open();
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("news_cat_id", news_cat_id);
        news_categories n = null;
        SqlDataReader rd = cmd.ExecuteReader();
        while (rd.Read())
        {
            n = new news_categories();
            n.news_cat_id = (int)rd["news_cat_id"];
            n.news_cat_name = (string)rd["news_cat_name"];
            n.news_cat_description = (string)rd["news_cat_description"];

        }
        con.Close();
        return n;

    }

    //Cập nhật danh mục tin tức
    public void Capnhatdanhmuc(news_categories n)
    {
        con.Open();
        string strSql = "update news_categories set news_cat_name=@name,news_cat_description=@description where news_cat_id=@news_cat_id";
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("name", n.news_cat_name);
        cmd.Parameters.AddWithValue("description", n.news_cat_description);
        cmd.Parameters.AddWithValue("news_cat_id", n.news_cat_id);

        cmd.ExecuteNonQuery();
        con.Close();
    }

    //Phần Tin ---------------------------------------------------------------------------------------------

    // Get ra danh sách tin đang hiện vs news_status=0
    public List<news> getNews()
    {
        string sql = "Select * From news, news_categories where news.news_cat_id=news_categories.news_cat_id ORDER BY news_id DESC";
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlDataReader rd = cmd.ExecuteReader();
        List<news> li = new List<news>();
        while (rd.Read())
        {
            news n = new news();
            n.news_id = (int)rd["news_id"];
            n.news_title = (string)rd["news_title"];
            n.news_description = (string)rd["news_description"];
            n.news_content = (string)rd["news_content"];
            n.news_avatar = (string)rd["news_avatar"];
            n.news_cat_id = (int)rd["news_cat_id"];
            n.news_cat_name = (string)rd["news_cat_name"];
            n.news_content = (string)rd["news_content"];
            n.news_status = (Boolean)rd["news_status"];
            li.Add(n);
        }
        con.Close();
        return li;
    }

    // Get ra danh sách tin đang ẩn vs news_status=0
    public List<news> getNews1()
    {
        string sql = "Select * From news, news_categories where news.news_cat_id=news_categories.news_cat_id and news.news_status=1 ORDER BY news_id DESC";
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);
        SqlDataReader rd = cmd.ExecuteReader();
        List<news> li = new List<news>();
        while (rd.Read())
        {
            news n = new news();
            n.news_id = (int)rd["news_id"];
            n.news_title = (string)rd["news_title"];
            n.news_description = (string)rd["news_description"];
            n.news_content = (string)rd["news_content"];
            n.news_avatar = (string)rd["news_avatar"];
            n.news_cat_id = (int)rd["news_cat_id"];
            n.news_cat_name = (string)rd["news_cat_name"];
            n.news_content = (string)rd["news_content"];
            n.news_status = (Boolean)rd["news_status"];
            li.Add(n);
        }
        con.Close();
        return li;
    }

    //// Get ra danh sách các phòng trống từ bảng rooms
    //public List<news> getAnTin()
    //{
    //    List<news> li = new List<news>();
    //    // Phòng có room_status = 0 là phòng trống chưa có người
    //    string sql = "Select * From news where news_status = 0";
    //    con.Open();
    //    SqlCommand cmd = new SqlCommand(sql, con);
    //    SqlDataReader rd = cmd.ExecuteReader();
    //    while (rd.Read())
    //    {
    //        news room = new news();
    //        room.news_id = (int)rd["room_id"];
    //        room.news_title = (string)rd["room_name"];
    //        room.news_description = (string)rd["news_description"];
    //        room.news_content = (string)rd["news_content"];
    //        room.news_avatar = (string)rd["news_avatar"];
    //        room.news_cat_id = (int)rd["news_cat_id"];
    //        room.news_status = (Boolean)rd["news_status"];
    //        li.Add(room);
    //    }
    //    con.Close();
    //    return li;
    //}

    //// Get danh sách tất cả các phòng 
    //public List<rooms> getAllRooms()
    //{
    //    List<rooms> li = new List<rooms>();
    //    string sql = "Select * From rooms, room_types where rooms.room_type_id=room_types.room_type_id ORDER BY room_id DESC";
    //    con.Open();
    //    SqlCommand cmd = new SqlCommand(sql, con);
    //    SqlDataReader rd = cmd.ExecuteReader();
    //    while (rd.Read())
    //    {
    //        rooms room = new rooms();
    //        room.room_id = (int)rd["room_id"];
    //        room.room_name = (string)rd["room_name"];
    //        room.room_status = (Boolean)rd["room_status"];
    //        room.room_type_name = (string)rd["room_type_name"];
    //        li.Add(room);
    //    }
    //    con.Close();
    //    return li;
    //}

    // Thêm 1 Tin
    public int ThemTin(news n)
    {
        string sql = "Insert Into news (news_title, news_description, news_content, news_avatar, news_cat_id) output INSERTED.news_id Values (@news_title, @news_description, @news_content,@news_avatar, @news_cat_id)";
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddWithValue("news_title", n.news_title);
        cmd.Parameters.AddWithValue("news_description", n.news_description);
        cmd.Parameters.AddWithValue("news_content", n.news_content);
        cmd.Parameters.AddWithValue("news_avatar", n.news_avatar);
        cmd.Parameters.AddWithValue("news_status", n.news_status);
        cmd.Parameters.AddWithValue("news_cat_id", n.news_cat_id);
        // Get last news_id insert
        int news_id = Convert.ToInt32(cmd.ExecuteScalar());
        con.Close();
        return news_id;
    }

    // Xóa 1 Tin
    public void deleteNew(int news_id)
    {
        con.Open();
        // Cập nhật room_status là 0 (Phòng trống)
        //string sql_room = "update news_categories set room_status=0 where room_id=(select schedules.room_id From schedules, rooms where schedules.room_id=rooms.room_id and schedules.schedule_id=@schedule_id)";
        //SqlCommand cmd_room = new SqlCommand(sql_room, con);
        //cmd_room.Parameters.AddWithValue("schedule_id", schedule_id);
        //cmd_room.ExecuteNonQuery();

        string sql = "Delete From news Where news_id=@news_id";
        //con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddWithValue("news_id", news_id);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    public news get1New(int news_id)
    {
        string sql = "Select * From news, news_categories where news.news_cat_id=news_categories.news_cat_id And news_id=@news_id";
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddWithValue("news_id", news_id);
        SqlDataReader rd = cmd.ExecuteReader();
        news n = null;
        if (rd.Read())
        {
            n = new news();
            n.news_id = (int)rd["news_id"];
            n.news_title = (string)rd["news_title"];
            n.news_description = (string)rd["news_description"];
            n.news_content = (string)rd["news_content"];
            n.news_avatar = (string)rd["news_avatar"];
            n.news_status = (Boolean)rd["news_status"];
            n.news_cat_id = (int)rd["news_cat_id"];
        }
        con.Close();
        return n;
    }

    // Cập nhật thông tin phòng
    public void CapnhatTin(news n)
    {
        string sql = "Update news Set news_title=@news_title,news_description=@news_description,news_content=@news_content,news_avatar=@news_avatar,news_status=@news_status,news_cat_id=@news_cat_id where news_id=@news_id";
        con.Open();
        SqlCommand cmd = new SqlCommand(sql, con);
        cmd.Parameters.AddWithValue("news_title", n.news_title);
        cmd.Parameters.AddWithValue("news_description", n.news_description);
        cmd.Parameters.AddWithValue("news_content", n.news_content);
        cmd.Parameters.AddWithValue("news_avatar", n.news_avatar);
        cmd.Parameters.AddWithValue("news_status", n.news_status);
        cmd.Parameters.AddWithValue("news_cat_id", n.news_cat_id);
        cmd.Parameters.AddWithValue("news_id", n.news_id);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    //// Get 1 schedule theo schedule_id
    //public schedules get1Schedule(int schedule_id)
    //{
    //    string sql = "Select * From schedules Where schedule_id=@schedule_id";
    //    con.Open();
    //    SqlCommand cmd = new SqlCommand(sql, con);
    //    cmd.Parameters.AddWithValue("schedule_id", schedule_id);
    //    SqlDataReader rd = cmd.ExecuteReader();
    //    schedules schedule = null;
    //    if (rd.Read())
    //    {
    //        schedule = new schedules();
    //        schedule.schedule_id = (int)rd["schedule_id"];
    //        schedule.fullname = (string)rd["fullname"];
    //        schedule.phone = (string)rd["phone"];
    //        schedule.email = (string)rd["email"];
    //        schedule.room_id = (int)rd["room_id"];
    //        schedule.date_in = (DateTime)rd["date_in"];
    //        schedule.date_out = (DateTime)rd["date_out"];
    //    }
    //    con.Close();
    //    return schedule;
    //}

    //// Update schedule 
    //public void updateSchedule(schedules schedule)
    //{
    //    string sql = "Update schedules Set fullname=@fullname, phone=@phone, email=@email, room_id=@room_id, date_in=@date_in, date_out=@date_out Where schedule_id=@schedule_id";
    //    con.Open();
    //    SqlCommand cmd = new SqlCommand(sql, con);
    //    cmd.Parameters.AddWithValue("schedule_id", schedule.schedule_id);
    //    cmd.Parameters.AddWithValue("fullname", schedule.fullname);
    //    cmd.Parameters.AddWithValue("phone", schedule.phone);
    //    cmd.Parameters.AddWithValue("email", schedule.email);
    //    cmd.Parameters.AddWithValue("room_id", schedule.room_id);
    //    cmd.Parameters.AddWithValue("date_in", schedule.date_in);
    //    cmd.Parameters.AddWithValue("date_out", schedule.date_out);
    //    cmd.ExecuteNonQuery();
    //    con.Close();
    //}

    //// Tự động cập nhật trạng thái phòng là trống sau khi đặt phòng hết hạn
    //public void CreatingNewThreadTimer()
    //{
    //    Thread thread = new Thread(new ThreadStart(MyTimer));
    //    thread.Start();
    //}
    //public void MyTimer()
    //{
    //    DateTime time;
    //    while (true)
    //    {
    //        time = DateTime.Now;
    //        int hour = time.Hour;
    //        int minute = time.Minute;
    //        int second = time.Second;
    //        // Tự động chạy hàm kiểm tra date_out để set room_status=0 (phòng trống)
    //        if (hour == 21 && minute == 21 && second == 21)
    //        {
    //            autoUpdateRoomStatus();
    //        }
    //    }
    //}
    //public void autoUpdateRoomStatus()
    //{
    //    con.Close();
    //    con.Open();
    //    DateTime today = DateTime.Today;
    //    // Cập nhật room_status là 0 (Phòng trống) của room_id trong schedules khi day_out bằng today
    //    string update_room = "update rooms set room_status=0 where room_id IN (select room_id from schedules where schedule_status=0 and date_out=@today)";
    //    SqlCommand cmd_room = new SqlCommand(update_room, con);
    //    cmd_room.Parameters.AddWithValue("today", today);
    //    cmd_room.ExecuteNonQuery();
    //    // System.Diagnostics.Debug.WriteLine(today);
    //    con.Close();
    //}
}