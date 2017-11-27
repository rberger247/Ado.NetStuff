using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication3
{
    public partial class _Default : Page
    {
        private SqlConnection con;
        private DataSet ds;
        private SqlDataAdapter da;
        private string cons = "Server=(localdb)\\mssqllocaldb;Database=FanAppDb;Trusted_Connection=True;MultipleActiveResultSets=true";
        protected void Page_Load(object sender, EventArgs e)
        {

            
            ds = new DataSet();
            DataTable dt = new DataTable();
            con = new SqlConnection(cons);
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Inbox";
            con.Open();
            da = new SqlDataAdapter(cmd);
           
            da.Fill(ds);
            dt = ds.Tables[0];
            foreach (DataRow row in dt.Rows )
            {
                string field1 = row.ItemArray[0].ToString();

            }
        }
    }
}