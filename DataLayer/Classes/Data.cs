using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Policy;
using System.Net;

namespace DataLayer.Classes
{
    public class Data
    {
        public static string connectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();


        public DataTable SelectAllCustomers()
        {
            SqlCommand sqlCommand = new SqlCommand("sp_SelectAllCustomers");

            sqlCommand.CommandType = CommandType.StoredProcedure;

            DataTable dataTable = SelectData(sqlCommand);

            return dataTable;
        }

        public int InsertCustomer(string customerName, string paymentMethod, string phone, string email, string address, string zip, string city, string defaultPickupAddress)
        {
            int affectedRows = 0;

            SqlCommand sqlCommand = new SqlCommand("sp_InsertToCustomers");

            sqlCommand.CommandType = CommandType.StoredProcedure;

            sqlCommand.Parameters.AddWithValue("@Customername", customerName);
            sqlCommand.Parameters.AddWithValue("@PaymentMethod", paymentMethod);
            sqlCommand.Parameters.AddWithValue("@Phone", phone);
            sqlCommand.Parameters.AddWithValue("@Email", email);
            sqlCommand.Parameters.AddWithValue("@Address", address);
            sqlCommand.Parameters.AddWithValue("@Zip", zip);
            sqlCommand.Parameters.AddWithValue("@City", city);
            sqlCommand.Parameters.AddWithValue("@DefaultPickupAddress", defaultPickupAddress);

            affectedRows = UpdateData(sqlCommand);

            return affectedRows;
        }



        // DB
        private static int UpdateData(SqlCommand sqlCommand)
        {
            int affectedRows = 0;

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (sqlCommand)
                {
                    sqlCommand.Connection = sqlConnection;

                    affectedRows = sqlCommand.ExecuteNonQuery();
                }
            }

            return affectedRows;
        }

        public static DataTable SelectData(SqlCommand sqlCommand)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                sqlConnection.Open();

                using (sqlCommand)
                {
                    sqlCommand.Connection = sqlConnection;

                    dataTable.Load(sqlCommand.ExecuteReader());
                }
            }

            return dataTable;
        }

    }
}
