using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ASGSSTN004_1.Employee_
{
    public class Class1
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();

        public Class1()
        {
            con.ConnectionString = "Data Source=NTP-LAP-835\\MS_SQL;Initial Catalog=ASS5DB;Integrated Security=True;Pooling=False;Pooling=False;";
            cmd.Connection = con;
        }
        public SqlConnection Getcon()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }
        public void dbclose()
        {
            con.Close();
        }
        public int exenonquery(String sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            int i = cmd.ExecuteNonQuery();
            return i;
        }
        public object exescalar(String sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            object ob = cmd.ExecuteScalar();
            return ob;

        }
        public SqlDataReader exereader(String sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            SqlDataReader dr = cmd.ExecuteReader();
            return dr;
        }
        /*Disconnected Architecture*/
        public DataSet exedataset(String sql)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        public DataTable exedatatable(String sql)
        {
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public void FillGrid(string sql, GridView dv)
        {
            dv.DataSource = exedataset(sql);
            dv.DataBind();
        }
    }
}