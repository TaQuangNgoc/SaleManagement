using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SaleManagement
{
    public class DataAccess
    {
        private readonly DatabaseConnection connection;

        public DataAccess()
        {
            connection = new DatabaseConnection();
        }

        #region Categories

        public bool CategoryNameExists(string categoryName)
        {
            string query = "SELECT TOP 1 * FROM [Categories] WHERE [CategoryName] = " + "@categoryName";
            var parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@categoryName", categoryName);
            var table = connection.ExecuteSelectQuery(query, parameters);
            return table.Rows.Count == 1;
        }

        public void InsertCategory(string categoryName, string description)
        {
            string query = "INSERT INTO [Categories]" + " VALUES (" + "@categoryName" + ", " + "@description" + ")";
            var parameters = new SqlParameter[2];
            parameters[0] = new SqlParameter("@categoryName", SqlDbType.NVarChar);
            parameters[0].Value = categoryName;
            parameters[1] = new SqlParameter("@description", SqlDbType.NVarChar);
            parameters[1].Value = description;
            connection.ExecuteInsertQuery(query, parameters);
        }

        public void UpdateCategory(string categoryName, string description, int categoryID)
        {
            string query = "UPDATE [Categories] SET [CategoryName] = " + "@categoryName" + ", [Description] = " + "@description" + " WHERE [CategoryID] = " + "@categoryID";
            var parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@categoryName", SqlDbType.NVarChar);
            parameters[0].Value = categoryName;
            parameters[1] = new SqlParameter("@description", SqlDbType.NVarChar);
            parameters[1].Value = description;
            parameters[2] = new SqlParameter("@categoryID", SqlDbType.Int);
            parameters[2].Value = categoryID;
            connection.ExecuteUpdateQuery(query, parameters);
        }

        public void DeleteCategory(int categoryID)
        {
            string query = "DELETE FROM [Categories] WHERE [CategoryID] = @" + "categoryID";
            var parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@categoryID", SqlDbType.Int);
            parameters[0].Value = categoryID;
            connection.ExecuteDeleteQuery(query, parameters);
        }

        public DataTable SelectCategories()
        {
            string query = "SELECT * FROM [Categories]";
            var parameters = new SqlParameter[0];
            return connection.ExecuteSelectQuery(query, parameters);
        }

        #endregion

        #region Suppliers

        public bool CompanyNameExists(string companyName)
        {
            string query = "SELECT TOP 1 * FROM [Suppliers] WHERE [CompanyName] = " + "@companyName";
            var parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@companyName", SqlDbType.NVarChar);
            parameters[0].Value = companyName;
            var table = connection.ExecuteSelectQuery(query, parameters);
            return table.Rows.Count == 1;
        }

        public void InsertSupplier(string companyName, string phone, string address)
        {
            string query = "INSERT INTO [Suppliers]" + " VALUES (" + "@companyName" + ", " + "@phone" + ", " + "@address" + ")";
            var parameters = new SqlParameter[3];
            parameters[0] = new SqlParameter("@companyName", SqlDbType.NVarChar);
            parameters[0].Value = companyName;
            parameters[1] = new SqlParameter("@phone", SqlDbType.NVarChar);
            parameters[1].Value = phone;
            parameters[2] = new SqlParameter("@address", SqlDbType.NVarChar);
            parameters[2].Value = address;
            connection.ExecuteInsertQuery(query, parameters);
        }

        public void UpdateSupplier(string companyName, string phone, string address, int supplierID)
        {
            string query = "UPDATE [Suppliers] SET [CompanyName] = " + "@companyName" + ", [Phone] = " + "@phone" + ", [Address] = " + "@address" + " WHERE [SupplierID] = " + "@supplierID";
            var parameters = new SqlParameter[4];
            parameters[0] = new SqlParameter("@companyName", SqlDbType.NVarChar);
            parameters[0].Value = companyName;
            parameters[1] = new SqlParameter("@phone", SqlDbType.NVarChar);
            parameters[1].Value = phone;
            parameters[2] = new SqlParameter("@address", SqlDbType.NVarChar);
            parameters[2].Value = address;
            parameters[3] = new SqlParameter("@supplierID", SqlDbType.Int);
            parameters[3].Value = supplierID;
            connection.ExecuteUpdateQuery(query, parameters);
        }

        public void DeleteSupplier(int supplierID)
        {
            string query = "DELETE FROM [Suppliers] WHERE [SupplierID] = " + "@supplierID";
            var parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@supplierID", SqlDbType.Int);
            parameters[0].Value = supplierID;
            connection.ExecuteDeleteQuery(query, parameters);
        }

        public DataTable SelectSuppliers()
        {
            string query = "SELECT * FROM [Suppliers]";
            var parameters = new SqlParameter[0];
            return connection.ExecuteSelectQuery(query, parameters);
        }

        #endregion

        #region Products

        public void InsertProduct(string productName, int supplierID, int categoryID, decimal unitPrice, int unitsInStock, byte[] image)
        {
            string query = "INSERT INTO [Products]" + " VALUES (" + "@productName" + ", " + "@supplierID" + ", " + "@categoryID" + "," + "@unitPrice" + "," + "@unitsInStock" + ", " + "@image" + ")";
            var parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@productName", SqlDbType.NVarChar);
            parameters[0].Value = productName;
            parameters[1] = new SqlParameter("@supplierID", SqlDbType.Int);
            parameters[1].Value = supplierID;
            parameters[2] = new SqlParameter("@categoryID", SqlDbType.Int);
            parameters[2].Value = categoryID;
            parameters[3] = new SqlParameter("@unitPrice", SqlDbType.NVarChar);
            parameters[3].Value = unitPrice;
            parameters[4] = new SqlParameter("@unitsInStock", SqlDbType.Int);
            parameters[4].Value = unitsInStock;
            parameters[5] = new SqlParameter("@image", SqlDbType.Image);
            parameters[5].Value = image;
            connection.ExecuteInsertQuery(query, parameters);
        }

        public void UpdateProduct(string productName, int supplierID, int categoryID, decimal unitPrice, int unitsInStock, byte[] image, int productID)
        {
            string query = "UPDATE [Products] SET [ProductName] = " + "@productName" + ", [SupplierID] = " + "@supplierID" + ", [CategoryID] = " + "@categoryID" + ", [UnitPrice] = " + "@unitPrice" + ", [UnitsInStock] = " + "@unitsInStock" + ", [Picture] = " + "@image" + " WHERE [ProductID] = " + "@productID";
            var parameters = new SqlParameter[7];
            parameters[0] = new SqlParameter("@productName", SqlDbType.NVarChar);
            parameters[0].Value = productName;
            parameters[1] = new SqlParameter("@supplierID", SqlDbType.Int);
            parameters[1].Value = supplierID;
            parameters[2] = new SqlParameter("@categoryID", SqlDbType.Int);
            parameters[2].Value = categoryID;
            parameters[3] = new SqlParameter("@unitPrice", SqlDbType.NVarChar);
            parameters[3].Value = unitPrice;
            parameters[4] = new SqlParameter("@unitsInStock", SqlDbType.Int);
            parameters[4].Value = unitsInStock;
            parameters[5] = new SqlParameter("@image", SqlDbType.Image);
            parameters[5].Value = image;
            parameters[6] = new SqlParameter("@productID", SqlDbType.Int);
            parameters[6].Value = productID;
            connection.ExecuteUpdateQuery(query, parameters);
        }

        public void DeleteProducts(int productID)
        {
            string query = "DELETE FROM [Products] WHERE [ProductID] = " + "@productID";
            var parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@productID", SqlDbType.Int);
            parameters[0].Value = productID;
            connection.ExecuteDeleteQuery(query, parameters);
        }

        public DataTable SelectProducts()
        {
            string query = "SELECT * FROM [ProductsView]";
            var parameters = new SqlParameter[0];
            return connection.ExecuteSelectQuery(query, parameters);
        }

        #endregion

        #region Customers

        public void InsertCustomer(string lastName, string firstName, string address, string phone, DateTime dateOfBirth)
        {
            string query = "INSERT INTO [Customers]" + " VALUES (" + "@lastName" + ", " + "@firstName" + ", " + "@address" + ", " + "@phone" + "," + "@dateOfBirth" + ")";
            var parameters = new SqlParameter[5];
            parameters[0] = new SqlParameter("@lastName", SqlDbType.NVarChar);
            parameters[0].Value = lastName;
            parameters[1] = new SqlParameter("@firstName", SqlDbType.NVarChar);
            parameters[1].Value = firstName;
            parameters[2] = new SqlParameter("@address", SqlDbType.NVarChar);
            parameters[2].Value = address;
            parameters[3] = new SqlParameter("@phone", SqlDbType.NVarChar);
            parameters[3].Value = phone;
            parameters[4] = new SqlParameter("@dateOfBirth", SqlDbType.Date);
            parameters[4].Value = dateOfBirth;
            connection.ExecuteInsertQuery(query, parameters);
        }

        public void UpdateCustomer(string lastName, string firstName, string address, string phone, DateTime dateOfBirth, int customerID)
        {
            string query = "UPDATE [Customers] SET [LastName] = " + "@lastName" + ", [FirstName] = " + "@firstName" + ", [Address] = " + "@address" + ", [Phone] = " + "@phone" + ", [DateOfBirth] = " + "@dateOfBirth" + " WHERE [CustomerID] = " + "@customerID";
            var parameters = new SqlParameter[6];
            parameters[0] = new SqlParameter("@lastName", SqlDbType.NVarChar);
            parameters[0].Value = lastName;
            parameters[1] = new SqlParameter("@firstName", SqlDbType.NVarChar);
            parameters[1].Value = firstName;
            parameters[2] = new SqlParameter("@address", SqlDbType.NVarChar);
            parameters[2].Value = address;
            parameters[3] = new SqlParameter("@phone", SqlDbType.NVarChar);
            parameters[3].Value = phone;
            parameters[4] = new SqlParameter("@dateOfBirth", SqlDbType.Date);
            parameters[4].Value = dateOfBirth;
            parameters[5] = new SqlParameter("@customerID", SqlDbType.Int);
            parameters[5].Value = customerID;
            connection.ExecuteInsertQuery(query, parameters);
        }

        public void DeleteCustomer(int customerID)
        {
            string query = "DELETE FROM [Customers] WHERE [CustomerID] = " + "@customerID";
            var parameters = new SqlParameter[1];
            parameters[0] = new SqlParameter("@customerID", SqlDbType.Int);
            parameters[0].Value = customerID;
            connection.ExecuteDeleteQuery(query, parameters);
        }

        public DataTable SelectCustomers()
        {
            string query = "SELECT * FROM Customers";
            return connection.ExecuteSelectQuery(query, new SqlParameter[0]);
        }
        #endregion
    }
}
