using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_newsList : System.Web.UI.Page
{
    DataUtil data = new DataUtil();

    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            DanhSachDangtin();
    }

    private void DanhSachDangtin()
    {
        grvNews.DataSource = data.getNews();
        DataBind();
    }

    protected void Xoa_Click(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "xoa")
        {
            int news_id = Convert.ToInt16(e.CommandArgument);
            data.deleteNew(news_id);
            DanhSachDangtin();
        }
    }

    protected void Sua_Click(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "sua")
        {
            int news_id = Convert.ToInt16(e.CommandArgument);
            news n = data.get1New(news_id);
            Session["new"] = n;
            Response.Redirect("newsEdit.aspx");
        }
    }
}