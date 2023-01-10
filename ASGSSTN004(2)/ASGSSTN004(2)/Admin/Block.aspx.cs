using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASGSSTN004_2_.Admin
{
    public partial class Block : System.Web.UI.Page
    {
        Db db = new Db();
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = db.Executedataset("select * from Employe e inner join Login l on e.LoginId=l.LoginId");
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string id = GridView1.DataKeys[e.RowIndex].Value.ToString();
            db.Executenonquery("update Login set status='Blocked' where LoginId='" + id + "'");

            GridView1.DataSource = db.Executedataset("select * from Employe e inner join Login l on e.LoginId=l.LoginId");
            GridView1.DataBind();
        }
    }
}