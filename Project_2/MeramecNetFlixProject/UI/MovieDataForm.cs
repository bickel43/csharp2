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
            //movieDataViewGrid.DataSource = MovieDB.GetMovies();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
