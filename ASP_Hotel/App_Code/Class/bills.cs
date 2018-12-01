using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for bills
/// </summary>
public class bills
{
	public bills()
	{
		//
		// TODO: Add constructor logic here
		//
	}
	public int bill_id { get; set; }
	public int schedule_id { get; set; }
	public int num_day { get; set; }
	public float price_room { get; set; }
	public float price_service { get; set; }
	public float total_price { get; set; }
	public Boolean bill_status { get; set; }
}