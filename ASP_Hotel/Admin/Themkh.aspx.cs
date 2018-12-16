using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Themkh : System.Web.UI.Page
{
    khachhang data = new khachhang();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {

            DataBind();
        }
    }

    protected void btnthem_Click(object sender, EventArgs e)
    {
        try
        {
            users s = new users();
            s.password = txtpassword.Text;
            s.phone = txtphone.Text;
            s.email = txtemail.Text;
            s.address = txtaddress.Text;

            data.Themkh(s);
            msg.ForeColor = System.Drawing.Color.Blue;
            msg.Text = "Them thanh cong";


        }
        catch (Exception ex)
        {
            msg.ForeColor = System.Drawing.Color.Red;
            msg.Text = " khong them duoc, co loi:" + ex.Message;
        }
    }
}