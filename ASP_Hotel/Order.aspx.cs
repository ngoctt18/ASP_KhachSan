using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Order : System.Web.UI.Page
{
    OrderServices ord = new OrderServices();
    Categories ctg = new Categories();
    categories ct = new categories();
    Services svc = new Services();
    
    protected void Page_Load(object sender, EventArgs e)
    {
        RandomSlide();
        if(!IsPostBack)
        {
            drppickroom.DataSource = ord.getRoom_namefordrp();
            drppickroom.DataValueField = "schedule_id";
            drppickroom.DataTextField = "room_name";


            //drppickcategory.DataSource = ctg.getCategories();
            //drppickcategory.DataTextField = "cat_name";
            //drppickcategory.DataValueField = "cat_id";

            drppickservice.DataSource = svc.getallServices();
            drppickservice.DataTextField = "service_name";
            drppickservice.DataValueField = "service_id";
            DataBind();
        }

    }
    protected void Timer2_Tick(object sender, EventArgs e)
    {
        RandomSlide();
    }
    private void RandomSlide()
    {
        Random r = new Random();
        int n = r.Next(1, 5);
        imgSlide.ImageUrl = "assets/images/ban" + n + ".jpg";
    }

    protected void btnOderUser_Click(object sender, EventArgs e)
    {
        try
        {
            orders o = new orders();
            o.schedule_id=int.Parse(drppickroom.SelectedValue.ToString());
            o.service_id = int.Parse(drppickservice.SelectedValue.ToString());
            o.quantity = int.Parse(txtpickquantity.Text.ToString());
            o.bill_id = ord.getBill_id(int.Parse(drppickroom.SelectedValue.ToString()));
			ord.addOrder(o);
			ord.updateService_price(int.Parse(drppickroom.SelectedValue.ToString()));
			ord.updateTotal_price(int.Parse(drppickroom.SelectedValue.ToString()));
            err_msg.ForeColor = System.Drawing.Color.White;
            err_msg.Text = "Đặt dịch vụ thành công";
        }
        catch
        {
            err_msg.ForeColor = System.Drawing.Color.White;
            err_msg.Text = "Đã xảy ra lỗi, không đặt được";
        }
    }
    protected void drppickcategory_SelectedIndexChanged(object sender, EventArgs e)
    {
        //var c_id = int.Parse(drppickcategory.SelectedValue);
        //drppickservice.DataSource = svc.getServices(c_id);
        //drppickservice.DataTextField = "service_name";
        //drppickservice.DataValueField = "service_id";
        //DataBind();
    }
}