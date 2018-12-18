using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Thembp : System.Web.UI.Page
{
    bophan data = new bophan();
    protected void Page_Load(object sender, EventArgs e)
    {
        if(!IsPostBack)
        {

            DataBind();
        }
    }

    protected void btnthem_Click(object sender, EventArgs e)
    {
        try
        {
            departments s = new departments();
            s.department_name = txtdepartment_name.Text;
          

            data.Thembp(s);
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
