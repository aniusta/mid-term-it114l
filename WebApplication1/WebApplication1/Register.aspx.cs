using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected bool ValidateForm()
        {
            bool isValid = true;

            // Validate Name
            if (string.IsNullOrEmpty(username.Text))
            {
                isValid = false;
            }

            if (string.IsNullOrEmpty(password.Text))
            {
                isValid = false;
            }

            return isValid;
        }

        protected void register_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                errorLabel.Visible = false;
                string connectionString = "Server=localhost;Port=3306;Database=mid-lab-exam-db;Uid=root;Pwd=;";
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "INSERT INTO customer_info_tbl (cx_name, cx_password) " +
        "VALUES (@username, @password)";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username.Text);
                        command.Parameters.AddWithValue("@password", password.Text);
                        command.ExecuteNonQuery();
                    }
                    connection.Close();
                }
                ScriptManager.RegisterStartupScript(this, this.GetType(), "UploadSuccess", "alert('Successfully registered!');", true);
            }
            else
            {
                errorLabel.Text = "Username and password must not be empty.";
                errorLabel.Visible = true;
            }

        }
    }
}