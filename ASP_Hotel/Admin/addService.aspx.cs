using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_addService : System.Web.UI.Page
{
    Categories ctg = new Categories();
    Services svc = new Services();
    protected void Page_Load(object sender, EventArgs e)
    {
        //lay data ra dropdownlist
        if (!IsPostBack)
        {
            drpcategoryonaddservice.DataSource = ctg.getCategories();
            drpcategoryonaddservice.DataTextField = "cat_name";
            drpcategoryonaddservice.DataValueField = "cat_id";
            DataBind();
        }
    }

    protected void btnaddService_Click(object sender, EventArgs e)
    {
        try
        {
            services s = new services();
            s.service_name = txtservice_name.Text;
            s.price = double.Parse(txtprice.Text);
            s.cat_id = int.Parse(drpcategoryonaddservice.SelectedValue.ToString());
            s.service_description = txtservice_description.Text;
            svc.addService(s);
            lbmsgaddservice.Text = "Thêm thành công";
        }
        catch
        {
            lbmsgaddservice.Text = "Có lỗi, không thêm được";
        }
    }
}