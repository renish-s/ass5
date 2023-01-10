using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASGSSTN004_1.Employee_
{
    public partial class test : System.Web.UI.Page
    {
        Class1 db = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            string Id = Request.QueryString["Id"];
            DataTable dt = db.exedatatable("select * from emp where Id ='" + Id + "'");
            Label2.Text = dt.Rows[0]["name"].ToString();
            Label4.Text = dt.Rows[0]["email"].ToString();
            Label6.Text = dt.Rows[0]["phn"].ToString();
            Label8.Text = dt.Rows[0]["age"].ToString();
        }
    }
}