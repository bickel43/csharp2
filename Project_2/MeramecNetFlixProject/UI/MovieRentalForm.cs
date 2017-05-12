using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.DataAccessLayer;

namespace MeramecNetFlixProject.UI
{
    public partial class MovieRentalForm : Form
    {
        public MovieRentalForm()
        {
            InitializeComponent();
        }

        private void MovieRentalForm_Load(object sender, EventArgs e)
        {
            SetupDataGrid();
        }
        private void SetupDataGrid()
        {
            //grid adjustments to make it look decent
            rentalDataGridView.ColumnHeadersVisible = false;
            rentalDataGridView.RowHeadersVisible = false;
            rentalDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            rentalDataGridView.AllowUserToResizeRows = false;
            rentalDataGridView.AllowUserToResizeColumns = false;

            rentalDataGridView.DataSource = MovieDB.GetMovies();

            //enable & disable fields in the grid
            rentalDataGridView.Columns[0].Visible = false; //movie number
            rentalDataGridView.Columns[1].Visible = true; //title
            rentalDataGridView.Columns[2].Visible = false; //description
            rentalDataGridView.Columns[3].Visible = true; //year
            rentalDataGridView.Columns[4].Visible = false; //genre
            rentalDataGridView.Columns[5].Visible = false; //rating
            rentalDataGridView.Columns[6].Visible = false; //media
            rentalDataGridView.Columns[7].Visible = false; //retail cost
            rentalDataGridView.Columns[8].Visible = false; //copies on hand
            rentalDataGridView.Columns[9].Visible = false; //image
            rentalDataGridView.Columns[10].Visible = false; //trailer
        }
        public void displayUserSelection()
        {
            try
            {
                if (rentalDataGridView.SelectedRows.Count > 0)
                {
                    //Assign variables for values in the DB
                    string movieNumber = rentalDataGridView.SelectedRows[0].Cells[0].Value + string.Empty;
                    string movieTitle = rentalDataGridView.SelectedRows[0].Cells[1].Value + string.Empty;
                    string movieDescription = rentalDataGridView.SelectedRows[0].Cells[2].Value + string.Empty;
                    string movieReleaseYear = rentalDataGridView.SelectedRows[0].Cells[3].Value + string.Empty;
                    string movieGenreID = rentalDataGridView.SelectedRows[0].Cells[4].Value + string.Empty;
                    string movieRating = rentalDataGridView.SelectedRows[0].Cells[5].Value + string.Empty;
                    string movieMediaType = rentalDataGridView.SelectedRows[0].Cells[6].Value + string.Empty;
                    string movieRetailCost = rentalDataGridView.SelectedRows[0].Cells[7].Value + string.Empty;
                    string movieCopies = rentalDataGridView.SelectedRows[0].Cells[8].Value + string.Empty;
                    string movieImage = rentalDataGridView.SelectedRows[0].Cells[9].Value + string.Empty;
                    string movieTrailer = rentalDataGridView.SelectedRows[0].Cells[10].Value + string.Empty;

                    //Start convert the regular youtube link provided into a link that the
                    //  shockwave player can handle nicely
                    //watch?v= -> v/
                    //https://www.youtube.com/watch?v=rwDNaK-fwAM //sample link for a trailer
                    var newLink = new StringBuilder(movieTrailer);
                    newLink.Remove(24, 8);
                    newLink.Insert(24, "v/");
                    movieTrailer = newLink.ToString();
                    //End convert & reassignment of the link

                    //Currency section for the users display
                    var movieCost = new StringBuilder(movieRetailCost);
                    movieCost.Remove(4, 2);
                    movieCost.Insert(4, "");
                    movieRetailCost = movieCost.ToString();

                    //Assign user viewable attributes some values for what is being selected
                    movieTitleLabel.Text = movieTitle.ToString();
                    movieYearLabel.Text = movieReleaseYear.ToString();
                    movieDescTextBox.Text = movieDescription.ToString();
                    movieTrailerContainer.Movie = movieTrailer.ToString();
                    rentalPrice.Text = "$" + movieRetailCost;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void rentalDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            displayUserSelection();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rentalButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks for renting " + movieTitleLabel.Text + ".\nYour rental will be available shortly", "Rental successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
