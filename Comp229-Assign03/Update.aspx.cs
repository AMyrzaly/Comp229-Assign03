using System;
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
    public partial class Update : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                this.UpdateBindList();
            }
        }
        private void UpdateBindList()
        {
            int StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);
            String LName = Convert.ToString(txtBxFname.Text);
            string connectionString = ConfigurationManager.ConnectionStrings["Assginment_03"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand("SELECT * FROM Students where (StudentID)=(@StudentID)", conn);
            comm.Parameters.AddWithValue("@StudentID", StudentID);
            try
            {
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.Read())
                {
                    txtBxLname.Text += reader["LastName"];
                    txtBxFname.Text += reader["FirstMidName"];
                    txtBxEnrDate.Text += reader["EnrollmentDate"];
                }
                reader.Close();
            }
            finally
            {
                conn.Close();
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SqlConnection conn;
            SqlCommand comm;
            string connectionString = ConfigurationManager.ConnectionStrings["Assginment_03"].ConnectionString;
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                comm = conn.CreateCommand();
                comm.CommandType = CommandType.Text;
                comm.ExecuteNonQuery();
                conn.Close();

            }
            catch (Exception) { }
            finally
            {
                Response.Redirect("default.aspx");
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("default.aspx");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            int StudentID = Convert.ToInt32(Request.QueryString["StudentID"]);
            String LName = Convert.ToString(txtBxFname.Text);
            string connectionString = ConfigurationManager.ConnectionStrings["Assginment_03"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionString);
            SqlCommand comm = new SqlCommand("UPDATE [Students] SET LastName=@LastName,FirstMidName=@FirstName,EnrollmentDate=@EnrollmentDate WHERE StudentID=@StudentID", conn);
            comm.Parameters.AddWithValue("@LastName", txtBxLname.Text);
            comm.Parameters.AddWithValue("@FirstName", txtBxFname.Text);
            comm.Parameters.AddWithValue("@EnrollmentDate", txtBxEnrDate.Text);
            comm.Parameters.AddWithValue("@StudentID", StudentID);
            try
            {
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                reader.Close();
            }
            finally
            {
                conn.Close();
                Response.Redirect("default.aspx");
            }
        }
    }
}