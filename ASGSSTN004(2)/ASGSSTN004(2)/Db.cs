using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace ASGSSTN004_2_
{
    public class Db
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();

        public Db()
        {
            con.ConnectionString = "Data Source=NTP-LAP-835\\MS_SQL;Initial Catalog=ASS5DB;Integrated Security=True;Pooling=False";
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

        public int Executenonquery(String Sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = Sql; //query is sql 
            int i = cmd.ExecuteNonQuery();
            return i;

        }
        public DataSet Executedataset(String sql)
        {
            cmd.CommandType = CommandType.Text;//set command type or store procdedure or xml like wise
            cmd.CommandText = sql;//pass sql command to command text
            SqlDataAdapter da = new SqlDataAdapter(cmd);//create adapter class because disconnected architecture
            DataSet ds = new DataSet();//create data set
            da.Fill(ds);//fill data to dataset using adapter object
            return ds;//return data set
        }

        public object Executescalar(String sql)
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

        public DataTable Executedatatable(String sql)
        {
            Getcon();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dtobj = new DataTable();
            da.Fill(dtobj);
            return dtobj;
        }
        public void fillgrid(String sql, GridView dv)
        {
            dv.DataSource = Executedataset(sql);
            dv.DataBind();
        }
    }
}