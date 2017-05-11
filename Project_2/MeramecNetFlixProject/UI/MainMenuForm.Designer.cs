namespace MeramecNetFlixProject
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.manageAccountButton = new System.Windows.Forms.Button();
            this.browseButton = new System.Windows.Forms.Button();
            this.exitMovieButton = new System.Windows.Forms.Button();
            this.signInButton = new System.Windows.Forms.Button();
            this.rentButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageAccountButton
            // 
            this.manageAccountButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.manageAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageAccountButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.manageAccountButton.Location = new System.Drawing.Point(458, 350);
            this.manageAccountButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.manageAccountButton.Name = "manageAccountButton";
            this.manageAccountButton.Size = new System.Drawing.Size(214, 41);
            this.manageAccountButton.TabIndex = 0;
            this.manageAccountButton.Text = "Manage Account";
            this.manageAccountButton.UseVisualStyleBackColor = false;
            this.manageAccountButton.Click += new System.EventHandler(this.manageAccountButton_Click);
            // 
            // browseButton
            // 
            this.browseButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.browseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.browseButton.Location = new System.Drawing.Point(236, 350);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(214, 41);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "Browse Inventory";
            this.browseButton.UseVisualStyleBackColor = false;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // exitMovieButton
            // 
            this.exitMovieButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.exitMovieButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitMovieButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitMovieButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitMovieButton.Location = new System.Drawing.Point(129, 399);
            this.exitMovieButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exitMovieButton.Name = "exitMovieButton";
            this.exitMovieButton.Size = new System.Drawing.Size(214, 41);
            this.exitMovieButton.TabIndex = 2;
            this.exitMovieButton.Text = "Exit";
            this.exitMovieButton.UseVisualStyleBackColor = false;
            this.exitMovieButton.Click += new System.EventHandler(this.exitMovieButton_Click);
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.signInButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signInButton.Location = new System.Drawing.Point(14, 350);
            this.signInButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(214, 41);
            this.signInButton.TabIndex = 4;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // rentButton
            // 
            this.rentButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.rentButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rentButton.Location = new System.Drawing.Point(351, 399);
            this.rentButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rentButton.Name = "rentButton";
            this.rentButton.Size = new System.Drawing.Size(214, 41);
            this.rentButton.TabIndex = 5;
            this.rentButton.Text = "Rent ";
            this.rentButton.UseVisualStyleBackColor = false;
            this.rentButton.Click += new System.EventHandler(this.rentButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1167, 530);
            this.Controls.Add(this.rentButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.exitMovieButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.manageAccountButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageAccountButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button exitMovieButton;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button rentButton;
    }
}