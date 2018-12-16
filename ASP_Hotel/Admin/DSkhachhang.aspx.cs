using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class DSkhachhang : System.Web.UI.Page
{
    khachhang data = new khachhang();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            HienthiDulieu();
    }
    private void HienthiDulieu()
    {
        grdDskh.DataSource = data.users();
        DataBind();
    }
    public void Xoa_Click(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "xoa")
        {
            int m = Convert.ToInt16(e.CommandArgument);
            data.Xoakh(m);
            HienthiDulieu();
        }
    }
    public void Sua_Click(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "sua")
        {
            int m = Convert.ToInt16(e.CommandArgument);
            users s = data.layra1kh(m);
            Session["kh"] = s;
            Response.Redirect("Suakh.aspx");



        }
    }
}