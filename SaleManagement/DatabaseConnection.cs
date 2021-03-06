﻿using System;
using System.Data;
using System.Data.SqlClient;

namespace SaleManagement
{
    class DatabaseConnection
    {
        private static readonly string connectionString = "Data Source=27.118.16.60;Initial Catalog=SaleManagement;User id=kstn;Password=sa";

        private SqlDataAdapter adapter;
        private SqlConnection connection;

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

        public void ExecuteInsertQuery(string query, SqlParameter[] sqlParameter)
        {
            try
            {
                OpenConnection();
                var command = new SqlCommand(query, connection);
                command.Parameters.AddRange(sqlParameter);
                command.ExecuteNonQuery();
                adapter.InsertCommand = command;
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
            try
            {
                OpenConnection();
                var command = new SqlCommand(query, connection);
                command.Parameters.AddRange(sqlParameter);
                command.ExecuteNonQuery();
                adapter.UpdateCommand = command;
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
            try
            {
                OpenConnection();
                var command = new SqlCommand(query, connection);
                command.Parameters.AddRange(sqlParameter);
                command.ExecuteNonQuery();
                adapter.DeleteCommand = command;
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {

            }
        }

        public DataTable ExecuteSelectQuery(string query, SqlParameter[] sqlParameter)
        {
            DataSet dataSet = new DataSet();
            try
            {
                OpenConnection();
                var command = new SqlCommand(query, connection);
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

        public DataTable ExecuteProcedure(string procedureName, SqlParameter[] sqlParameter)
        {
            DataSet dataSet = new DataSet();
            try
            {
                OpenConnection();
                var command = new SqlCommand(procedureName, connection);
                command.Parameters.AddRange(sqlParameter);
                command.CommandType = CommandType.StoredProcedure;
                command.ExecuteNonQuery();
                adapter.SelectCommand = command;
                adapter.Fill(dataSet);
            }
            catch (SqlException v_e)
            {
                throw v_e;
            }
            finally
            {

            }

            return dataSet.Tables[0];
        }
    }
}
