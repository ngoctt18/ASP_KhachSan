using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_SuaNV : System.Web.UI.Page
{
    nhanvien data = new nhanvien();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            employees nv = (employees)Session["nv"];
            txtemployee_id.Text = nv.employee_id.ToString();
            txtphone.Text = nv.phone;
            txtpassword.Text = nv.password;
            txtemail.Text = nv.email;
            txtaddress.Text = nv.address;
            string urlImg = "images/" + nv.avatar;
            avatar.ImageUrl = urlImg;
            //txtavatar.Text = nv.avatar;
            dddepartment_id.DataSource = data.departments();
            dddepartment_id.DataTextField = "department_name";
            dddepartment_id.DataValueField = "department_id";
            DataBind();
            dddepartment_id.SelectedValue = nv.department_id.ToString();
        }
    }

    protected void btnsua_Click(object sender, EventArgs e)
    {
        try
        {
            employees s = (employees)Session["nv"];
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
            s.employee_id = int.Parse(txtemployee_id.Text);

            data.Capnhatnv(s);
            msg.Text = "Ban cap nhat thanh cong";
        }
        catch (Exception ex)
        {
            msg.Text = " co loi :" + ex;
        }

    }
}