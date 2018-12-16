using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Lienhe : System.Web.UI.Page
{
    lienhe data = new lienhe();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            HienthiDulieu();
    }
    private void HienthiDulieu()
    {
        grdDslh.DataSource = data.contacts();
        DataBind();
    }
    public void Xoa_Click(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "xoa")
        {
            int m = Convert.ToInt16(e.CommandArgument);
            data.Xoalh(m);
            HienthiDulieu();
        }
    }

    public void Sua_Click(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "sua")
        {
            int m = Convert.ToInt16(e.CommandArgument);
            contacts s = data.layra1lh(m);
            Session["lh"] = s;
            Response.Redirect("Sualh.aspx");



        }
    }
    
}