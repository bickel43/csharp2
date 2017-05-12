using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeramecNetFlixProject.DataAccessLayer;
using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.UI;

namespace MeramecNetFlixProject
{
    public partial class MovieData : Form
    {
        public MovieData()
        {
            InitializeComponent();
        }

        private void MovieData_Load(object sender, EventArgs e)
        {
            movieDataViewGrid.DataSource = MovieDB.GetMovies();

            movieNumberTextBox.Text = Convert.ToString(movieDataViewGrid.RowCount + 1);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                MovieClass myMovieObj = new MovieClass();

                myMovieObj.MovieNumber = Convert.ToInt32(movieNumberTextBox.Text);
                myMovieObj.MovieTitle = movieTitleTextBox.Text;
                myMovieObj.Description = movieDescriptionTextBox.Text;
                myMovieObj.MovieYear = Convert.ToInt32(movieReleaseYearTextBox.Text);
                myMovieObj.GenreID = Convert.ToInt32(genreIDComboBox.Text);
                myMovieObj.MovieRating = ratingComboBox.Text;
                myMovieObj.MediaType = mediaTypeComboBox.Text;
                myMovieObj.MovieRetailCost = retailCostTextBox.Text;
                myMovieObj.CopiesOnHand = Convert.ToInt32(copiedOnHandTextBox.Text);
                myMovieObj.MovieImage = imageFileNameTextBox.Text;
                myMovieObj.MovieTrailer = trailerLinkTextBox.Text;

                bool recordAdded = MovieDB.AddMovie(myMovieObj);

                //if record is true, or false, do some stuff
                if (recordAdded == true)
                {
                    //MessageBox.Show("Record added");
                    rowsAffectedLabel.Text = "1 row added";
                }
                else
                {
                    rowsAffectedLabel.Text = "No Changes Made";
                }
                cleanupUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //MessageBox.Show("Error when adding user. \nMake sure all fields are populated.", "User Addition Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cleanupUI()
        {
            //Used to clean up the txtbx and refresh the datagrid
            movieNumberTextBox.Clear();
            movieTitleTextBox.Clear();
            movieDescriptionTextBox.Clear();
            movieReleaseYearTextBox.Clear();
            genreIDComboBox.ResetText();
            ratingComboBox.ResetText();
            mediaTypeComboBox.ResetText();
            retailCostTextBox.Clear();
            copiedOnHandTextBox.Clear();
            imageFileNameTextBox.Clear();
            trailerLinkTextBox.Clear();

            //Populate the genre data grid on form load
            movieDataViewGrid.DataSource = MovieDB.GetMovies();
            movieNumberTextBox.Text = Convert.ToString(movieDataViewGrid.RowCount + 1);

        }

        public void displayUserSelection()
        {
            try
            {
                if (movieDataViewGrid.SelectedRows.Count > 0)
                {
                    string movieNumber = movieDataViewGrid.SelectedRows[0].Cells[0].Value + string.Empty;
                    string movieTitle = movieDataViewGrid.SelectedRows[0].Cells[1].Value + string.Empty;
                    string movieDescription = movieDataViewGrid.SelectedRows[0].Cells[2].Value + string.Empty;
                    string movieReleaseYear = movieDataViewGrid.SelectedRows[0].Cells[3].Value + string.Empty;
                    string movieGenreID = movieDataViewGrid.SelectedRows[0].Cells[4].Value + string.Empty;
                    string movieRating = movieDataViewGrid.SelectedRows[0].Cells[5].Value + string.Empty;
                    string movieMediaType = movieDataViewGrid.SelectedRows[0].Cells[6].Value + string.Empty;
                    string movieRetailCost = movieDataViewGrid.SelectedRows[0].Cells[7].Value + string.Empty;
                    string movieCopies = movieDataViewGrid.SelectedRows[0].Cells[8].Value + string.Empty;
                    string movieImage = movieDataViewGrid.SelectedRows[0].Cells[9].Value + string.Empty;
                    string movieTrailer = movieDataViewGrid.SelectedRows[0].Cells[10].Value + string.Empty;


                    movieNumberTextBox.Text = movieNumber.ToString();
                    movieTitleTextBox.Text = movieTitle.ToString();
                    movieDescriptionTextBox.Text = movieDescription.ToString();
                    movieReleaseYearTextBox.Text = movieReleaseYear.ToString();
                    genreIDComboBox.Text = movieGenreID.ToString();
                    ratingComboBox.Text = movieRating.ToString();
                    mediaTypeComboBox.Text = movieMediaType.ToString();
                    retailCostTextBox.Text = movieRetailCost.ToString();
                    copiedOnHandTextBox.Text = movieCopies.ToString();
                    imageFileNameTextBox.Text = movieImage.ToString();
                    trailerLinkTextBox.Text = movieTrailer.ToString();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void movieDataViewGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            displayUserSelection();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                MovieClass myMovieObj = new MovieClass();

                myMovieObj.MovieNumber = Convert.ToInt32(movieNumberTextBox.Text);
                myMovieObj.MovieTitle = movieTitleTextBox.Text;
                myMovieObj.Description = movieDescriptionTextBox.Text;
                myMovieObj.MovieYear = Convert.ToInt32(movieReleaseYearTextBox.Text);
                myMovieObj.GenreID = Convert.ToInt32(genreIDComboBox.Text);
                myMovieObj.MovieRating = ratingComboBox.Text;
                myMovieObj.MediaType = mediaTypeComboBox.Text;
                myMovieObj.MovieRetailCost = retailCostTextBox.Text;
                myMovieObj.CopiesOnHand = Convert.ToInt32(copiedOnHandTextBox.Text);
                myMovieObj.MovieImage = imageFileNameTextBox.Text;
                myMovieObj.MovieTrailer = trailerLinkTextBox.Text;


                bool recordUpdated = MovieDB.UpdateMovie(myMovieObj);

                //if record is true, or false, do some stuff
                if (recordUpdated == true)
                {
                    rowsAffectedLabel.Text = "1 row updated";
                    //MessageBox.Show("Record Updated");          
                }
                else
                {
                    MessageBox.Show("Record Not Updated");
                }
                cleanupUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Update Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //MessageBox.Show("Error when updating user. \nMake sure a record is selected.", "User Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                MovieClass myMovieObj = new MovieClass();

                myMovieObj.MovieNumber = Convert.ToInt32(movieNumberTextBox.Text);
                myMovieObj.MovieTitle = movieTitleTextBox.Text;
                myMovieObj.Description = movieDescriptionTextBox.Text;
                myMovieObj.MovieYear = Convert.ToInt32(movieReleaseYearTextBox.Text);
                myMovieObj.GenreID = Convert.ToInt32(genreIDComboBox.Text);
                myMovieObj.MovieRating = ratingComboBox.Text;
                myMovieObj.MediaType = mediaTypeComboBox.Text;
                myMovieObj.MovieRetailCost = retailCostTextBox.Text;
                myMovieObj.CopiesOnHand = Convert.ToInt32(copiedOnHandTextBox.Text);
                myMovieObj.MovieImage = imageFileNameTextBox.Text;
                myMovieObj.MovieTrailer = trailerLinkTextBox.Text;


                bool recordDeleted = MovieDB.DeleteMovie(myMovieObj);

                //if record is true, or false, do some stuff
                if (recordDeleted == true)
                {
                    rowsAffectedLabel.Text = "1 row deleted";
                    //MessageBox.Show("Record Deleted");
                }
                else
                {
                    MessageBox.Show("Record Not Deleted");
                }
                cleanupUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Deletion Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                //MessageBox.Show("Error when deleting user. \nMake sure a record is selected.", "User Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            cleanupUI();
        }

        private void movieReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
             MovieReport Mreport = new MovieReport();
             Mreport.ShowDialog();
             Mreport = null;
        }

        private void viewVendorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendorForm openVendorForm = new VendorForm();
            openVendorForm.ShowDialog();
        }

        private void genresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Genre openGenreForm = new Genre();
            openGenreForm.ShowDialog();
        }
    }
}
