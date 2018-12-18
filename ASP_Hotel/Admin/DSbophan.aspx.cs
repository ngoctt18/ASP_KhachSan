using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_DSbophan : System.Web.UI.Page
{
    bophan data = new bophan();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            HienthiDulieu();
    }
    private void HienthiDulieu()
    {
        grdDsbp.DataSource = data.departments();
        DataBind();
    }

    public void Sua_Click(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "sua")
        {
            int m = Convert.ToInt16(e.CommandArgument);
            departments s = data.layra1bp(m);
            Session["bp"] = s;
            Response.Redirect("Suabp.aspx");



        }
    }
    public void Xoa_Click(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "xoa")
        {
            int m = Convert.ToInt16(e.CommandArgument);
            data.Xoabp(m);
            HienthiDulieu();
        }
    }
}