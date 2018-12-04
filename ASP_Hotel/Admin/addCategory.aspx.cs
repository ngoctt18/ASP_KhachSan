using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_addCategory : System.Web.UI.Page
{
    Categories ctg = new Categories();
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnaddcategory_Click(object sender, EventArgs e)
    {
        try
        {
            categories ct = new categories();
            ct.cat_name = txtcat_name.Text;
            ctg.addCategory(ct);
            msgaddcategory.Text = "Thêm thành công";
        }
        catch
        {
            msgaddcategory.Text = "Có lỗi";
        }
    }
}