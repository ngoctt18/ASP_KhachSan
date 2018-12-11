using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Sql;

/// <summary>
/// Summary description for OrderServices
/// </summary>
public class OrderServices
{
	SqlConnection con = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=qlkhachsan;Integrated Security=True");
	Services svc = new Services();
	public OrderServices()
	{
		//
		// TODO: Add constructor logic here
		//
	}

	//lay schedule_id va room id
	public List<orders> getRoom_namefordrp()
	{
		List<orders> li = new List<orders>();
		con.Open();
		SqlCommand cmd = new SqlCommand("select * from schedules,rooms where schedules.room_id=rooms.room_id and schedules.schedule_status=0", con);
		SqlDataReader rd = cmd.ExecuteReader();
		while (rd.Read())
		{
			orders orr = new orders();
			orr.schedule_id = (int)rd["schedule_id"];
			orr.room_name = (string)rd["room_name"];
			li.Add(orr);
		}
		con.Close();
		return li;
	}

	//lay du lieu ra gridview
	public List<orders> getOrder(int schedule_id)
	{
		List<orders> li = new List<orders>();
		con.Open();
		SqlCommand cmd = new SqlCommand("select * from orders,schedules,rooms,bills,services,categories where orders.schedule_id=schedules.schedule_id and schedules.room_id=rooms.room_id and orders.bill_id=bills.bill_id and orders.service_id=services.service_id and services.cat_id=categories.cat_id and schedules.schedule_status=0 and orders.order_status=0 and orders.schedule_id=" + schedule_id + "", con);
		SqlDataReader rd = cmd.ExecuteReader();
		while (rd.Read())
		{
			orders ord = new orders();
			ord.order_id = (int)rd["order_id"];
			ord.schedule_id = (int)rd["schedule_id"];
			ord.service_id = (int)rd["service_id"];
			ord.quantity = (int)rd["quantity"];
			ord.order_price = (float)(ord.quantity * svc.getPrice(ord.service_id));
			ord.bill_id = (int)rd["bill_id"];
			ord.fullname = (string)rd["fullname"];
			ord.room_name = (string)rd["room_name"];
			ord.service_name = (string)rd["service_name"];
			li.Add(ord);
		}
		con.Close();
		return li;
	}

	//lay nhung order da xong
	public List<orders> getOrderdone(int schedule_id)
	{
		List<orders> li = new List<orders>();
		con.Open();
		SqlCommand cmd = new SqlCommand("select * from orders,schedules,rooms,bills,services,categories where orders.schedule_id=schedules.schedule_id and schedules.room_id=rooms.room_id and orders.bill_id=bills.bill_id and orders.service_id=services.service_id and services.cat_id=categories.cat_id and schedules.schedule_status=0 and orders.order_status=1 and orders.schedule_id=" + schedule_id + "", con);
		SqlDataReader rd = cmd.ExecuteReader();
		while (rd.Read())
		{
			orders ord = new orders();
			ord.order_id = (int)rd["order_id"];
			ord.schedule_id = (int)rd["schedule_id"];
			ord.service_id = (int)rd["service_id"];
			ord.quantity = (int)rd["quantity"];
			ord.order_price = (float)(ord.quantity * svc.getPrice(ord.service_id));
			ord.bill_id = (int)rd["bill_id"];
			ord.fullname = (string)rd["fullname"];
			ord.room_name = (string)rd["room_name"];
			ord.service_name = (string)rd["service_name"];
			li.Add(ord);
		}
		con.Close();
		return li;
	}

	//them Order
	public void addOrder(orders o)
	{
		con.Open();
		SqlCommand cmd = new SqlCommand("insert into orders values(@schedule_id,@service_id,@quantity,@order_price,@bill_id,@order_status)", con);
		cmd.Parameters.AddWithValue("schedule_id", o.schedule_id);
		cmd.Parameters.AddWithValue("service_id", o.service_id);
		cmd.Parameters.AddWithValue("quantity", o.quantity);
		cmd.Parameters.AddWithValue("order_price", o.quantity * svc.getPrice(o.service_id));
		cmd.Parameters.AddWithValue("bill_id", o.bill_id);
		cmd.Parameters.AddWithValue("order_status", false);
		cmd.ExecuteNonQuery();
		con.Close();
	}

	//lay bill_id
	public int getBill_id(int schedule_id)
	{
		con.Open();
		SqlCommand cmd = new SqlCommand("select * from bills where bills.schedule_id=" + schedule_id + "", con);
		int b_id = 0;
		SqlDataReader rd = cmd.ExecuteReader();
		if (rd.Read())
			b_id = (int)rd["bill_id"];
		con.Close();
		return b_id;
	}

	//update order
	public void updateOrder(int order_id)
	{
		con.Open();
		SqlCommand cmd = new SqlCommand("update orders set order_status=1 where order_id=" + order_id + "", con);
		cmd.ExecuteNonQuery();
		con.Close();
	}

	//xoa order
	public void deleteOrder(int order_id)
	{
		con.Open();
		SqlCommand cmd = new SqlCommand("delete from orders where order_id=" + order_id + "", con);
		cmd.ExecuteNonQuery();
		con.Close();
	}

	//cap nhat gia dich vu va tong gia hoa don trong hoa don
	public void updateService_price(int bill_id)
	{
		con.Open();
		SqlCommand cmd = new SqlCommand("update bills set price_service=(select sum(order_price) as price_check from orders where bill_id=" + bill_id + "), total_price=(select sum(price_service+price_room) as price_check2 from bills where bill_id=" + bill_id + ") where bill_id=" + bill_id + "", con);
		cmd.ExecuteNonQuery();
		con.Close();
	}
}