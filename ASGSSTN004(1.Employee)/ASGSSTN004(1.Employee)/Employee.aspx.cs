using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASGSSTN004_1.Employee_
{
    public partial class Employee : System.Web.UI.Page
    {
        Class1 db = new Class1();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                GridView1.DataSource = db.exedataset("Select * from emp");
                GridView1.DataBind();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into emp values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
            int i = db.exenonquery(sql);
            if (i == 1)
            {
                Response.Write("<script>alert('Registered Successfully');</script>");

            }
            GridView1.DataSource = db.exedataset("Select * from emp");
            GridView1.DataBind();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            GridView1.DataSource = db.exedataset("Select * from emp");
            GridView1.DataBind();
        }

        
        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            GridView1.DataSource = db.exedataset("Select * from emp");
            GridView1.DataBind();
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            string Id = GridView1.DataKeys[e.RowIndex].Value.ToString();
            db.exenonquery("Delete from emp where Id ='" + Id + "'");
            GridView1.DataSource = db.exedataset("Select * from emp");
            GridView1.DataBind();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            string Id = GridView1.DataKeys[e.RowIndex].Value.ToString();

            TextBox txtname = new TextBox();
            txtname = (TextBox)GridView1.Rows[e.RowIndex].Cells[0].Controls[0];

            TextBox txtdesig = new TextBox();
            txtdesig = (TextBox)GridView1.Rows[e.RowIndex].Cells[1].Controls[0];

            TextBox txtsal = new TextBox();
            txtsal = (TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0];

            TextBox txtage = new TextBox();
            txtage = (TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0];

            db.exenonquery("update emp set name='" + txtname.Text + "',email='" + txtdesig.Text + "',phn=" + txtsal.Text + ",age='" + txtage.Text + "' where Id=" + Id + "");

            GridView1.EditIndex = -1;
            GridView1.DataSource = db.exedataset("Select * from emp");
            GridView1.DataBind();
        }
    }
}