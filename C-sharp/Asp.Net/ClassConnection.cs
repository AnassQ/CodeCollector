using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Configuration;

namespace CodeCollector_MyProject
{
    static class sqldb
    {
    
        public static SqlConnection cn = new SqlConnection(@"Data Source=.\sqlexpress;Initial Catalog=DATA_BASE_NAME;Integrated Security=True");
        //Change DATA_BASE_NAME to your database name
        //note that i use for "Data Source" ".\sqlexpress" for SQL SERVER 2008 you can use also localhost\sqlexpress
        // or you can generate the Connection String from tools > connected to a database 
        public static SqlDataAdapter da;
        public static SqlCommand cmd;
        public static SqlDataReader dr;
        public static DataSet ds = new DataSet();
        public static DataSet dsxml;
        public static SqlCommandBuilder cmdb;

        public static DataTable dt = new DataTable();
        public static DataView dv = new DataView();
        

    }
}
