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
using MeramecNetFlixProject.BusinessObjects;
using MeramecNetFlixProject.DataAccessLayer;


namespace MeramecNetFlixProject.UI
{
    //Create delegate object
    public delegate void EnableMenu();
    

    public partial class LogInForm : Form
    {
        //Event variables
        public event EnableMenu memberVerified;

        MemberClass objMember = new MemberClass();

        public LogInForm()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void signUpLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            MemberInfo signUpForm = new MemberInfo();
            signUpForm.ShowDialog();
        }

        public static Boolean IsValid(MemberClass objMember, TextBox usernameTextBox, TextBox passwordTextBox)
        {
            SqlConnection objConn = AccessDataSQLServer.GetConnection();
            SqlCommand objCommand;
            SqlDataReader memberReader;

            objMember.LoginName = usernameTextBox.Text;
            objMember.Password = passwordTextBox.Text;

            bool loginAccepted = false;

            using (objConn)
            {
                objConn.Open();
                string sqlString = $"Select * from Member WHERE login_name=@LoginName AND password=@Password";

                using (objCommand = new SqlCommand(sqlString, objConn))
                {
                    objCommand.Parameters.AddWithValue("@LoginName", objMember.LoginName);
                    objCommand.Parameters.AddWithValue("@Password", objMember.Password);

                    using (memberReader = objCommand.ExecuteReader(CommandBehavior.CloseConnection))
                    {
                        if (memberReader.Read())
                        {
                            loginAccepted = true;

                        }
                    }

                }
            }
            return loginAccepted;
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (IsValid(objMember, usernameTextBox, passwordTextBox))
            {
                Hide();
                MainMenu sign = new MainMenu();
                memberVerified();
                sign.Show();
            }
            else
            {
                MessageBox.Show("Wrong Username and/or Password!", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Error,
                       MessageBoxDefaultButton.Button1);
                return;
            }
        }
        
    }
}
