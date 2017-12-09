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
    public partial class AddStudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {


                string connectionString = ConfigurationManager.ConnectionStrings["Assginment_03"].ConnectionString;
                SqlConnection conn = new SqlConnection(connectionString);
                SqlCommand comm = conn.CreateCommand();
                comm.CommandType = CommandType.Text;

                comm = new SqlCommand("INSERT INTO Students (FirstMidName,LastName,EnrollmentDate) Values(@FirstName, @LastName, @EnrollmentDate)", conn);

                comm.Parameters.Add("@FirstName", System.Data.SqlDbType.VarChar, 50);
                comm.Parameters["@FirstName"].Value = Fname.Text;
                comm.Parameters.Add("@LastName", System.Data.SqlDbType.VarChar, 50);
                comm.Parameters["@LastName"].Value = Lname.Text;
                comm.Parameters.Add("@EnrollmentDate", System.Data.SqlDbType.Date);
                comm.Parameters["@EnrollmentDate"].Value = Date.Text;
            try
            {
                conn.Open();
                comm.ExecuteNonQuery();
              
            }

            catch (Exception)
            {

            }
            finally
            {
               
                conn.Close();
            }
            Response.Redirect("Default.aspx");
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("Default.aspx");
        }
    }
}