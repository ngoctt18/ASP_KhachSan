using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for users
/// </summary>
public class users
{
    public users()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int user_id { get; set; }
    public string phone { get; set; }
    public string password { get; set; }
    public string email { get; set; }
    public string address { get; set; }
}