using MVCTest.DAL.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

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
                SqlCommand command = new SqlCommand("SELECT Id, FundName, Ticket, Morningstar, One_Mo, Third_Mo, One_Yr, Five_Yr, InceptionToDate FROM Funds", connection);
                SqlDataReader reader = null;
                DataTable schemaTable = null;


                try
                {
                    connection.Open();

                        reader = command.ExecuteReader();
                        schemaTable = reader.GetSchemaTable();

                    while (reader.Read())
                    {
                        model = new FundModel();

                        model.Id = int.Parse(reader["Id"].ToString());
                        model.FundName = reader["FundName"].ToString();
                        model.Ticket = reader["Ticket"].ToString();
                        model.MorningStar = reader["Morningstar"].ToString();
                        model.OneMo = decimal.Parse(reader["One_Mo"].ToString());
                        model.ThirdMo = decimal.Parse(reader["Third_Mo"].ToString());
                        model.OneYr = decimal.Parse(reader["One_Yr"].ToString());
                        model.FiveYr = decimal.Parse(reader["Five_Yr"].ToString());
                        model.InceptionToDate = decimal.Parse(reader["InceptionToDate"].ToString());

                        result.Add(model);
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
                SqlCommand command = new SqlCommand("SELECT Id, FundName, Ticket, Morningstar, One_Mo, Third_Mo, One_Yr, Five_Yr, InceptionToDate FROM Funds WHERE FundName LIKE"+"'%"+search +"%'" , connection);
                SqlDataReader reader = null;
                DataTable schemaTable = null;


                try
                {
                    connection.Open();

                    reader = command.ExecuteReader();
                    schemaTable = reader.GetSchemaTable();

                    while (reader.Read())
                    {
                        model = new FundModel();

                        model.Id = int.Parse(reader["Id"].ToString());
                        model.FundName = reader["FundName"].ToString();
                        model.Ticket = reader["Ticket"].ToString();
                        model.MorningStar = reader["Morningstar"].ToString();
                        model.OneMo = decimal.Parse(reader["One_Mo"].ToString());
                        model.ThirdMo = decimal.Parse(reader["Third_Mo"].ToString());
                        model.OneYr = decimal.Parse(reader["One_Yr"].ToString());
                        model.FiveYr = decimal.Parse(reader["Five_Yr"].ToString());
                        model.InceptionToDate = decimal.Parse(reader["InceptionToDate"].ToString());

                        result.Add(model);
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
