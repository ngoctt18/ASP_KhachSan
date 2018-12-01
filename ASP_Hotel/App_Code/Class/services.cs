using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for services
/// </summary>
public class services
{
	public services()
	{
		//
		// TODO: Add constructor logic here
		//
	}
	public int service_id { get; set; }
	public string service_name { get; set; }
	public float price { get; set; }
	public int cat_id { get; set; }
	public string service_description { get; set; }
}