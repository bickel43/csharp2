namespace MeramecNetFlixProject
{
    partial class Genre
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
            this.genreDataViewGrid = new System.Windows.Forms.DataGridView();
            this.genreIDTextBox = new System.Windows.Forms.TextBox();
            this.genreNameTextBox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addGenreButton = new System.Windows.Forms.Button();
            this.updateGenreButton = new System.Windows.Forms.Button();
            this.deleteGenreButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.genreDataViewGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // genreDataViewGrid
            // 
            this.genreDataViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genreDataViewGrid.Location = new System.Drawing.Point(12, 80);
            this.genreDataViewGrid.Name = "genreDataViewGrid";
            this.genreDataViewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.genreDataViewGrid.Size = new System.Drawing.Size(449, 194);
            this.genreDataViewGrid.TabIndex = 0;
            // 
            // genreIDTextBox
            // 
            this.genreIDTextBox.Location = new System.Drawing.Point(90, 12);
            this.genreIDTextBox.Name = "genreIDTextBox";
            this.genreIDTextBox.Size = new System.Drawing.Size(127, 20);
            this.genreIDTextBox.TabIndex = 1;
            // 
            // genreNameTextBox
            // 
            this.genreNameTextBox.Location = new System.Drawing.Point(90, 38);
            this.genreNameTextBox.Name = "genreNameTextBox";
            this.genreNameTextBox.Size = new System.Drawing.Size(127, 20);
            this.genreNameTextBox.TabIndex = 2;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 19);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Genre Name:";
            // 
            // addGenreButton
            // 
            this.addGenreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGenreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGenreButton.Location = new System.Drawing.Point(12, 291);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(147, 48);
            this.addGenreButton.TabIndex = 5;
            this.addGenreButton.Text = "Add";
            this.addGenreButton.UseVisualStyleBackColor = true;
            this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
            // 
            // updateGenreButton
            // 
            this.updateGenreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateGenreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateGenreButton.Location = new System.Drawing.Point(164, 291);
            this.updateGenreButton.Name = "updateGenreButton";
            this.updateGenreButton.Size = new System.Drawing.Size(147, 48);
            this.updateGenreButton.TabIndex = 7;
            this.updateGenreButton.Text = "Update";
            this.updateGenreButton.UseVisualStyleBackColor = true;
            this.updateGenreButton.Click += new System.EventHandler(this.updateGenreButton_Click);
            // 
            // deleteGenreButton
            // 
            this.deleteGenreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteGenreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteGenreButton.Location = new System.Drawing.Point(314, 291);
            this.deleteGenreButton.Name = "deleteGenreButton";
            this.deleteGenreButton.Size = new System.Drawing.Size(147, 48);
            this.deleteGenreButton.TabIndex = 8;
            this.deleteGenreButton.Text = "Delete";
            this.deleteGenreButton.UseVisualStyleBackColor = true;
            this.deleteGenreButton.Click += new System.EventHandler(this.deleteGenreButton_Click);
            // 
            // Genre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(473, 355);
            this.Controls.Add(this.deleteGenreButton);
            this.Controls.Add(this.updateGenreButton);
            this.Controls.Add(this.addGenreButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.genreNameTextBox);
            this.Controls.Add(this.genreIDTextBox);
            this.Controls.Add(this.genreDataViewGrid);
            this.Name = "Genre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genre";
            this.Load += new System.EventHandler(this.Genre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genreDataViewGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView genreDataViewGrid;
        private System.Windows.Forms.TextBox genreIDTextBox;
        private System.Windows.Forms.TextBox genreNameTextBox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addGenreButton;
        private System.Windows.Forms.Button updateGenreButton;
        private System.Windows.Forms.Button deleteGenreButton;
    }
}