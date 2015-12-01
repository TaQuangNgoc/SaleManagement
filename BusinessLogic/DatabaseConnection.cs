﻿using System;
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
        private SqlDataAdapter myAdapter;
        private SqlConnection conn;

        public DatabaseConnection()
        {
            myAdapter = new SqlDataAdapter();
            string connectionString=" Data Source=taquangngoc-pc\\sqlexpress;Initial Catalog=SaleManagement;User id=sa;Password=sa";
            conn = new SqlConnection(connectionString);
     
        }

        private SqlConnection OpenConnection()
        {
            if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
            {
                conn.Open();
            }
            return conn;
        }

        public bool ExecuteSelectQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myCommand.ExecuteNonQuery();                
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
              //  dataTable = ds.Tables[0];
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: " + _query +
                                " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {
            }
            return true;
        }

        public DataTable ExecuteSelectQuery(String _query)
        {
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = _query;
                myCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeSelectQuery - Query: " + _query +
                                " \nException: " + e.StackTrace.ToString());
                return null;
            }
            finally
            {
            }
            return dataTable;
        }

        public bool ExecuteInsertQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.InsertCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeInsertQuery - Query: " + _query +
                                " \nException: \n" + e.StackTrace.ToString());
                return false;
            }
            finally
            {
            }
            return true;
        }

        public bool ExcuteQuery(String _query)
        {
            SqlCommand myCommand = new SqlCommand(
                 "excuteQuery", conn);
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandType = CommandType.StoredProcedure;
                myCommand.Parameters.Add(
                new SqlParameter("@excuteQuery", _query));
                myCommand.ExecuteReader();
               
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeInsertQuery - Query: " + _query +
                                " \nException: \n" + e.StackTrace.ToString());
                return false;
            }
            finally
            {
            }
            return true;
        }

        public bool ExecuteUpdateQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.UpdateCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeUpdateQuery - Query: " + _query +
                                " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {
            }
            return true;
        }

        public bool ExecuteDeleteQuery(String _query, SqlParameter[] sqlParameter)
        {
            SqlCommand myCommand = new SqlCommand();
            try
            {
                myCommand.Connection = OpenConnection();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myAdapter.UpdateCommand = myCommand;
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.Write("Error - Connection.executeUpdateQuery - Query: " + _query +
                                " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {
            }
            return true;
        }
    }
}
