using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Sql;
using System.Data.SqlClient;

/// <summary>
/// Summary description for Categories
/// </summary>
public class Categories
{
    SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=qlkhachsan;Integrated Security=True");
	public Categories()
	{
        
	}

    // lay du lieu tu bang category
    public List<categories> getCategories()
    {
        List<categories> li = new List<categories>();
        con.Open();
        SqlCommand cmd = new SqlCommand("Select * From categories", con);
        SqlDataReader rd = cmd.ExecuteReader();
        while (rd.Read())
        {
            categories ctg = new categories();
            ctg.cat_id = (int)rd["cat_id"];
            ctg.cat_name = (string)rd["cat_name"];
            li.Add(ctg);
        }
        con.Close();
        return li;
    }

    // lay 1 category
    public categories get1Category(int cat_id)
    {
        categories ct = new categories();
        con.Open();
        SqlCommand cmd = new SqlCommand("Select * From categories where cat_id=@cat_id", con);
        cmd.Parameters.AddWithValue("cat_id", cat_id);
        ct = null;
        SqlDataReader rd = cmd.ExecuteReader();
        if (rd.Read())
        {
            ct = new categories();
            ct.cat_id = (int)rd["cat_id"];
            ct.cat_name = (string)rd["cat_name"];
        }
        con.Close();
        return ct;
    }

    // Tạo thêm category
    public void addCategory(categories ctg)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("insert into categories values(@cat_name)", con);
        cmd.Parameters.AddWithValue("cat_name", ctg.cat_name);
        cmd.ExecuteNonQuery();
        con.Close();
    }
    public void deleteCategories(int cat_id)
    {
        con.Open();
        SqlCommand cmd = new SqlCommand("delete from services where cat_id=" + cat_id + "", con);
        cmd.ExecuteNonQuery();
        SqlCommand cmd2 = new SqlCommand("delete from orders where cat_id=" + cat_id + "", con);
        cmd.ExecuteNonQuery();
        SqlCommand cmd1 = new SqlCommand("delete from categories where cat_id=" + cat_id + "", con);
        cmd1.ExecuteNonQuery();
        con.Close();
    }

    //cap nhat category
    public void updateCategory(categories ctg)
    {
        con.Open();
        SqlCommand cmd= new SqlCommand("update categories set cat_name=N'"+ctg.cat_name+"' where cat_id="+ctg.cat_id+"",con);
        cmd.ExecuteNonQuery();
        con.Close();
    }
}