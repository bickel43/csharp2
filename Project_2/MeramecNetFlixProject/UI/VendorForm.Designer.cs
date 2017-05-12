namespace MeramecNetFlixProject.UI
{
    partial class VendorForm
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
            this.addVendorButton = new System.Windows.Forms.Button();
            this.vendorDataGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vendorReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateVendorButton = new System.Windows.Forms.Button();
            this.deleteVendorButton = new System.Windows.Forms.Button();
            this.exitVendorButton = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.rowsAffectedStatusStripLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.vendorIDTextBox = new System.Windows.Forms.TextBox();
            this.vendorNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.vendorPhone1TextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.vendorPhone2TextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vendorDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // addVendorButton
            // 
            this.addVendorButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.addVendorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addVendorButton.Location = new System.Drawing.Point(12, 252);
            this.addVendorButton.Name = "addVendorButton";
            this.addVendorButton.Size = new System.Drawing.Size(147, 48);
            this.addVendorButton.TabIndex = 0;
            this.addVendorButton.Text = "Add";
            this.addVendorButton.UseVisualStyleBackColor = false;
            this.addVendorButton.Click += new System.EventHandler(this.addVendorButton_Click);
            // 
            // vendorDataGridView
            // 
            this.vendorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vendorDataGridView.Location = new System.Drawing.Point(12, 96);
            this.vendorDataGridView.Name = "vendorDataGridView";
            this.vendorDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vendorDataGridView.Size = new System.Drawing.Size(606, 150);
            this.vendorDataGridView.TabIndex = 1;
            this.vendorDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.vendorDataGridView_CellClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(629, 24);
            this.menuStrip1.TabIndex = 2;
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
            this.vendorReportToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // vendorReportToolStripMenuItem
            // 
            this.vendorReportToolStripMenuItem.Name = "vendorReportToolStripMenuItem";
            this.vendorReportToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.vendorReportToolStripMenuItem.Text = "Vendor Report";
            this.vendorReportToolStripMenuItem.Click += new System.EventHandler(this.vendorReportToolStripMenuItem_Click);
            // 
            // updateVendorButton
            // 
            this.updateVendorButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.updateVendorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateVendorButton.Location = new System.Drawing.Point(165, 252);
            this.updateVendorButton.Name = "updateVendorButton";
            this.updateVendorButton.Size = new System.Drawing.Size(147, 48);
            this.updateVendorButton.TabIndex = 3;
            this.updateVendorButton.Text = "Update";
            this.updateVendorButton.UseVisualStyleBackColor = false;
            this.updateVendorButton.Click += new System.EventHandler(this.updateVendorButton_Click);
            // 
            // deleteVendorButton
            // 
            this.deleteVendorButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.deleteVendorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteVendorButton.Location = new System.Drawing.Point(318, 252);
            this.deleteVendorButton.Name = "deleteVendorButton";
            this.deleteVendorButton.Size = new System.Drawing.Size(147, 48);
            this.deleteVendorButton.TabIndex = 4;
            this.deleteVendorButton.Text = "Delete";
            this.deleteVendorButton.UseVisualStyleBackColor = false;
            this.deleteVendorButton.Click += new System.EventHandler(this.deleteVendorButton_Click);
            // 
            // exitVendorButton
            // 
            this.exitVendorButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.exitVendorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitVendorButton.Location = new System.Drawing.Point(471, 252);
            this.exitVendorButton.Name = "exitVendorButton";
            this.exitVendorButton.Size = new System.Drawing.Size(147, 48);
            this.exitVendorButton.TabIndex = 5;
            this.exitVendorButton.Text = "Exit";
            this.exitVendorButton.UseVisualStyleBackColor = false;
            this.exitVendorButton.Click += new System.EventHandler(this.exitVendorButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.rowsAffectedStatusStripLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 376);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(629, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(77, 17);
            this.toolStripStatusLabel1.Text = "Last Activity: ";
            // 
            // rowsAffectedStatusStripLabel
            // 
            this.rowsAffectedStatusStripLabel.Name = "rowsAffectedStatusStripLabel";
            this.rowsAffectedStatusStripLabel.Size = new System.Drawing.Size(105, 17);
            this.rowsAffectedStatusStripLabel.Text = "No Changes Made";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Vendor ID:";
            // 
            // vendorIDTextBox
            // 
            this.vendorIDTextBox.Location = new System.Drawing.Point(76, 36);
            this.vendorIDTextBox.Name = "vendorIDTextBox";
            this.vendorIDTextBox.Size = new System.Drawing.Size(102, 20);
            this.vendorIDTextBox.TabIndex = 8;
            // 
            // vendorNameTextBox
            // 
            this.vendorNameTextBox.Location = new System.Drawing.Point(228, 36);
            this.vendorNameTextBox.Name = "vendorNameTextBox";
            this.vendorNameTextBox.Size = new System.Drawing.Size(142, 20);
            this.vendorNameTextBox.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(184, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Name:";
            // 
            // vendorPhone1TextBox
            // 
            this.vendorPhone1TextBox.Location = new System.Drawing.Point(426, 36);
            this.vendorPhone1TextBox.Name = "vendorPhone1TextBox";
            this.vendorPhone1TextBox.Size = new System.Drawing.Size(130, 20);
            this.vendorPhone1TextBox.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(379, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Phone:";
            // 
            // vendorPhone2TextBox
            // 
            this.vendorPhone2TextBox.Location = new System.Drawing.Point(426, 62);
            this.vendorPhone2TextBox.Name = "vendorPhone2TextBox";
            this.vendorPhone2TextBox.Size = new System.Drawing.Size(130, 20);
            this.vendorPhone2TextBox.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(370, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Phone 2:";
            // 
            // clearButton
            // 
            this.clearButton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearButton.Location = new System.Drawing.Point(242, 306);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(147, 48);
            this.clearButton.TabIndex = 15;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = false;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // VendorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(629, 398);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.vendorPhone2TextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.vendorPhone1TextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.vendorNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.vendorIDTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.exitVendorButton);
            this.Controls.Add(this.deleteVendorButton);
            this.Controls.Add(this.updateVendorButton);
            this.Controls.Add(this.vendorDataGridView);
            this.Controls.Add(this.addVendorButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VendorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VendorForm";
            this.Load += new System.EventHandler(this.VendorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vendorDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addVendorButton;
        private System.Windows.Forms.DataGridView vendorDataGridView;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vendorReportToolStripMenuItem;
        private System.Windows.Forms.Button updateVendorButton;
        private System.Windows.Forms.Button deleteVendorButton;
        private System.Windows.Forms.Button exitVendorButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel rowsAffectedStatusStripLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox vendorIDTextBox;
        private System.Windows.Forms.TextBox vendorNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox vendorPhone1TextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox vendorPhone2TextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clearButton;
    }
}