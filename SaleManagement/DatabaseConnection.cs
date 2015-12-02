using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace SaleManagement
{
    class DatabaseConnection
    {
        private SqlDataAdapter adapter;
        private SqlConnection connection;
        private readonly string connectionString = "Data Source=27.118.16.60\\sqlexpress;Initial Catalog=SaleManagement;User id=kstn;Password=sa";

        public DatabaseConnection()
        {
            adapter = new SqlDataAdapter();
            connection = new SqlConnection(connectionString);
        }

        private void OpenConnection()
        {
            if (connection.State == ConnectionState.Closed || connection.State == ConnectionState.Broken)
                connection.Open();
        }

        public DataTable ExecuteSelectQuery(string query, SqlParameter[] sqlParameter)
        {
            DataSet dataSet = new DataSet();
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddRange(sqlParameter);
                command.ExecuteNonQuery();                
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {

            }

            return dataSet.Tables[0];
        }

        public void ExecuteInsertQuery(string query, SqlParameter[] sqlParameter)
        {
            DataSet dataSet = new DataSet();
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddRange(sqlParameter);
                command.ExecuteNonQuery();
                adapter.InsertCommand = command;
                adapter.Fill(dataSet);
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {

            }
        }

        public void ExecuteUpdateQuery(string query, SqlParameter[] sqlParameter)
        {
            DataSet dataSet = new DataSet();
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddRange(sqlParameter);
                command.ExecuteNonQuery();
                adapter.UpdateCommand = command;
                adapter.Fill(dataSet);
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {

            }
        }

        public void ExecuteDeleteQuery(string query, SqlParameter[] sqlParameter)
        {

            DataSet dataSet = new DataSet();
            try
            {
                OpenConnection();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddRange(sqlParameter);
                command.ExecuteNonQuery();
                adapter.DeleteCommand = command;
                adapter.Fill(dataSet);
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {

            }
        }
    }
}
