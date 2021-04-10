using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace CustomList
{
    class EntryComponent
    {
        public Panel mainPanel;

        private ComponentResourceManager resources;

        private Panel childPanel;
        private PictureBox btnIncrementWatch; 
        private Panel moreEntryInfoPanel;
        private Panel entryName;
        private Panel scoreAndWatchesPanel;
        private PictureBox entryPoster;
        private PictureBox btnDots;
        private Label lblEntryName;
        private Panel watchCountPanel;
        private Label lblWatchCount;
        private Panel ratingPanel;
        private PictureBox picStar;
        private Label lblRating;

        public EntryComponent(UInt32 index, Entry entry)
        {
            this.resources = new ComponentResourceManager();
            //initialize components
            mainPanel = new Panel();
            childPanel = new Panel();
            btnIncrementWatch = new PictureBox();
            moreEntryInfoPanel = new Panel();
            entryName = new Panel();
            scoreAndWatchesPanel = new Panel();
            entryPoster = new PictureBox();
            btnDots = new PictureBox();
            lblEntryName = new Label();
            watchCountPanel = new Panel();
            lblWatchCount = new Label();
            ratingPanel = new Panel();
            picStar = new PictureBox();
            lblRating = new Label();

            //set up main panel
            mainPanel.Location = new System.Drawing.Point(10, 10);
            //mainPanel.Margin = new System.Windows.Forms.Padding(50);
            mainPanel.Name = "dataPanel" + index;
            mainPanel.Padding = new System.Windows.Forms.Padding(4);
            mainPanel.Size = new System.Drawing.Size(143, 439);
            mainPanel.Dock = DockStyle.Left;
            mainPanel.Controls.Add(childPanel);

            //set up child panel. It contains further components of an entry
            childPanel.BorderStyle = BorderStyle.FixedSingle;
            childPanel.Dock = DockStyle.Fill;
            childPanel.Location = new System.Drawing.Point(4, 4);
            childPanel.Name = "dataPanelChild" + index;
            childPanel.Size = new System.Drawing.Size(175, 422);
            childPanel.Controls.Add(btnIncrementWatch);
            childPanel.Controls.Add(moreEntryInfoPanel);
            childPanel.Controls.Add(entryName);
            childPanel.Controls.Add(scoreAndWatchesPanel);
            childPanel.Controls.Add(entryPoster);

            //button to increment watch count
            btnIncrementWatch.Dock = DockStyle.Fill;
            btnIncrementWatch.Image = Properties.Resources.IncrementBtn2;
            btnIncrementWatch.Location = new System.Drawing.Point(0, 385);
            btnIncrementWatch.Name = "btnIncrementWatch" + index;
            btnIncrementWatch.Size = new System.Drawing.Size(173, 35);
            btnIncrementWatch.SizeMode = PictureBoxSizeMode.StretchImage;
            btnIncrementWatch.TabStop = false;

            moreEntryInfoPanel.BorderStyle = BorderStyle.FixedSingle;
            moreEntryInfoPanel.Controls.Add(btnDots);
            moreEntryInfoPanel.Dock = DockStyle.Top;
            moreEntryInfoPanel.Location = new Point(0, 350);
            moreEntryInfoPanel.Name = "MoreEntryInformation" + index;
            moreEntryInfoPanel.Size = new System.Drawing.Size(173, 35);

            entryName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            entryName.Controls.Add(lblEntryName);
            entryName.Dock = System.Windows.Forms.DockStyle.Top;
            entryName.Location = new System.Drawing.Point(0, 314);
            entryName.Name = "EntryName" + index;
            entryName.Size = new System.Drawing.Size(173, 36);

            scoreAndWatchesPanel.Controls.Add(watchCountPanel);
            scoreAndWatchesPanel.Controls.Add(ratingPanel);
            scoreAndWatchesPanel.Dock = System.Windows.Forms.DockStyle.Top;
            scoreAndWatchesPanel.Location = new System.Drawing.Point(0, 278);
            scoreAndWatchesPanel.Name = "scoreAndWatchesPanel" + index;
            scoreAndWatchesPanel.Size = new System.Drawing.Size(173, 36);

            entryPoster.Dock = System.Windows.Forms.DockStyle.Top;
            entryPoster.Image = Properties.Resources.Borat;
            entryPoster.Location = new System.Drawing.Point(0, 0);
            entryPoster.Name = "pictureBox1";
            entryPoster.Size = new System.Drawing.Size(173, 225);
            entryPoster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            entryPoster.TabIndex = 4;
            entryPoster.TabStop = false;

            //button dots
            btnDots.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDots.Image = Properties.Resources.dots2;
            btnDots.Location = new System.Drawing.Point(0, 0);
            btnDots.Name = "btnDots" + index;
            btnDots.Size = new System.Drawing.Size(171, 33);
            btnDots.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            btnDots.TabIndex = 0;
            btnDots.TabStop = false;

            //entry name
            lblEntryName.AutoSize = true;
            lblEntryName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblEntryName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            lblEntryName.Location = new System.Drawing.Point(55, 2);
            lblEntryName.Name = "lblEntryName" + index;
            lblEntryName.Size = new System.Drawing.Size(69, 23);
            lblEntryName.Text = entry.name;
            lblEntryName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            watchCountPanel.Controls.Add(lblWatchCount);
            watchCountPanel.Dock = System.Windows.Forms.DockStyle.Left;
            watchCountPanel.Location = new System.Drawing.Point(90, 0);
            watchCountPanel.Name = "watchCountPanel" + index;
            watchCountPanel.Size = new System.Drawing.Size(92, 36);

            lblWatchCount.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblWatchCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            lblWatchCount.Location = new System.Drawing.Point(3, 0);
            lblWatchCount.Name = "lblWatchCount" + index;
            lblWatchCount.Size = new System.Drawing.Size(40, 36);
            lblWatchCount.Text = "12";
            lblWatchCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

            ratingPanel.Controls.Add(this.picStar);
            ratingPanel.Controls.Add(this.lblRating);
            ratingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            ratingPanel.Location = new System.Drawing.Point(0, 0);
            ratingPanel.Name = "ratingPanel" + index;
            ratingPanel.Size = new System.Drawing.Size(90, 36);;

            picStar.Dock = System.Windows.Forms.DockStyle.Left;
            picStar.Image = Properties.Resources.star;
            picStar.Location = new System.Drawing.Point(0, 0);
            picStar.Name = "picStar" + index;
            picStar.Size = new System.Drawing.Size(35, 36);
            picStar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            // 
            // lblRating
            // 
            lblRating.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lblRating.ForeColor = System.Drawing.Color.FromArgb(0, 126, 249);
            lblRating.Location = new System.Drawing.Point(35, 9);
            lblRating.Name = "lblRating" + index;
            lblRating.Size = new System.Drawing.Size(35, 36);
            lblRating.Text = entry.score.ToString();
        }

        public void DestroyComponent()
        {
            mainPanel.Dispose();
            childPanel.Dispose();
            btnIncrementWatch.Dispose();
            moreEntryInfoPanel.Dispose();
            entryName.Dispose();
            scoreAndWatchesPanel.Dispose();
            entryPoster.Image.Dispose();
            entryPoster.Dispose();
            btnDots.Image.Dispose();
            btnDots.Dispose();
            lblEntryName.Dispose();
            watchCountPanel.Dispose();
            lblWatchCount.Dispose();
            ratingPanel.Dispose();
            picStar.Image.Dispose();
            picStar.Dispose();
            lblRating.Dispose();
        }
    }
}
