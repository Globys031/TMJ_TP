namespace CustomList
{
    partial class MoreInfoForm
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
            this.TopPanel = new System.Windows.Forms.Panel();
            this.BottonPanel = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDeleteEntry = new System.Windows.Forms.Button();
            this.TextPanel = new System.Windows.Forms.Panel();
            this.lblAnyText = new System.Windows.Forms.Label();
            this.btnSaveChanges = new System.Windows.Forms.Button();
            this.txtEntryDescription = new System.Windows.Forms.RichTextBox();
            this.dateRelease = new System.Windows.Forms.DateTimePicker();
            this.txtRating = new System.Windows.Forms.TextBox();
            this.txtEntryName = new System.Windows.Forms.TextBox();
            this.TopPanel.SuspendLayout();
            this.BottonPanel.SuspendLayout();
            this.TextPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.Controls.Add(this.txtEntryDescription);
            this.TopPanel.Controls.Add(this.dateRelease);
            this.TopPanel.Controls.Add(this.txtRating);
            this.TopPanel.Controls.Add(this.txtEntryName);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(768, 346);
            this.TopPanel.TabIndex = 0;
            // 
            // BottonPanel
            // 
            this.BottonPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.BottonPanel.Controls.Add(this.btnSaveChanges);
            this.BottonPanel.Controls.Add(this.btnClose);
            this.BottonPanel.Controls.Add(this.btnDeleteEntry);
            this.BottonPanel.Controls.Add(this.TextPanel);
            this.BottonPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottonPanel.Location = new System.Drawing.Point(0, 349);
            this.BottonPanel.Name = "BottonPanel";
            this.BottonPanel.Size = new System.Drawing.Size(768, 79);
            this.BottonPanel.TabIndex = 1;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnClose.Location = new System.Drawing.Point(590, 30);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(178, 49);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDeleteEntry
            // 
            this.btnDeleteEntry.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDeleteEntry.FlatAppearance.BorderSize = 0;
            this.btnDeleteEntry.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteEntry.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteEntry.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnDeleteEntry.Location = new System.Drawing.Point(0, 30);
            this.btnDeleteEntry.Name = "btnDeleteEntry";
            this.btnDeleteEntry.Size = new System.Drawing.Size(178, 49);
            this.btnDeleteEntry.TabIndex = 1;
            this.btnDeleteEntry.Text = "Delete This Entry";
            this.btnDeleteEntry.UseVisualStyleBackColor = true;
            this.btnDeleteEntry.Click += new System.EventHandler(this.btnDeleteEntry_Click);
            // 
            // TextPanel
            // 
            this.TextPanel.Controls.Add(this.lblAnyText);
            this.TextPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextPanel.Location = new System.Drawing.Point(0, 0);
            this.TextPanel.Name = "TextPanel";
            this.TextPanel.Size = new System.Drawing.Size(768, 30);
            this.TextPanel.TabIndex = 0;
            // 
            // lblAnyText
            // 
            this.lblAnyText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblAnyText.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnyText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblAnyText.Location = new System.Drawing.Point(0, 0);
            this.lblAnyText.Name = "lblAnyText";
            this.lblAnyText.Size = new System.Drawing.Size(768, 30);
            this.lblAnyText.TabIndex = 0;
            // 
            // btnSaveChanges
            // 
            this.btnSaveChanges.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSaveChanges.FlatAppearance.BorderSize = 0;
            this.btnSaveChanges.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveChanges.Font = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveChanges.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSaveChanges.Location = new System.Drawing.Point(178, 30);
            this.btnSaveChanges.Name = "btnSaveChanges";
            this.btnSaveChanges.Size = new System.Drawing.Size(178, 49);
            this.btnSaveChanges.TabIndex = 3;
            this.btnSaveChanges.Text = "Save Changes";
            this.btnSaveChanges.UseVisualStyleBackColor = true;
            this.btnSaveChanges.Click += new System.EventHandler(this.btnSaveChanges_Click);
            // 
            // txtEntryDescription
            // 
            this.txtEntryDescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEntryDescription.DetectUrls = false;
            this.txtEntryDescription.Location = new System.Drawing.Point(0, 98);
            this.txtEntryDescription.Name = "txtEntryDescription";
            this.txtEntryDescription.Size = new System.Drawing.Size(768, 96);
            this.txtEntryDescription.TabIndex = 12;
            this.txtEntryDescription.Text = "Description of your entry here..";
            // 
            // dateRelease
            // 
            this.dateRelease.Location = new System.Drawing.Point(548, 37);
            this.dateRelease.Name = "dateRelease";
            this.dateRelease.Size = new System.Drawing.Size(220, 22);
            this.dateRelease.TabIndex = 11;
            // 
            // txtRating
            // 
            this.txtRating.Location = new System.Drawing.Point(448, 37);
            this.txtRating.Name = "txtRating";
            this.txtRating.Size = new System.Drawing.Size(75, 22);
            this.txtRating.TabIndex = 10;
            // 
            // txtEntryName
            // 
            this.txtEntryName.Location = new System.Drawing.Point(0, 37);
            this.txtEntryName.Name = "txtEntryName";
            this.txtEntryName.Size = new System.Drawing.Size(424, 22);
            this.txtEntryName.TabIndex = 9;
            // 
            // MoreInfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(768, 428);
            this.Controls.Add(this.BottonPanel);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MoreInfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MoreInfoForm";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.BottonPanel.ResumeLayout(false);
            this.TextPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Panel BottonPanel;
        private System.Windows.Forms.Button btnDeleteEntry;
        private System.Windows.Forms.Panel TextPanel;
        private System.Windows.Forms.Label lblAnyText;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSaveChanges;
        private System.Windows.Forms.RichTextBox txtEntryDescription;
        private System.Windows.Forms.DateTimePicker dateRelease;
        private System.Windows.Forms.TextBox txtRating;
        private System.Windows.Forms.TextBox txtEntryName;
    }
}