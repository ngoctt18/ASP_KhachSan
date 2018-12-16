using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_news_categoriesAdd : System.Web.UI.Page
{
    DataUtil data = new DataUtil();
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnThem_Click(object sender, EventArgs e)
    {
        try
        {
            news_categories n = new news_categories();
            n.news_cat_name = txtname.Text;
            n.news_cat_description = txtdescription.Text;
            data.ThemNewCategories(n);
            msg.ForeColor = System.Drawing.Color.Red;
            msg.Text = "Thêm thành công";
        }
        catch (Exception ex)
        {

            msg.Text = "Không thêm được,có lỗi:" + ex.Message;
        }
    }
}