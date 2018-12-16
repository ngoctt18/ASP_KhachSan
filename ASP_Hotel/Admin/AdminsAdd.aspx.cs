using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_AdminsAdd : System.Web.UI.Page
{
    DataUtil data = new DataUtil();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnThem_Click(object sender, EventArgs e)
    {
        try
        {
            admins a = new admins();
            a.phone = txtphone.Text;
            a.password = txtpassword.Text;
            a.email = txtemail.Text;
            a.address = txtaddress.Text;
            //a.avatar = txtavartar.Text;

            {
                string fileName = "images/" + FileUpload3.FileName;
                string filePath = MapPath(fileName);
                FileUpload3.SaveAs(filePath);
                a.avatar = FileUpload3.FileName;


            }
            data.Themadmin(a);
            msg.ForeColor = System.Drawing.Color.Red;
            msg.Text = "Thêm thành công";
        }
        catch (Exception ex)
        {

            msg.Text = "Không thêm được,có lỗi:" + ex.Message;
        }
    }
}