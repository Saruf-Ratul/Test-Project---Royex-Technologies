using System;
using System.Data;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Test_Project___Royex_Technologies
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Initialize the GridView
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Position", typeof(string));
                dt.Columns.Add("Salary with bonus", typeof(decimal));
                dt.Columns.Add("Join Date", typeof(DateTime));

                // Populate the GridView with sample data
                dt.Rows.Add(1, "John", "General Manager", 5000.00, new DateTime(2017, 1, 1));
                dt.Rows.Add(2, "Ron", "Manager", 4000.00, new DateTime(2018, 2, 1));
                dt.Rows.Add(14, "Jack", "Office Executive", 3000.00, new DateTime(2020, 5, 1));
                dt.Rows.Add(15, "Jane", "Office Executive", 3000.00, new DateTime(2022, 6, 1));
                dt.Rows.Add(16, "Hun", "Office Executive", 3000.00, new DateTime(2023, 7, 1));

                gvEmployees.DataSource = dt;
                gvEmployees.DataBind();
            }
        }

        protected void btnShowSalary_Click(object sender, EventArgs e)
        {
            int employeeId;
            if (int.TryParse(txtEmployeeId.Text.Trim(), out employeeId))
            {
                // Perform the necessary logic to retrieve the employee's salary with bonus
                // based on the provided employee ID

                // Example: Retrieve the data from the database
                DataTable dt = new DataTable();
                dt.Columns.Add("ID", typeof(int));
                dt.Columns.Add("Name", typeof(string));
                dt.Columns.Add("Position", typeof(string));
                dt.Columns.Add("Salary with bonus", typeof(decimal));
                dt.Columns.Add("Join Date", typeof(DateTime));

                // Add the data for the root manager
                dt.Rows.Add(1, "John", "General Manager", 6000.00, new DateTime(2015, 1, 1));

                // Add the data for other employees under the root manager
                dt.Rows.Add(2, "Ron", "Manager", 5000.00, new DateTime(2017, 2, 1));
                dt.Rows.Add(14, "Jack", "Office Executive", 4000.00, new DateTime(2021, 5, 1));
                dt.Rows.Add(15, "Jane", "Office Executive", 4000.00, new DateTime(2022, 6, 1));
                dt.Rows.Add(16, "Hun", "Office Executive", 4000.00, new DateTime(2023, 7, 1));

                gvEmployees.DataSource = dt;
                gvEmployees.DataBind();
            }
            else
            {
                // Display a validation message using a popup (e.g., Bootstrap modal)
                // You need to implement the popup/modal functionality separately using JavaScript/jQuery
                // Here's an example of how to show a Bootstrap modal using jQuery:
                string script = "$('#validationModal').modal('show');";
                ScriptManager.RegisterStartupScript(this, GetType(), "ValidationModalScript", script, true);
            }
        }
    }
}
