using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_Suabp : System.Web.UI.Page
{
    bophan data = new bophan();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            departments bp = (departments)Session["bp"];
            txtdeparment_id.Text = bp.department_id.ToString();
            txtdepartment_name.Text = bp.department_name;
           

            DataBind();

        }
    }

    protected void btnsua_Click(object sender, EventArgs e)
    {
        try
        {
            departments s = (departments)Session["bp"];
            s.department_name = txtdepartment_name.Text;
          



            data.Capnhatbp(s);
            msg.Text = "Ban cap nhat thanh cong";
        }
        catch (Exception ex)
        {
            msg.Text = " co loi :" + ex;
        }
    }
}
