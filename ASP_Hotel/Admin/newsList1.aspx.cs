using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_newsList1 : System.Web.UI.Page
{
    DataUtil data = new DataUtil();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
            DanhSachTin();
    }

    private void DanhSachTin()
    {
        grvNews.DataSource = data.getNews1();
        DataBind();
    }
}