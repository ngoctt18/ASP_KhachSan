using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_ThemNV : System.Web.UI.Page
{
    nhanvien data = new nhanvien();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            dddepartment_id.DataSource = data.departments();
            dddepartment_id.DataTextField = "department_name";
            dddepartment_id.DataValueField = "department_id";
            DataBind();
        }
    }

    protected void btnthem_Click(object sender, EventArgs e)
    {
        try
        {
            employees s = new employees();
            s.phone = txtphone.Text;
            s.password = txtpassword.Text;
            s.email = txtemail.Text;
            s.address = txtaddress.Text;
            s.department_id = int.Parse(dddepartment_id.SelectedValue);
            //s.avatar = txtavatar.Text;
            if (Page.IsValid && FileUpload.HasFile)
            {
                string fileName = "images/" + FileUpload.FileName;
                string filePath = MapPath(fileName);
                FileUpload.SaveAs(filePath);
                s.avatar = FileUpload.FileName;
            }
            data.Themnv(s);
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