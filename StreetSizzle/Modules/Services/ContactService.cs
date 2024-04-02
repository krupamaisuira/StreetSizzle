using StreetSizzle.Models.Utility;
using StreetSizzle.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using StreetSizzle.Modules.Interface;

namespace StreetSizzle.Modules.Services
{
    public class ContactService : IContact
    {

        private IConnectionStringProvider connectionstring;

        public ContactService(IConnectionStringProvider connectionstring)
        {
            this.connectionstring = connectionstring;
        }
        public void addInquiry(ContactModel obj)
        {
            // Get the connection string from the provider
            string connectionString = connectionstring.GetConnectionString();
            string query = "INSERT INTO tblContact (name, emailID,subject,message,createdOn) VALUES (@name, @emailID,@subject,@message,@createdOn)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to the command
                command.Parameters.AddWithValue("@name", obj.Name);
                command.Parameters.AddWithValue("@emailID", obj.Email);
                command.Parameters.AddWithValue("@subject", obj.Subject);
                command.Parameters.AddWithValue("@message", obj.Message);
                command.Parameters.AddWithValue("@createdOn", DateTime.UtcNow);

                try
                {
                    // Open the connection
                    connection.Open();

                    // Execute the command
                    int rowsAffected = command.ExecuteNonQuery();

                    Console.WriteLine($"Rows affected: {rowsAffected}");
                    Console.WriteLine("Data inserted successfully.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}