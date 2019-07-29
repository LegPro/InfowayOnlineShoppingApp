using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;
using System.Configuration;
using InfowayOnlineShoppingApp.Models;
    namespace InfowayOnlineShoppingApp.Dal
{
    public class ProductDal : IDisposable
    {

        DataTable DT;
        MySqlDataReader DR;
        MySqlConnection CN;
        MySqlCommand CMD;

        public ProductDal()
        {

            CN = new MySqlConnection(ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString);

        }

        public void Dispose()
        {

            CN = null;
        }

        public DataTable GetAllProducts()
        {
            try
            {
                if (CN.State == ConnectionState.Closed)
                {
                    CN.Open();
                }
                CMD = new MySqlCommand();
                CMD.Connection = CN;
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.CommandText = "GetAllProduct";
                DR = CMD.ExecuteReader();
                DT = new DataTable("product");
                DT.Load(DR);
            }
            catch (Exception ex)
            {
                throw ex;
               

            }
            finally
            {
                if (CN.State == ConnectionState.Open)
                {
                    CN.Close();
                }

            }
            return DT;
        }





        public DataTable GetAllProducts( int productId)
        {
            try
            {
                if (CN.State == ConnectionState.Closed)
                {
                    CN.Open();
                }
                CMD = new MySqlCommand();
                CMD.Connection = CN;
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.CommandText = "GetSingleProduct";
                CMD.Parameters.AddWithValue("_ProductId", productId);
                DR = CMD.ExecuteReader();
                DT = new DataTable("product");
                DT.Load(DR);
            }
            catch (Exception ex)
            {

                throw ex;

            }
            finally
            {
                if (CN.State == ConnectionState.Open)
                {
                    CN.Close();
                }

            }
            return DT;
        }










        public DataTable InsertNewProduct(Product product)
        {
            try
            {

                if (CN.State == ConnectionState.Closed)
                {
                    CN.Open();
                }
                CMD = new MySqlCommand();
                CMD.Connection = CN;
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.CommandText = "insertNewProduct";
                CMD.Parameters.AddWithValue("_name", product.Name);
                CMD.Parameters.AddWithValue("_price", product.Price);
                CMD.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (CN.State == ConnectionState.Open)
                {
                    CN.Close();
                }

            }
            return GetAllProducts();
        }




        public DataTable ModifyProduct(Product product)
        {
            try
            {

                if (CN.State == ConnectionState.Closed)
                {
                    CN.Open();
                }
                CMD = new MySqlCommand();
                CMD.Connection = CN;
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.CommandText = "ModifyProduct";
                CMD.Parameters.AddWithValue("_id", product.Id);
                CMD.Parameters.AddWithValue("_name", product.Name);
                CMD.Parameters.AddWithValue("_price", product.Price);
                CMD.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (CN.State == ConnectionState.Open)
                {
                    CN.Close();
                }

            }
            return GetAllProducts();
        }






        public DataTable DeleteProduct(int id)
        {
            try
            {

                if (CN.State == ConnectionState.Closed)
                {
                    CN.Open();
                }
                CMD = new MySqlCommand();
                CMD.Connection = CN;
                CMD.CommandType = CommandType.StoredProcedure;
                CMD.CommandText = "DeleteProduct";
                CMD.Parameters.AddWithValue("_id", id);

                CMD.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                if (CN.State == ConnectionState.Open)
                {
                    CN.Close();
                }

            }
            return GetAllProducts();
        }




    }
}