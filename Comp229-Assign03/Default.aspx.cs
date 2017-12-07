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
            if (!IsPostBack)
            {
                BindList();
            }
        }

        /// <summary>
        /// This is a method to get the student's data from the DataBase
        /// </summary>
        private void BindList()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Assginment_03"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand("select * from Students", conn);
            try
            {
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader(); // Can pass any object bookList.DataSource = reader; // Start data dinding | Calls whille loop that goes though this data source 
                //studentsList.DataSource = reader;
                //studentsList.DataBind();
                reader.Close();
            }
            finally
            {
                conn.Close();
            }
        }
    }
}

