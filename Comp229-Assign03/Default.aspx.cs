using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign03
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack) { BindList(); }
        }
        private void BindList()
        {
            string connectionStringLog = ConfigurationManager.ConnectionStrings["Assginment_03"].ConnectionString;
            SqlConnection connectionN = new SqlConnection(connectionStringLog);
            SqlCommand comm = new SqlCommand("select Title, Credits from Courses;", connectionN);
            try
            {
                connectionN.Open();
                SqlDataReader reader = comm.ExecuteReader(); // Can pass any object bookList.DataSource = reader; // Start data dinding | Calls whille loop that goes though this data source 
                //bookList.DataBind();
                reader.Close();
            }
            catch (SqlException ex)
            {
                //lblError.Text = ex.Message;
            }
            finally
            {
                connectionN.Close();
            }
        }

    }
}

