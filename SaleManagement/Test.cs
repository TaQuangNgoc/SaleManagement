using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Data.SqlClient;

namespace SaleManagement
{
    static class Test
    {
        public static void RunTest()
        {
            SelectQueryTest();
        }

        private static void SelectQueryTest()
        {
            DatabaseConnection connection = new DatabaseConnection();
            string query = "SELECT * FROM [Suppliers]";
            var dataTable = connection.ExecuteSelectQuery(query, new SqlParameter[0]);
            Debug.Assert(dataTable.Rows.Count == 2);
        }

        private static void ExistCheckingTest()
        {
            DatabaseConnection connection = new DatabaseConnection();
            string query = "SELECT TOP 1 * FROM [Suppliers] WHERE [CompanyName] = " + "@companyName";
            var parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@companyName", System.Data.SqlDbType.NVarChar);
            parameters[0].Value = "Nokia Việt Nam";
            var table = connection.ExecuteSelectQuery(query, parameters);
            Debug.Assert(table.Rows.Count == 1);
        }
    }
}
