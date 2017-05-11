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
    public static class MovieDB
    {
        //Not too sure what was going on, but internal instead of public fixed the issue 
        internal static List<MovieClass> GetMovies()
        {
            //Change the MyCustomObject name to your customer business object that is returning data from the specific table
            List<MovieClass> objMovieList = new List<MovieClass>();
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
            SqlDataReader movieReader;

            try
            {
                using (myConnection)
                {
                    //Open the DB connection
                    myConnection.Open();

                    //Define SQL statement
                    //SQLStatement = "select number, joindate, member_status, firstname, lastname, email from Member";
                    SQLStatement = "select * from Movie";

                    //Create a command object with the sql statement
                    using (objCommand = new SqlCommand(SQLStatement, myConnection))
                    {

                        //Execute the SQL and return a datareader object
                        using (movieReader = objCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {
                            while (movieReader.Read())
                            {
                                MovieClass objReturnMovie = new MovieClass();

                                objReturnMovie.MovieNumber = Convert.ToInt32(movieReader["movie_number"]);
                                objReturnMovie.MovieTitle = movieReader["movie_title"].ToString();
                                objReturnMovie.Description = movieReader["Description"].ToString();
                                objReturnMovie.MovieYear = Convert.ToInt32(movieReader["movie_year_made"]);
                                objReturnMovie.GenreID = Convert.ToInt32(movieReader["genre_id"]);
                                objReturnMovie.MovieRating = movieReader["movie_rating"].ToString();
                                objReturnMovie.MediaType = movieReader["media_type"].ToString();
                                objReturnMovie.MovieRetailCost = movieReader["movie_retail_cost"].ToString();
                                objReturnMovie.CopiesOnHand = Convert.ToInt32(movieReader["copies_on_hand"]);
                                objReturnMovie.MovieImage = movieReader["image"].ToString();
                                objReturnMovie.MovieTrailer = movieReader["trailer"].ToString();

                                objMovieList.Add(objReturnMovie);
                            }
                        }
                    }
                    //Close the connection
                    myConnection.Close();
                }
            }
            catch (SqlException)
            {

            }

            //Step #3: Return the objtemp variable back to the calling UI 
            return objMovieList;
        }

        internal static bool AddMovie(MovieClass myMovie)
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
                    sqlString = "INSERT into Movie values (@movie_number,@movie_title,@Description,@movie_year_made,@genre_id,@movie_rating,@media_type,@movie_retail_cost,@copies_on_hand,@image,@trailer)";

                    using (objCommand = new SqlCommand(sqlString, myConnection))
                    {
                        objCommand.Parameters.AddWithValue("@movie_number", myMovie.MovieNumber);
                        objCommand.Parameters.AddWithValue("@movie_title", myMovie.MovieTitle);
                        objCommand.Parameters.AddWithValue("@Description", myMovie.Description);
                        objCommand.Parameters.AddWithValue("@movie_year_made", myMovie.MovieYear);
                        objCommand.Parameters.AddWithValue("@genre_id", myMovie.GenreID);
                        objCommand.Parameters.AddWithValue("@movie_rating", myMovie.MovieRating);
                        objCommand.Parameters.AddWithValue("@media_type", myMovie.MediaType);
                        objCommand.Parameters.AddWithValue("@movie_retail_cost", myMovie.MovieRetailCost);
                        objCommand.Parameters.AddWithValue("@copies_on_hand", myMovie.CopiesOnHand);
                        objCommand.Parameters.AddWithValue("@image", myMovie.MovieImage);
                        objCommand.Parameters.AddWithValue("@trailer", myMovie.MovieTrailer);

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

        internal static bool UpdateMovie(MovieClass myMovie)
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
                    sqlString = "UPDATE Movie set movie_number=@movie_number,movie_title=@movie_title,Description=@Description,movie_year_made=@movie_year_made,genre_id=@genre_id,movie_rating=@movie_rating,media_type=@media_type,movie_retail_cost=@movie_retail_cost,copies_on_hand=@copies_on_hand,image=@image,trailer=@trailer";
                    //add joindate=@joindate, to the SQL string
                    //sqlString = "UPDATE Member set firstname=@firstname where number=@number";

                    using (objCommand = new SqlCommand(sqlString, myConnection))
                    {
                        objCommand.Parameters.AddWithValue("@movie_number", myMovie.MovieNumber);
                        objCommand.Parameters.AddWithValue("@movie_title", myMovie.MovieTitle);
                        objCommand.Parameters.AddWithValue("@Description", myMovie.Description);
                        objCommand.Parameters.AddWithValue("@movie_year_made", myMovie.MovieYear);
                        objCommand.Parameters.AddWithValue("@genre_id", myMovie.GenreID);
                        objCommand.Parameters.AddWithValue("@movie_rating", myMovie.MovieRating);
                        objCommand.Parameters.AddWithValue("@media_type", myMovie.MediaType);
                        objCommand.Parameters.AddWithValue("@movie_retail_cost", myMovie.MovieRetailCost);
                        objCommand.Parameters.AddWithValue("@copies_on_hand", myMovie.CopiesOnHand);
                        objCommand.Parameters.AddWithValue("@image", myMovie.MovieImage);
                        objCommand.Parameters.AddWithValue("@trailer", myMovie.MovieTrailer);

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
                if (myMovie != null)
                {
                    myConnection.Close();
                }
            }
            return true;
        }

        internal static bool DeleteMovie(MovieClass myMovie)
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
                    sqlString = "DELETE Movie where movie_number=@movie_number";

                    //Added this for some testing...
                    //sqlString = "INSERT into Member values (@firstname,@lastname)";


                    using (objCommand = new SqlCommand(sqlString, myConnection))
                    {
                        objCommand.Parameters.AddWithValue("@movie_number", myMovie.MovieNumber);
                        objCommand.Parameters.AddWithValue("@movie_title", myMovie.MovieTitle);
                        objCommand.Parameters.AddWithValue("@Description", myMovie.Description);
                        objCommand.Parameters.AddWithValue("@movie_year_made", myMovie.MovieYear);
                        objCommand.Parameters.AddWithValue("@genre_id", myMovie.GenreID);
                        objCommand.Parameters.AddWithValue("@movie_rating", myMovie.MovieRating);
                        objCommand.Parameters.AddWithValue("@media_type", myMovie.MediaType);
                        objCommand.Parameters.AddWithValue("@movie_retail_cost", myMovie.MovieRetailCost);
                        objCommand.Parameters.AddWithValue("@copies_on_hand", myMovie.CopiesOnHand);
                        objCommand.Parameters.AddWithValue("@image", myMovie.MovieImage);
                        objCommand.Parameters.AddWithValue("@trailer", myMovie.MovieTrailer);

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
    }
}