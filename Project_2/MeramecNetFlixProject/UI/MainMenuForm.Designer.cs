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
            this.helpButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manageAccountButton
            // 
            this.manageAccountButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.manageAccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manageAccountButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageAccountButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.manageAccountButton.Location = new System.Drawing.Point(515, 438);
            this.manageAccountButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.manageAccountButton.Name = "manageAccountButton";
            this.manageAccountButton.Size = new System.Drawing.Size(241, 51);
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
            this.browseButton.Location = new System.Drawing.Point(266, 438);
            this.browseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(241, 51);
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
            this.exitMovieButton.Location = new System.Drawing.Point(145, 499);
            this.exitMovieButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.exitMovieButton.Name = "exitMovieButton";
            this.exitMovieButton.Size = new System.Drawing.Size(241, 51);
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
            this.signInButton.Location = new System.Drawing.Point(16, 438);
            this.signInButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(241, 51);
            this.signInButton.TabIndex = 4;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helpButton.Location = new System.Drawing.Point(395, 499);
            this.helpButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(241, 51);
            this.helpButton.TabIndex = 5;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1313, 662);
            this.Controls.Add(this.helpButton);
            this.Controls.Add(this.signInButton);
            this.Controls.Add(this.exitMovieButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.manageAccountButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manageAccountButton;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button exitMovieButton;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.Button helpButton;
    }
}