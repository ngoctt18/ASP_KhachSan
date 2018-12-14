using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for orders
/// </summary>
public class orders
{
	public orders()
	{
		//
		// TODO: Add constructor logic here
		//
	}

	public int order_id { get; set; }
	public int schedule_id { get; set; }
	public int service_id { get; set; }
	public int quantity { get; set; }
	public double order_price { get; set; }
	public int bill_id { get; set; }
	public Boolean order_status { get; set; }
	public string fullname { get; set; }
    public string room_name { get; set; }
    public string service_name { get; set; }
    public double price { get; set; }
    public int room_id { get; set; }
    public string cat_name { get; set; }
    public int cat_id { get; set; }
}