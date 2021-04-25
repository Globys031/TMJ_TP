namespace CustomList
{
    partial class Form2
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSelectPoster = new System.Windows.Forms.Button();
            this.txtEntryName = new System.Windows.Forms.TextBox();
            this.dateRelease = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExitAddDialogue = new System.Windows.Forms.Button();
            this.txtEntryDescription = new System.Windows.Forms.RichTextBox();
            this.ControlsPanel = new System.Windows.Forms.Panel();
            this.drpdRating = new System.Windows.Forms.ComboBox();
            this.TextPanel = new System.Windows.Forms.Panel();
            this.lblAnyText = new System.Windows.Forms.Label();
            this.ControlsPanel.SuspendLayout();
            this.TextPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelectPoster
            // 
            this.btnSelectPoster.Location = new System.Drawing.Point(13, 307);
            this.btnSelectPoster.Name = "btnSelectPoster";
            this.btnSelectPoster.Size = new System.Drawing.Size(107, 33);
            this.btnSelectPoster.TabIndex = 1;
            this.btnSelectPoster.Text = "Select Poster";
            this.btnSelectPoster.UseVisualStyleBackColor = true;
            this.btnSelectPoster.Click += new System.EventHandler(this.btnSelectPoster_Click);
            // 
            // txtEntryName
            // 
            this.txtEntryName.Location = new System.Drawing.Point(3, 29);
            this.txtEntryName.Name = "txtEntryName";
            this.txtEntryName.Size = new System.Drawing.Size(574, 22);
            this.txtEntryName.TabIndex = 2;
            // 
            // dateRelease
            // 
            this.dateRelease.Location = new System.Drawing.Point(167, 69);
            this.dateRelease.Name = "dateRelease";
            this.dateRelease.Size = new System.Drawing.Size(271, 22);
            this.dateRelease.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(337, 307);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 33);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save and Add";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExitAddDialogue
            // 
            this.btnExitAddDialogue.Location = new System.Drawing.Point(471, 307);
            this.btnExitAddDialogue.Name = "btnExitAddDialogue";
            this.btnExitAddDialogue.Size = new System.Drawing.Size(104, 33);
            this.btnExitAddDialogue.TabIndex = 7;
            this.btnExitAddDialogue.Text = "Exit";
            this.btnExitAddDialogue.UseVisualStyleBackColor = true;
            this.btnExitAddDialogue.Click += new System.EventHandler(this.btnExitAddDialogue_Click);
            // 
            // txtEntryDescription
            // 
            this.txtEntryDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEntryDescription.DetectUrls = false;
            this.txtEntryDescription.Location = new System.Drawing.Point(47, 129);
            this.txtEntryDescription.Name = "txtEntryDescription";
            this.txtEntryDescription.Size = new System.Drawing.Size(458, 96);
            this.txtEntryDescription.TabIndex = 8;
            this.txtEntryDescription.Text = "Description of your entry here..";
            // 
            // ControlsPanel
            // 
            this.ControlsPanel.Controls.Add(this.drpdRating);
            this.ControlsPanel.Controls.Add(this.txtEntryName);
            this.ControlsPanel.Controls.Add(this.dateRelease);
            this.ControlsPanel.Controls.Add(this.txtEntryDescription);
            this.ControlsPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ControlsPanel.Location = new System.Drawing.Point(10, 10);
            this.ControlsPanel.Name = "ControlsPanel";
            this.ControlsPanel.Size = new System.Drawing.Size(580, 231);
            this.ControlsPanel.TabIndex = 9;
            // 
            // drpdRating
            // 
            this.drpdRating.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.drpdRating.FormattingEnabled = true;
            this.drpdRating.Items.AddRange(new object[] {
            "10",
            "9",
            "8",
            "7",
            "6",
            "5",
            "4",
            "3",
            "2",
            "1"});
            this.drpdRating.Location = new System.Drawing.Point(4, 65);
            this.drpdRating.MaxDropDownItems = 10;
            this.drpdRating.Name = "drpdRating";
            this.drpdRating.Size = new System.Drawing.Size(121, 24);
            this.drpdRating.TabIndex = 9;
            // 
            // TextPanel
            // 
            this.TextPanel.Controls.Add(this.lblAnyText);
            this.TextPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextPanel.Location = new System.Drawing.Point(10, 241);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(580, 60);
            this.TextPanel.TabIndex = 10;
            // 
            // lblAnyText
            // 
            this.lblAnyText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnyText.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnyText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblAnyText.Location = new System.Drawing.Point(0, 0);
            this.lblAnyText.Name = "lblAnyText";
            this.lblAnyText.Size = new System.Drawing.Size(580, 60);
            this.lblAnyText.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(600, 353);
            this.Controls.Add(this.TextPanel);
            this.Controls.Add(this.ControlsPanel);
            this.Controls.Add(this.btnExitAddDialogue);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSelectPoster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "AddEntryDialogueForm";
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.ControlsPanel.ResumeLayout(false);
            this.ControlsPanel.PerformLayout();
            this.TextPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelectPoster;
        private System.Windows.Forms.TextBox txtEntryName;
        private System.Windows.Forms.DateTimePicker dateRelease;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExitAddDialogue;
        private System.Windows.Forms.RichTextBox txtEntryDescription;
        private System.Windows.Forms.Panel ControlsPanel;
        private System.Windows.Forms.ComboBox drpdRating;
        private System.Windows.Forms.Panel TextPanel;
        private System.Windows.Forms.Label lblAnyText;
    }
}