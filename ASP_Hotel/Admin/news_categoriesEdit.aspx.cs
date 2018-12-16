using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_news_categoriesEdit : System.Web.UI.Page
{
    DataUtil data = new DataUtil();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            news_categories n = (news_categories)Session["nn"];
            txtid.Text = Convert.ToString(n.news_cat_id);
            txtname.Text = n.news_cat_name;
            txtdescription.Text = n.news_cat_description;
            DataBind();
        }
    }

    protected void btnSua_Click(object sender, EventArgs e)
    {
        try
        {
            news_categories n = new news_categories();
            n.news_cat_id = int.Parse(txtid.Text);
            n.news_cat_name = txtname.Text;
            n.news_cat_description = txtdescription.Text;
            data.Capnhatdanhmuc(n);
            msg.Text = "Bạn cập nhật thành công.";
        }
        catch (Exception ex)
        {

            msg.Text = "Có lỗi:" + ex;
        }
    }
}