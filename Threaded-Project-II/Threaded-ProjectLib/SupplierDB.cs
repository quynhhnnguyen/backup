using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadedProjectLib
{
    /* Supplier Data Access class - Provide sql functions to work with Supplier.
     * Author: Quynh Nguyen (Queenie)
     * Created Date: Dec - 17 - 2018 
     */
    public class SupplierDB : BaseDB
    {
        List<Supplier> AssocSuppliers = new List<Supplier>();
        SqlConnection conn = null;

        /* Get List of Suppliers from database */
        public List<Supplier> GetSuppliers()
        {
            List<Supplier> result = new List<Supplier>();
            string query = "SELECT * FROM Suppliers";
            try
            {
                conn = GetConnection();
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Supplier supplier = new Supplier(Convert.ToInt32(reader[0]),
                                                    Convert.ToString(reader[1]));
                    result.Add(supplier);
                }
            }
            catch (Exception e)
            {
                Utils.ErrorManager(e, "Supplier", "SupplierDB.GetSuppliers()");
            }
            finally
            {
                //close connection
                if(conn != null)
                    conn.Close();
            }
            return result;
        }

        /* Get Supplier Information by supplierId*/
        public Supplier GetSupplier(int supplierId)
        {
            Supplier result = null;

            string query = "SELECT * FROM Suppliers WHERE SupplierId = @SupplierId ";
            try
            {
                conn = GetConnection();
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("SupplierId", supplierId);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    result = new Supplier(Convert.ToInt32(reader[0]),
                                          Convert.ToString(reader[1]));
                }
            }
            catch (Exception e)
            {
                Utils.ErrorManager(e, "Supplier", "SupplierDB.GetSupplier()");
            }
            finally
            {
                //close connection
                if (conn != null)
                    conn.Close();
            }
            return result;
        }

        /* Update Supplier Information */
        public bool UpdateSupplier(Supplier supplier)
        {
            int rows = 0;

            string query = "UPDATE Suppliers SET SupName = @SupName " +
                            "WHERE SupplierId = @SupplierId ";

            if (supplier == null) // null parameter
                throw new ArgumentNullException();

            try
            {
                conn = GetConnection();
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("SupplierId", supplier.SupplierId);
                command.Parameters.AddWithValue("SupName", supplier.SupName);
                rows = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Utils.ErrorManager(e, "Supplier", "SupplierDB.UpdateSupplier()");
            }
            finally
            {
                //close connection
                if (conn != null)
                    conn.Close();
            }
            return (rows != 0);
        }

        // Get Supplier by Product Id
        public List<Supplier> getSupplierByProductId(int productID)
        {
            string query = "SELECT [ProductSupplierId], [Supplierid], [SupName] " +
            "FROM[TravelExperts].[dbo].[PRODUCT_SUPPLIER] Where Productid =" + productID;
            using (SqlConnection connection = GetConnection())
            {
                SqlCommand command = new SqlCommand( query, connection);
                //open the connection
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                try
                {
                    Supplier supp = new Supplier();
                    while (reader.Read())
                    {
                        AssocSuppliers.Add(new Supplier(Convert.ToInt32(reader[1]), Convert.ToString(reader[2]), Convert.ToInt32(reader[0])));
                    }
                }
                catch(Exception e)
                {
                    Utils.ErrorManager(e, "PRODUCT_SUPPLIER", "SupplierDB.getSupplierByProductId()");
                }
                finally
                {
                    // Always call Close when done reading.
                    reader.Close();
                }

                return AssocSuppliers;
            }
        }

        /* Insert Supplier to database */
        public bool InsertSuppliers(Supplier supplier)
        {

            int result = 0;

            try
            {
                conn = GetConnection();
                conn.Open();

                SqlCommand command = conn.CreateCommand();
                
                command.CommandText = @"Select(MAX(SupplierId) + 1) From Suppliers;";
                int maxPId = (int)command.ExecuteScalar();

                command.CommandText =
                    //"SET IDENTITY_INSERT dbo.Suppliers ON;" +
                    "INSERT INTO dbo.Suppliers ( SupplierId, SupName ) VALUES (@maxPid, @SupName) "; //+
                    //"SET IDENTITY_INSERT dbo.Suppliers OFF;";
                command.Prepare();

                command.Parameters.AddWithValue("@SupName", supplier.SupName);
                command.Parameters.AddWithValue("@maxPid", maxPId);
                command.ExecuteNonQuery();



            }
            catch (Exception e)
            {
                Utils.ErrorManager(e, "Supplier", "SupplierDB.InsertSuppliers()");
            }
            finally
            {
                //close connection
                if (conn != null)
                    conn.Close();
            }
            return (result != 0);

        }

        // Delete supplier by SupplierId
        public bool DeleteSupplier(int supplierId)
        {
            int result = 0;

            string query = "DELETE Suppliers WHERE SupplierId = @SupplierId";
            try
            {
                conn = GetConnection();
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("SupplierId", supplierId);
                result = command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Utils.ErrorManager(e, "Supplier", "SupplierDB.DeleteSupplier()");
            }
            finally
            {
                //close connection
                if (conn != null)
                    conn.Close();
            }

            return (result != 0);
        }

    }
}
