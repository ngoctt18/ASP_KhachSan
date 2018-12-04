using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Services : System.Web.UI.Page
{
    Categories ctg = new Categories();
    Services svc = new Services();
    protected void Page_Load(object sender, EventArgs e)
    {

        //lay data ra dropdownlist
        if(!IsPostBack)
        {
            drpcategory.DataSource = ctg.getCategories();
            drpcategory.DataTextField = "cat_name";
            drpcategory.DataValueField = "cat_id";
            DataBind();
        }
        //grdservices.DataSource = svc.getServices();
        //DataBind();
        
    }
    protected void drpcategory_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    public void hienthi()
    {
        var cat_id = int.Parse(drpcategory.SelectedValue);
        grdservices.DataSource = svc.getServices(cat_id);
        DataBind();
    }
    protected void btnhienthi_Click(object sender, EventArgs e)
    {
        hienthi();
    }
    protected void deleteservices_Command(object sender, CommandEventArgs e)
    {
        if (e.CommandName == "deleteservices")
        {
            int x = Convert.ToInt16(e.CommandArgument);
            svc.deleteServices(x);
            hienthi();
        }
    }
    protected void updateservices_Command(object sender, CommandEventArgs e)
    {
        if(e.CommandName=="updateservices")
        {
            int u = Convert.ToInt16(e.CommandArgument);
            services s = svc.get1Service(u);
            Session["svc"] = s;
            Response.Redirect("updateService.aspx");
        }
    }
}