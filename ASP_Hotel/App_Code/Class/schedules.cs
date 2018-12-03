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

	public string getSchedule_status
	{
		get
		{
			if (this.schedule_status == true)
				return "Đã trả phòng";
			else
				return "Đang ở";
		}
		set
		{
			if (this.schedule_status == true)
				this.schedule_status = true;
			else
				this.schedule_status = false;
		}
	}

	public string getDate_in
	{
		get
		{
			return this.date_in.ToString("dd/MM/yyyy");
		}
		set
		{
			this.date_in = Convert.ToDateTime(value);
		}
	}
	public string getDate_out
	{
		get
		{
			return this.date_out.ToString("dd/MM/yyyy");
		}
		set
		{
			this.date_out = Convert.ToDateTime(value);
		}
	}
}