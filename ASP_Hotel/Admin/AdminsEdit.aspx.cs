using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminsEdit : System.Web.UI.Page
{
    DataUtil data = new DataUtil();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            admins a = (admins)Session["aa"];
            txtid.Text = Convert.ToString(a.admin_id);
            txtphone.Text = a.phone;
            txtpassword.Text = a.password;
            txtemail.Text = a.email;
            txtaddress.Text = a.address;
            txtavartar.Text = a.avatar;
            DataBind();
        }
    }

    protected void btnSua_Click(object sender, EventArgs e)
    {
        try
        {
            admins a = new admins();
            a.admin_id = int.Parse(txtid.Text);
            a.phone = txtphone.Text;
            a.password = txtpassword.Text;
            a.email = txtemail.Text;
            a.address = txtaddress.Text;
            a.avatar = txtavartar.Text;
            data.Capnhatadmin(a);
            msg.Text = "Bạn cập nhật thành công.";
        }
        catch (Exception ex)
        {

            msg.Text = "Có lỗi:" + ex;
        }
    }
}