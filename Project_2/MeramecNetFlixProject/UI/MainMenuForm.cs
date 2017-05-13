using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MeramecNetFlixProject.UI;

namespace MeramecNetFlixProject
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        public void manageAccountButton_Click(object sender, EventArgs e)
        {
            MemberInfo openMemberInfo = new MemberInfo();
            openMemberInfo.ShowDialog();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            LogInForm openSignIn = new LogInForm();

            openSignIn.memberVerified += new EnableMenu(EnableMainMenuButtons);

            openSignIn.ShowDialog();   
        }

        public void browseButton_Click(object sender, EventArgs e)
        {
            //open up MovieData form
            MovieData openMovieData = new MovieData();
            openMovieData.ShowDialog();
        }

        private void exitMovieButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void MainMenu_Load(object sender, EventArgs e)
        {
            DisableMainMenuButtons();
        }

        public void DisableMainMenuButtons()
        {

            //disable menu buttons
            browseButton.Enabled = false;
            manageAccountButton.Enabled = false;
            rentButton.Enabled = false;
        }

        public void EnableMainMenuButtons()
        {
            //enable menu buttons
            browseButton.Enabled = true;
            manageAccountButton.Enabled = true;
            rentButton.Enabled = true;
            signInButton.Enabled = false;
        }

        private void rentButton_Click(object sender, EventArgs e)
        {
            MovieRentalForm openRentalForm = new MovieRentalForm();
            openRentalForm.ShowDialog();
        }

        private void linkDeveloper_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AboutDeveloper about = new AboutDeveloper();
            about.ShowDialog();

        }
    }
}
