using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThreadedProjectLib;

namespace ThreadedProjectLib
{
   public  class Package_AddProduct_DB :BaseDB
    {
        /*Class to perform select and all dml(CRUD) operations on packages table and all its detailed 
         * tables dealing with packages products
         Author: Muhammad Islam
         Created: Jan, 2019
         */
        //SqlDataAdapter adatper;
        SqlDataReader dataReader;
        //List of all suppliers Id, based on which we will dynamically get data from Product_suppliers table
        public List<Packages_AddProduct> supp = new List<Packages_AddProduct>();
        public List<PkgProduct> getProduct = new List<PkgProduct>();
        //Establsih connection to database
        //public string GetDBConnectionString()
        //{
        //    // To avoid storing the connection string in your code, 
        //    // you can retrieve it from a configuration file, using the 
        //    // System.Configuration.ConfigurationManager.ConnectionStrings property 
        //    //Connects to the App config 

        //    ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

        //    if (settings != null)
        //    {
        //        foreach (ConnectionStringSettings cs in settings)
        //        {
        //            return cs.ConnectionString;
        //        }
        //        //string connectionToString = @"Data Source=WIN-50GP30FGO75;Initial Catalog=Demodb;User ID=sa;Password=demol23";
        //    }
        //    else
        //    {
        //        MessageBox.Show("Missing database configuration, please check those information in App.config");
        //    }

        //    return null;

        //}
        //Get Supplierid from Packages_Products_Suppliers based on the argument
        public void  GetSupplierId(int packgId)
        {     //Geto connection to database    
            //string dbConnect = GetDBConnectionString();
            // create sql connection object.  Be sure to put a valid connection string
            SqlConnection Con = GetConnection();
            Con.Open();
            // create command object with SQL query and link to connection object

            string query = "select ProductSupplierId from Packages_Products_Suppliers where PackageId=@pkgId";

            SqlCommand command = new SqlCommand(query, Con);
            command.Parameters.AddWithValue("@pkgId", packgId);            
            SqlDataReader dataReader;
            dataReader = command.ExecuteReader();
            Packages_AddProduct getSupObj;
            while (dataReader.Read())
            {                
                getSupObj = new Packages_AddProduct();
                getSupObj.SuppId = Convert.ToInt32(dataReader.GetValue(0));
                supp.Add(getSupObj);
            }

             Con.Close();            
               
        }
        //Function to get package product
        public  List<PkgProduct> getPackageProduct()
        {
            //string dbConnect = GetDBConnectionString();
            // create sql connection object.  Be sure to put a valid connection string
            SqlConnection Con = GetConnection();
            Con.Open();
            // create command object with SQL query and link to connection object
            //Make a list Packages_AddProducts class objects to populate data into packages products gridview            
                foreach (Packages_AddProduct i in supp)
                {

                string query = "select distinct  prodname, supname from products,Suppliers,Products_Suppliers" +
                   " where products.ProductId = Products_Suppliers.ProductId" +
                    " and Suppliers.SupplierId=Products_Suppliers.SupplierId"+
                    " and Products_Suppliers.ProductSupplierId=@Suppid"; 

                    SqlCommand command = new SqlCommand(query, Con);

                     command.Parameters.AddWithValue("@Suppid", i.SuppId);
                   
                    dataReader = command.ExecuteReader();

                PkgProduct getSupObj;

                while (dataReader.Read())
                {
                    getSupObj = new PkgProduct();                                      
                    getSupObj.ProductnName= Convert.ToString(dataReader.GetValue(0));
                    getSupObj.SupplierName = Convert.ToString(dataReader.GetValue(1));
                    getProduct.Add(getSupObj);
                }
                dataReader.Close();
              
                }
            Con.Close();
            return getProduct;

        }
        //Function to add packages to a product based on specific PackageId select in Packages Gridview
        public bool AddPackageProduct(string SupName,string ProductName,int PackageId)
        {   
            int getSupplierId = 0;
            int getProductId = 0;
            int getProductSupplierId = 0;
            int pkgId = 0;
            int getPkgId = 0;
            getPkgId = PackageId;
            bool productAdded = false;
            //Make connection to DB
            //string dbConnect = GetDBConnectionString();
            // create sql connection object.  Be sure to put a valid connection string
            SqlConnection Con = GetConnection();
            Con.Open();
            // create command object with SQL query and link to connection object
            string query = "select SupplierId from suppliers where SupName=@supName";
            SqlCommand command = new SqlCommand(query, Con);
            command.Parameters.AddWithValue("@supName", SupName);
           //Make a data reader to put data into it            
            SqlDataReader dataReader;
            dataReader = command.ExecuteReader();           
            while (dataReader.Read())
            {
                getSupplierId = Convert.ToInt32(dataReader.GetValue(0));
                                
            }
            dataReader.Close();
            //prepare your query for another statement to get productId from Products table based on the prodname
            query = "select ProductId from products where ProdName=@prodName";
            //make a new sql command
           command = new SqlCommand(query, Con);
            command.Parameters.AddWithValue("@prodName", ProductName);                                  
            dataReader = command.ExecuteReader();           
            while (dataReader.Read())
            {
                getProductId = Convert.ToInt32(dataReader.GetValue(0));
                               
            }
            dataReader.Close();                                                                     
            //Prepare your query for another statemnt
            query = "select ProductSupplierId from products_suppliers where ProductId='" + getProductId + "'" +
                "and SupplierId='" + getSupplierId + "'";
            //make a new sql command           
            command = new SqlCommand(query, Con);                  
            //make a new data reader
            dataReader = command.ExecuteReader();
            //Packages_AddProduct getSupObj;
            while (dataReader.Read())
            {
                getProductSupplierId = Convert.ToInt32(dataReader.GetValue(0));
                               
            }
            dataReader.Close();            
            //Prepare query for insert statment
            query = "insert into packages_products_suppliers values(@pkgid,@pordsupid)";
            command = new SqlCommand(query, Con);
            command.Parameters.AddWithValue("@pkgId", getPkgId);
            command.Parameters.AddWithValue("@pordsupid",getProductSupplierId);
            try
            {
                int RowsAffected = command.ExecuteNonQuery();
                if (RowsAffected > 0)
                {
                    productAdded = true;
                    Con.Close();
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Package should be Uinque " + ex.Message);
            }
            
            return productAdded;
        }
        //Function to updare packages, based on the arguemtn values
        public bool UpdatePackages(int pkgId,string pkgName,DateTime strtDate, DateTime endDate,
            string desc, decimal basePrice,decimal agencyComm)
        {
            bool pkgUpdated = false;
            //string dbConnect = GetConnection();
            // create sql connection object.  Be sure to put a valid connection string
            SqlConnection Con = GetConnection();
            Con.Open();
            // create command object with SQL query and link to connection object
            //quer for update table
            string query = "update packages set PkgName=@pkgname , PkgStartDate=@pkgstartdate" +
                " , PkgEndDate=@pkgenddate , PkgDesc=@pkgdesc , PkgBasePrice=@pkgbaseprice" +
                " , PkgAgencyCommission=@pkgagencyComm where PackageId= @pkgId";
            //set the parameters
            SqlCommand command = new SqlCommand(query, Con);
            command.Parameters.AddWithValue("@pkgname", pkgName);
            command.Parameters.AddWithValue("@pkgstartdate", strtDate);
            command.Parameters.AddWithValue("@pkgenddate", endDate);
            command.Parameters.AddWithValue("@pkgdesc", desc);
            command.Parameters.AddWithValue("@pkgbaseprice", basePrice);
            command.Parameters.AddWithValue("@pkgagencyComm", agencyComm);
            command.Parameters.AddWithValue("@pkgId", pkgId);

            try
            {
                
                Int32 rowsAffected = command.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    pkgUpdated = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }                                  
            SqlDataReader dataReader;
            dataReader = command.ExecuteReader();            
            return true;
        }
        //Function to get producti supplierd id based on the argument values
        public int Get_Package_Product_SupplierId(string prodName,string suppName)
        {
            int getSupplierId = 0;
            int getProductId = 0;
            int getProductSupplierId = 0;          
            bool productAdded = false;
            //Get the DB connection
            //string dbConnect = GetDBConnectionString();
            // create sql connection object.  Be sure to put a valid connection string
            SqlConnection Con = GetConnection();
            Con.Open();
            // create command object with SQL query and link to connection object
            string query = "select SupplierId from suppliers where SupName=@supName";
            //Make a new command
            SqlCommand command = new SqlCommand(query, Con);
            command.Parameters.AddWithValue("@supName", suppName);           
            SqlDataReader dataReader;
            dataReader = command.ExecuteReader();
            
            while (dataReader.Read())
            {
                getSupplierId = Convert.ToInt32(dataReader.GetValue(0));
                                
            }
            dataReader.Close();
            //Prepare your query for another statement
            query = "select ProductId from products where ProdName=@prodName";
            command = new SqlCommand(query, Con);
            command.Parameters.AddWithValue("@prodName", prodName);
            dataReader = command.ExecuteReader();            
            while (dataReader.Read())
            {
                getProductId = Convert.ToInt32(dataReader.GetValue(0));                
                
            }
            dataReader.Close();
            //Prepare your query foranother statement
            query = "select ProductSupplierId from products_suppliers where ProductId='" + getProductId + "'" +
                "and SupplierId='" + getSupplierId + "'";                       
            command = new SqlCommand(query, Con);
            dataReader = command.ExecuteReader();            
            while (dataReader.Read())
            {
                getProductSupplierId = Convert.ToInt32(dataReader.GetValue(0));         
                
            }
            dataReader.Close();
            Con.Close();
            return getProductSupplierId;

        }
        //Function to update packages products based on the argument values
        public bool Update_Package_Product(string SupName, string ProductName, int PackageId, int OldSupplierdId)
        {
            int getSupplierId = 0;
            int getProductId = 0;
            int getProductSupplierId = 0;
            int pkgId = 0;
            int getPkgId = 0;
            getPkgId = PackageId;
            bool productAdded = false;
            //Get DB Connection
           // string dbConnect = GetDBConnectionString();
            // create sql connection object.  Be sure to put a valid connection string
            SqlConnection Con = GetConnection();
            Con.Open();
            // create command object with SQL query and link to connection object

            string query = "select SupplierId from suppliers where SupName=@supName";

            SqlCommand command = new SqlCommand(query, Con);
            command.Parameters.AddWithValue("@supName", SupName);                       
            SqlDataReader dataReader;
            dataReader = command.ExecuteReader();            
            while (dataReader.Read())
            {
                getSupplierId = Convert.ToInt32(dataReader.GetValue(0));
                                
            }
            dataReader.Close();
            //Prepare query for another statement
            query = "select ProductId from products where ProdName=@prodName";
            command = new SqlCommand(query, Con);
            command.Parameters.AddWithValue("@prodName", ProductName);
            dataReader = command.ExecuteReader();           
            while (dataReader.Read())
            {
                getProductId = Convert.ToInt32(dataReader.GetValue(0));
                                
            }
            dataReader.Close();
            //Prepare your query for another statement
            query = "select ProductSupplierId from products_suppliers where ProductId='" + getProductId + "'" +
                "and SupplierId='" + getSupplierId + "'";
            command = new SqlCommand(query, Con);
            dataReader = command.ExecuteReader();            
            while (dataReader.Read())
            {
                getProductSupplierId = Convert.ToInt32(dataReader.GetValue(0));
                                
            }
            dataReader.Close(); 
            //Prepare your query for another statement
            query = "update Packages_Products_Suppliers set ProductSupplierId=@pordsupid" +
                " where PackageId=@pkgId and ProductSupplierId=@oldSuppId ";
            command = new SqlCommand(query, Con);
            command.Parameters.AddWithValue("@pkgId", getPkgId);
            command.Parameters.AddWithValue("@oldSuppId",OldSupplierdId);
            command.Parameters.AddWithValue("@pordsupid", getProductSupplierId);
            int RowsAffected = command.ExecuteNonQuery();
            if (RowsAffected > 0)
            {
                productAdded = true;
                Con.Close();
            }                       
            return productAdded;
        }
        //Function to delete package based on the argument value
        public bool DeletePackage(int pkgId)
        {
            bool pkgDeleted = false;
            //string dbConnect = GetDBConnectionString();
            // create sql connection object.  Be sure to put a valid connection string
            SqlConnection Con = GetConnection();
            Con.Open();
            // create command object with SQL query and link to connection object

            string query = "delete from Packages where PackageId=@PkgId";

            SqlCommand command = new SqlCommand(query, Con);
           
            // adapter = new SqlDataAdapter(query, Con);
            command = new SqlCommand(query, Con);
            command.Parameters.AddWithValue("@PkgId", pkgId);            
            int RowsAffected = command.ExecuteNonQuery();
            if (RowsAffected > 0)
            {
                pkgDeleted = true;
                Con.Close();
            }
            return pkgDeleted;
        }
        public void Pkg_Products_Delete(int pkgId)
        {

            int count = 0;
            int getPkgId = 0;

            //string dbConnect = GetDBConnectionString();
            // create sql connection object.  Be sure to put a valid connection string
            SqlConnection Con = GetConnection();
            Con.Open();
            // create command object with SQL query and link to connection object
            string query = "select PackageId from Packages_Products_Suppliers where PackageId=@PkgId";
            SqlCommand command = new SqlCommand(query, Con);
            command.Parameters.AddWithValue("@PkgId", pkgId);            
            SqlDataReader dataReader;
            dataReader = command.ExecuteReader();            
            while (dataReader.Read())
            {
             getPkgId = Convert.ToInt32(dataReader.GetValue(0));
                count++;              
                
            }
            dataReader.Close();
            if (count > 0)
            {
               query = "delete from Packages_Products_Suppliers where PackageId=@PkgId";                                
                command = new SqlCommand(query, Con);
                command.Parameters.AddWithValue("@PkgId", pkgId);                
                int RowsAffected = command.ExecuteNonQuery();
            }
            Con.Close();
        }
        //Function to deleted packages products based on the arguments values
        public bool Delete_Package_Product(string SupName, string ProductName, int PackageId)
        {
            int getSupplierId = 0;
            int getProductId = 0;
            int getProductSupplierId = 0;
            int pkgId = 0;
            int getPkgId = 0;
            getPkgId = PackageId;
            bool productDeleted = false;
            //Get DB connection
            //string dbConnect = GetDBConnectionString();
            // create sql connection object.  Be sure to put a valid connection string
            SqlConnection Con = GetConnection();
            Con.Open();
            // create command object with SQL query and link to connection object
            string query = "select SupplierId from suppliers where SupName=@suppName";
            SqlCommand command = new SqlCommand(query, Con);
            command.Parameters.AddWithValue("@suppName", SupName);            
            SqlDataReader dataReader;
            dataReader = command.ExecuteReader();            
            while (dataReader.Read())
            {
                getSupplierId = Convert.ToInt32(dataReader.GetValue(0));                
            }
            dataReader.Close();            
            query = "select ProductId from products where ProdName=@ProdName";
            command = new SqlCommand(query, Con);
            command.Parameters.AddWithValue("@ProdName", ProductName);
            dataReader = command.ExecuteReader();            
            while (dataReader.Read())
            {
                getProductId = Convert.ToInt32(dataReader.GetValue(0));                
            }
            dataReader.Close();
            query = "select ProductSupplierId from products_suppliers where ProductId='" + getProductId + "'" +
                "and SupplierId='" + getSupplierId + "'";
            command = new SqlCommand(query, Con);
            dataReader = command.ExecuteReader();           
            while (dataReader.Read())
            {
                getProductSupplierId = Convert.ToInt32(dataReader.GetValue(0));               
                
            }
            dataReader.Close();             
            query = "Delete from Packages_Products_Suppliers where PackageId=@PkgId and ProductSupplierId=@Prodsupid";
            command = new SqlCommand(query, Con);
            command.Parameters.AddWithValue("@PkgId", getPkgId);           
            command.Parameters.AddWithValue("@Prodsupid", getProductSupplierId);
            int RowsAffected = command.ExecuteNonQuery();
            if (RowsAffected > 0)
            {
               productDeleted = true;
                Con.Close();
            }            

            return productDeleted;
        }

    }
}
