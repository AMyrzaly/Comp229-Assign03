﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Comp229_Assign03
{
    public partial class Addtocourse : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Assginment_03"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {

            try
            {
                SqlConnection conn = new SqlConnection(connectionString);

                SqlCommand comm = conn.CreateCommand();
                comm.CommandType = CommandType.Text;
                comm = new SqlCommand("INSERT INTO Enrollments (StudentID,CourseID,Grade) VALUES(@StudentID, @CourseID, @Grade)", conn);
                comm.Parameters.AddWithValue("@StudentID", txtBxStudentID.Text);
                comm.Parameters.AddWithValue("@CourseID", txtBxCourseID.Text);
                comm.Parameters.AddWithValue("@Grade", txtBxGrade.Text);

                conn.Open();
                comm.ExecuteNonQuery();
                conn.Close();

            }

            catch (Exception)
            {

            }
            finally
            {
                Response.Redirect("Default.aspx");

            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }
    }
}