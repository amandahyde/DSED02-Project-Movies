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
            //set background image size

            //      Image image = this.BackgroundImage;
            // this.ClientSize = image.Size;

            if (chcOutRented.Checked == true)
            {
                chcAllRented.Checked = false;
            }

        
        }


        public void loadDB()
        {
            //load the customer dgv
            DisplayDataGridViewCustomer();
            DisplayDataGridViewMovies();
            DisplayDataGridViewRentals();

        }


        //load customer datagrid

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

            //if (chcAllRented.Checked)
            //{
            //    DGVRental.DataSource = myDatabase.FillDGVRentalsWithOutRented();
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void DGVCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            ////   txtCDName.Text = txtCDName.Text.Trim();
            //   int CDID = 0;
            //   txtCDID.Text = CDID.ToString();
            ////these are the cell clicks for the values in the row that you click on
            //try
            //{
            //  CDID = (int)DGVCD.Rows[e.RowIndex].Cells[3].Value;

            txtName.Text = DGVCustomer.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSurname.Text = DGVCustomer.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAddress.Text = DGVCustomer.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtPhone.Text = DGVCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCustID.Text = DGVCustomer.Rows[e.RowIndex].Cells[0].Value.ToString();
            //lblCustID.Text = DGVCustomer.Rows[e.RowIndex].Cells[4].Value.ToString();


            ////if you are clicking on a row and not ouside it
            if (e.RowIndex >= 0)
            {
                //Fill the next Track DGV with the CDID
                DGVCustomer.DataSource = myDatabase.FillDGVCustomerwithCustomerInfo();
                //   DGVTracks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                //  txtOwnerID.Text = OwnerID.ToString();

            }
        }

        private void DGVMovies_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtTitle.Text = DGVMovies.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRating.Text = DGVMovies.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtYear.Text = DGVMovies.Rows[e.RowIndex].Cells[3].Value.ToString();
            //   txtCopies.Text = DGVMovies.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtCost.Text = DGVMovies.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtGenre.Text = DGVMovies.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtPlot.Text = DGVMovies.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtCopies.Text = DGVMovies.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtMovieID.Text = DGVMovies.Rows[e.RowIndex].Cells[0].Value.ToString();

            if (e.RowIndex >= 0)
            {
                //Fill the next Track DGV with the CDID
                DGVMovies.DataSource = myDatabase.FillDGVMoviesWithMoviesInfo();
                //   DGVTracks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
                //  txtOwnerID.Text = OwnerID.ToString();

            }

            //txtDateTime.Text = DateTime.Now.ToString();

           

            txtCurrentYear.Text = DateTime.Now.Date.Year.ToString();

            int CurrentYear = Convert.ToInt16(txtCurrentYear.Text);

            int MovieYear = Convert.ToInt16(txtYear.Text);

            int Calculation = myDatabase.CaluclateFee(CurrentYear, MovieYear);


            txtMovieFee.Text = Calculation.ToString();


        }

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

        private void btnAddMovie_Click(object sender, EventArgs e)
        {
            string result = null;

            if ((txtTitle.Text != string.Empty) && (txtGenre.Text != string.Empty))
            {
                try
                {
                    result = myDatabase.InsertOrUpdateMovie(txtMovieID.Text, txtRating.Text, txtTitle.Text, txtYear.Text, txtCost.Text, txtCopies.Text,  txtPlot.Text, txtGenre.Text, "Add"
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
            MessageBox.Show( " delete " + result);

           
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            string result = null;

            result = myDatabase.DeleteMovie(txtMovieID.Text);
            MessageBox.Show(" delete " + result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (chcOutRented.Checked)
            {
                DGVRental.DataSource = myDatabase.FillDGVRentalsWithOutRented();
              
            }

            else
            {
                DGVRental.DataSource = myDatabase.FillDGVRentalsWithRentalsInfo();
            }


        }

        private void chcAllRented_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            //DateTime DateTimeNow = Convert.ToDateTime(txtDateTime.Text);
            
                //string result = null;
          
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

        private void DGVRental_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRMID.Text = DGVMovies.Rows[e.RowIndex].Cells[0].Value.ToString();

        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
           
                try
                {
                    string result = myDatabase.ReturnMovie(txtRMID.Text);
                    MessageBox.Show(" Updating " + result);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                //update the datagrid view to see new entries
                DisplayDataGridViewRentals();

            }


    }
    }


    