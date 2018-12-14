using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for rooms
/// </summary>
public class rooms
{
	public rooms()
	{
		//
		// TODO: Add constructor logic here
		//
	}
	public int room_id { get; set; }
	public string room_name { get; set; }
	public string avatar { get; set; }
	public Boolean room_status { get; set; }
	public int room_type_id { get; set; }


	public string room_type_name { get; set; }
	public string getRoom_status {
		get
		{
			if (this.room_status == true)
				return "Đã thuê";
			else
				return "Còn trống";
		}
		set
		{
			if (this.room_status == true)
				this.room_status = true;
			else
				this.room_status = false;
		}
	}
}