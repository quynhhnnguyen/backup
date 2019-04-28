using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadedProjectLib
{
    /* Product Data Access class - Provide sql functions to work with Product.
     * Author: Jeremiah Lobo
     * Created Date: Dec - 17 - 2018 
     */
    public class ProductDB : BaseDB
    {

        List<Product> Products = new List<Product>();
        // Get all products
        public List<Product> GetAllProducts()
        {
            string queryString = "SELECT Productid, ProdName FROM dbo.Products";
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand command = new SqlCommand(
                    queryString, connection);

                try
                {
                    //open the connection
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Products.Add(new Product() { ProductId = Convert.ToInt32(reader[0]), ProductName = reader[1].ToString() });
                    }
                }
                catch (Exception ex)
                {
                    Utils.ErrorManager(ex, "Products", "getAllProducts()");
                }

                return Products;
            }
        }

        //Add a product with  prepare
        public void AddProduct(string ProductName)
        {
            using (SqlConnection connection = base.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction("SimpleTransaction");

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText = @"Select(MAX(Productid) + 1) From Products;";
                    int maxPId = (int)command.ExecuteScalar();

                    command.CommandText =
                        "SET IDENTITY_INSERT dbo.Products ON;" +
                        "Insert into dbo.Products ( Productid, ProdName ) VALUES (@maxPid, @pname) " +
                        "SET IDENTITY_INSERT dbo.Products OFF;";
                    command.Prepare();

                    command.Parameters.AddWithValue("@pname", ProductName);
                    command.Parameters.AddWithValue("@maxPid", maxPId);
                    command.ExecuteNonQuery();

                    // Attempt to commit the transaction.
                    transaction.Commit();
                    Utils.WriteErrorLog("Records are written to database.");
                    MessageBox.Show("Product has been added");
                }
                catch (Exception ex)
                {
                    Utils.ErrorManager(ex, "Products", "AddProduct()");

                    // Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred
                        // on the server that would cause the rollback to fail, such as
                        // a closed connection.
                        Utils.ErrorManager(ex2, "Products", "AddProduct().Rollback");
                    }
                }
            }
        }

        public void UpdateProduct(List<Supplier> assocSuppliers, Product product)
        {
            foreach (Supplier sap in assocSuppliers)
            {
                Console.WriteLine("supplier name" + sap.SupName);
                Console.WriteLine("supplier id" + sap.SupplierId);
                Console.WriteLine("suplier product id" + sap.SuppProductId);
            }

            Console.WriteLine("product id" + product.ProductId);
            Console.WriteLine("product name" + product.ProductName);





            using (SqlConnection connection = base.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction();

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    command.CommandText += string.Format("INSERT INTO [dbo].[Products_Suppliers] " +
                                                  "([ProductId], [SupplierId]) VALUES( @prodid, @supid)");
                    // Set connection, etc.
                    for (int i = 0; i < assocSuppliers.Count; i++)
                    {
                        if (Convert.ToInt32(assocSuppliers[i].SuppProductId) == 0)
                        {
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@supid", assocSuppliers[i].SupplierId);
                            command.Parameters.AddWithValue("@prodid", product.ProductId);
                            command.ExecuteNonQuery();
                        }

                    }

                    command.Parameters.Clear();
                    command.CommandText = "UPDATE [dbo].[Products] SET[Products].[ProdName] = @prodName WHERE ProductId = @prodId";
                    command.Parameters.AddWithValue("@prodId", product.ProductId);
                    command.Parameters.AddWithValue("@prodName", product.ProductName);
                    command.ExecuteNonQuery();

                    // Attempt to commit the transaction.

                    transaction.Commit();

                }
                catch (Exception ex)
                {
                    //send this to logs
                    Utils.WriteErrorLog("Commit Exception Type: " + ex.GetType() + "  Message: " + ex.Message);
                    Utils.ErrorManager(ex, "Products, Products_Suppliers", "Commit failed: UpdateProduct()");
                    // Attempt to roll back the transaction.
                    try
                    {
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        // This catch block will handle any errors that may have occurred
                        // on the server that would cause the rollback to fail, such as
                        // a closed connection.
                        Utils.WriteErrorLog("Rollback Exception Type: " + ex2.GetType() + "  Message: " + ex2.Message);
                        Utils.ErrorManager(ex2, "Products, Products_Suppliers", "Rollback failed:UpdateProduct()");
                    }
                }
            }
        }

        public bool RemoveProduct(Supplier assocSuppliers, Product product)
        {
            bool result = false;
            using (SqlConnection connection = base.GetConnection())
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                SqlTransaction transaction;

                // Start a local transaction.
                transaction = connection.BeginTransaction();

                // Must assign both transaction object and connection
                // to Command object for a pending local transaction
                command.Connection = connection;
                command.Transaction = transaction;

                try
                {
                    // Set connection, etc.
                    
                        if (Convert.ToInt32(assocSuppliers.SuppProductId) != 0)
                        {
                            command.CommandText += string.Format("DELETE FROM[dbo].[Products_Suppliers]" +
                                                            "WHERE[ProductSupplierId] = @prodsupid");
                            command.Parameters.Clear();
                            command.Parameters.AddWithValue("@prodsupid", assocSuppliers.SuppProductId);
                            command.ExecuteNonQuery();
                        }

                    transaction.Commit();

                    result = true;

                }
                catch (Exception ex)
                {
                    result = false;
                    //send this to logs
                    Utils.WriteErrorLog("Commit Exception Type: " + ex.GetType() + "  Message: " + ex.Message);
                    Utils.ErrorManager(ex, "Products, Products_Suppliers", "Commit failed: UpdateProduct()");
                    // Attempt to roll back the transaction.
                    try
                    {
                        
                        transaction.Rollback();
                    }
                    catch (Exception ex2)
                    {
                        result = false;
                        // This catch block will handle any errors that may have occurred
                        // on the server that would cause the rollback to fail, such as
                        // a closed connection.
                        Utils.WriteErrorLog("Rollback Exception Type: " + ex2.GetType() + "  Message: " + ex2.Message);
                        Utils.ErrorManager(ex2, "Products, Products_Suppliers", "Rollback failed:UpdateProduct()");
                    }
                }
            }
            return result;
        }
    }
}
