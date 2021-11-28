using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;

namespace DBControls
{
    public partial class Employee2 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlDataSource ds = new SqlDataSource(System.Web.Configuration.WebConfigurationManager.ConnectionStrings["ConnString"].ConnectionString, "select * from Employee");
            ds.ID = "mydatasource";
            GridView1.DataSourceID = "mydatasource";
            Page.Controls.Add(ds);
            GridView1.DataBind();

        }
    }
}