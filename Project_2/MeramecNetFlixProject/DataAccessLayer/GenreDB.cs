using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//The System.Data.SqlClient reference is needed to access SQL Server database
using System.Data.SqlClient;
using MeramecNetFlixProject.BusinessObjects;

namespace MeramecNetFlixProject.DataAccessLayer
{
    //Instructions:
    //#1:Rename the SkeletonTableNameDB class to the Specific Database Table name. i.e. CustomerDB
    //#2:The SkeletonTableNameDB class should inherit the superclass called AccessDataSQLServer
    //#3: The AccessDataSQLServer class must be created. See Project#2 Specs for class definition.

    //public class SkeletonTableNameDB
    public static class GenreDB
    {

        //Instructions: 
        //Replace all ???TableNameHere phrases with the name of your specific SQL Server Database Table Name
        //Replace yourCustomeObject phrase with the name of the business object (represents database table name) you are referencing or returning
        //Replace datatype phrase with the appropriate C# data type or custom data type based on Project #2 CRUD specs
        //Replace parameter phrase with the appropriate input parameter based on Project #2 CRUD specs
        //Refer to the ADO.Net Demo for method examples below


        public static List<GenreClass> GetAllGenres()
        {
            //Change the MyCustomObject name to your customer business object that is returning data from the specific table
            List<GenreClass> objGenreList = new List<GenreClass>();
            string SQLStatement = String.Empty;

            //Pre-step: Replace the general object parameter with the appropriate data type parameter for retrieving a specific item from the specific database table. 

            //Change the MyCustomObject references  to your customer business object

            //Step #1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object
            SqlConnection myConnection = AccessDataSQLServer.GetConnection();

            //Step #2: Code logic to create appropriate SQL Server objects calls
            //         Code logic to retrieve data from database
            //         Add Try..Catch appropriate block and throw exception back to calling program            

            SqlCommand objCommand;
            SqlDataReader genreReader;
            try
            {
                using (myConnection)
                {
                    //Open the DB connection
                    myConnection.Open();

                    //Define SQL statement
                    SQLStatement = "select id,name from Genre";

                    //Create a command object with the sql statement
                    using (objCommand = new SqlCommand(SQLStatement, myConnection))
                    {

                        //Execute the SQL and return a datareader object
                        using (genreReader = objCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {
                            while (genreReader.Read())
                            {
                                GenreClass objReturnGenre = new GenreClass();

                                //objCommand.Parameters.AddWithValue("@customer_id", objCustomer.CustomerID);
                                objReturnGenre.GenreID = genreReader["id"].ToString();
                                objReturnGenre.GenreName = genreReader["name"].ToString();

                                objGenreList.Add(objReturnGenre);
                            }
                        }
                    }
                    //Close the connection
                    myConnection.Close();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }

            //Step #3: Return the objtemp variable back to the calling UI 
            return objGenreList;
        }

        public static bool AddGenre(GenreClass myGenre)
        {
            //Pre-step: Replace the general object parameter with the appropriate business class object that you are using to insert data in the underline database table 
            string SQLStatement = String.Empty;

            //Step #1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object
            SqlConnection myConnection = AccessDataSQLServer.GetConnection();

            //Step #2: Code logic to create appropriate SQL Server objects calls
            //         Cod Logic to retrieve data from database
            //         Add Try..Catch appropriate block and throw exception back to calling program

            SqlCommand objCommand = null;
            int rowsAffected = 0;

            string sqlString;

            try
            {
                using (myConnection)
                {
                    myConnection.Open();
                    sqlString = "INSERT into Genre values (@id, @name)";

                    using (objCommand = new SqlCommand(sqlString, myConnection))
                    {
                        objCommand.Parameters.AddWithValue("@id",myGenre.GenreID);
                        objCommand.Parameters.AddWithValue("@name", myGenre.GenreName);

                        rowsAffected = objCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                if (myConnection != null)
                {
                    myConnection.Close();
                }
            }

            //Step #3: return false if record was not added successfully
            //         return true if record was added successfully  

            return true; //temporary return until your code is fully flushed out. Remove or comment out this line
        }

        public static bool UpdateGenre(GenreClass myGenre)
        {
            //Pre-step: Replace the general object parameter with the appropriate business class object that you are using to insert data in the underline database table 
            string SQLStatement = String.Empty;

            //Step #1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object
            SqlConnection myConnection = AccessDataSQLServer.GetConnection();

            //Step #2: Code logic to create appropriate SQL Server objects calls
            //         Cod Logic to retrieve data from database
            //         Add Try..Catch appropriate block and throw exception back to calling program

            SqlCommand objCommand = null;
            int rowsAffected = 0;

            string sqlString;

            try
            {
                using (myConnection)
                {
                    myConnection.Open();
                    sqlString = "UPDATE Genre set name=@name where id=@id";

                    using (objCommand = new SqlCommand(sqlString, myConnection))
                    {
                        objCommand.Parameters.AddWithValue("@id", myGenre.GenreID);
                        objCommand.Parameters.AddWithValue("@name", myGenre.GenreName);

                        rowsAffected = objCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                if (myConnection != null)
                {
                    myConnection.Close();
                }
            }
            return true; //temporary return until your code is fully flushed out. Remove or comment out this line

        }

        public static bool DeleteGenre(GenreClass myGenre)
        {
            //Pre-step: Replace the general object parameter with the appropriate business class object that you are using to insert data in the underline database table 
            string SQLStatement = String.Empty;

            //Step #1: Add code to call the appropriate method from the inherited AccessDataSQLServer class
            //To return a database connection object
            SqlConnection myConnection = AccessDataSQLServer.GetConnection();

            //Step #2: Code logic to create appropriate SQL Server objects calls
            //         Cod Logic to retrieve data from database
            //         Add Try..Catch appropriate block and throw exception back to calling program

            SqlCommand objCommand = null;
            int rowsAffected = 0;

            string sqlString;

            try
            {
                using (myConnection)
                {
                    myConnection.Open();
                    sqlString = "DELETE Genre where id=@id";

                    using (objCommand = new SqlCommand(sqlString, myConnection))
                    {
                        objCommand.Parameters.AddWithValue("@id", myGenre.GenreID);
                        objCommand.Parameters.AddWithValue("@name", myGenre.GenreName);

                        rowsAffected = objCommand.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }

            finally
            {
                if (myConnection != null)
                {
                    myConnection.Close();
                }
            }
            return true; //temporary return until your code is fully flushed out. Remove or comment out this line
        }

    }
}
