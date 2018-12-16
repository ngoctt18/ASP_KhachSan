using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_DSNhanVien : System.Web.UI.Page
{
    nhanvien data = new nhanvien();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        HienthiDulieu();
    }
    private void HienthiDulieu()
    {
        grdDsnv.DataSource = data.employees();
        DataBind();
    }
    public void Xoa_Click(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "xoa")
        {
            int m = Convert.ToInt16(e.CommandArgument);
            data.Xoanv(m);
            HienthiDulieu();
        }
    }
    public void Sua_Click(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "sua")
        {
            int m = Convert.ToInt16(e.CommandArgument);
            employees s = data .layra1nv(m);
            Session["nv"] = s;
            Response.Redirect("SuaNV.aspx");



        }
    }
}