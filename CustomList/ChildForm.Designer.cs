namespace CustomList
{
    partial class ChildForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChildForm));
            this.dataPanel = new System.Windows.Forms.Panel();
            this.dataPanelChild = new System.Windows.Forms.Panel();
            this.btnIncrementWatch = new System.Windows.Forms.PictureBox();
            this.MoreEntryInformation = new System.Windows.Forms.Panel();
            this.EntryName = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblWatchCount = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.picStar = new System.Windows.Forms.PictureBox();
            this.lblRating = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataPanelDuplicate = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAddEntry = new System.Windows.Forms.PictureBox();
            this.lblEntryName = new System.Windows.Forms.Label();
            this.btnDots = new System.Windows.Forms.PictureBox();
            this.dataPanel.SuspendLayout();
            this.dataPanelChild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnIncrementWatch)).BeginInit();
            this.MoreEntryInformation.SuspendLayout();
            this.EntryName.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picStar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.dataPanelDuplicate.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDots)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.dataPanelChild);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataPanel.Location = new System.Drawing.Point(10, 10);
            this.dataPanel.Margin = new System.Windows.Forms.Padding(50);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Padding = new System.Windows.Forms.Padding(4);
            this.dataPanel.Size = new System.Drawing.Size(183, 430);
            this.dataPanel.TabIndex = 0;
            // 
            // dataPanelChild
            // 
            this.dataPanelChild.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataPanelChild.Controls.Add(this.btnIncrementWatch);
            this.dataPanelChild.Controls.Add(this.MoreEntryInformation);
            this.dataPanelChild.Controls.Add(this.EntryName);
            this.dataPanelChild.Controls.Add(this.panel2);
            this.dataPanelChild.Controls.Add(this.pictureBox1);
            this.dataPanelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanelChild.Location = new System.Drawing.Point(4, 4);
            this.dataPanelChild.Name = "dataPanelChild";
            this.dataPanelChild.Size = new System.Drawing.Size(175, 422);
            this.dataPanelChild.TabIndex = 0;
            // 
            // btnIncrementWatch
            // 
            this.btnIncrementWatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIncrementWatch.Image = ((System.Drawing.Image)(resources.GetObject("btnIncrementWatch.Image")));
            this.btnIncrementWatch.Location = new System.Drawing.Point(0, 385);
            this.btnIncrementWatch.Name = "btnIncrementWatch";
            this.btnIncrementWatch.Size = new System.Drawing.Size(173, 35);
            this.btnIncrementWatch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnIncrementWatch.TabIndex = 0;
            this.btnIncrementWatch.TabStop = false;
            // 
            // MoreEntryInformation
            // 
            this.MoreEntryInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MoreEntryInformation.Controls.Add(this.btnDots);
            this.MoreEntryInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.MoreEntryInformation.Location = new System.Drawing.Point(0, 350);
            this.MoreEntryInformation.Name = "MoreEntryInformation";
            this.MoreEntryInformation.Size = new System.Drawing.Size(173, 35);
            this.MoreEntryInformation.TabIndex = 7;
            // 
            // EntryName
            // 
            this.EntryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EntryName.Controls.Add(this.lblEntryName);
            this.EntryName.Dock = System.Windows.Forms.DockStyle.Top;
            this.EntryName.Location = new System.Drawing.Point(0, 314);
            this.EntryName.Name = "EntryName";
            this.EntryName.Size = new System.Drawing.Size(173, 36);
            this.EntryName.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 278);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 36);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblWatchCount);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(90, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(92, 36);
            this.panel3.TabIndex = 1;
            // 
            // lblWatchCount
            // 
            this.lblWatchCount.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWatchCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblWatchCount.Location = new System.Drawing.Point(0, 0);
            this.lblWatchCount.Name = "lblWatchCount";
            this.lblWatchCount.Size = new System.Drawing.Size(83, 36);
            this.lblWatchCount.TabIndex = 0;
            this.lblWatchCount.Text = "1";
            this.lblWatchCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.picStar);
            this.panel4.Controls.Add(this.lblRating);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(90, 36);
            this.panel4.TabIndex = 0;
            // 
            // picStar
            // 
            this.picStar.Dock = System.Windows.Forms.DockStyle.Left;
            this.picStar.Image = ((System.Drawing.Image)(resources.GetObject("picStar.Image")));
            this.picStar.Location = new System.Drawing.Point(0, 0);
            this.picStar.Name = "picStar";
            this.picStar.Size = new System.Drawing.Size(35, 36);
            this.picStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picStar.TabIndex = 1;
            this.picStar.TabStop = false;
            // 
            // lblRating
            // 
            this.lblRating.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblRating.Location = new System.Drawing.Point(35, 7);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(49, 29);
            this.lblRating.TabIndex = 0;
            this.lblRating.Text = "6.7";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 278);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // dataPanelDuplicate
            // 
            this.dataPanelDuplicate.Controls.Add(this.panel5);
            this.dataPanelDuplicate.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataPanelDuplicate.Location = new System.Drawing.Point(193, 10);
            this.dataPanelDuplicate.Margin = new System.Windows.Forms.Padding(50);
            this.dataPanelDuplicate.Name = "dataPanelDuplicate";
            this.dataPanelDuplicate.Padding = new System.Windows.Forms.Padding(4);
            this.dataPanelDuplicate.Size = new System.Drawing.Size(183, 430);
            this.dataPanelDuplicate.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnAddEntry);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(175, 422);
            this.panel5.TabIndex = 0;
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddEntry.Image = ((System.Drawing.Image)(resources.GetObject("btnAddEntry.Image")));
            this.btnAddEntry.Location = new System.Drawing.Point(0, 0);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(173, 420);
            this.btnAddEntry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddEntry.TabIndex = 0;
            this.btnAddEntry.TabStop = false;
            // 
            // lblEntryName
            // 
            this.lblEntryName.AutoSize = true;
            this.lblEntryName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lblEntryName.Location = new System.Drawing.Point(55, 2);
            this.lblEntryName.Name = "lblEntryName";
            this.lblEntryName.Size = new System.Drawing.Size(69, 23);
            this.lblEntryName.TabIndex = 0;
            this.lblEntryName.Text = "Borat 2";
            this.lblEntryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDots
            // 
            this.btnDots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDots.Image = ((System.Drawing.Image)(resources.GetObject("btnDots.Image")));
            this.btnDots.Location = new System.Drawing.Point(0, 0);
            this.btnDots.Name = "btnDots";
            this.btnDots.Size = new System.Drawing.Size(171, 33);
            this.btnDots.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnDots.TabIndex = 0;
            this.btnDots.TabStop = false;
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataPanelDuplicate);
            this.Controls.Add(this.dataPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChildForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "ChildForm";
            this.Activated += new System.EventHandler(this.ChildForm_Activated);
            this.Load += new System.EventHandler(this.ChildForm_Load);
            this.Shown += new System.EventHandler(this.ChildForm_Shown);
            this.dataPanel.ResumeLayout(false);
            this.dataPanelChild.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnIncrementWatch)).EndInit();
            this.MoreEntryInformation.ResumeLayout(false);
            this.EntryName.ResumeLayout(false);
            this.EntryName.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picStar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.dataPanelDuplicate.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDots)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel dataPanel;
        private System.Windows.Forms.Panel dataPanelChild;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblWatchCount;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox picStar;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel dataPanelDuplicate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel MoreEntryInformation;
        private System.Windows.Forms.Panel EntryName;
        private System.Windows.Forms.PictureBox btnAddEntry;
        private System.Windows.Forms.PictureBox btnIncrementWatch;
        private System.Windows.Forms.PictureBox btnDots;
        private System.Windows.Forms.Label lblEntryName;
    }
}