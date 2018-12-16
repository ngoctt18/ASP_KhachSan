using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Suakh : System.Web.UI.Page
{
    khachhang data = new khachhang();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            users kh = (users)Session["kh"];
            txtuser_id.Text = kh.user_id.ToString();
            txtphone.Text = kh.phone;
            txtpassword.Text = kh.password;
            txtemail.Text = kh.email;
            txtaddress.Text = kh.address;

            DataBind();

        }
    }
    protected void btnsua_Click(object sender, EventArgs e)
    {
        try
        {
            users s = (users)Session["kh"];
            s.phone = txtphone.Text;
            s.password = txtpassword.Text;
            s.email = txtemail.Text;
            s.address = txtaddress.Text;



            data.Capnhatkh(s);
            msg.Text = "Ban cap nhat thanh cong";
        }
        catch (Exception ex)
        {
            msg.Text = " co loi :" + ex;
        }
    }
}