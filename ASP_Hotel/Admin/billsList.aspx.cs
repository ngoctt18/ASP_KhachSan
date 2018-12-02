using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_billsList : System.Web.UI.Page
{
	KHDatPhong data = new KHDatPhong();
	protected void Page_Load(object sender, EventArgs e)
	{
		if (!IsPostBack)
			DanhSachHoaDon();
	}

	private void DanhSachHoaDon()
	{
		grvDSHoaDon.DataSource = data.getBills();
		DataBind();
	}

	protected void ThanhToan_Click(object sender, CommandEventArgs e)
	{
		if (e.CommandName == "ThanhToan") {
			int bill_id = Convert.ToInt16(e.CommandArgument);
			data.ThanhToanHoaDon(bill_id);
			DanhSachHoaDon();
		}
	}
}