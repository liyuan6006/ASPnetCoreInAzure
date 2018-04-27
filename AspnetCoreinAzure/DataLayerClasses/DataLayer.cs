using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using AspnetCoreinAzure.Models;

namespace AspnetCoreinAzure.DataLayerClasses
{
    public class DataLayer
    {
        SqlConnection connection;
       
        public DataLayer(IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("localDB");
            connection = new SqlConnection(connectionString);

        }

        public IEnumerable<AddressLabel> getAddressLable(long ID)
        {
            List<AddressLabel> addressLabels = new List<AddressLabel>();
            SqlCommand command;
            if (ID==0)
            {
                command = new SqlCommand("SELECT * FROM [SalesLT].[vAddressLabels]",connection);
            }
            else
            {
                command = new SqlCommand("SELECT * FROM [SalesLT].[vAddressLabels] where CustomerID =" + ID,connection);
            }

            connection.Open();
            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    AddressLabel addressLabel = new AddressLabel
                        (Convert.ToInt32(reader["CustomerID"]),
                        reader["Title"].ToString(),
                         reader["FirstName"].ToString(),
                           reader["LastName"].ToString(),
                            reader["AddressLine1"].ToString()
                        );

                    addressLabels.Add(addressLabel);
                }
            }
            connection.Close();
            return addressLabels;
        }
    }
}
