using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for contacts
/// </summary>
public class contacts
{
    public contacts()
    {
        //
        // TODO: Add constructor logic here
        //
    }
    public int contact_id { get; set; }
    public string fullname { get; set; }
    public string phone { get; set; }
    public string email { get; set; }
    public string message { get; set; }
  
}