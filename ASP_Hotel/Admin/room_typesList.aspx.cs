using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_room_typesList : System.Web.UI.Page
{
    DataUtil data = new DataUtil();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
            Hienthi();
    }

    private void Hienthi()
    {
        grdroom_types.DataSource = data.getRoom_types();
        DataBind();
    }

    protected void Xoa_Click(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "xoa")
        {
            int rt = Convert.ToInt16(e.CommandArgument);
            data.deleteRoom_types(rt);
            Hienthi();
        }
    }

    protected void Sua_Click(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "sua")
        {
            int m = Convert.ToInt16(e.CommandArgument);
            room_types rt = data.Layra1phong(m);
            Session["nn"] = rt;

            Response.Redirect("room_typesEdit.aspx");
        }
    }
}