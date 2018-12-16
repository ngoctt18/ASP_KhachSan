using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;

/// <summary>
/// Summary description for khachhang
/// </summary>
public class khachhang
{
    SqlConnection con;
    public khachhang()
    {
        string StrConnnect = @"Data Source=.\SQLEXPRESS;Initial Catalog=qlkhachsan;Integrated Security=True";
        con = new SqlConnection(StrConnnect);
    }
    public List<users> users()
    {
        List<users> li = new List<users>();
        string strSql = " select * from users";
        con.Open();
        SqlCommand cmd = new SqlCommand(strSql, con);
        SqlDataReader rd = cmd.ExecuteReader();
        while (rd.Read())
        {
            users s = new users();
            s.user_id = (int)rd["user_id"];
            s.password = (string)rd["password"];
            s.phone = (string)rd["phone"];
            s.email = (string)rd["email"];
            s.address = (string)rd["address"];

            li.Add(s);
        }
        con.Close();
        return li;
    }
    public void Xoakh(int user_id)
    {
        con.Open();
        string strSql = " delete from users where user_id=@user_id";
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("user_id", user_id);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void Themkh(users s)
    {
        con.Open();
        string strSql = " insert into users  values (@password,@phone,@email,@address)";
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("password", s.password);
        cmd.Parameters.AddWithValue("phone", s.phone);
        cmd.Parameters.AddWithValue("email", s.email);
        cmd.Parameters.AddWithValue("address", s.address);

        cmd.ExecuteNonQuery();
        con.Close();

    }
    public users layra1kh(int user_id)
    {
        List<users> li = new List<users>();
        string strSql = " select * from users where user_id=@user_id";
        con.Open();
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("user_id", user_id);
        users s = null;
        SqlDataReader rd = cmd.ExecuteReader();
        if (rd.Read())
        {
            s = new users();
            s.user_id = (int)rd["user_id"];
            s.password = (string)rd["password"];
            s.phone = (string)rd["phone"];
            s.email = (string)rd["email"];
            s.address = (string)rd["address"];

            li.Add(s);
        }
        con.Close();
        return s;
    }
    public void Capnhatkh(users s)
    {
        con.Open();
        string strSql = "update users set password=@password,phone=@phone,email=@email,address=@address where user_id=@user_id";
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("password", s.password);
        cmd.Parameters.AddWithValue("phone", s.phone);
        cmd.Parameters.AddWithValue("email", s.email);
        cmd.Parameters.AddWithValue("address", s.address);
        cmd.Parameters.AddWithValue("user_id", s.user_id);


        cmd.ExecuteNonQuery();
        con.Close();

    }
}