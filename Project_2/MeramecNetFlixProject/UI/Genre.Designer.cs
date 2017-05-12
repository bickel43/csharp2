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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.genreDataViewGrid)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // genreDataViewGrid
            // 
            this.genreDataViewGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.genreDataViewGrid.Location = new System.Drawing.Point(12, 114);
            this.genreDataViewGrid.Name = "genreDataViewGrid";
            this.genreDataViewGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.genreDataViewGrid.Size = new System.Drawing.Size(297, 194);
            this.genreDataViewGrid.TabIndex = 0;
            this.genreDataViewGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.genreDataViewGrid_CellClick);
            // 
            // genreIDTextBox
            // 
            this.genreIDTextBox.Location = new System.Drawing.Point(90, 46);
            this.genreIDTextBox.Name = "genreIDTextBox";
            this.genreIDTextBox.Size = new System.Drawing.Size(161, 20);
            this.genreIDTextBox.TabIndex = 1;
            // 
            // genreNameTextBox
            // 
            this.genreNameTextBox.Location = new System.Drawing.Point(90, 72);
            this.genreNameTextBox.Name = "genreNameTextBox";
            this.genreNameTextBox.Size = new System.Drawing.Size(161, 20);
            this.genreNameTextBox.TabIndex = 2;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(12, 53);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(21, 13);
            this.idLabel.TabIndex = 3;
            this.idLabel.Text = "ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Genre Name:";
            // 
            // addGenreButton
            // 
            this.addGenreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addGenreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGenreButton.Location = new System.Drawing.Point(15, 314);
            this.addGenreButton.Name = "addGenreButton";
            this.addGenreButton.Size = new System.Drawing.Size(142, 32);
            this.addGenreButton.TabIndex = 5;
            this.addGenreButton.Text = "Add";
            this.addGenreButton.UseVisualStyleBackColor = true;
            this.addGenreButton.Click += new System.EventHandler(this.addGenreButton_Click);
            // 
            // updateGenreButton
            // 
            this.updateGenreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateGenreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateGenreButton.Location = new System.Drawing.Point(166, 314);
            this.updateGenreButton.Name = "updateGenreButton";
            this.updateGenreButton.Size = new System.Drawing.Size(142, 32);
            this.updateGenreButton.TabIndex = 7;
            this.updateGenreButton.Text = "Update";
            this.updateGenreButton.UseVisualStyleBackColor = true;
            this.updateGenreButton.Click += new System.EventHandler(this.updateGenreButton_Click);
            // 
            // deleteGenreButton
            // 
            this.deleteGenreButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteGenreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteGenreButton.Location = new System.Drawing.Point(15, 352);
            this.deleteGenreButton.Name = "deleteGenreButton";
            this.deleteGenreButton.Size = new System.Drawing.Size(142, 32);
            this.deleteGenreButton.TabIndex = 8;
            this.deleteGenreButton.Text = "Delete";
            this.deleteGenreButton.UseVisualStyleBackColor = true;
            this.deleteGenreButton.Click += new System.EventHandler(this.deleteGenreButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(321, 24);
            this.menuStrip1.TabIndex = 9;
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
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // clearButton
            // 
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(166, 352);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(142, 32);
            this.clearButton.TabIndex = 10;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(90, 390);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(142, 32);
            this.exitButton.TabIndex = 11;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Genre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(321, 429);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.deleteGenreButton);
            this.Controls.Add(this.updateGenreButton);
            this.Controls.Add(this.addGenreButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idLabel);
            this.Controls.Add(this.genreNameTextBox);
            this.Controls.Add(this.genreIDTextBox);
            this.Controls.Add(this.genreDataViewGrid);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Genre";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Genre";
            this.Load += new System.EventHandler(this.Genre_Load);
            ((System.ComponentModel.ISupportInitialize)(this.genreDataViewGrid)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}