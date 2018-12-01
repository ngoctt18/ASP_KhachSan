using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for employees
/// </summary>
public class employees
{
	public employees()
	{
		//
		// TODO: Add constructor logic here
		//
	}
	public int employee_id { get; set; }
	public string phone { get; set; }
	public string password { get; set; }
	public string email { get; set; }
	public string address { get; set; }
	public int department_id { get; set; }
	public string avatar { get; set; }
}