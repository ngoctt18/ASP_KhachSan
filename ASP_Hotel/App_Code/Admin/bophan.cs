using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;

/// <summary>
/// Summary description for bophan
/// </summary>
public class bophan
{
    SqlConnection con;
    public bophan()
    {
        string StrConnnect = @"Data Source=.\SQLEXPRESS;Initial Catalog=qlkhachsan;Integrated Security=True";
        con = new SqlConnection(StrConnnect);
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
    public void Thembp(departments s)
    {
        con.Open();
        string strSql = " insert into departments  values (@department_name)";
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("department_name", s.department_name);
       

        cmd.ExecuteNonQuery();
        con.Close();

    }
    public departments layra1bp(int department_id)
    {
        List<departments> li = new List<departments>();
        string strSql = " select * from departments where department_id=@department_id";
        con.Open();
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("department_id", department_id);
        departments s = null;
        SqlDataReader rd = cmd.ExecuteReader();
        if (rd.Read())
        {
            s = new departments();
            s.department_id = (int)rd["department_id"];
            s.department_name = (string)rd["department_name"];
          

            li.Add(s);
        }
        con.Close();
        return s;
    }
    public void Capnhatbp(departments s)
    {
        con.Open();
        string strSql = "update departments set department_name=@department_name where department_id=@department_id";
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("department_name", s.department_name);
       
        cmd.Parameters.AddWithValue("department_id", s.department_id);


        cmd.ExecuteNonQuery();
        con.Close();

    }
    public void Xoabp(int department_id)
    {
        con.Open();
        string strSql = " delete from departments where department_id=@department_id";
        SqlCommand cmd = new SqlCommand(strSql, con);
        cmd.Parameters.AddWithValue("department_id", department_id);
        cmd.ExecuteNonQuery();
        con.Close();
    }
}