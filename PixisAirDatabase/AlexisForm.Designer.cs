namespace PixisAirDatabase
{
    partial class AlexisForm
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
            this.staffListBox = new System.Windows.Forms.ListBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.employeeFormButton = new System.Windows.Forms.Button();
            this.regionalFormButton = new System.Windows.Forms.Button();
            this.stateFormButton = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeesFormMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regionalFormMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stateFormMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightTextBox = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // staffListBox
            // 
            this.staffListBox.FormattingEnabled = true;
            this.staffListBox.Location = new System.Drawing.Point(196, 27);
            this.staffListBox.Name = "staffListBox";
            this.staffListBox.Size = new System.Drawing.Size(530, 394);
            this.staffListBox.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(48, 386);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(116, 34);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(48, 115);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(116, 34);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // employeeFormButton
            // 
            this.employeeFormButton.Location = new System.Drawing.Point(49, 212);
            this.employeeFormButton.Name = "employeeFormButton";
            this.employeeFormButton.Size = new System.Drawing.Size(116, 34);
            this.employeeFormButton.TabIndex = 3;
            this.employeeFormButton.Text = "Employees/Jobs Form";
            this.employeeFormButton.UseVisualStyleBackColor = true;
            this.employeeFormButton.Click += new System.EventHandler(this.employeeFormButton_Click);
            // 
            // regionalFormButton
            // 
            this.regionalFormButton.Location = new System.Drawing.Point(48, 252);
            this.regionalFormButton.Name = "regionalFormButton";
            this.regionalFormButton.Size = new System.Drawing.Size(116, 34);
            this.regionalFormButton.TabIndex = 4;
            this.regionalFormButton.Text = "Regional Employees Form";
            this.regionalFormButton.UseVisualStyleBackColor = true;
            this.regionalFormButton.Click += new System.EventHandler(this.regionalFormButton_Click);
            // 
            // stateFormButton
            // 
            this.stateFormButton.Location = new System.Drawing.Point(48, 292);
            this.stateFormButton.Name = "stateFormButton";
            this.stateFormButton.Size = new System.Drawing.Size(116, 34);
            this.stateFormButton.TabIndex = 5;
            this.stateFormButton.Text = "Employee\'s State Form";
            this.stateFormButton.UseVisualStyleBackColor = true;
            this.stateFormButton.Click += new System.EventHandler(this.stateFormButton_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.formsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchMenuItem,
            this.exitMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // searchMenuItem
            // 
            this.searchMenuItem.Name = "searchMenuItem";
            this.searchMenuItem.Size = new System.Drawing.Size(109, 22);
            this.searchMenuItem.Text = "Search";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(109, 22);
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // formsToolStripMenuItem
            // 
            this.formsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeesFormMenuItem,
            this.regionalFormMenuItem,
            this.stateFormMenuItem});
            this.formsToolStripMenuItem.Name = "formsToolStripMenuItem";
            this.formsToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.formsToolStripMenuItem.Text = "Forms";
            // 
            // employeesFormMenuItem
            // 
            this.employeesFormMenuItem.Name = "employeesFormMenuItem";
            this.employeesFormMenuItem.Size = new System.Drawing.Size(211, 22);
            this.employeesFormMenuItem.Text = "Employees/Jobs Form";
            this.employeesFormMenuItem.Click += new System.EventHandler(this.employeesFormMenuItem_Click);
            // 
            // regionalFormMenuItem
            // 
            this.regionalFormMenuItem.Name = "regionalFormMenuItem";
            this.regionalFormMenuItem.Size = new System.Drawing.Size(211, 22);
            this.regionalFormMenuItem.Text = "Regional Employees Form";
            this.regionalFormMenuItem.Click += new System.EventHandler(this.regionalFormMenuItem_Click);
            // 
            // stateFormMenuItem
            // 
            this.stateFormMenuItem.Name = "stateFormMenuItem";
            this.stateFormMenuItem.Size = new System.Drawing.Size(211, 22);
            this.stateFormMenuItem.Text = "Employee\'s State Form";
            this.stateFormMenuItem.Click += new System.EventHandler(this.stateFormMenuItem_Click);
            // 
            // flightTextBox
            // 
            this.flightTextBox.Location = new System.Drawing.Point(48, 71);
            this.flightTextBox.Name = "flightTextBox";
            this.flightTextBox.Size = new System.Drawing.Size(116, 20);
            this.flightTextBox.TabIndex = 7;
            // 
            // AlexisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flightTextBox);
            this.Controls.Add(this.stateFormButton);
            this.Controls.Add(this.regionalFormButton);
            this.Controls.Add(this.employeeFormButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.staffListBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AlexisForm";
            this.Text = "Search Staff by Flight Number";
            this.Load += new System.EventHandler(this.AlexisForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox staffListBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button employeeFormButton;
        private System.Windows.Forms.Button regionalFormButton;
        private System.Windows.Forms.Button stateFormButton;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formsToolStripMenuItem;
        private System.Windows.Forms.TextBox flightTextBox;
        private System.Windows.Forms.ToolStripMenuItem employeesFormMenuItem;
        private System.Windows.Forms.ToolStripMenuItem regionalFormMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stateFormMenuItem;
    }
}