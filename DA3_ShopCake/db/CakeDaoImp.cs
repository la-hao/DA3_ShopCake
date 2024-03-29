﻿using DA3_ShopCake.utils;
using dbforproject3.db.DbHelper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows;

namespace ConsoleApp2.db
{
    class CakeDaoImp : CakeDao
    {

        private List<Cake> cakes;

        public CakeDaoImp()
        {
            cakes = new List<Cake>();

            string strConn = $"Server=localhost; Database=QLTiemBanh; Trusted_Connection=True;";
            SqlConnection sqlConnection = new SqlConnection(strConn);
            SqlCommand sqlCommand = new SqlCommand();
            String query = "select A.CAKE_ID, B.CATALOGUE_ID, B.CAKE_NAME, B.PRICE, B.DESCRIPTION, A.IMAGE from CAKEIMAGE as A join CAKE as B on A.CAKE_ID = B.CAKE_ID where A.IMAGE = (select top(1) IMAGE from CAKEIMAGE where CAKE_ID = B.CAKE_ID)";

            try
            {
                sqlCommand.CommandText = query;
                sqlCommand.CommandType = CommandType.Text;
                sqlCommand.Connection = sqlConnection;

                sqlConnection.Open();
                SqlDataReader reader = sqlCommand.ExecuteReader();
                while (reader.Read())
                {
                    Cake cake = new Cake();
                    var currentFolder = AppDomain.CurrentDomain.BaseDirectory;

                    cake.Id = reader[0].ToString();
                    cake.CatalogueId = reader[1].ToString();
                    cake.Name = reader[2].ToString();
                    cake.Price = Int32.Parse(reader[3].ToString());
                    cake.Description = reader[4].ToString();
                    cake.Image = $"{currentFolder}Assets\\Images\\{reader[5].ToString()}";

                    cakes.Add(cake);
                }
                sqlConnection.Close();

            }
            catch (Exception ex)
            {
                sqlConnection.Close();
                throw ex;
            }
        }
        public void deleteCake(Cake cake)
        {

            String delQuery = $"DELETE FROM CAKE WHERE CAKE_ID = '{cake.Id}';";
            DatabaseHelper.executeQuery(delQuery);
        }

        public List<Cake> GetCakes()
        {
            return cakes;
        }

        public void insertCake(Cake cake)
        {
            using (SqlConnection connection = new SqlConnection("Server=localhost; Database=QLTiemBanh; Trusted_Connection=True;"))
            {
                String query = "INSERT INTO dbo.CAKE (CAKE_ID, CATALOGUE_ID, CAKE_NAME, PRICE, DESCRIPTION)" +
                " VALUES (@Id,@CatalogueId,@Name,@Price,@Description)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id", cake.Id);
                    command.Parameters.AddWithValue("@CatalogueId", cake.CatalogueId);
                    command.Parameters.AddWithValue("@Name", cake.Name);
                    command.Parameters.AddWithValue("@Price", cake.Price);
                    command.Parameters.AddWithValue("@Description", cake.Description);

                    connection.Open();
                    int result = command.ExecuteNonQuery();

                    if (result < 0)
                    {
                        MessageBox.Show("Insertion: failed");
                    }
                }
            }
        }

        public void updateCake(Cake cake)
        {
            /*
CAKE: CAKE_ID (PK), CATALOGUE_ID (FK), CAKE_NAME, PRICE (INT), IMAGE (TEXT)
 */
            string strConn = $"Server=localhost; Database=QLTiemBanh; Trusted_Connection=True;";
            SqlConnection sqlConnection = new SqlConnection(strConn);
            SqlCommand sqlCommand = new SqlCommand();
            String query = "select * from CAKE";

            sqlCommand.CommandText = query;
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Connection = sqlConnection;
            sqlConnection.Open();

            try
            {
                string sql = "Update CAKE set CAKE_NAME = @Name, PRICE = @Price, DESCRIPTION = @Description where CAKE_ID = @Id";

                SqlCommand cmd = new SqlCommand();

                cmd.Connection = sqlConnection;
                cmd.CommandText = sql;

                cmd.Parameters.Add("@Name", SqlDbType.NVarChar).Value = cake.Name;
                cmd.Parameters.Add("@Price", SqlDbType.Int).Value = cake.Price;
                cmd.Parameters.Add("@Description", SqlDbType.NVarChar).Value = cake.Description;
                cmd.Parameters.Add("@Id", SqlDbType.VarChar).Value = cake.Id;

                int rowCount = cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                sqlConnection.Close();
                sqlConnection.Dispose();
                sqlConnection = null;
            }
        }

        public Cake getCakeById(String id)
        {
            Cake result = null;

            foreach (Cake cake in cakes)
            {
                if (cake.Id.Equals(id))
                {
                    result = cake;
                    break;
                }
            }

            return result;
        }

        public String getNextId()
        {
            String newId = "";
            bool isFoundNewId = false;

            while (!isFoundNewId)
            {
                newId = StringHelper.RandomString(6);
                if (cakes.Count() == 0)
                {
                    isFoundNewId = true;
                }
                for (int i = 0; i < cakes.Count(); i++)
                {
                    if (cakes[i].Id.Equals(newId))
                    {
                        break;
                    }
                    if (i == cakes.Count() - 1)
                    {
                        isFoundNewId = true;
                        break;
                    }
                }
            }

            return newId;
        }

        public List<Cake> GetCakesByType(int type)
        {
            List<Cake> rs = new List<Cake>();
            foreach (Cake c in cakes)
            {
                int num;
                bool success = Int32.TryParse(c.CatalogueId, out num);

                if (success && num == type)
                {
                    rs.Add(c);
                }
            }

            return rs;
        }

    }

}
