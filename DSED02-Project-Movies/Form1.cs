using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DSED02_Project_Movies
{
    public partial class Form1 : Form
    {

        //creates an instance of the Database Class
        private Database myDatabase = new Database();
        public Form1()
        {

           
            InitializeComponent();
            loadDB();
            txtMovieID.Visible = false;
            txtDateTime.Text = DateTime.Now.ToString();

        }


        public void loadDB()
        {
            //load the customer dgv
            DisplayDataGridViewCustomer();
            DisplayDataGridViewMovies();
            DisplayDataGridViewRentals();
            DisplayDataGridViewTopCustomers();
            DisplayDataGridViewTopMovies();
        }


        //load customer datagrid


        #region Display Customer Information

        private void DisplayDataGridViewCustomer()

        {
            //clear out the old data
            DGVCustomer.DataSource = null;
            try
            {
                DGVCustomer.DataSource = myDatabase.FillDGVCustomerwithCustomerInfo();
                //pass the datatable data to the DataGridView
                DGVCustomer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //  column.Width = 300;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        #endregion

        #region Display Movie Information
        private void DisplayDataGridViewMovies()

        {
            //clear out the old data
            DGVMovies.DataSource = null;
            try
            {
                DGVMovies.DataSource = myDatabase.FillDGVMoviesWithMoviesInfo();
                //pass the datatable data to the DataGridView
                DGVMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        #endregion

        #region Display Rentail Information

        private void DisplayDataGridViewRentals()
        {
            //clear out the old data
            DGVRental.DataSource = null;
            try
            {
                DGVRental.DataSource = myDatabase.FillDGVRentalsWithRentalsInfo();
                //pass the datatable data to the DataGridView
                DGVRental.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        #endregion



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        #region Customer Content Click
        private void DGVCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {



            txtName.Text = DGVCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSurname.Text = DGVCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAddress.Text = DGVCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPhone.Text = DGVCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCustID.Text = DGVCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (e.RowIndex >= 0)
            {

                DGVCustomer.DataSource = myDatabase.FillDGVCustomerwithCustomerInfo();

            }
        }
        #endregion

        #region Movies Content Click & FEE calculation display
        private void DGVMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtTitle.Text = DGVMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRating.Text = DGVMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtYear.Text = DGVMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtCost.Text = DGVMovies.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtGenre.Text = DGVMovies.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtPlot.Text = DGVMovies.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtCopies.Text = DGVMovies.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtMovieID.Text = DGVMovies.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (e.RowIndex >= 0)
            {

                DGVMovies.DataSource = myDatabase.FillDGVMoviesWithMoviesInfo();


            }




            // Display calculation of movie fee
            txtCurrentYear.Text = DateTime.Now.Date.Year.ToString();
            myDatabase.CurrentYear = Convert.ToInt16(txtCurrentYear.Text);
            myDatabase.MovieYear = Convert.ToInt16(txtYear.Text);
            myDatabase.Calculation = myDatabase.CaluclateFee(myDatabase.CurrentYear, myDatabase.MovieYear);
            lblFee.Text = myDatabase.Calculation.ToString();


        }
        #endregion

        #region Add Customer
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            string result = null;
            //hold the success or failure result
            //only run if there is something in the textboxes
            if ((txtName.Text != string.Empty) && (txtSurname.Text != string.Empty))
            {
                try
                {
                    result = myDatabase.InsertOrUpdateCustomer(txtName.Text, txtSurname.Text, txtAddress.Text, txtPhone.Text, txtCustID.Text, "Add");
                    MessageBox.Show(txtName.Text + " " + txtSurname.Text + " Updating " + result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //update the datagrid view to see new entries
                DisplayDataGridViewCustomer();
                txtName.Text = "";
                txtSurname.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";
                txtCustID.Text = "";
            }
            else
            {
                MessageBox.Show("Fill First Name and Surname fields");
            }



        }

        #endregion

        #region Add Movie
        //Add Movie
        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            string result = null;

            if ((txtTitle.Text != string.Empty) && (txtGenre.Text != string.Empty))
            {
                try
                {
                    result = myDatabase.InsertOrUpdateMovie(txtMovieID.Text, txtRating.Text, txtTitle.Text, txtYear.Text, txtCost.Text, txtCopies.Text, txtPlot.Text, txtGenre.Text, "Add"
                        );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                DisplayDataGridViewMovies();
                txtMovieID.Text = "";
                txtRating.Text = "";
                txtTitle.Text = "";
                txtYear.Text = "";
                txtCost.Text = "";
                txtCopies.Text = "";
                txtPlot.Text = "";
                txtGenre.Text = "";


            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }
        #endregion


        #region Update Customer
        //Update Customer
        private void btnUpdateCustomer_Click(object sender, EventArgs e)
        {

            string result = null;
            //hold the success or failure result
            //only run if there is something in the textboxes
            if ((txtName.Text != string.Empty) && (txtSurname.Text != string.Empty))
            {
                try
                {
                    result = myDatabase.InsertOrUpdateCustomer(txtName.Text, txtSurname.Text, txtAddress.Text, txtPhone.Text, txtCustID.Text, "Update");
                    MessageBox.Show(txtName.Text + " " + txtSurname.Text + " Updating " + result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //update the datagrid view to see new entries
                DisplayDataGridViewCustomer();
                txtName.Text = "";
                txtSurname.Text = "";
                txtAddress.Text = "";
                txtPhone.Text = "";
                txtCustID.Text = "";
            }
            else
            {
                MessageBox.Show("Fill First Name and Surname fields");
            }


        }
        #endregion

        #region Update Movie
        private void btnUpdateMovie_Click(object sender, EventArgs e)
        {
            string result = null;

            if ((txtTitle.Text != string.Empty) && (txtGenre.Text != string.Empty))
            {
                try
                {
                    result = myDatabase.InsertOrUpdateMovie(txtMovieID.Text, txtRating.Text, txtTitle.Text, txtYear.Text, txtCost.Text, txtCopies.Text, txtPlot.Text, txtGenre.Text, "Update"
                        );
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                DisplayDataGridViewMovies();
                txtMovieID.Text = "";
                txtRating.Text = "";
                txtTitle.Text = "";
                txtYear.Text = "";
                txtCost.Text = "";
                txtCopies.Text = "";
                txtPlot.Text = "";
                txtGenre.Text = "";


            }
            else
            {
                MessageBox.Show("Please fill in all fields");
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            string result = null;

            result = myDatabase.DeleteCustomer(txtCustID.Text);
            MessageBox.Show(" Delete " + result);


        }
        #endregion

        #region Delete Movie
        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            //string result = null;

            string result = myDatabase.DeleteMovie(txtMovieID.Text);
            MessageBox.Show(" Delete " + result);
        }

        #endregion


        #region Issue Movie
        private void btnIssue_Click(object sender, EventArgs e)
        {


            if ((txtCustID.Text != string.Empty) && (txtMovieID.Text != string.Empty))
            {
                try
                {
                    string result = myDatabase.IssueMovie(txtMovieID.Text, txtCustID.Text);
                    MessageBox.Show(" Updating " + result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //update the datagrid view to see new entries
                DisplayDataGridViewRentals();

            }
            else
            {
                MessageBox.Show("Please Select Customer and Movie");
            }


        }
        #endregion

        #region View Rental Movies
        private void DGVRental_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRMID.Text = DGVRental.Rows[e.RowIndex].Cells[6].Value.ToString();

        }
        #endregion
       
        #region Return Movie
        private void btnReturn_Click(object sender, EventArgs e)


        {


            DateTime Date = Convert.ToDateTime(txtDateTime.Text);

            try
            {
                string result = myDatabase.ReturnMovie(txtRMID.Text, Date);
                MessageBox.Show(" Updating " + result);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //update the datagrid view to see new entries
            DisplayDataGridViewRentals();

        }

        #endregion


        #region Radio Buttons to Display Rented / Out Rented
        //display all rented movies
        private void RbnAllRented_CheckedChanged(object sender, EventArgs e)
        {
            DGVRental.DataSource = myDatabase.FillDGVRentalsWithRentalsInfo();
        }


        //display all rented movies yet to be returned
        private void RbnOutRented_CheckedChanged(object sender, EventArgs e)
        {

            DGVRental.DataSource = myDatabase.FillDGVRentalsWithOutRented();
        }

        #endregion

        #region View Top Customers
        private void DisplayDataGridViewTopCustomers()
        {
            //clear out the old data
            DGVTopCustomers.DataSource = null;
            try
            {
                DGVTopCustomers.DataSource = myDatabase.FillDGVTopCustomers();
                //pass the datatable data to the DataGridView
                DGVTopCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        #endregion

        #region View Top Movies
        private void DisplayDataGridViewTopMovies()
        {
            DGVTopMovies.DataSource = null;
            try
            {
                DGVTopMovies.DataSource = myDatabase.FillDGVTopMovies();
                //pass the datatable data to the DataGridView
                DGVTopMovies.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        } 
        #endregion

    }
    }


    