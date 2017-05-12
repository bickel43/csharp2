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
    public static class VendorDB
    {

        //Instructions: 
        //Replace all ???TableNameHere phrases with the name of your specific SQL Server Database Table Name
        //Replace yourCustomeObject phrase with the name of the business object (represents database table name) you are referencing or returning
        //Replace datatype phrase with the appropriate C# data type or custom data type based on Project #2 CRUD specs
        //Replace parameter phrase with the appropriate input parameter based on Project #2 CRUD specs
        //Refer to the ADO.Net Demo for method examples below


        internal static List<VendorClass> GetAllVendors()
        {
            //Change the MyCustomObject name to your customer business object that is returning data from the specific table
            List<VendorClass> objVendorList = new List<VendorClass>();
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
            SqlDataReader vendorReader;

            try
            {
                using (myConnection)
                {
                    //Open the DB connection
                    myConnection.Open();

                    //Define SQL statement
                    //SQLStatement = "select number, joindate, member_status, firstname, lastname, email from Member";
                    SQLStatement = "select * from Vendor";

                    //Create a command object with the sql statement
                    using (objCommand = new SqlCommand(SQLStatement, myConnection))
                    {

                        //Execute the SQL and return a datareader object
                        using (vendorReader = objCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {
                            while (vendorReader.Read())
                            {
                                VendorClass objReturnVendor = new VendorClass();

                                objReturnVendor.VendorID = Convert.ToInt32(vendorReader["id"]);
                                objReturnVendor.VendorName = vendorReader["name"].ToString();
                                objReturnVendor.VendorPhone1 = vendorReader["phone"].ToString();
                                objReturnVendor.VendorPhone2 = vendorReader["phone2"].ToString();


                                objVendorList.Add(objReturnVendor);
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
            return objVendorList;
        }

        internal static bool AddVendor(VendorClass myVendor)
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
                    sqlString = "INSERT into Vendor values (@id,@name,@phone,@phone2)";

                    using (objCommand = new SqlCommand(sqlString, myConnection))
                    {
                        objCommand.Parameters.AddWithValue("@id", myVendor.VendorID);
                        objCommand.Parameters.AddWithValue("@name", myVendor.VendorName);
                        objCommand.Parameters.AddWithValue("@phone", myVendor.VendorPhone1);
                        objCommand.Parameters.AddWithValue("@phone2", myVendor.VendorPhone2);

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

        internal static bool UpdateVendor(VendorClass myVendor)
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
                    sqlString = "UPDATE Vendor set name=@name,phone=@phone,phone2=@phone2";
                    //add joindate=@joindate, to the SQL string
                    //sqlString = "UPDATE Member set firstname=@firstname where number=@number";

                    using (objCommand = new SqlCommand(sqlString, myConnection))
                    {
                        objCommand.Parameters.AddWithValue("@id", myVendor.VendorID);
                        objCommand.Parameters.AddWithValue("@name", myVendor.VendorName);
                        objCommand.Parameters.AddWithValue("@phone", myVendor.VendorPhone1);
                        objCommand.Parameters.AddWithValue("@phone2", myVendor.VendorPhone2);

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
                if (myVendor != null)
                {
                    myConnection.Close();
                }
            }
            return true;
        }

        internal static bool DeleteVendor(VendorClass myVendor)
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
                    sqlString = "DELETE Vendor where id=@id";

                    //Added this for some testing...
                    //sqlString = "INSERT into Member values (@firstname,@lastname)";


                    using (objCommand = new SqlCommand(sqlString, myConnection))
                    {
                        objCommand.Parameters.AddWithValue("@id", myVendor.VendorID);
                        objCommand.Parameters.AddWithValue("@name", myVendor.VendorName.ToString());
                        objCommand.Parameters.AddWithValue("@phone", myVendor.VendorPhone1);
                        objCommand.Parameters.AddWithValue("@phone2", myVendor.VendorPhone2);


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
