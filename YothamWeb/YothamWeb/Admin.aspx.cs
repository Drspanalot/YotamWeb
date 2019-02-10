using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class Admin : System.Web.UI.Page
{
    public string supportList = "";
    String q = "select * from users";
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["user"] == null)
        Response.Redirect("PageAdmin.aspx");
        if ((bool)Session["admin"] != true)
        Response.Redirect("PageAdmin.aspx");
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter(q, DalBll.GetConnection());
        da.Fill(ds,"USERS");
        DataTable dt = ds.Tables["USERS"];

        supportList += "<table cellpadding='2' cellspacing='1' border='3'>";
        supportList += "<tr >";
        supportList += "<th > תעודת זהות</th>";
        supportList += "<th > שם פרטי</th>";
        supportList += "<th > שם משפחה</th>";
        supportList += "<th >מין</th>";
        supportList += "<th >טלפון</th>";
        supportList += "<th >אימייל</th>";
        supportList += "<th >מדינה</th>";
        supportList += "<th >סיסמא</th>";
        supportList += "<th >מנהל</th>";
        supportList += "</tr>";


        for (int i = 0; i < dt.Rows.Count; i++)
        {
            supportList += "<tr>";
            supportList += "<td >" + dt.Rows[i]["TZ"] + "</td>";
            supportList += "<td >" + dt.Rows[i]["FNAME"] + "</td>";
            supportList += "<td >" + dt.Rows[i]["LNAME"] + "</td>";
            supportList += "<td >" + dt.Rows[i]["GENDER"] + "</td>";
            supportList += "<td >" + dt.Rows[i]["PHONE"] + "</td>";
            supportList += "<td >" + dt.Rows[i]["EMAIL"] + "</td>";
            supportList += "<td >" + dt.Rows[i]["COUNTRY"] + "</td>";
            supportList += "<td >" + dt.Rows[i]["PASS"] + "</td>";
            supportList += "<td >" + dt.Rows[i]["ADMIN"] + "</td>";
            supportList += "</tr>";
        }
        supportList += "</table>";
    }
}