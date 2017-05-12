using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MeramecNetFlixProject.UI;
using MeramecNetFlixProject.DataAccessLayer;
using MeramecNetFlixProject.BusinessObjects;

namespace MeramecNetFlixProject
{
    public partial class Genre : Form
    {
        public Genre()
        {
            InitializeComponent();
        }

        private void Genre_Load(object sender, EventArgs e)
        {
            //Populate the genre data grid on form load
            genreDataViewGrid.DataSource = GenreDB.GetAllGenres();
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            try
            {
                GenreClass myGenreObj = new GenreClass();

                myGenreObj.GenreID = genreIDTextBox.Text;
                myGenreObj.GenreName = genreNameTextBox.Text;

                bool recordAdded = GenreDB.AddGenre(myGenreObj);

                //if record is true, or false, do some stuff
                if (recordAdded == true)
                {
                    MessageBox.Show("Record added");
                }
                else
                {
                    MessageBox.Show("Record not added");
                }
                cleanupUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Addition Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateGenreButton_Click(object sender, EventArgs e)
        {
            try
            {
                GenreClass myGenreObj = new GenreClass();

                myGenreObj.GenreID = genreIDTextBox.Text;
                myGenreObj.GenreName = genreNameTextBox.Text;

                bool recordUpdated = GenreDB.UpdateGenre(myGenreObj);

                //if record is true, or false, do some stuff
                if (recordUpdated == true)
                {
                    MessageBox.Show("Record Updated");
                }
                else
                {
                    MessageBox.Show("Record Not Updated");
                }
                cleanupUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void deleteGenreButton_Click(object sender, EventArgs e)
        {
            try
            {
                GenreClass myGenreObj = new GenreClass();

                myGenreObj.GenreID = genreIDTextBox.Text;
                myGenreObj.GenreName = genreNameTextBox.Text;

                bool recordDeleted = GenreDB.DeleteGenre(myGenreObj);

                //if record is true, or false, do some stuff
                if (recordDeleted == true)
                {
                    MessageBox.Show("Record Deleted");
                }
                else
                {
                    MessageBox.Show("Record Not Deleted");
                }
                cleanupUI();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cleanupUI()
        {
            //Used to clean up the txtbx and refresh the datagrid
            genreIDTextBox.Clear();
            genreNameTextBox.Clear();

            //Populate the genre data grid on form load
            genreDataViewGrid.DataSource = GenreDB.GetAllGenres();
        }
        private void displayGenreSelection()
        {
            try
            {
                if (genreDataViewGrid.SelectedRows.Count > 0)
                {
                    //Populate the selected genre into the UI fields
                    string genreID = genreDataViewGrid.SelectedRows[0].Cells[0].Value + string.Empty;
                    string genreName = genreDataViewGrid.SelectedRows[0].Cells[1].Value + string.Empty;

                    genreIDTextBox.Text = genreID.ToString();
                    genreNameTextBox.Text = genreName.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Selection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void genreDataViewGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            displayGenreSelection();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            cleanupUI();
        }
    }
}
