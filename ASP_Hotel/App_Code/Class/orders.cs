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
	public float order_price { get; set; }
	public int bill_id { get; set; }
}