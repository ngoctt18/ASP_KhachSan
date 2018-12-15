using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Sql;
using System.Data.SqlClient;

public partial class Admin_Dangnhap : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnlogin_Click(object sender, EventArgs e)
    {
       
        SqlConnection con = new SqlConnection();
        con.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=qlkhachsan;Integrated Security=True";


        Int32 verify;
        string query1 = "Select count(*) from admins where phone='" + txttentk.Text + "' and Password='" + txtmatkhau.Text + "' ";
        SqlCommand cmd1 = new SqlCommand(query1, con);
        con.Open();
        verify = Convert.ToInt32(cmd1.ExecuteScalar());
        con.Close();
        if (verify > 0)
        {
            Response.Redirect("DSNhanVien.aspx");
        }
        else
        {
            errmsg.Text = "Sai tài khoản hoặc mật khẩu";
        }


    }
}