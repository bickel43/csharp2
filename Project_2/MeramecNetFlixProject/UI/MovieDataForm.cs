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

            //Populate the genre data grid on form load
            movieDataViewGrid.DataSource = MovieDB.GetMovies();
        }
    }
}
