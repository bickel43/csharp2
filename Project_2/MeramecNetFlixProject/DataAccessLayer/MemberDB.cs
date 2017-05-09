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
    public static class MemberDB
    {

        //Instructions: 
        //Replace all ???TableNameHere phrases with the name of your specific SQL Server Database Table Name
        //Replace yourCustomeObject phrase with the name of the business object (represents database table name) you are referencing or returning
        //Replace datatype phrase with the appropriate C# data type or custom data type based on Project #2 CRUD specs
        //Replace parameter phrase with the appropriate input parameter based on Project #2 CRUD specs
        //Refer to the ADO.Net Demo for method examples below


        public static List<MemberClass> GetAllMembers()
        {
            //Change the MyCustomObject name to your customer business object that is returning data from the specific table
            List<MemberClass> objMemberList = new List<MemberClass>();
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
            SqlDataReader memberReader;
            
            try
            {
                using (myConnection)
                {
                    //Open the DB connection
                    myConnection.Open();

                    //Define SQL statement
                    //SQLStatement = "select number, joindate, member_status, firstname, lastname, email from Member";
                    SQLStatement = "select * from Member";

                    //Create a command object with the sql statement
                    using (objCommand = new SqlCommand(SQLStatement, myConnection))
                    {

                        //Execute the SQL and return a datareader object
                        using (memberReader = objCommand.ExecuteReader(System.Data.CommandBehavior.CloseConnection))
                        {
                            while (memberReader.Read())
                            {
                                MemberClass objReturnMember = new MemberClass();

                                objReturnMember.JoinDate = memberReader["joindate"].ToString();
                                objReturnMember.Firstname = memberReader["firstname"].ToString();
                                objReturnMember.Lastname = memberReader["lastname"].ToString();
                                objReturnMember.Address = memberReader["address"].ToString();
                                objReturnMember.City = memberReader["city"].ToString();
                                objReturnMember.State = memberReader["state"].ToString();
                                objReturnMember.Zipcode = memberReader["zipcode"].ToString();
                                objReturnMember.Phone = memberReader["phone"].ToString();
                                objReturnMember.Email = memberReader["email"].ToString();
                                objReturnMember.LoginName = memberReader["login_name"].ToString();
                                objReturnMember.Password = memberReader["password"].ToString();
                                objReturnMember.SubscriptionID = Convert.ToInt16(memberReader["subscription_id"]);
                                objReturnMember.MemberNumber = Convert.ToInt16(memberReader["number"]);
                                objReturnMember.ContactMethod = Convert.ToInt16(memberReader["contact_method"]);
                                //objReturnMember.MemberStatus = Convert.ToBoolean(memberReader["member_status"]); // this is throwing some stuff off, and shows up differently in the gridview a sa checkbox...
                                objReturnMember.Photo = memberReader["photo"].ToString(); 

                                objMemberList.Add(objReturnMember);
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
            return objMemberList;
        }

        public static bool AddMember(MemberClass myMember)
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
                    sqlString = "INSERT into Member values (@number,@joindate,@firstname,@lastname,@address,@city,@state,@zipcode,@phone,@member_status,@login_name,@password,@email,@contact_method,@subscription_id,@photo)";

                    using (objCommand = new SqlCommand(sqlString, myConnection))
                    {
                        objCommand.Parameters.AddWithValue("@number", myMember.MemberNumber);
                        objCommand.Parameters.AddWithValue("@joindate", myMember.JoinDate);
                        objCommand.Parameters.AddWithValue("@firstname", myMember.Firstname);
                        objCommand.Parameters.AddWithValue("@lastname", myMember.Lastname);
                        objCommand.Parameters.AddWithValue("@address", myMember.Address);
                        objCommand.Parameters.AddWithValue("@city", myMember.City);
                        objCommand.Parameters.AddWithValue("@state", myMember.State);
                        objCommand.Parameters.AddWithValue("@zipcode", myMember.Zipcode);
                        objCommand.Parameters.AddWithValue("@phone", myMember.Phone);
                        objCommand.Parameters.AddWithValue("@member_status", myMember.MemberStatus);
                        objCommand.Parameters.AddWithValue("@login_name", myMember.LoginName);
                        objCommand.Parameters.AddWithValue("@password", myMember.Password);
                        objCommand.Parameters.AddWithValue("@email", myMember.Email);
                        objCommand.Parameters.AddWithValue("@contact_method", myMember.ContactMethod);
                        objCommand.Parameters.AddWithValue("@subscription_id", myMember.SubscriptionID);
                        objCommand.Parameters.AddWithValue("@photo", myMember.Photo);

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

        public static bool UpdateMember(MemberClass myMember)
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
                    sqlString = "UPDATE Member set firstname=@firstname,lastname=@lastname,address=@address,city=@city,state=@state,zipcode=@zipcode,phone=@phone,login_name=@login_name,password=@password,email=@email where number=@number";
                    //add joindate=@joindate, to the SQL string
                    //sqlString = "UPDATE Member set firstname=@firstname where number=@number";

                    using (objCommand = new SqlCommand(sqlString, myConnection))
                    {                             
                        objCommand.Parameters.AddWithValue("@number", myMember.MemberNumber);
                        //objCommand.Parameters.AddWithValue("@joindate", myMember.JoinDate.ToString());
                        objCommand.Parameters.AddWithValue("@firstname", myMember.Firstname);
                        objCommand.Parameters.AddWithValue("@lastname", myMember.Lastname.ToString());
                        objCommand.Parameters.AddWithValue("@address", myMember.Address.ToString());
                        objCommand.Parameters.AddWithValue("@city", myMember.City.ToString());
                        objCommand.Parameters.AddWithValue("@state", myMember.State.ToString());
                        objCommand.Parameters.AddWithValue("@zipcode", myMember.Zipcode.ToString());
                        objCommand.Parameters.AddWithValue("@phone", myMember.Phone.ToString());
                        ////objCommand.Parameters.AddWithValue("@member_status", myMember.MemberStatus);
                        objCommand.Parameters.AddWithValue("@login_name", myMember.LoginName.ToString());
                        objCommand.Parameters.AddWithValue("@password", myMember.Password.ToString());
                        objCommand.Parameters.AddWithValue("@email", myMember.Email.ToString());
                        ////objCommand.Parameters.AddWithValue("@contact_method", myMember.ContactMethod);
                        //objCommand.Parameters.AddWithValue("@subscription_id", myMember.SubscriptionID.ToString());
                        objCommand.Parameters.AddWithValue("@photo", "photo");

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
                if (myMember != null)
                {
                    myConnection.Close();   
                }
            }
            return true;
        }

        public static bool DeleteMember(MemberClass myMember)
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
                    sqlString = "DELETE Member where number=@number";

                    //Added this for some testing...
                    //sqlString = "INSERT into Member values (@firstname,@lastname)";


                    using (objCommand = new SqlCommand(sqlString, myConnection))
                    {
                        objCommand.Parameters.AddWithValue("@number", myMember.MemberNumber);
                        objCommand.Parameters.AddWithValue("@joindate", myMember.JoinDate.ToString());
                        objCommand.Parameters.AddWithValue("@firstname", myMember.Firstname);
                        objCommand.Parameters.AddWithValue("@lastname", myMember.Lastname.ToString());
                        objCommand.Parameters.AddWithValue("@address", myMember.Address.ToString());
                        objCommand.Parameters.AddWithValue("@city", myMember.City.ToString());
                        objCommand.Parameters.AddWithValue("@state", myMember.State.ToString());
                        objCommand.Parameters.AddWithValue("@zipcode", myMember.Zipcode.ToString());
                        objCommand.Parameters.AddWithValue("@phone", myMember.Phone.ToString());
                        objCommand.Parameters.AddWithValue("@member_status", myMember.MemberStatus);
                        objCommand.Parameters.AddWithValue("@login_name", myMember.LoginName.ToString());
                        objCommand.Parameters.AddWithValue("@password", myMember.Password.ToString());
                        objCommand.Parameters.AddWithValue("@email", myMember.Email.ToString());
                        objCommand.Parameters.AddWithValue("@contact_method", myMember.ContactMethod);
                        objCommand.Parameters.AddWithValue("@subscription_id", myMember.SubscriptionID.ToString());
                        objCommand.Parameters.AddWithValue("@photo", "photo");

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
