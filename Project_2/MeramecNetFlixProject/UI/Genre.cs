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
            GenreClass myGenreObj = new GenreClass();

            myGenreObj.GenreID = genreIDTextBox.Text;
            myGenreObj.GenreName = genreNameTextBox.Text;

            bool recordAdded =  GenreDB.AddGenre(myGenreObj);
            
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

        private void updateGenreButton_Click(object sender, EventArgs e)
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

        private void deleteGenreButton_Click(object sender, EventArgs e)
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

        private void cleanupUI()
        {
            //Used to clean up the txtbx and refresh the datagrid
            genreIDTextBox.Clear();
            genreNameTextBox.Clear();

            //Populate the genre data grid on form load
            genreDataViewGrid.DataSource = GenreDB.GetAllGenres();
        }
        private void gridView_SelectionChanged()
        {
            foreach (DataGridViewRow row in genreDataViewGrid.SelectedRows)
            {
                string genreID = row.Cells[0].Value.ToString();
                string genreName = row.Cells[1].Value.ToString();

                genreIDTextBox.Text = genreID;
                genreNameTextBox.Text = genreName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            if (genreNameTextBox.Text == "Action")
            {
                Rental action = new Rental();
                action.ShowDialog();
            }
            if (genreNameTextBox.Text == "Comedy")
            {
                Comedy comedy = new Comedy();
                comedy.ShowDialog();
            }
        
        }
          
    }
}
