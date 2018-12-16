using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminList : System.Web.UI.Page
{
    DataUtil data = new DataUtil();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        HienThiDuLieu();
    }

    private void HienThiDuLieu()
    {
        grdDs.DataSource = data.getAdmins();
        DataBind();
    }

    protected void Xoa_Click(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "xoa")
        {
            int m = Convert.ToInt16(e.CommandArgument);
            data.Xoaadmin(m);
            HienThiDuLieu();
        }
    }

    protected void Sua_Click(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "sua")
        {
            int m = Convert.ToInt16(e.CommandArgument);
            admins a = data.Layra1admin(m);
            Session["aa"] = a;

            Response.Redirect("AdminsEdit.aspx");
        }
    }
}