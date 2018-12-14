using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_updateService : System.Web.UI.Page
{
    Services svc = new Services();
    Categories ctg = new Categories();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {
            services s = (services)Session["svc"];
            txtservice_name.Text = s.service_name;
            txtprice.Text = s.price.ToString();
            txtservice_description.Text = s.service_description;
            drpcategoryonaddservice.DataSource = ctg.getCategories();
            drpcategoryonaddservice.DataTextField = "cat_name";
            drpcategoryonaddservice.DataValueField = "cat_id";
            DataBind();
            drpcategoryonaddservice.SelectedValue = s.cat_id.ToString();
        }
    }
    protected void btnupdateService_Click(object sender, EventArgs e)
    {
        try
        {
            services s = (services)Session["svc"];
            s.service_name = txtservice_name.Text;
            s.price = double.Parse(txtprice.Text);
            s.cat_id = int.Parse(drpcategoryonaddservice.SelectedValue.ToString());
            s.service_description = txtservice_description.Text;
            svc.updateService(s);
            lbmsgupdateservice.Text = "Cập nhật thành công";
        }
        catch
        {
            lbmsgupdateservice.Text = "Có lỗi, không cập nhật được";
        }
    }
}