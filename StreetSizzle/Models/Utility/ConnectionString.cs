using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StreetSizzle.Models.Utility
{
    public interface IConnectionStringProvider
    {
        string GetConnectionString();
    } 
    public class ConnectionString : IConnectionStringProvider
    {
       
             string _connectionString = "";


            public ConnectionString(string connectionString = null)
            {
            if (!string.IsNullOrEmpty(connectionString))
            {
                _connectionString = connectionString;
            }
        }

            public string GetConnectionString()
            {
                return _connectionString;
            }
        

    }
}