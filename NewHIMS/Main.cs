using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace NewHIMS
{
    public class Main
    {
        public static SqlConnection GetDBConnection()
        {
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString);
            return con;
        }
        public string Converter_string(string SQL)
        {
            try
            {
                SqlConnection con = Main.GetDBConnection();
                DataTable consultanttable = new DataTable();
                string StringConsultant;
                SqlDataAdapter Consultantdataadapter = new SqlDataAdapter(SQL, con);
                Consultantdataadapter.Fill(consultanttable);
                foreach (DataRow myrow in consultanttable.Rows)
                {
                    StringConsultant = Convert.ToString(myrow[0]);
                    return StringConsultant;
                }
            }
            catch
            {
                throw;
            }
            return "0";
        }
        public void Execute(string SQL)
        {
            try
            {
                SqlConnection con = Main.GetDBConnection();
                DataTable consultanttable = new DataTable();
                SqlDataAdapter Consultantdataadapter = new SqlDataAdapter(SQL, con);
                Consultantdataadapter.Fill(consultanttable);
            }
            catch
            {
                throw;
            }
        }
    }
}