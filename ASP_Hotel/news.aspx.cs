using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class news : System.Web.UI.Page
{
	protected void Page_Load(object sender, EventArgs e)
	{
		RandomSlide();
	}
	protected void Timer2_Tick(object sender, EventArgs e)
	{
		RandomSlide();
	}
	private void RandomSlide()
	{
		Random r = new Random();
		int n = r.Next(1, 5);
		imgSlide.ImageUrl = "assets/images/ban" + n + ".jpg";
	}
}