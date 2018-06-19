using MVCTest.DAL.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;


namespace MVCTest.DAL
{
    public class DataAccess
    {
        private string conn_String = "Server=tcp:redtwizzler.database.windows.net,1433;Initial Catalog=MVCTestDB;Persist Security Info=False;User ID=Team1;Password=Admin123456;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        //ConfigurationManager.ConnectionStrings[''];

        public IEnumerable<FundModel> RetrieveAllFunds()
        {
            List<FundModel> result = new List<FundModel>();
            FundModel model;

            using (SqlConnection connection = new SqlConnection(this.conn_String))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Funds", connection);
                SqlDataReader reader = null;
                DataTable schemaTable = null;

                try
                {
                    connection.Open();

                        reader = command.ExecuteReader();
                        schemaTable = reader.GetSchemaTable();

                    while (reader.Read())
                    {
                        result.Add( new FundModel
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            FundName = reader["FundName"].ToString(),
                            Ticket = reader["Ticket"].ToString(),
                            MorningStar = reader["Morningstar"].ToString(),
                            OneMo = Convert.ToDecimal(reader["One_Mo"]),
                            ThirdMo = Convert.ToDecimal(reader["Third_Mo"]),
                            OneYr = Convert.ToDecimal(reader["One_Yr"]),
                            FiveYr = Convert.ToDecimal(reader["Five_Yr"]),
                            InceptionToDate = Convert.ToDecimal(reader["InceptionToDate"])
                        });
                    }
               
                    connection.Close();
                }
                catch (Exception e)
                {
                    connection.Close();
                    return null;
                }
            }

            return result; 
        }

        public IEnumerable<FundModel> RetrieveDataBySearch(string search)
        {
            List<FundModel> result = new List<FundModel>();
            FundModel model;

            using (SqlConnection connection = new SqlConnection(this.conn_String))
            {
                SqlCommand command = new SqlCommand("SELECT * FROM Funds WHERE FundName LIKE"+"'%"+search+"%'" , connection);
                SqlDataReader reader = null;
                DataTable schemaTable = null;

                try
                {
                    connection.Open();

                    reader = command.ExecuteReader();
                    schemaTable = reader.GetSchemaTable();

                    while (reader.Read())
                    {
                        result.Add(new FundModel
                        {
                            Id = Convert.ToInt32(reader["Id"]),
                            FundName = reader["FundName"].ToString(),
                            Ticket = reader["Ticket"].ToString(),
                            MorningStar = reader["Morningstar"].ToString(),
                            OneMo = Convert.ToDecimal(reader["One_Mo"]),
                            ThirdMo = Convert.ToDecimal(reader["Third_Mo"]),
                            OneYr = Convert.ToDecimal(reader["One_Yr"]),
                            FiveYr = Convert.ToDecimal(reader["Five_Yr"]),
                            InceptionToDate = Convert.ToDecimal(reader["InceptionToDate"])
                        });
                    }

                    connection.Close();
                }
                catch (Exception e)
                {
                    connection.Close();
                    return null;
                }
            }

            return result;
        } 
    }
}
