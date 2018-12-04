using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Sql;

/// <summary>
/// Summary description for Services
/// </summary>
public class Services
{
    SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=qlkhachsan;Integrated Security=True");
    public Services()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    //lay tat cả service
    public List<services> getallServices()
    {
        List<services> li = new List<services>();
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from services", con);
        SqlDataReader rd = cmd.ExecuteReader();
        while (rd.Read())
        {
            services svc = new services();
            svc.service_id = (int)rd["service_id"];
            svc.service_name = (string)rd["service_name"];
            svc.price = (double)rd["price"];
            svc.service_description = (string)rd["service_description"];
            li.Add(svc);
        }
        con.Close();
        return li;
    }

    // lay services theo cat_id
    public List<services> getServices(int cat_id)
    {
        List<services> li = new List<services>();
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from services,categories where services.cat_id=categories.cat_id and services.cat_id='"+cat_id+"'", con);
        SqlDataReader rd = cmd.ExecuteReader();
        while (rd.Read())
        {
            services svc = new services();
            svc.service_id = (int)rd["service_id"];
            svc.service_name = (string)rd["service_name"];
            svc.price = (double)rd["price"];
            svc.cat_name = (string)rd["cat_name"];
            svc.service_description = (string)rd["service_description"];
            li.Add(svc);
        }
        con.Close();
        return li;
    }
    public void deleteServices(int service_id)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("delete from services where service_id=" + service_id + "", con);
        cmd.ExecuteNonQuery();
        SqlCommand cmd1 = new SqlCommand("delete from orders where service_id=" + service_id + "", con);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    //them dich vu
    public void addService(services svc)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into services values(@service_name,@price,@cat_id,@service_description)", con);
        cmd.Parameters.AddWithValue("service_name",svc.service_name);
        cmd.Parameters.AddWithValue("price", svc.price);
        cmd.Parameters.AddWithValue("cat_id", svc.cat_id);
        cmd.Parameters.AddWithValue("service_description", svc.service_description);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    //lay ra 1 dich vu
    public services get1Service(int service_id)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from services where services.service_id=" + service_id + "", con);
        services svc = null;
        SqlDataReader rd = cmd.ExecuteReader();
        if (rd.Read())
        {
            svc = new services();
            svc.service_id = (int)rd["service_id"];
            svc.service_name = (string)rd["service_name"];
            svc.price = (double)rd["price"];
            svc.cat_id = (int)rd["cat_id"];
            svc.service_description = (string)rd["service_description"];
        }
        con.Close();
        return svc;
    }

    //cap nhat dich vu
    public void updateService(services svc)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("update services set service_name=N'" + svc.service_name + "', price=" + svc.price + ", cat_id=" + svc.cat_id + ",service_description=N'" + svc.service_description + "' where service_id="+svc.service_id+"", con);
        cmd.ExecuteNonQuery();
        con.Close();
    }

    //lay gia dich vu
    public double getPrice(int service_id)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("select * from services where services.service_id=" + service_id + "", con);
        double pr = 0;
        SqlDataReader rd = cmd.ExecuteReader();
        if (rd.Read())
            pr = (double)rd["price"];
        con.Close();
        return pr;
    }
}