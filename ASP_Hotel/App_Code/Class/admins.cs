using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for admins
/// </summary>
public class admins
{
	public admins()
	{
		//
		// TODO: Add constructor logic here
		//
	}
	public int admin_id { get; set; }
	public string phone { get; set; }
	public string password { get; set; }
	public string email { get; set; }
	public string address { get; set; }
	public string avatar { get; set; }
}