using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_updateCategory : System.Web.UI.Page
{
    Categories ctg = new Categories();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            categories ct = (categories)Session["ctg"];
            txtcat_name.Text=ct.cat_name;
            DataBind();
        }
    }
    protected void btnupdatecategory_Click(object sender, EventArgs e)
    {
        try
        {
            categories ct = (categories)Session["ctg"];
            ct.cat_name = txtcat_name.Text;
            ctg.updateCategory(ct);
            msgudpatecategory.Text = "Cập nhật thành công";
        }
        catch
        {
            msgudpatecategory.Text = "Có lỗi, không cập nhật được";
        }
    }
}