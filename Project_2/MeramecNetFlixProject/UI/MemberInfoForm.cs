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
using System.IO;
using System.Data.SqlClient;


namespace MeramecNetFlixProject
{
    public partial class MemberInfo : Form
    {
        public MemberInfo()
        {
            InitializeComponent();
        }


        private void MemberInfo_Load(object sender, EventArgs e)
        {
            memberDataViewGrid.DataSource = MemberDB.GetAllMembers();

            //hide columns - use this to hide everything we don't want showing (password and other irrevelant info)
            memberDataViewGrid.Columns[11].Visible = false;  //password field

            //automagically enumerate the member number
            memberNumberTextBox.Text = Convert.ToString(memberDataViewGrid.RowCount + 1);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewPasswordImage_Click(object sender, EventArgs e)
        {
            //Toggles between the password char and the viewable text password
            if (passwordTextBox.PasswordChar.ToString() == "●")
            {
                passwordTextBox.PasswordChar = default(char);
            }
            else
            {
                passwordTextBox.PasswordChar = Convert.ToChar("●");
            }
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Check member activity level
                bool memberActive;

                if (activeRadioButton.Checked)
                {
                    memberActive = true;
                }
                else
                {
                    memberActive = false;
                }

                //Check contact methods
                int contactMethod;
                if (phoneRadioButton.Checked)
                {
                    contactMethod = 1;
                }
                else if (emailRadioButton.Checked)
                {
                    contactMethod = 2;
                }
                else
                {
                    contactMethod = 0;
                }


                MemberClass myMemberObj = new MemberClass();

                myMemberObj.MemberNumber = Convert.ToInt16(memberNumberTextBox.Text);
                myMemberObj.Firstname = firstNameTextBox.Text;
                myMemberObj.Lastname = lastNameTextBox.Text;
                myMemberObj.JoinDate = joinDateTimePicker.Value.ToShortDateString();
                myMemberObj.Address = addressTextBox.Text;
                myMemberObj.City = cityTextBox.Text;
                myMemberObj.State = stateTextBox.Text;
                myMemberObj.Zipcode = zipcodeTextBox.Text;
                myMemberObj.Phone = phoneNumberTextBox.Text;
                myMemberObj.MemberStatus = Convert.ToBoolean(memberActive.ToString());
                //MessageBox.Show(memberActive.ToString(), "Member Active?"); //For testing
                myMemberObj.LoginName = usernameTextBox.Text;
                myMemberObj.Password = passwordTextBox.Text;
                myMemberObj.Email = emailTextBox.Text;
                myMemberObj.ContactMethod = Convert.ToInt32(contactMethod);
                //MessageBox.Show(contactMethod.ToString(), "Contact Method"); //For testing
                myMemberObj.SubscriptionID = Convert.ToInt32(subscriptionIdTextBox.Text);
                myMemberObj.Photo = "photo"; // this will later be changed to an actual file path or name

                bool recordAdded = MemberDB.AddMember(myMemberObj);

                //if record is true, or false, do some stuff
                if (recordAdded == true)
                {
                    //MessageBox.Show("Record added");
                    rowsAffectedCountLabel.Text = "1 row added";
                }
                else
                {
                    MessageBox.Show("Record not added");
                }
                cleanupUI();
            }
            catch (Exception)
            {
                MessageBox.Show("Error when adding user. \nMake sure all fields are populated.","User Addition Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void cleanupUI()
        {
            //Used to clean up the txtbx and refresh the datagrid
            activeRadioButton.Checked = false;
            inactiveRadioButton.Checked = false;
            phoneRadioButton.Checked = false;
            emailRadioButton.Checked = false;
            noneRadioButton.Checked = false;
            memberNumberTextBox.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            joinDateTimePicker.ResetText();
            addressTextBox.Clear();
            cityTextBox.Clear();
            stateTextBox.Clear();
            zipcodeTextBox.Clear();
            phoneNumberTextBox.Clear();
            emailTextBox.Clear();
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            subscriptionIdTextBox.Clear();


            //Populate the genre data grid on form load
            memberDataViewGrid.DataSource = MemberDB.GetAllMembers();
            memberNumberTextBox.Text = Convert.ToString(memberDataViewGrid.RowCount + 1);
        }
        string imgLocation = "";
        //browse local comp for photos
        private void changePhotoButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                userPhoto.ImageLocation = imgLocation;
            }
            //this does nothing right now
            //OpenFileDialog choosePhoto = new OpenFileDialog();
            //choosePhoto.ShowDialog();

            //Throw this messagebox, since it really isnt doing anything productive
            //MessageBox.Show("Feature not yet implemented", "Woah there", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void clearUserInfoButton_Click(object sender, EventArgs e)
        {
            cleanupUI();
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                MemberClass myMemberObj = new MemberClass();

                myMemberObj.MemberNumber = Convert.ToInt16(memberNumberTextBox.Text);
                myMemberObj.JoinDate = joinDateTimePicker.Value.ToShortDateString();
                myMemberObj.Firstname = firstNameTextBox.Text;
                myMemberObj.Lastname = lastNameTextBox.Text;
                myMemberObj.Address = addressTextBox.Text;
                myMemberObj.City = cityTextBox.Text;
                myMemberObj.State = stateTextBox.Text;
                myMemberObj.Zipcode = zipcodeTextBox.Text;
                myMemberObj.Phone = phoneNumberTextBox.Text;
                //myMemberObj.MemberStatus = Convert.ToString(memberStatusGroupBox);
                myMemberObj.LoginName = usernameTextBox.Text;
                myMemberObj.Password = passwordTextBox.Text;
                myMemberObj.Email = emailTextBox.Text;
                //myMemberObj.ContactMethod = Convert.ToString(contactMethodGroupBox);
                //myMemberObj.SubscriptionID = Convert.ToInt64(subscriptionIdTextBox);
                //myMemberObj.Photo = Convert.ToString(); //still a little lost on what to do with this

                bool recordDeleted = MemberDB.DeleteMember(myMemberObj);

                //if record is true, or false, do some stuff
                if (recordDeleted == true)
                {
                    rowsAffectedCountLabel.Text = "1 row deleted";
                    //MessageBox.Show("Record Deleted");
                }
                else
                {
                    MessageBox.Show("Record Not Deleted");
                }
                cleanupUI();
            }
            catch (Exception)
            {
                MessageBox.Show("Error when deleting user. \nMake sure a record is selected.","User Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void displayUserSelection()
        {
            try
            {
                if (memberDataViewGrid.SelectedRows.Count > 0)
                {
                    string memberNumber = memberDataViewGrid.SelectedRows[0].Cells[0].Value + string.Empty;
                    string joindate = memberDataViewGrid.SelectedRows[0].Cells[1].Value + string.Empty;
                    string firstname = memberDataViewGrid.SelectedRows[0].Cells[2].Value + string.Empty;
                    string lastname = memberDataViewGrid.SelectedRows[0].Cells[3].Value + string.Empty;
                    string address = memberDataViewGrid.SelectedRows[0].Cells[4].Value + string.Empty;
                    string city = memberDataViewGrid.SelectedRows[0].Cells[5].Value + string.Empty;
                    string state = memberDataViewGrid.SelectedRows[0].Cells[6].Value + string.Empty;
                    string zipcode = memberDataViewGrid.SelectedRows[0].Cells[7].Value + string.Empty;
                    string phone = memberDataViewGrid.SelectedRows[0].Cells[8].Value + string.Empty;
                    string member_status = memberDataViewGrid.SelectedRows[0].Cells[9].Value + string.Empty;
                    string login_name = memberDataViewGrid.SelectedRows[0].Cells[10].Value + string.Empty;
                    string password = memberDataViewGrid.SelectedRows[0].Cells[11].Value + string.Empty;
                    string email = memberDataViewGrid.SelectedRows[0].Cells[12].Value + string.Empty;
                    string contact_method = memberDataViewGrid.SelectedRows[0].Cells[13].Value + string.Empty;
                    string subscription_id = memberDataViewGrid.SelectedRows[0].Cells[14].Value + string.Empty;
                    string photo = memberDataViewGrid.SelectedRows[0].Cells[15].Value + string.Empty;


                    memberNumberTextBox.Text = memberNumber.ToString();
                    joinDateTimePicker.Text = joindate.ToString();
                    firstNameTextBox.Text = firstname.ToString();
                    lastNameTextBox.Text = lastname.ToString();
                    addressTextBox.Text = address.ToString();
                    cityTextBox.Text = city.ToString();
                    stateTextBox.Text = state.ToString();
                    zipcodeTextBox.Text = zipcode.ToString();
                    phoneNumberTextBox.Text = phone.ToString();
                    //memberStatusGroupBox = memberStatusGroupBox.Text; //groupbox issue when selecting the row
                    usernameTextBox.Text = login_name.ToString();
                    passwordTextBox.Text = password.ToString();
                    emailTextBox.Text = email.ToString();
                    //contactMethodGroupBox.Text = contact_method.ToString(); //groupbox issue when selecting the row
                    subscriptionIdTextBox.Text = subscription_id.ToString();
                    photo = photo.ToString();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        
        private void memberDataViewGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            displayUserSelection();
        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            try
            {
                MemberClass myMemberObj = new MemberClass();

                myMemberObj.MemberNumber = Convert.ToInt16(memberNumberTextBox.Text);
                //myMemberObj.JoinDate = joinDateTimePicker.ToString();
                myMemberObj.Firstname = firstNameTextBox.Text;
                myMemberObj.Lastname = lastNameTextBox.Text;
                myMemberObj.Address = addressTextBox.Text;
                myMemberObj.City = cityTextBox.Text;
                myMemberObj.State = stateTextBox.Text;
                myMemberObj.Zipcode = zipcodeTextBox.Text;
                myMemberObj.Phone = phoneNumberTextBox.Text;
                //myMemberObj.MemberStatus = Convert.ToString(memberStatusGroupBox);
                myMemberObj.LoginName = usernameTextBox.Text;
                myMemberObj.Password = passwordTextBox.Text;
                myMemberObj.Email = emailTextBox.Text;
                //myMemberObj.ContactMethod = Convert.ToString(contactMethodGroupBox);
                //myMemberObj.SubscriptionID = Convert.ToInt64(subscriptionIdTextBox);
                //myMemberObj.Photo = Convert.ToString(); //still a little lost on what to do with this

                bool recordUpdated = MemberDB.UpdateMember(myMemberObj);

                //if record is true, or false, do some stuff
                if (recordUpdated == true)
                {
                    rowsAffectedCountLabel.Text = "1 row updated";
                    //MessageBox.Show("Record Updated");          
                }
                else
                {
                    MessageBox.Show("Record Not Updated");
                }
                cleanupUI();
            }
            catch (Exception)
            {
                MessageBox.Show("Error when updating user. \nMake sure a record is selected.","User Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //throw;
            }
        }

        private void userReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserReport report = new UserReport();
            report.ShowDialog();
            report = null;
        }
   

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void overrideMemberNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (memberNumberTextBox.ReadOnly == true)
            {
                memberNumberTextBox.ReadOnly = false;
            }
            else
            {
                memberNumberTextBox.ReadOnly = true;
      
            }
        }
    }
}
