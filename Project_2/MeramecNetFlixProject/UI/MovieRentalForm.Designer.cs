namespace MeramecNetFlixProject.UI
{
    partial class MovieRentalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MovieRentalForm));
            this.rentalDataGridView = new System.Windows.Forms.DataGridView();
            this.movieTitleLabel = new System.Windows.Forms.Label();
            this.movieYearLabel = new System.Windows.Forms.Label();
            this.movieTrailerContainer = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.movieDescTextBox = new System.Windows.Forms.TextBox();
            this.rentalButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rentalPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rentalDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTrailerContainer)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rentalDataGridView
            // 
            this.rentalDataGridView.AllowUserToAddRows = false;
            this.rentalDataGridView.AllowUserToDeleteRows = false;
            this.rentalDataGridView.AllowUserToResizeColumns = false;
            this.rentalDataGridView.AllowUserToResizeRows = false;
            this.rentalDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.rentalDataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.rentalDataGridView.Location = new System.Drawing.Point(12, 46);
            this.rentalDataGridView.MultiSelect = false;
            this.rentalDataGridView.Name = "rentalDataGridView";
            this.rentalDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.rentalDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rentalDataGridView.Size = new System.Drawing.Size(434, 456);
            this.rentalDataGridView.TabIndex = 0;
            this.rentalDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.rentalDataGridView_CellClick);
            // 
            // movieTitleLabel
            // 
            this.movieTitleLabel.AutoSize = true;
            this.movieTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieTitleLabel.Location = new System.Drawing.Point(452, 46);
            this.movieTitleLabel.Name = "movieTitleLabel";
            this.movieTitleLabel.Size = new System.Drawing.Size(70, 26);
            this.movieTitleLabel.TabIndex = 2;
            this.movieTitleLabel.Text = "Movie";
            // 
            // movieYearLabel
            // 
            this.movieYearLabel.AutoSize = true;
            this.movieYearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieYearLabel.Location = new System.Drawing.Point(452, 72);
            this.movieYearLabel.Name = "movieYearLabel";
            this.movieYearLabel.Size = new System.Drawing.Size(47, 20);
            this.movieYearLabel.TabIndex = 3;
            this.movieYearLabel.Text = " Year";
            // 
            // movieTrailerContainer
            // 
            this.movieTrailerContainer.Enabled = true;
            this.movieTrailerContainer.Location = new System.Drawing.Point(457, 241);
            this.movieTrailerContainer.Name = "movieTrailerContainer";
            this.movieTrailerContainer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("movieTrailerContainer.OcxState")));
            this.movieTrailerContainer.Size = new System.Drawing.Size(437, 261);
            this.movieTrailerContainer.TabIndex = 4;
            // 
            // movieDescTextBox
            // 
            this.movieDescTextBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.movieDescTextBox.Location = new System.Drawing.Point(457, 116);
            this.movieDescTextBox.Multiline = true;
            this.movieDescTextBox.Name = "movieDescTextBox";
            this.movieDescTextBox.ReadOnly = true;
            this.movieDescTextBox.Size = new System.Drawing.Size(437, 119);
            this.movieDescTextBox.TabIndex = 5;
            // 
            // rentalButton
            // 
            this.rentalButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalButton.Location = new System.Drawing.Point(292, 508);
            this.rentalButton.Name = "rentalButton";
            this.rentalButton.Size = new System.Drawing.Size(602, 49);
            this.rentalButton.TabIndex = 6;
            this.rentalButton.Text = "Rent Movie";
            this.rentalButton.UseVisualStyleBackColor = true;
            this.rentalButton.Click += new System.EventHandler(this.rentalButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(12, 508);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(274, 49);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(906, 24);
            this.menuStrip1.TabIndex = 8;
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
            // rentalPrice
            // 
            this.rentalPrice.AutoSize = true;
            this.rentalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentalPrice.Location = new System.Drawing.Point(455, 96);
            this.rentalPrice.Name = "rentalPrice";
            this.rentalPrice.Size = new System.Drawing.Size(81, 17);
            this.rentalPrice.TabIndex = 9;
            this.rentalPrice.Text = "Rental Cost";
            // 
            // MovieRentalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(906, 569);
            this.Controls.Add(this.rentalPrice);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.rentalButton);
            this.Controls.Add(this.movieDescTextBox);
            this.Controls.Add(this.movieTrailerContainer);
            this.Controls.Add(this.movieYearLabel);
            this.Controls.Add(this.movieTitleLabel);
            this.Controls.Add(this.rentalDataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MovieRentalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MovieRentalForm";
            this.Load += new System.EventHandler(this.MovieRentalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.rentalDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movieTrailerContainer)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rentalDataGridView;
        private System.Windows.Forms.Label movieTitleLabel;
        private System.Windows.Forms.Label movieYearLabel;
        private AxShockwaveFlashObjects.AxShockwaveFlash movieTrailerContainer;
        private System.Windows.Forms.TextBox movieDescTextBox;
        private System.Windows.Forms.Button rentalButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label rentalPrice;
    }
}