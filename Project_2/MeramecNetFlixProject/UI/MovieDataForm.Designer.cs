﻿namespace MeramecNetFlixProject
{
    partial class MovieData
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
            this.label1 = new System.Windows.Forms.Label();
            this.movieNumberTextBox = new System.Windows.Forms.TextBox();
            this.movieTitleTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.movieDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.movieReleaseYearTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.genreIDComboBox = new System.Windows.Forms.ComboBox();
            this.ratingComboBox = new System.Windows.Forms.ComboBox();
            this.mediaTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.retailCostTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.copiedOnHandTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.imageFileNameTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.trailerLinkTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.movieDataViewGrid = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movieReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewVendorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.genresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.genericRowsAffectedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.rowsAffectedLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.movienumberOverrideCheckbox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.movieDataViewGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Number: ";
            // 
            // movieNumberTextBox
            // 
            this.movieNumberTextBox.Location = new System.Drawing.Point(137, 42);
            this.movieNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.movieNumberTextBox.Name = "movieNumberTextBox";
            this.movieNumberTextBox.ReadOnly = true;
            this.movieNumberTextBox.Size = new System.Drawing.Size(64, 22);
            this.movieNumberTextBox.TabIndex = 1;
            // 
            // movieTitleTextBox
            // 
            this.movieTitleTextBox.Location = new System.Drawing.Point(137, 68);
            this.movieTitleTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.movieTitleTextBox.Name = "movieTitleTextBox";
            this.movieTitleTextBox.Size = new System.Drawing.Size(169, 22);
            this.movieTitleTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Title:";
            // 
            // movieDescriptionTextBox
            // 
            this.movieDescriptionTextBox.Location = new System.Drawing.Point(137, 94);
            this.movieDescriptionTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.movieDescriptionTextBox.Multiline = true;
            this.movieDescriptionTextBox.Name = "movieDescriptionTextBox";
            this.movieDescriptionTextBox.Size = new System.Drawing.Size(509, 114);
            this.movieDescriptionTextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Description:";
            // 
            // movieReleaseYearTextBox
            // 
            this.movieReleaseYearTextBox.Location = new System.Drawing.Point(137, 212);
            this.movieReleaseYearTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.movieReleaseYearTextBox.Name = "movieReleaseYearTextBox";
            this.movieReleaseYearTextBox.Size = new System.Drawing.Size(169, 22);
            this.movieReleaseYearTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Release Year:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Genre ID:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Rating:";
            // 
            // genreIDComboBox
            // 
            this.genreIDComboBox.FormattingEnabled = true;
            this.genreIDComboBox.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11"});
            this.genreIDComboBox.Location = new System.Drawing.Point(137, 236);
            this.genreIDComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.genreIDComboBox.Name = "genreIDComboBox";
            this.genreIDComboBox.Size = new System.Drawing.Size(184, 24);
            this.genreIDComboBox.Sorted = true;
            this.genreIDComboBox.TabIndex = 11;
            // 
            // ratingComboBox
            // 
            this.ratingComboBox.FormattingEnabled = true;
            this.ratingComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.ratingComboBox.Location = new System.Drawing.Point(396, 236);
            this.ratingComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ratingComboBox.Name = "ratingComboBox";
            this.ratingComboBox.Size = new System.Drawing.Size(184, 24);
            this.ratingComboBox.TabIndex = 12;
            // 
            // mediaTypeComboBox
            // 
            this.mediaTypeComboBox.FormattingEnabled = true;
            this.mediaTypeComboBox.Items.AddRange(new object[] {
            "Online",
            "DVD",
            "BluRay"});
            this.mediaTypeComboBox.Location = new System.Drawing.Point(651, 236);
            this.mediaTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mediaTypeComboBox.Name = "mediaTypeComboBox";
            this.mediaTypeComboBox.Size = new System.Drawing.Size(184, 24);
            this.mediaTypeComboBox.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(592, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 13;
            this.label7.Text = "Media:";
            // 
            // retailCostTextBox
            // 
            this.retailCostTextBox.Location = new System.Drawing.Point(137, 263);
            this.retailCostTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.retailCostTextBox.Name = "retailCostTextBox";
            this.retailCostTextBox.Size = new System.Drawing.Size(169, 22);
            this.retailCostTextBox.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 268);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Retail Cost:";
            // 
            // copiedOnHandTextBox
            // 
            this.copiedOnHandTextBox.Location = new System.Drawing.Point(460, 263);
            this.copiedOnHandTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.copiedOnHandTextBox.Name = "copiedOnHandTextBox";
            this.copiedOnHandTextBox.Size = new System.Drawing.Size(91, 22);
            this.copiedOnHandTextBox.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(321, 267);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Copies in Inventory:";
            // 
            // imageFileNameTextBox
            // 
            this.imageFileNameTextBox.Location = new System.Drawing.Point(137, 289);
            this.imageFileNameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.imageFileNameTextBox.Name = "imageFileNameTextBox";
            this.imageFileNameTextBox.Size = new System.Drawing.Size(169, 22);
            this.imageFileNameTextBox.TabIndex = 22;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(15, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 17);
            this.label11.TabIndex = 21;
            this.label11.Text = "Image File Name:";
            // 
            // trailerLinkTextBox
            // 
            this.trailerLinkTextBox.Location = new System.Drawing.Point(405, 289);
            this.trailerLinkTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.trailerLinkTextBox.Name = "trailerLinkTextBox";
            this.trailerLinkTextBox.Size = new System.Drawing.Size(429, 22);
            this.trailerLinkTextBox.TabIndex = 24;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(321, 294);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "Trailer Link:";
            // 
            // movieDataViewGrid
            // 
            this.movieDataViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.movieDataViewGrid.Location = new System.Drawing.Point(17, 324);
            this.movieDataViewGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.movieDataViewGrid.Name = "movieDataViewGrid";
            this.movieDataViewGrid.RowTemplate.Height = 28;
            this.movieDataViewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.movieDataViewGrid.Size = new System.Drawing.Size(816, 210);
            this.movieDataViewGrid.TabIndex = 25;
            this.movieDataViewGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.movieDataViewGrid_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(851, 26);
            this.menuStrip1.TabIndex = 26;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(108, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.movieReportToolStripMenuItem,
            this.viewVendorsToolStripMenuItem,
            this.genresToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // movieReportToolStripMenuItem
            // 
            this.movieReportToolStripMenuItem.Name = "movieReportToolStripMenuItem";
            this.movieReportToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.movieReportToolStripMenuItem.Text = "Movie Report";
            this.movieReportToolStripMenuItem.Click += new System.EventHandler(this.movieReportToolStripMenuItem_Click);
            // 
            // viewVendorsToolStripMenuItem
            // 
            this.viewVendorsToolStripMenuItem.Name = "viewVendorsToolStripMenuItem";
            this.viewVendorsToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.viewVendorsToolStripMenuItem.Text = "Vendors";
            this.viewVendorsToolStripMenuItem.Click += new System.EventHandler(this.viewVendorsToolStripMenuItem_Click);
            // 
            // genresToolStripMenuItem
            // 
            this.genresToolStripMenuItem.Name = "genresToolStripMenuItem";
            this.genresToolStripMenuItem.Size = new System.Drawing.Size(174, 26);
            this.genresToolStripMenuItem.Text = "Genres";
            this.genresToolStripMenuItem.Click += new System.EventHandler(this.genresToolStripMenuItem_Click);
            // 
            // addButton
            // 
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Location = new System.Drawing.Point(84, 540);
            this.addButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(132, 50);
            this.addButton.TabIndex = 27;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateButton.Location = new System.Drawing.Point(221, 539);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(132, 50);
            this.updateButton.TabIndex = 29;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Location = new System.Drawing.Point(359, 539);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(132, 50);
            this.deleteButton.TabIndex = 30;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(495, 539);
            this.clearButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(132, 50);
            this.clearButton.TabIndex = 31;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Location = new System.Drawing.Point(632, 539);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(132, 50);
            this.exitButton.TabIndex = 32;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.genericRowsAffectedLabel,
            this.rowsAffectedLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 601);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.statusStrip1.Size = new System.Drawing.Size(851, 25);
            this.statusStrip1.TabIndex = 33;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // genericRowsAffectedLabel
            // 
            this.genericRowsAffectedLabel.BackColor = System.Drawing.SystemColors.Control;
            this.genericRowsAffectedLabel.Name = "genericRowsAffectedLabel";
            this.genericRowsAffectedLabel.Size = new System.Drawing.Size(91, 20);
            this.genericRowsAffectedLabel.Text = "Last Activity:";
            // 
            // rowsAffectedLabel
            // 
            this.rowsAffectedLabel.BackColor = System.Drawing.SystemColors.Control;
            this.rowsAffectedLabel.Name = "rowsAffectedLabel";
            this.rowsAffectedLabel.Size = new System.Drawing.Size(131, 20);
            this.rowsAffectedLabel.Text = "No Changes Made";
            // 
            // movienumberOverrideCheckbox
            // 
            this.movienumberOverrideCheckbox.AutoSize = true;
            this.movienumberOverrideCheckbox.Location = new System.Drawing.Point(211, 47);
            this.movienumberOverrideCheckbox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.movienumberOverrideCheckbox.Name = "movienumberOverrideCheckbox";
            this.movienumberOverrideCheckbox.Size = new System.Drawing.Size(180, 21);
            this.movienumberOverrideCheckbox.TabIndex = 34;
            this.movienumberOverrideCheckbox.Text = "Override Movie Number";
            this.movienumberOverrideCheckbox.UseVisualStyleBackColor = true;
            this.movienumberOverrideCheckbox.CheckedChanged += new System.EventHandler(this.movienumberOverrideCheckbox_CheckedChanged);
            // 
            // MovieData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(851, 626);
            this.Controls.Add(this.movienumberOverrideCheckbox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.movieDataViewGrid);
            this.Controls.Add(this.trailerLinkTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.imageFileNameTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.copiedOnHandTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.retailCostTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mediaTypeComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ratingComboBox);
            this.Controls.Add(this.genreIDComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.movieReleaseYearTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.movieDescriptionTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.movieTitleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.movieNumberTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MovieData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieData";
            this.Load += new System.EventHandler(this.MovieData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieDataViewGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox movieNumberTextBox;
        private System.Windows.Forms.TextBox movieTitleTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox movieDescriptionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox movieReleaseYearTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox genreIDComboBox;
        private System.Windows.Forms.ComboBox ratingComboBox;
        private System.Windows.Forms.ComboBox mediaTypeComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox retailCostTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox copiedOnHandTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox imageFileNameTextBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox trailerLinkTextBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView movieDataViewGrid;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movieReportToolStripMenuItem;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel genericRowsAffectedLabel;
        private System.Windows.Forms.ToolStripStatusLabel rowsAffectedLabel;
        private System.Windows.Forms.ToolStripMenuItem viewVendorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem genresToolStripMenuItem;
        private System.Windows.Forms.CheckBox movienumberOverrideCheckbox;
        public System.Windows.Forms.Button addButton;
    }
}