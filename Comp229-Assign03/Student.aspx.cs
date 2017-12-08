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
    public partial class Student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindList();
                CourseBindList();
            }
        }

        protected void StudentsList_ItemCommand(object source, RepeaterCommandEventArgs e)
        {
            // Btn
            if (e.CommandName == "MoreDetails")
            {

            }
            else if (e.CommandName == "Edit")
            {

                BindList();
            }
        }
        private void BindList()
        {
            int StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);
            string connectionString = ConfigurationManager.ConnectionStrings["Assginment_03"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand("SELECT * FROM Students where StudentID=@StudentID", conn);
            comm.Parameters.AddWithValue("StudentID", StudentID);
            try
            {
                conn.Open();
                SqlDataReader reader= comm.ExecuteReader();
                ViewStudent.DataSource = reader;
                ViewStudent.DataBind();
                reader.Close();
            }
            finally
            {
                conn.Close();
            }
        }

        private void CourseBindList()
        {
            int StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);
            string connectionString = ConfigurationManager.ConnectionStrings["Assginment_03"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand("SELECT * FROM Courses WHERE CourseID IN (SELECT CourseID FROM Enrollments WHERE StudentID=" + StudentID + ")", conn);
            try
            {
                // Open the connection
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                CourseList.DataSource = reader;
                CourseList.DataBind();
                reader.Close();
            }
            finally
            {
                conn.Close();
            }
        }

        protected void GvStudent_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);
            string connectionString = ConfigurationManager.ConnectionStrings["Students"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand commTwo = new SqlCommand("DELETE FROM Enrollments where StudentID=" + StudentID, conn);
            SqlCommand comm = new SqlCommand("DELETE FROM Students Where StudentID=" + StudentID, conn);
            // Enclose database code in Try-Catch-Finally
            try
            {
                conn.Open();
                SqlDataReader reader = commTwo.ExecuteReader();
                reader.Close();

                SqlDataReader readerTwo = comm.ExecuteReader();
                readerTwo.Close();
            }
            finally
            {
                conn.Close();
                Response.Redirect("default.aspx");

            }
        }
    }
}