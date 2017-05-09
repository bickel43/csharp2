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

        private void manageAccountButton_Click(object sender, EventArgs e)
        {
            MemberInfo openMemberInfo = new MemberInfo();
            openMemberInfo.ShowDialog();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            LogInForm openSignIn = new LogInForm();
            openSignIn.ShowDialog();   
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            MovieData openMovieData = new MovieData();
            openMovieData.ShowDialog();
        }

        private void exitMovieButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
