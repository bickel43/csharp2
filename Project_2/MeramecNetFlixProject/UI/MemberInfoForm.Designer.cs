﻿namespace MeramecNetFlixProject
{
    partial class MemberInfo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberInfo));
            this.label1 = new System.Windows.Forms.Label();
            this.memberNumberTextBox = new System.Windows.Forms.TextBox();
            this.memberStatusGroupBox = new System.Windows.Forms.GroupBox();
            this.inactiveRadioButton = new System.Windows.Forms.RadioButton();
            this.activeRadioButton = new System.Windows.Forms.RadioButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.joinDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.zipcodeTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.subscriptionIdTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.userPhoto = new System.Windows.Forms.PictureBox();
            this.changePhotoButton = new System.Windows.Forms.Button();
            this.contactMethodGroupBox = new System.Windows.Forms.GroupBox();
            this.noneRadioButton = new System.Windows.Forms.RadioButton();
            this.emailRadioButton = new System.Windows.Forms.RadioButton();
            this.phoneRadioButton = new System.Windows.Forms.RadioButton();
            this.addUserButton = new System.Windows.Forms.Button();
            this.updateUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.clearUserInfoButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.rowsAffectedStatusStrip = new System.Windows.Forms.ToolStripStatusLabel();
            this.rowsAffectedCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.viewPasswordImage = new System.Windows.Forms.PictureBox();
            this.memberDataViewGrid = new System.Windows.Forms.DataGridView();
            this.overrideMemberNumber = new System.Windows.Forms.CheckBox();
            this.memberStatusGroupBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).BeginInit();
            this.contactMethodGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPasswordImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 117);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Number:";
            // 
            // memberNumberTextBox
            // 
            this.memberNumberTextBox.Location = new System.Drawing.Point(117, 115);
            this.memberNumberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.memberNumberTextBox.Name = "memberNumberTextBox";
            this.memberNumberTextBox.ReadOnly = true;
            this.memberNumberTextBox.Size = new System.Drawing.Size(104, 20);
            this.memberNumberTextBox.TabIndex = 1;
            // 
            // memberStatusGroupBox
            // 
            this.memberStatusGroupBox.Controls.Add(this.inactiveRadioButton);
            this.memberStatusGroupBox.Controls.Add(this.activeRadioButton);
            this.memberStatusGroupBox.Location = new System.Drawing.Point(8, 36);
            this.memberStatusGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.memberStatusGroupBox.Name = "memberStatusGroupBox";
            this.memberStatusGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.memberStatusGroupBox.Size = new System.Drawing.Size(174, 58);
            this.memberStatusGroupBox.TabIndex = 2;
            this.memberStatusGroupBox.TabStop = false;
            this.memberStatusGroupBox.Text = "Member Status";
            // 
            // inactiveRadioButton
            // 
            this.inactiveRadioButton.AutoSize = true;
            this.inactiveRadioButton.Location = new System.Drawing.Point(86, 26);
            this.inactiveRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.inactiveRadioButton.Name = "inactiveRadioButton";
            this.inactiveRadioButton.Size = new System.Drawing.Size(63, 17);
            this.inactiveRadioButton.TabIndex = 1;
            this.inactiveRadioButton.TabStop = true;
            this.inactiveRadioButton.Text = "Inactive";
            this.inactiveRadioButton.UseVisualStyleBackColor = true;
            // 
            // activeRadioButton
            // 
            this.activeRadioButton.AutoSize = true;
            this.activeRadioButton.Location = new System.Drawing.Point(14, 26);
            this.activeRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.activeRadioButton.Name = "activeRadioButton";
            this.activeRadioButton.Size = new System.Drawing.Size(55, 17);
            this.activeRadioButton.TabIndex = 0;
            this.activeRadioButton.TabStop = true;
            this.activeRadioButton.Text = "Active";
            this.activeRadioButton.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(638, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userReportToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // userReportToolStripMenuItem
            // 
            this.userReportToolStripMenuItem.Name = "userReportToolStripMenuItem";
            this.userReportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userReportToolStripMenuItem.Text = "User Report";
            this.userReportToolStripMenuItem.Click += new System.EventHandler(this.userReportToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Join Date:";
            // 
            // joinDateTimePicker
            // 
            this.joinDateTimePicker.Location = new System.Drawing.Point(117, 138);
            this.joinDateTimePicker.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.joinDateTimePicker.Name = "joinDateTimePicker";
            this.joinDateTimePicker.Size = new System.Drawing.Size(210, 20);
            this.joinDateTimePicker.TabIndex = 5;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(117, 159);
            this.firstNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(104, 20);
            this.firstNameTextBox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "First Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(117, 179);
            this.lastNameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(104, 20);
            this.lastNameTextBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 180);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Last Name:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(117, 200);
            this.addressTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(241, 20);
            this.addressTextBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Address:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(117, 223);
            this.cityTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(133, 20);
            this.cityTextBox.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 227);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "City:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(302, 223);
            this.stateTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(50, 20);
            this.stateTextBox.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(262, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "State:";
            // 
            // zipcodeTextBox
            // 
            this.zipcodeTextBox.Location = new System.Drawing.Point(411, 223);
            this.zipcodeTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.zipcodeTextBox.Name = "zipcodeTextBox";
            this.zipcodeTextBox.Size = new System.Drawing.Size(83, 20);
            this.zipcodeTextBox.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(363, 225);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Zipcode";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(117, 244);
            this.phoneNumberTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(133, 20);
            this.phoneNumberTextBox.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 245);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Phone Number:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.Location = new System.Drawing.Point(302, 244);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(140, 20);
            this.emailTextBox.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(255, 249);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Email:";
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(117, 265);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(104, 20);
            this.usernameTextBox.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 266);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Username:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(302, 265);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '●';
            this.passwordTextBox.Size = new System.Drawing.Size(102, 20);
            this.passwordTextBox.TabIndex = 25;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(235, 266);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 24;
            this.label12.Text = "Password:";
            // 
            // subscriptionIdTextBox
            // 
            this.subscriptionIdTextBox.Location = new System.Drawing.Point(526, 263);
            this.subscriptionIdTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subscriptionIdTextBox.Name = "subscriptionIdTextBox";
            this.subscriptionIdTextBox.Size = new System.Drawing.Size(104, 20);
            this.subscriptionIdTextBox.TabIndex = 27;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(441, 266);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(82, 13);
            this.label13.TabIndex = 26;
            this.label13.Text = "Subscription ID:";
            // 
            // userPhoto
            // 
            this.userPhoto.Image = ((System.Drawing.Image)(resources.GetObject("userPhoto.Image")));
            this.userPhoto.Location = new System.Drawing.Point(482, 36);
            this.userPhoto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.userPhoto.Name = "userPhoto";
            this.userPhoto.Size = new System.Drawing.Size(147, 141);
            this.userPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPhoto.TabIndex = 28;
            this.userPhoto.TabStop = false;
            // 
            // changePhotoButton
            // 
            this.changePhotoButton.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.changePhotoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.changePhotoButton.Location = new System.Drawing.Point(482, 180);
            this.changePhotoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.changePhotoButton.Name = "changePhotoButton";
            this.changePhotoButton.Size = new System.Drawing.Size(147, 24);
            this.changePhotoButton.TabIndex = 29;
            this.changePhotoButton.Text = "Browse";
            this.changePhotoButton.UseVisualStyleBackColor = false;
            this.changePhotoButton.Click += new System.EventHandler(this.changePhotoButton_Click);
            // 
            // contactMethodGroupBox
            // 
            this.contactMethodGroupBox.Controls.Add(this.noneRadioButton);
            this.contactMethodGroupBox.Controls.Add(this.emailRadioButton);
            this.contactMethodGroupBox.Controls.Add(this.phoneRadioButton);
            this.contactMethodGroupBox.Location = new System.Drawing.Point(194, 36);
            this.contactMethodGroupBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contactMethodGroupBox.Name = "contactMethodGroupBox";
            this.contactMethodGroupBox.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.contactMethodGroupBox.Size = new System.Drawing.Size(202, 58);
            this.contactMethodGroupBox.TabIndex = 30;
            this.contactMethodGroupBox.TabStop = false;
            this.contactMethodGroupBox.Text = "Contact Method";
            // 
            // noneRadioButton
            // 
            this.noneRadioButton.AutoSize = true;
            this.noneRadioButton.Location = new System.Drawing.Point(141, 26);
            this.noneRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.noneRadioButton.Name = "noneRadioButton";
            this.noneRadioButton.Size = new System.Drawing.Size(51, 17);
            this.noneRadioButton.TabIndex = 4;
            this.noneRadioButton.TabStop = true;
            this.noneRadioButton.Text = "None";
            this.noneRadioButton.UseVisualStyleBackColor = true;
            // 
            // emailRadioButton
            // 
            this.emailRadioButton.AutoSize = true;
            this.emailRadioButton.Location = new System.Drawing.Point(79, 26);
            this.emailRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.emailRadioButton.Name = "emailRadioButton";
            this.emailRadioButton.Size = new System.Drawing.Size(50, 17);
            this.emailRadioButton.TabIndex = 3;
            this.emailRadioButton.TabStop = true;
            this.emailRadioButton.Text = "Email";
            this.emailRadioButton.UseVisualStyleBackColor = true;
            // 
            // phoneRadioButton
            // 
            this.phoneRadioButton.AutoSize = true;
            this.phoneRadioButton.Location = new System.Drawing.Point(10, 26);
            this.phoneRadioButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.phoneRadioButton.Name = "phoneRadioButton";
            this.phoneRadioButton.Size = new System.Drawing.Size(56, 17);
            this.phoneRadioButton.TabIndex = 2;
            this.phoneRadioButton.TabStop = true;
            this.phoneRadioButton.Text = "Phone";
            this.phoneRadioButton.UseVisualStyleBackColor = true;
            // 
            // addUserButton
            // 
            this.addUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addUserButton.Location = new System.Drawing.Point(72, 437);
            this.addUserButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(96, 34);
            this.addUserButton.TabIndex = 32;
            this.addUserButton.Text = "Add";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // updateUserButton
            // 
            this.updateUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateUserButton.Location = new System.Drawing.Point(172, 437);
            this.updateUserButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.Size = new System.Drawing.Size(96, 34);
            this.updateUserButton.TabIndex = 34;
            this.updateUserButton.Text = "Update";
            this.updateUserButton.UseVisualStyleBackColor = true;
            this.updateUserButton.Click += new System.EventHandler(this.updateUserButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUserButton.Location = new System.Drawing.Point(272, 437);
            this.deleteUserButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(96, 34);
            this.deleteUserButton.TabIndex = 35;
            this.deleteUserButton.Text = "Delete";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // clearUserInfoButton
            // 
            this.clearUserInfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearUserInfoButton.Location = new System.Drawing.Point(374, 437);
            this.clearUserInfoButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.clearUserInfoButton.Name = "clearUserInfoButton";
            this.clearUserInfoButton.Size = new System.Drawing.Size(96, 34);
            this.clearUserInfoButton.TabIndex = 36;
            this.clearUserInfoButton.Text = "Clear";
            this.clearUserInfoButton.UseVisualStyleBackColor = true;
            this.clearUserInfoButton.Click += new System.EventHandler(this.clearUserInfoButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(473, 437);
            this.exitButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(96, 34);
            this.exitButton.TabIndex = 37;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rowsAffectedStatusStrip,
            this.rowsAffectedCountLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 487);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(638, 22);
            this.statusStrip1.TabIndex = 38;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // rowsAffectedStatusStrip
            // 
            this.rowsAffectedStatusStrip.BackColor = System.Drawing.SystemColors.Control;
            this.rowsAffectedStatusStrip.Name = "rowsAffectedStatusStrip";
            this.rowsAffectedStatusStrip.Size = new System.Drawing.Size(74, 17);
            this.rowsAffectedStatusStrip.Text = "Last Activity:";
            // 
            // rowsAffectedCountLabel
            // 
            this.rowsAffectedCountLabel.BackColor = System.Drawing.SystemColors.Control;
            this.rowsAffectedCountLabel.Name = "rowsAffectedCountLabel";
            this.rowsAffectedCountLabel.Size = new System.Drawing.Size(105, 17);
            this.rowsAffectedCountLabel.Text = "No Changes Made";
            // 
            // viewPasswordImage
            // 
            this.viewPasswordImage.Image = ((System.Drawing.Image)(resources.GetObject("viewPasswordImage.Image")));
            this.viewPasswordImage.Location = new System.Drawing.Point(405, 265);
            this.viewPasswordImage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.viewPasswordImage.Name = "viewPasswordImage";
            this.viewPasswordImage.Size = new System.Drawing.Size(22, 19);
            this.viewPasswordImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.viewPasswordImage.TabIndex = 39;
            this.viewPasswordImage.TabStop = false;
            this.viewPasswordImage.Click += new System.EventHandler(this.viewPasswordImage_Click);
            // 
            // memberDataViewGrid
            // 
            this.memberDataViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.memberDataViewGrid.Location = new System.Drawing.Point(15, 301);
            this.memberDataViewGrid.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.memberDataViewGrid.Name = "memberDataViewGrid";
            this.memberDataViewGrid.RowTemplate.Height = 24;
            this.memberDataViewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.memberDataViewGrid.Size = new System.Drawing.Size(600, 122);
            this.memberDataViewGrid.TabIndex = 40;
            this.memberDataViewGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.memberDataViewGrid_CellClick);
            // 
            // overrideMemberNumber
            // 
            this.overrideMemberNumber.AutoSize = true;
            this.overrideMemberNumber.Location = new System.Drawing.Point(224, 115);
            this.overrideMemberNumber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.overrideMemberNumber.Name = "overrideMemberNumber";
            this.overrideMemberNumber.Size = new System.Drawing.Size(147, 17);
            this.overrideMemberNumber.TabIndex = 41;
            this.overrideMemberNumber.Text = "Override Member Number";
            this.overrideMemberNumber.UseVisualStyleBackColor = true;
            this.overrideMemberNumber.CheckedChanged += new System.EventHandler(this.overrideMemberNumber_CheckedChanged);
            // 
            // MemberInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(638, 509);
            this.Controls.Add(this.overrideMemberNumber);
            this.Controls.Add(this.memberDataViewGrid);
            this.Controls.Add(this.viewPasswordImage);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearUserInfoButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.updateUserButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.contactMethodGroupBox);
            this.Controls.Add(this.changePhotoButton);
            this.Controls.Add(this.userPhoto);
            this.Controls.Add(this.subscriptionIdTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.phoneNumberTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.zipcodeTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.joinDateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.memberStatusGroupBox);
            this.Controls.Add(this.memberNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MemberInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MemberInfo";
            this.Load += new System.EventHandler(this.MemberInfo_Load);
            this.memberStatusGroupBox.ResumeLayout(false);
            this.memberStatusGroupBox.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).EndInit();
            this.contactMethodGroupBox.ResumeLayout(false);
            this.contactMethodGroupBox.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.viewPasswordImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memberDataViewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox memberNumberTextBox;
        private System.Windows.Forms.GroupBox memberStatusGroupBox;
        private System.Windows.Forms.RadioButton inactiveRadioButton;
        private System.Windows.Forms.RadioButton activeRadioButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker joinDateTimePicker;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox zipcodeTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox subscriptionIdTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox userPhoto;
        private System.Windows.Forms.Button changePhotoButton;
        private System.Windows.Forms.GroupBox contactMethodGroupBox;
        private System.Windows.Forms.RadioButton noneRadioButton;
        private System.Windows.Forms.RadioButton emailRadioButton;
        private System.Windows.Forms.RadioButton phoneRadioButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button updateUserButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button clearUserInfoButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel rowsAffectedStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel rowsAffectedCountLabel;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userReportToolStripMenuItem;
        private System.Windows.Forms.PictureBox viewPasswordImage;
        private System.Windows.Forms.DataGridView memberDataViewGrid;
        private System.Windows.Forms.CheckBox overrideMemberNumber;
    }
}