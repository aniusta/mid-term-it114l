using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication1
{
    public partial class About : Page
    {
        List<List<string>> productList = new List<List<string>>();
        protected void Page_Load(object sender, EventArgs e)
        {
            //Created with own logic
            string connectionString = "Server=localhost;Port=3306;Database=mid-lab-exam-db;Uid=root;Pwd=;";
            string query = "SELECT * FROM product_info_tbl";
            DBlist.Items.Clear();
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", username.Text);
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string prd = reader["prd_details"].ToString();
                        DBlist.Items.Add(new ListItem(prd));
                    }
                }
            }
            TableRow headerRow = new TableRow();
            headerRow.Cells.Add(new TableCell() { Text = "Transaction ID" });
            headerRow.Cells.Add(new TableCell() { Text = "Product" });
            headerRow.Cells.Add(new TableCell() { Text = "Price" });
            headerRow.Cells.Add(new TableCell() { Text = "cust ID" });
            myTable.Rows.Add(headerRow);

            foreach (List<string> innerList in productList)
            {
                TableRow row = new TableRow();
                foreach (string item in innerList)
                {
                    TableCell cell = new TableCell();
                    cell.Text = item;
                    row.Cells.Add(cell);
                }
                myTable.Rows.Add(row);
            }

        }

        protected void submit_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;Database=mid-lab-exam-db;Uid=root;Pwd=;";
            string query = "SELECT * FROM customer_info_tbl WHERE cx_name = @name";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@name", username.Text);
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read()) 
                    {
                        string uname = reader.GetString(1);
                        string pw = reader.GetString(2);

                        if (pw == password.Text)
                        {
                            mymodal.Style["display"] = "none";
                            userID.Value = reader.GetString(0);
                        }

                    }
                }


                connection.Close();
            }
        }

        protected void register_Click(object sender, EventArgs e)
        {
            Response.Redirect("/Register.aspx");
        }

        protected void add_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=localhost;Port=3306;Database=mid-lab-exam-db;Uid=root;Pwd=;";
            string query = "SELECT * FROM product_info_tbl WHERE prd_details = @prd";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@prd", DBlist.SelectedValue);
                connection.Open();
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        List<string> rowList = new List<string>();
                        rowList.Add("1");
                        rowList.Add(reader.GetString(1));
                        rowList.Add(reader.GetString(2));
                        rowList.Add(userID.Value);
                        productList.Add(rowList);
                    }
                }
                connection.Close();
            }

            foreach (List<string> innerList in productList)
            {
                TableRow row = new TableRow();
                foreach (string item in innerList)
                {
                    TableCell cell = new TableCell();
                    cell.Text = item;
                    row.Cells.Add(cell);
                }
                myTable.Rows.Add(row);
            }
        }

        protected void buy_Click(object sender, EventArgs e)
        { 
        }
    }
}