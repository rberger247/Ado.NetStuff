using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using  System.Data;

namespace WebApplication30
{
    public class db0
    {
        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["con"].ConnectionString);

        public void addData()
        {

            SqlCommand com = new SqlCommand("select message from inbox", con);
            con.Open();
    
            com.ExecuteNonQuery();
            con.Open();
                Console.ReadLine();
            }
        }

    }
 