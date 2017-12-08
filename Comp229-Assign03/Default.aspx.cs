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
                SqlDataReader reader = comm.ExecuteReader();
                StudentsGridView.DataSource = reader;
                StudentsGridView.DataBind();
                reader.Close();
            }
            finally
            {
                conn.Close();
            }
        }


        protected void StudentsList_ItemCommand(object source, GridView e)
        {
            // Which button was clicked?
            if (e.ID == "StudentGridView")
            {
                Session["currentStudentID"] = e.ID.ToString();
                Response.Redirect("student.aspx");
            }
        }
    }
}

