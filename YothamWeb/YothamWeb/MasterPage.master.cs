using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;


public partial class MasterPage : System.Web.UI.MasterPage
{
    public string login = "";
    string p;
    public string punnel;
    public string home;
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        {
            login += "<table border=\"0\" cellpadding=\"0\" cellspacing=\"10\" style=\"direction: rtl\" translate=\"no\">";
            login += "<tr>";
            login += "<td><b> תעודת זהות </b>";
            login += "</td>";
            login += "<td><input type=\"text\" size=15; name=\"ident\"/></td>";
            login += "</tr>";
            login += "<tr>";
            login += "<td><b> סיסמא </b>";
            login += "</td>";
            login += "<td><input type=\"text\" size=15; name=\"PASS\"/></td>";
            login += "</tr>";
            login += "<tr>";
            login += "<tr><td colspan=\"2\"><center><input type=\"submit\" name=\"conc\"value=\"התחבר\"/></td></center></tr>";
            login += "</table>";
            if (Request.Form["conc"] != null)
            {
                p = " select * from USERS where TZ='" + Request.Form["ident"] + "' and PASS='" + Request.Form["PASS"] + "'";
                SqlDataReader data = DalBll.DataReadSQL(p);
                if (data.Read())
                {
                    Session["id"] = data["TZ"];
                    Session["admin"] = data["ADMIN"];
                    Session["user"] = data["FNAME"] + " " + data["LNAME"];
                }

                Response.Redirect("Home.aspx");

            }
        }
        else
        {
            home = "שלום " + " " + Session["user"];
            punnel = "<a href=edit.aspx>פרטים אישיים</a>|<a href =logout.aspx>תתנתק</a>";
            if ((bool)Session["admin"])
            {
                punnel += "|<a href= Admin.aspx>משתמשים</a>";
            }
        }

    }
}

