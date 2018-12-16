using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Admin_newsEdit : System.Web.UI.Page
{
    DataUtil data = new DataUtil();
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            news n = (news)Session["new"];
            //news_id.Text = Convert.ToString(n.news_id);
            news_id.Text = n.news_id.ToString();
            news_title.Text = n.news_title;
            news_description.Text = n.news_description;
            news_content.Text = n.news_content;
            //news_avatar.Text = n.news_avatar;

            string urlImg = "images/" +n.news_avatar;
            news_avatar.ImageUrl = urlImg;

            news_cat_id.DataSource = data.getNewsCategories();
            news_cat_id.DataValueField = "news_cat_id";
            news_cat_id.DataTextField = "news_cat_name";
            DataBind();
            news_cat_id.SelectedValue = n.news_cat_id.ToString();

            //news_status.ClearSelection();
            news_status.Items.FindByValue(n.news_status.ToString()).Selected = true;
        }
    }

    protected void btnSuaTin_Click(object sender, EventArgs e)
    {
        try
        {
            news n = new news();
            n.news_id = int.Parse(news_id.Text);
            n.news_title = news_title.Text;
            n.news_description = news_description.Text;
            n.news_content = news_content.Text;

            //upload file ảnh
            if (Page.IsValid && FileUpload1.HasFile)
            {
                string fileName = "images/" + FileUpload1.FileName;
                string filePath = MapPath(fileName);
                FileUpload1.SaveAs(filePath);
                n.news_avatar = FileUpload1.FileName;


            }

            n.news_status = Convert.ToBoolean(news_status.SelectedValue);
            n.news_cat_id = Convert.ToInt32(news_cat_id.SelectedValue);

            data.CapnhatTin(n);

            err_msg.ForeColor = System.Drawing.Color.Green;
            err_msg.Text = "Cập nhật phòng thành công!";
        }
        catch (Exception ex)
        {
            err_msg.ForeColor = System.Drawing.Color.Red;
            err_msg.Text = "Da xay ra loi: " + ex.Message;
        }
    }
}