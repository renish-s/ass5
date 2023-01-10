using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASGSSTN004_2_.Guest
{
    public partial class Login : System.Web.UI.Page
    {
        Db db = new Db();


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string sql = "SELECT * FROM Login WHERE username='" + txtuname.Text + "' AND password='" + txtpswd.Text + "'";
            DataTable dtobj = db.Executedatatable(sql);



            if (dtobj.Rows.Count == 1)
            {

                Session["uid"] = dtobj.Rows[0]["LoginId"];
                Session["uname"] = dtobj.Rows[0]["username"].ToString();
                string a = dtobj.Rows[0]["role"].ToString().Trim();

                if (a == "Admin")
                {
                    Response.Write("<script>alert('Admin Login ')</script>");
                    Response.Redirect("../Admin/Admin.aspx");
                }
                else
                {
                    string c = dtobj.Rows[0]["status"].ToString().Trim();
                    if (c == "Confirm")
                    {
                        Response.Write("<script>alert('Successfully logged in')</script>");
                        Response.Redirect("../User/User.aspx");
                    }
                    else
                    {
                        Response.Write("<script>alert('Failed to login')</script>");
                        Response.Redirect("../Guest/Guest.aspx");
                    }
                }
            }

        }

    }
}