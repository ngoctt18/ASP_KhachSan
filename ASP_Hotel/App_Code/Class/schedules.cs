using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for schedules
/// </summary>
public class schedules
{
	public schedules()
	{
		//
		// TODO: Add constructor logic here
		//
	}

	public int schedule_id { get; set; }
	public string fullname { get; set; }
	public string phone { get; set; }
	public string email { get; set; }
	public int room_id { get; set; }
	public DateTime date_in { get; set; }
	public DateTime date_out { get; set; }
	public Boolean schedule_status { get; set; }


	public string room_name { get; set; }

}