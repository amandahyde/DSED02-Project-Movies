using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DSED02_Project_Movies
{
    public class Database
    {
    // Create Connection and command and an adapter.
        private SqlConnection Connection = new SqlConnection();
        private SqlCommand Command = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();

        public Database()
        {

            //connect to the datasorce
            string connectionString = @"Data Source = DESKTOP-7J3KNR3; Initial Catalog = VBMoviesFullData; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite;
            MultiSubnetFailover = False";
       
            Connection.ConnectionString = connectionString;
            Command.Connection = Connection;

        }

        public DataTable FillDGVCustomerwithCustomerInfo()
        {
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from CustomerInformation", Connection))
            {
                Connection.Open();
                da.Fill(dt);
                Connection.Close();
            }
            return dt;
        }


        public DataTable FillDGVMoviesWithMoviesInfo()

        {
            DataTable dt = new DataTable();
            using (da = new SqlDataAdapter("select * from MoviesInformation", Connection))
            {
                Connection.Open();
                da.Fill(dt);
                Connection.Close();
            }
            return dt;
        }

        public DataTable FillDGVRentalsWithRentalsInfo()

        {

            DataTable dt = new DataTable();



            using (da = new SqlDataAdapter("select * from RentalInfo", Connection))
            {
                Connection.Open();
                da.Fill(dt);
                Connection.Close();
            }
            return dt;
        }

       public DataTable FillDGVRentalsWithOutRented()

        {

            DataTable dt = new DataTable();



            using (da = new SqlDataAdapter("select * from RentalInfo WHERE DateReturned IS NULL", Connection))
            {
                Connection.Open();
                da.Fill(dt);
                Connection.Close();
            }
            return dt;
        }


        public string InsertOrUpdateCustomer(string Firstname, string Lastname, string Phone, string Address, string CustID, string AddorUpdate)
        {
            try
            {
                //Add gets passed through the parameter
                if (AddorUpdate == "Add")
                {
                    //create a command object // create a query. Create and open a connection to SQL server
                  
                    string query = "INSERT INTO Customer(FirstName, LastName, Phone, Address) " + "VALUES(@Firstname, @Lastname, @Phone, @Address)";

                    var myCommand = new SqlCommand(query, Connection);
                    //create parameters
                    myCommand.Parameters.AddWithValue("Firstname", Firstname);
                    myCommand.Parameters.AddWithValue("Lastname", Lastname);
                    myCommand.Parameters.AddWithValue("Phone", Phone);
                    myCommand.Parameters.AddWithValue("Address", Address);
             

                    Connection.Open();
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }
                //update gets passed through the parameter
                else if (AddorUpdate == "Update")
                {
                    var myCommand = new SqlCommand("UPDATE Customer set Firstname = @Firstname, Lastname =@Lastname, Phone =@Phone, Address = @Address where CustID = @CustID", Connection);
                    //use parameters to prevent SQL injections
                    myCommand.Parameters.AddWithValue("Firstname", Firstname);
                    myCommand.Parameters.AddWithValue("Lastname", Lastname);
                    myCommand.Parameters.AddWithValue("Phone", Phone);
                    myCommand.Parameters.AddWithValue("Address", Address);
                    myCommand.Parameters.AddWithValue("CustID", CustID);
                    Connection.Open();
                    //open connection add in the SQL
                    myCommand.ExecuteNonQuery();
                    Connection.Open();
                    //open connection add in the SQL
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }

                return " is Successfull";
            }
            catch (Exception e)
            {
                Connection.Close();
                return " has Failed with " + e;
            }
        }



        public string DeleteCustomer(string CustID)
        {
            var myCommand = new SqlCommand("DELETE FROM Customer WHERE CustID = @CustID");

            myCommand.Connection = Connection;
            myCommand.Parameters.AddWithValue("CustID", CustID);
            //use parameters to prevent SQL injections

            Connection.Open();
            // open connection add in the SQL
            myCommand.ExecuteNonQuery();
            Connection.Close();
            return "Success";


        }

        public string DeleteMovie(string MovieID)
        {
            var myCommand = new SqlCommand("DELETE FROM Movies WHERE MovieID = @MovieID");

            myCommand.Connection = Connection;
            myCommand.Parameters.AddWithValue("MovieID", MovieID);
            //use parameters to prevent SQL injections

            Connection.Open();
            // open connection add in the SQL
            myCommand.ExecuteNonQuery();
            Connection.Close();
            return "Success";


        }





        public string AddNewMovie(string MovieID, string Rating, string Title, string Year, string Rental_Cost, string Copies, string Plot, string Genre)
        {
            try
            {
                var myCommand = new SqlCommand("INSERT INTO Movies (Rating, Title, Year, Rental_Cost, Copies, Plot, Genre) " + "VALUES(@Rating, @Title, @Year, @Rental_Cost, @Copies, @Plot, @Genre)", Connection);
                //create params


                myCommand.Parameters.AddWithValue("Rating", Rating);
                myCommand.Parameters.AddWithValue("Title", Title);
                myCommand.Parameters.AddWithValue("Year", Year);
                myCommand.Parameters.AddWithValue("Rental_Cost", Rental_Cost);
                myCommand.Parameters.AddWithValue("Copies", Copies);
                myCommand.Parameters.AddWithValue("Plot", Plot);
                myCommand.Parameters.AddWithValue("Genre", Genre);

                Connection.Open();
                // open connection add in the SQL
                myCommand.ExecuteNonQuery();
                Connection.Close();

                return " is Successful";
            }
            catch (Exception e)
            {

                Console.WriteLine(e);
                throw;
            }
        }

        

        public string InsertOrUpdateMovie(string MovieID, string Rating, string Title, string Year, string Rental_Cost, string Copies, string Plot, string Genre, string AddorUpdate)
        {
            try
            {
                //Add gets passed through the parameter
                if (AddorUpdate == "Add")
                {
                    //create a command object // create a query. Create and open a connection to SQL server

                    string query = "INSERT INTO Movies (Rating, Title, Year, Rental_Cost, Copies, Plot, Genre) " + "VALUES(@Rating, @Title, @Year, @Rental_Cost, @Copies, @Plot, @Genre)";

                  
                    var myCommand = new SqlCommand(query, Connection);
                    //create parameters
                    myCommand.Parameters.AddWithValue("Rating", Rating);
                    myCommand.Parameters.AddWithValue("Title", Title);
                    myCommand.Parameters.AddWithValue("Year", Year);
                    myCommand.Parameters.AddWithValue("Rental_Cost", Rental_Cost);
                    myCommand.Parameters.AddWithValue("Copies", Copies);
                    myCommand.Parameters.AddWithValue("Plot", Plot);
                    myCommand.Parameters.AddWithValue("Genre", Genre);


                    Connection.Open();
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }
                //update gets passed through the parameter
                else if (AddorUpdate == "Update")
                {
                    var myCommand = new SqlCommand("UPDATE Movies set Rating = @Rating, Title =@Title, Year =@Year, Rental_Cost = @Rental_Cost, Copies =@Copies, Plot =@Plot, Genre =@Genre where MovieID = @MovieID", Connection);
                    //use parameters to prevent SQL injections
                    myCommand.Parameters.AddWithValue("Rating", Rating);
                    myCommand.Parameters.AddWithValue("Title", Title);
                    myCommand.Parameters.AddWithValue("Year", Year);
                    myCommand.Parameters.AddWithValue("Rental_Cost", Rental_Cost);
                    myCommand.Parameters.AddWithValue("Copies", Copies);
                    myCommand.Parameters.AddWithValue("Plot", Plot);
                    myCommand.Parameters.AddWithValue("Genre", Genre);
                    myCommand.Parameters.AddWithValue("MovieID", MovieID);
                    Connection.Open();
                    //open connection add in the SQL
                    myCommand.ExecuteNonQuery();
                    Connection.Open();
                    //open connection add in the SQL
                    myCommand.ExecuteNonQuery();
                    Connection.Close();
                }

                return " is Successfull";
            }
            catch (Exception e)
            {
                Connection.Close();
                return " has Failed with " + e;
            }
        }


        public string ReturnMovie(string RMID)
        {
            DateTime now = new DateTime();
            now = DateTime.Now;

            var myCommand = new SqlCommand("UPDATE RentedMovies set DateReturned = @DateReturned where RMID = @RMID", Connection);

            myCommand.Parameters.AddWithValue("DateReturned", now);
            myCommand.Parameters.AddWithValue("RMID", RMID);

            Connection.Open();
            // open connection add in the SQL
            myCommand.ExecuteNonQuery();
            Connection.Close();

            return " is Successful";
        }

        public int CaluclateFee(int currentYear, int movieYear)
        {

            int TimeDifference = (currentYear - movieYear);

            if (TimeDifference > 5)
            {
                return 2;
            }
            else
            {
                return 5;
            }

        }

        public string IssueMovie(string MovieIDFK, string CustIDFK)
        {
            DateTime now = new DateTime();
            now = DateTime.Now;


            string query = "INSERT INTO RentedMovies (MovieIDFK, CustIDFK, DateRented) " + "VALUES(@MovieIDFK, @CustIDFK, @DateRented)";

            var myCommand = new SqlCommand(query, Connection);

            myCommand.Parameters.AddWithValue("MovieIDFK", MovieIDFK);
            myCommand.Parameters.AddWithValue("CustIDFK", CustIDFK);
            myCommand.Parameters.AddWithValue("DateRented", now);


            Connection.Open();
            // open connection add in the SQL
            myCommand.ExecuteNonQuery();
            Connection.Close();

            return " is Successful";
        }

     
}



}



