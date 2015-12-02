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
            parameters[2] = new SqlParameter("@description", SqlDbType.Int);
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
            string query = "UPDATE [Suppliers] SET [CompanyName] = " + "@companyName" + ", [Phone] = " + "@phone" + ", [Address] = " + "address" + " WHERE [SupplierID] = " + "@supplierID";
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

        public string SelectProductsString()
        {
            return string.Format("SELECT * FROM ProductsView");
        }

        public DataTable ProductsDataTable()
        {
            string query = SelectProductsString();
            return connection.ExecuteSelectQuery(query, new SqlParameter[0]);
        }

        public string InsertProductsString(string productName, decimal supplierID, decimal categoryID, string unitPrice, string unitsINStock, Byte[] image)
        {
            return string.Format("INSERT INTO [Products]" + " VALUES (N'" + productName + "', " + supplierID + ", " + categoryID + ","+ unitPrice+ ","+ unitsINStock+", @image )");
        }

        public bool IsInsertProducts(string productName, decimal supplierID, decimal categoryID, string unitPrice, string unitsInStock, Byte[] image)
        {
            SqlParameter[] sqlParameter = new SqlParameter[1];
            sqlParameter[0] = new SqlParameter("@image", image);
            string query = InsertProductsString(productName, supplierID, categoryID, unitPrice, unitsInStock, image);
            return true;// conn.ExecuteSelectQuery(query, sqlParameter);
        }

        private string UpdateProductsString(string productName, decimal supplierID, decimal categoryID, string unitPrice, string unitsInStock,Byte[] image, decimal productID)
        {
            return string.Format("UPDATE Products SET ProductName=N'" + productName + "', SupplierID= " + supplierID + ", CategoryID=" + categoryID + ", UnitPrice=" + unitPrice + ",UnitsInStock=" + unitsInStock + ", Picture=@image WHERE ProductID= " + productID);
        }

        public bool IsUpdateProducts(string productName, decimal supplierID, decimal categoryID, string unitPrice, string unitsOfStock,Byte[] image, decimal productID)
        {
            SqlParameter[] sqlParameter = new SqlParameter[1];
            sqlParameter[0] = new SqlParameter("@image", image);
            string query = UpdateProductsString(productName, supplierID, categoryID, unitPrice, unitsOfStock,image, productID);
            return true;// conn.ExecuteSelectQuery(query, sqlParameter);
        }

        private string DeleteProductsString(decimal productID)
        {
            return string.Format("Delete from Products where ProductID=" + productID);
        }

        public bool IsDeleteProducts(decimal productID)
        {
            string query = DeleteProductsString(productID);
            return true;// conn.ExcuteQuery(query);
        }



        #endregion

        #region Customers

        public string InsertCustomersString(string lastName, string firstName, string address, string phone,DateTime dateOfBirth )
        {
            return string.Format("INSERT INTO [Customers]" + " VALUES (N'" + lastName + "', N'" + firstName + "', N'" + address + "', '" + phone + "','" + dateOfBirth.ToString("yyyy-MM-dd") + "')");
        }

        public bool IsInsertCustomers(string lastName, string firstName, string address, string phone, DateTime dateOfBirth)
        {
            string query = InsertCustomersString(lastName, firstName, address, phone, dateOfBirth);
            return true;// conn.ExcuteQuery(query);

        }

        private string UpdateCustomerString(string lastName, string firstName, string address, string phone, DateTime dateOfBirth, decimal customerID)
        {
            return string.Format("UPDATE Customers SET LastName=N'" + lastName + "', FirstName= N'" + firstName + "', Address=N'" + address + "', Phone='" + phone + "', DateOfBirth='" + dateOfBirth.ToString("yyyy-MM-dd") + "' WHERE CustomerID= " + customerID.ToString());
        }

        public bool IsUpdateCustomers(string lastName, string firstName, string address, string phone, DateTime dateOfBirth, decimal customerID)
        {
            string query = UpdateCustomerString(lastName, firstName, address, phone, dateOfBirth, customerID);
            return true;// conn.ExcuteQuery(query);
        }

        private string DeleteCustomersString(decimal customerID)
        {
            return string.Format("Delete from Customers where CustomerID=" + customerID);
        }

        public bool IsDeleteCustomers(decimal customerID)
        {
            string query = DeleteCustomersString(customerID);
            return true;// conn.ExcuteQuery(query);
        }

        public string SelectCustomersString()
        {
            return string.Format("SELECT * FROM Customers");
        }

        public DataTable CustomersDataTable()
        {
            string query = SelectCustomersString();
            return connection.ExecuteSelectQuery(query, new SqlParameter[0]);
        }
        #endregion
    }
}
