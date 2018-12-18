using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_room_typesAdd : System.Web.UI.Page
{
    DataUtil data = new DataUtil();

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnThem_Click(object sender, EventArgs e)
    {
        try
        {
            room_types rt = new room_types();
            rt.room_type_name = txtroom_type_name.Text;
            data.addroom_types(rt);
            msg.ForeColor = System.Drawing.Color.Red;
            msg.Text = "Thêm thành công";
        }
        catch (Exception ex)
        {

            msg.Text = "Không thêm được,có lỗi:" + ex.Message;
        }
    }
}