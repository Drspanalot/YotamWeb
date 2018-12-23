using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage : System.Web.UI.MasterPage
{
    public string login = "";
    protected void Page_Load(object sender, EventArgs e)
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
        login += "<td><input type=\"text\" size=15; name=\"ident\"/></td>";
        login += "</tr>";
        login += "<tr>";
        login += "<tr><td colspan=\"2\"><center><input type=\"submit\" name=\"conc\"value=\"התחבר\"/></td></center></tr>";
        login += "</table>";


    }
}
