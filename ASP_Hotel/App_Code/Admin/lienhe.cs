using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;

/// <summary>
/// Summary description for lienhe
/// </summary>
public class lienhe
{
    SqlConnection con;
    public lienhe()
    {
        string StrConnnect = @"Data Source=DESKTOP-16M4UR1\SQLEXPRESS;Initial Catalog=qlkhachsan;Integrated Security=True";
        con = new SqlConnection(StrConnnect);

    }
    public List<contacts> contacts()
    {
        List<contacts> li = new List<contacts>();
        string strSql = " select * from contacts";
        con.Open();
        SqlCommand cmd = new SqlCommand(strSql, con);
        SqlDataReader rd = cmd.ExecuteReader();
        while (rd.Read())
        {
            contacts s = new contacts();
            s.contact_id = (int)rd["contact_id"];
            s.fullname = (string)rd["fullname"];
            s.phone = (string)rd["phone"];
            s.email = (string)rd["email"];
            s.message = (string)rd["message"];
           
            li.Add(s);
        }
        con.Close();
        return li;
    }
    public void Themlh(contacts s)
    {
        con.Open();
        string strSql = " insert into contacts  values (@fullname,@phone,@email,@massage)";
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("fullname", s.fullname);
        cmd.Parameters.AddWithValue("phone", s.phone);
        cmd.Parameters.AddWithValue("email", s.email);
        cmd.Parameters.AddWithValue("massage", s.message);
       
        cmd.ExecuteNonQuery();
        con.Close();

    }
    public void Xoalh(int contact_id)
    {
        con.Open();
        string strSql = " delete from contacts where contact_id=@contact_id";
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("contact_id", contact_id);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public contacts layra1lh(int contact_id)
    {
        List<contacts> li = new List<contacts>();
        string strSql = " select * from contacts where contact_id=@contact_id";
        con.Open();
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("contact_id", contact_id);
        contacts s = null;
        SqlDataReader rd = cmd.ExecuteReader();
        if (rd.Read())
        {
            s = new contacts();
            s.contact_id = (int)rd["contact_id"];
            s.fullname = (string)rd["fullname"];
            s.phone = (string)rd["phone"];
            s.email = (string)rd["email"];
            s.message = (string)rd["message"];
            
            li.Add(s);
        }
        con.Close();
        return s;
    }
    public void Capnhatlh(contacts s)
    {
        con.Open();
        string strSql = " update contacts set fullname=@fullname,phone=@phone,email=@email,message=@message where contact_id=@contact_id";
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("fullname", s.fullname);
        cmd.Parameters.AddWithValue("phone", s.phone);
        cmd.Parameters.AddWithValue("email", s.email);
        cmd.Parameters.AddWithValue("message", s.message);
        cmd.Parameters.AddWithValue("contact_id", s.contact_id);


        cmd.ExecuteNonQuery();
        con.Close();

    }
}