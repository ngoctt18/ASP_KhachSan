using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Admin_Categories : System.Web.UI.Page
{

    Categories ctg = new Categories();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            hienthi();
        }
        
    }
    public void hienthi()
    {
        grdcategories.DataSource = ctg.getCategories();
        DataBind();
    }
    protected void deleteCategories_Command(object sender, CommandEventArgs e)
    {
        if(e.CommandName=="deletecategories")
        {
            int x = Convert.ToInt16(e.CommandArgument);
            ctg.deleteCategories(x);
            hienthi();
        }
    }
    protected void addcategory_Click(object sender, EventArgs e)
    {
       
    }
    
    
    protected void updateCategories_Command(object sender, CommandEventArgs e)
    {
        if(e.CommandName=="updatecategories")
        {
            int u = Convert.ToInt16(e.CommandArgument);
            categories ct = ctg.get1Category(u);
            Session["ctg"] = ct;
            Response.Redirect("updateCategory.aspx");
        }
    }
}