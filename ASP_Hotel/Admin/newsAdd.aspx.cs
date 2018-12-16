using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_newsAdd : System.Web.UI.Page
{
    DataUtil data = new DataUtil();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            news_cat_id.DataSource = data.getNewsCategories();
            news_cat_id.DataTextField = "news_cat_name";
            news_cat_id.DataValueField = "news_cat_id";
            DataBind();
        }
    }


    protected void btnThemTin_Click(object sender, EventArgs e)
    {
        try
        {
            news n = new news();
            n.news_title = news_title.Text;
            n.news_description = news_description.Text;
            n.news_content = news_content.Text;
            //n.news_avatar = news_avatar.Text;
            //upload file ảnh
            if (Page.IsValid && FileUpload1.HasFile )
            {
                string fileName = "images/"  + FileUpload1.FileName;
                string filePath = MapPath(fileName);
                FileUpload1.SaveAs(filePath);
                n.news_avatar = FileUpload1.FileName;


            }

            n.news_status = Convert.ToBoolean(news_status.SelectedValue);
            n.news_cat_id = Convert.ToInt32(news_cat_id.SelectedValue);

            data.ThemTin(n);

            err_msg.ForeColor = System.Drawing.Color.Green;
            err_msg.Text = "Thêm phòng thành công!";
        }
        catch (Exception ex)
        {
            err_msg.ForeColor = System.Drawing.Color.Red;
            err_msg.Text = "Đã xảy ra lỗi: " + ex.Message;
        }
    }
}