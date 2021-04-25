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
            this.txtRating = new System.Windows.Forms.TextBox();
            this.dateRelease = new System.Windows.Forms.DateTimePicker();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExitAddDialogue = new System.Windows.Forms.Button();
            this.txtEntryDescription = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSelectPoster
            // 
            this.btnSelectPoster.Location = new System.Drawing.Point(13, 254);
            this.btnSelectPoster.Name = "btnSelectPoster";
            this.btnSelectPoster.Size = new System.Drawing.Size(107, 33);
            this.btnSelectPoster.TabIndex = 1;
            this.btnSelectPoster.Text = "Select Poster";
            this.btnSelectPoster.UseVisualStyleBackColor = true;
            this.btnSelectPoster.Click += new System.EventHandler(this.btnSelectPoster_Click);
            // 
            // txtEntryName
            // 
            this.txtEntryName.Location = new System.Drawing.Point(13, 28);
            this.txtEntryName.Name = "txtEntryName";
            this.txtEntryName.Size = new System.Drawing.Size(574, 22);
            this.txtEntryName.TabIndex = 2;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(13, 81);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(71, 22);
            this.txtRating.TabIndex = 4;
            // 
            // dateRelease
            // 
            this.dateRelease.Location = new System.Drawing.Point(119, 79);
            this.dateRelease.Name = "dateRelease";
            this.dateRelease.Size = new System.Drawing.Size(216, 22);
            this.dateRelease.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(337, 254);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 33);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save and Add";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnExitAddDialogue
            // 
            this.btnExitAddDialogue.Location = new System.Drawing.Point(471, 254);
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
            this.txtEntryDescription.Location = new System.Drawing.Point(13, 126);
            this.txtEntryDescription.Name = "txtEntryDescription";
            this.txtEntryDescription.Size = new System.Drawing.Size(574, 96);
            this.txtEntryDescription.TabIndex = 8;
            this.txtEntryDescription.Text = "Description of your entry here..";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(600, 300);
            this.Controls.Add(this.txtEntryDescription);
            this.Controls.Add(this.btnExitAddDialogue);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.dateRelease);
            this.Controls.Add(this.txtRating);
            this.Controls.Add(this.txtEntryName);
            this.Controls.Add(this.btnSelectPoster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "AddEntryDialogueForm";
            this.Shown += new System.EventHandler(this.Form2_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnSelectPoster;
        private System.Windows.Forms.TextBox txtEntryName;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.DateTimePicker dateRelease;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnExitAddDialogue;
        private System.Windows.Forms.RichTextBox txtEntryDescription;
    }
}