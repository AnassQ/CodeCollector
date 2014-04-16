using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace CodeCollector_MyProject
{
    public partial class ListProduits : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //for never load the Page_Load evrey time you get in this page 
            if (this.Page.IsPostBack) return;
            
            // i will use the ClassConnection class
            //open Connection
            ClassConnection.cn.Open();
            
            ClassConnection.cmd = new SqlCommand("SELECT * FROM Products", ClassConnection.cn);
            ClassConnection.dr = sqldb.cmd.ExecuteReader();
            //i create a new datatable i didnt use the one in the ClassConnection
            DataTable dt = new DataTable();
            //load the datatable
            dt.Load(sqldb.dr);
            //to the GridView :)
            GridView1.DataSource = dt;
            GridView1.DataBind();
            
            //close Connection
            sqldb.cn.Close();
        }

    }
}
