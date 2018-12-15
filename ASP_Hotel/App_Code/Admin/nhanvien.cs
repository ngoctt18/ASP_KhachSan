using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Sql;


public class nhanvien
{
    SqlConnection con;
    public nhanvien()
    {
        string strConnect = @"Data Source=.\SQLEXPRESS;Initial Catalog=qlkhachsan;Integrated Security=True";
        con = new SqlConnection(strConnect);
    }
    public List<employees> employees()
    {
        List<employees> li = new List<employees>();
        string strSql = " select * from employees";
        con.Open();
        SqlCommand cmd = new SqlCommand(strSql, con);
        SqlDataReader rd = cmd.ExecuteReader();
        while(rd.Read())
        {
            employees s = new employees();
            s.employee_id = (int)rd["employee_id"];
            s.phone = (string)rd["phone"];
            s.password = (string)rd["password"];
            s.email = (string)rd["email"];
            s.address = (string)rd["address"];
            s.department_id = (int)rd["department_id"];
            s.avatar = (string)rd["avatar"];
            li.Add(s);
        }
        con.Close();
        return li;
    }
    public void Themnv(employees s)
    {
        con.Open();
        string strSql = " insert into employees  values (@phone,@password,@email,@address,@department_id,@avatar)";
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("phone", s.phone);
        cmd.Parameters.AddWithValue("password", s.password);
        cmd.Parameters.AddWithValue("email", s.email);
        cmd.Parameters.AddWithValue("address", s.address);
        cmd.Parameters.AddWithValue("department_id", s.department_id);
        cmd.Parameters.AddWithValue("avatar", s.avatar);
        cmd.ExecuteNonQuery();
        con.Close();

    }
    public List<departments> departments()
    {
        List<departments> li = new List<departments>();
        string strSql = " select * from departments";
        con.Open();
        SqlCommand cmd = new SqlCommand(strSql, con);
        SqlDataReader rd = cmd.ExecuteReader();
        while (rd.Read())
        {
            departments s = new departments();
            s.department_id = (int)rd["department_id"];
            s.department_name = (string)rd["department_name"];
            li.Add(s);
        }
        con.Close();
        return li;
    }
   public void Xoanv (int employee_id)
    {
        con.Open();
        string strSql = " delete from employees where employee_id=@employee_id";
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("employee_id", employee_id);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public employees layra1nv(int employee_id)
    {
        List<employees> li = new List<employees>();
        string strSql = " select * from employees where employee_id=@employee_id";
        con.Open();
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("employee_id", employee_id);
        employees s = null;
        SqlDataReader rd = cmd.ExecuteReader();
        if (rd.Read())
        {
            s = new employees();
            s.employee_id = (int)rd["employee_id"];
            s.phone = (string)rd["phone"];
            s.password = (string)rd["password"];
            s.email = (string)rd["email"];
            s.address = (string)rd["address"];
            s.department_id = (int)rd["department_id"];
            s.avatar = (string)rd["avatar"];
            li.Add(s);
        }
        con.Close();
        return s ;
    }
    public void Capnhatnv(employees s)
    {
        con.Open();
        string strSql = " update employees set phone=@phone,password=@password,email=@email,address=@address,department_id=@department_id,avatar=@avatar where employee_id=@employee_id";
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("phone", s.phone);
        cmd.Parameters.AddWithValue("password", s.password);
        cmd.Parameters.AddWithValue("email", s.email);
        cmd.Parameters.AddWithValue("address", s.address);
        cmd.Parameters.AddWithValue("department_id", s.department_id);
        cmd.Parameters.AddWithValue("avatar", s.avatar);
        cmd.Parameters.AddWithValue("employee_id", s.employee_id);// chay thu xem

        cmd.ExecuteNonQuery();
        con.Close();

    }
  

}