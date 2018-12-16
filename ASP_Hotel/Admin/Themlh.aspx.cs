using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Themlh : System.Web.UI.Page
{
    lienhe data = new lienhe();
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
            contacts s = new contacts();
            s.fullname = txtfullname.Text;
            s.phone = txtphone.Text;
            s.email = txtemail.Text;
            s.message = txtmassage.Text;
          
            data.Themlh(s);
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