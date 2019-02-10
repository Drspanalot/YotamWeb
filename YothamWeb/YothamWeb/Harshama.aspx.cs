using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Harshama : System.Web.UI.Page
{
    public string msg = "";
    protected void Page_Load(object sender, EventArgs e)
    {
        string q;
        if (Request.Form["sub"] != null)
        {
            q = "select * from USERS where TZ='" + Request.Form["tz"] + "'";
            if (DalBll.IsExist(q))
            {
                msg = "משתמש תפוס";
            }
            else
            {
                q = "insert into USERS(TZ,FNAME,LNAME,PHONE,EMAIL,PASS,GENDER,COUNTRY,ADMIN) VALUES(";
                q += "'" + Request.Form["TZ"] + "',";
                q += "N'" + Request.Form["FNAME"] + "',";
                q += "N'" + Request.Form["LNAME"] + "',";
                q += "N'" + Request.Form["PHONE"] + "',";
                q += "'" + Request.Form["EMAIL"] + "',";
                q += "'" + Request.Form["PASS"] + "',";
                q += "N'" + Request.Form["GENDER"] + "',";
                q += "'" + Request.Form["COUNTRY"] + "',";
                q += "'false')";

                DalBll.DoQuery(q);
                msg = "<font style = color:blue> הרשמתך התקבלה </font>";
            }
        }
    }
}