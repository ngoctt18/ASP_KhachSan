using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_news_categoriesList : System.Web.UI.Page
{
    DataUtil data = new DataUtil();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        HienThiDuLieu();
    }

    private void HienThiDuLieu()
    {
        grdDs.DataSource = data.getNewsCategories();
        DataBind();
    }

    protected void Xoa_Click(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "xoa")
        {
            int m = Convert.ToInt16(e.CommandArgument);
            data.XoaNewCategories(m);
            HienThiDuLieu();
        }
    }

    protected void Sua_Click(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "sua")
        {
            int m = Convert.ToInt16(e.CommandArgument);
            news_categories n = data.Layra1danhmuc(m);
            Session["nn"] = n;

            Response.Redirect("news_categoriesEdit.aspx");
        }
    }
}