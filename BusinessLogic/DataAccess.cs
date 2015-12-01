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

        private DatabaseConnection conn;

        public DataAccess()
        {
            conn = new DatabaseConnection();
        }

        #region Categories

        public string InsertCategoriesString(string CategoryName, string Description)
        {
            return string.Format("INSERT INTO [Categories]" + " VALUES (N'" + CategoryName + "', N'"+ Description+"')");
        }

        public bool IsInsertCategories(string CategoryName, string Description)
        {
            string query = InsertCategoriesString(CategoryName, Description);
            return conn.ExcuteQuery(query);

        }

        private string UpdateCategoriesString(string CategoryName, string Description, decimal CategoryID)
        {
            return string.Format("UPDATE CATEGORIES SET CATEGORYNAME=N'" + CategoryName + "', DESCRIPTION= N'"+Description+"' WHERE CATEGORYID= " + CategoryID.ToString() );
        }

        public bool IsUpdateCategories(string CategoryName, string Description, decimal CategoryID)
        {
            string query = UpdateCategoriesString(CategoryName, Description, CategoryID);
            return conn.ExcuteQuery(query);
        }

        private string DeleteCategoriesString(decimal CategoryID)
        {
            return string.Format("Delete from Categories where CategoryID="+ CategoryID);
        }

        public bool IsDeleteCategories(decimal CategoryID)
        {
            string query = DeleteCategoriesString(CategoryID);
            return conn.ExcuteQuery(query);
        }

        public string SelectCategoriesString()
        {
            return string.Format("SELECT * FROM CATEGORIES");
        }

        public DataTable CategoriesDataTable()
        {
            string query = SelectCategoriesString();
            return conn.ExecuteSelectQuery(query);
        }

        #endregion

        #region Suppliers

        public string InsertSuppliersString(string CompanyName, string Phone, string Address)
        {
            return string.Format("INSERT INTO [Suppliers]" + " VALUES (N'" + CompanyName + "', N'" + Phone + "', N'"+Address+"' )");
        }

        public bool IsInsertSuppliers(string CompanyName, string Phone, string Address)
        {
            string query = InsertSuppliersString(CompanyName, Phone, Address);
            return conn.ExcuteQuery(query);

        }

        private string UpdateSuppliersString(string CompanyName, string Phone, string Address, decimal SupplierID)
        {
            return string.Format("UPDATE Suppliers SET CompanyName=N'" + CompanyName + "', Phone= '" + Phone + "', Address=N'" + Address + "' WHERE SupplierID= " + SupplierID.ToString());
        }

        public bool IsUpdateSuppliers(string CompanyName, string Phone, string Address, decimal SupplierID)
        {
            string query = UpdateSuppliersString(CompanyName, Phone, Address, SupplierID);
            return conn.ExcuteQuery(query);
        }

        private string DeleteSuppliersString(decimal SupplierID)
        {
            return string.Format("Delete from Suppliers where SupplierID=" + SupplierID);
        }

        public bool IsDeleteSuppliers(decimal SupplierID)
        {
            string query = DeleteSuppliersString(SupplierID);
            return conn.ExcuteQuery(query);
        }

        public string SelectSuppliersString()
        {
            return string.Format("SELECT * FROM Suppliers");
        }

        public DataTable SuppliersDataTable()
        {
            string query = SelectSuppliersString();
            return conn.ExecuteSelectQuery(query);
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
            return conn.ExecuteSelectQuery(query);
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
            return conn.ExecuteSelectQuery(query, sqlParameter);
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
            return conn.ExecuteSelectQuery(query, sqlParameter);
        }

        private string DeleteProductsString(decimal productID)
        {
            return string.Format("Delete from Products where ProductID=" + productID);
        }

        public bool IsDeleteProducts(decimal productID)
        {
            string query = DeleteProductsString(productID);
            return conn.ExcuteQuery(query);
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
            return conn.ExcuteQuery(query);

        }

        private string UpdateCustomerString(string lastName, string firstName, string address, string phone, DateTime dateOfBirth, decimal customerID)
        {
            return string.Format("UPDATE Customers SET LastName=N'" + lastName + "', FirstName= N'" + firstName + "', Address=N'" + address + "', Phone='" + phone + "', DateOfBirth='" + dateOfBirth.ToString("yyyy-MM-dd") + "' WHERE CustomerID= " + customerID.ToString());
        }

        public bool IsUpdateCustomers(string lastName, string firstName, string address, string phone, DateTime dateOfBirth, decimal customerID)
        {
            string query = UpdateCustomerString(lastName, firstName, address, phone, dateOfBirth, customerID);
            return conn.ExcuteQuery(query);
        }

        private string DeleteCustomersString(decimal customerID)
        {
            return string.Format("Delete from Customers where CustomerID=" + customerID);
        }

        public bool IsDeleteCustomers(decimal customerID)
        {
            string query = DeleteCustomersString(customerID);
            return conn.ExcuteQuery(query);
        }

        public string SelectCustomersString()
        {
            return string.Format("SELECT * FROM Customers");
        }

        public DataTable CustomersDataTable()
        {
            string query = SelectCustomersString();
            return conn.ExecuteSelectQuery(query);
        }
        #endregion
    }
}
