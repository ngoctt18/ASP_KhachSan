using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_room_typesEdit : System.Web.UI.Page
{
    DataUtil data = new DataUtil();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            room_types rt = (room_types)Session["nn"];
            txtroom_type_id.Text = Convert.ToString(rt.room_type_id);
            txtroom_type_name.Text = rt.room_type_name;
            DataBind();
        }
    }

    protected void btnSua_Click(object sender, EventArgs e)
    {
        try
        {
            room_types rt = new room_types();
            rt.room_type_id = int.Parse(txtroom_type_id.Text);
            rt.room_type_name = txtroom_type_name.Text;
            data.Capnhatloaiphong(rt);
            msg.Text = "Bạn cập nhật thành công.";
        }
        catch (Exception ex)
        {

            msg.Text = "Có lỗi:" + ex;
        }
    }
}