using Newtonsoft.Json.Linq;
using StreetSizzle.Models;
using StreetSizzle.Models.Utility;
using StreetSizzle.Modules.Interface;
using StructureMap;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace StreetSizzle.Modules.Services
{
    public class ReservationService : IReservation
    {
        private IConnectionStringProvider connectionstring;

        public ReservationService(IConnectionStringProvider connectionstring)
        {
            this.connectionstring = connectionstring;
        }
        public void bookreservation(ReservationModel obj)
        {

          
            // Get the connection string from the provider
            string connectionString = connectionstring.GetConnectionString();
            string query = "INSERT INTO tblreservation (name, emailID,date,time,guest,createdOn) VALUES (@name, @emailID,@date,@time,@guest,@createdOn)";


            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);

                // Add parameters to the command
                command.Parameters.AddWithValue("@name", obj.Name);
                command.Parameters.AddWithValue("@emailID", obj.Email);
                DateTime date;
                if (DateTime.TryParse(obj.Date, out date))
                {
                    command.Parameters.AddWithValue("@Date", date);
                }
                else
                {
                   command.Parameters.AddWithValue("@date", null);
                }
                command.Parameters.AddWithValue("@time", obj.Time);

                command.Parameters.AddWithValue("@guest", obj.TotalGuest);
                command.Parameters.AddWithValue("@createdOn",DateTime.UtcNow);

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