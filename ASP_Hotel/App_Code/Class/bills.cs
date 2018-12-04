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
	public double price_room { get; set; }
	public double price_service { get; set; }
	public double total_price { get; set; }
	public Boolean bill_status { get; set; }

	public string getBill_status
	{
		get
		{
			if (this.bill_status == true)
				return "Đã thanh toán";
			else
				return "Chưa thanh toán";
		}
		set
		{
			if (this.bill_status == true)
				this.bill_status = true;
			else
				this.bill_status = false;
		}
	}
	public string fullname { get; set; }
	public string phone { get; set; }
}