﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign03
{
    public partial class Course : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CourseBindList();
        }
        private void CourseBindList()
        {
            int CourseID = Convert.ToInt32(Request.QueryString["CourseID"]);
            string connectionString = ConfigurationManager.ConnectionStrings["Assginment_03"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand("SELECT * FROM Students WHERE StudentID IN (SELECT StudentID FROM Enrollments WHERE CourseID=@CourseID)", conn);
            comm.Parameters.AddWithValue("@CourseID", CourseID);
            try
            {
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
        protected void StudentGridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);
            string connectionString = ConfigurationManager.ConnectionStrings["Assginment_03"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand("DELETE FROM Enrollments WHERE StudentID = @StudentID", conn);
            comm.Parameters.AddWithValue("@StudentID", StudentID);
            comm = new SqlCommand("DELETE FROM Students WHERE StudentID = @StudentID", conn);
            comm.Parameters.AddWithValue("@StudentID", StudentID);
            try
            {
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                CourseList.DataSource = reader;
                CourseList.DataBind();
                reader.Close();
            }
            finally
            {
                conn.Close();
                Response.Redirect("Default.aspx");
            }
        }
    }
}