using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for news
/// </summary>
public class news
{
    public news()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int news_id { get; set; }
    public string news_title { get; set; }
    public string news_description { get; set; }
    public string news_content { get; set; }
    public string news_avatar { get; set; }
    public int news_cat_id { get; set; }
    public Boolean news_status { get; set; }

    public string news_cat_name { get; set; }

    public string getNews_status
    {
        get
        {
            if (this.news_status == true)
                return "Hiện tin";
            else
                return "Ẩn tin";
        }
        set
        {
            if (this.news_status == true)
                this.news_status = true;
            else
                this.news_status = false;
        }
    }
}