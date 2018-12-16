using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Sualh : System.Web.UI.Page
{
    lienhe data = new lienhe();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            contacts lh = (contacts)Session["lh"];
            txtcontact_id.Text = lh.contact_id.ToString();
            txtphone.Text = lh.phone;
            txtfullname.Text = lh.fullname;
            txtemail.Text = lh.email;
            txtmessage.Text = lh.message;
            
            DataBind();
          
        }
    }

    protected void btnsua_Click(object sender, EventArgs e)
    {
        try
        {
            contacts s = (contacts)Session["lh"];
            s.phone = txtphone.Text;
            s.fullname = txtfullname.Text;
            s.email = txtemail.Text;
            s.message = txtmessage.Text;
          
          

            data.Capnhatlh(s);
            msg.Text = "Ban cap nhat thanh cong";
        }
        catch (Exception ex)
        {
            msg.Text = " co loi :" + ex;
        }
    }
}