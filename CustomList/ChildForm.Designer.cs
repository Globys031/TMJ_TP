using System.Windows.Forms;

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
            this.dataPanelDuplicate = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAddEntry = new System.Windows.Forms.PictureBox();
            this.ToolBarPanel = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSortName = new System.Windows.Forms.Button();
            this.btnSortScore = new System.Windows.Forms.Button();
            this.DataPanel = new System.Windows.Forms.Panel();
            this.dataPanelDuplicate.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddEntry)).BeginInit();
            this.ToolBarPanel.SuspendLayout();
            this.DataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataPanelDuplicate
            // 
            this.dataPanelDuplicate.Controls.Add(this.panel5);
            this.dataPanelDuplicate.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataPanelDuplicate.Location = new System.Drawing.Point(0, 0);
            this.dataPanelDuplicate.Margin = new System.Windows.Forms.Padding(50);
            this.dataPanelDuplicate.Name = "dataPanelDuplicate";
            this.dataPanelDuplicate.Padding = new System.Windows.Forms.Padding(4);
            this.dataPanelDuplicate.Size = new System.Drawing.Size(183, 417);
            this.dataPanelDuplicate.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnAddEntry);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(175, 409);
            this.panel5.TabIndex = 0;
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddEntry.Image = global::CustomList.Properties.Resources.AddEntryStyle2;
            this.btnAddEntry.Location = new System.Drawing.Point(0, 0);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(173, 407);
            this.btnAddEntry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddEntry.TabIndex = 0;
            this.btnAddEntry.TabStop = false;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            this.btnAddEntry.MouseEnter += new System.EventHandler(this.btnAddEntry_MouseEnter);
            this.btnAddEntry.MouseLeave += new System.EventHandler(this.btnAddEntry_MouseLeave);
            // 
            // ToolBarPanel
            // 
            this.ToolBarPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ToolBarPanel.Controls.Add(this.btnSearch);
            this.ToolBarPanel.Controls.Add(this.textBox1);
            this.ToolBarPanel.Controls.Add(this.btnSortName);
            this.ToolBarPanel.Controls.Add(this.btnSortScore);
            this.ToolBarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ToolBarPanel.Location = new System.Drawing.Point(0, 0);
            this.ToolBarPanel.Name = "ToolBarPanel";
            this.ToolBarPanel.Size = new System.Drawing.Size(800, 33);
            this.ToolBarPanel.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::CustomList.Properties.Resources.search;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSearch.Location = new System.Drawing.Point(553, 0);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(33, 33);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(592, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(352, 22);
            this.textBox1.TabIndex = 4;
            this.textBox1.KeyUp += new KeyEventHandler(txtEnterUp);
            // 
            // btnSortName
            // 
            this.btnSortName.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSortName.FlatAppearance.BorderSize = 0;
            this.btnSortName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortName.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSortName.Location = new System.Drawing.Point(178, 0);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(178, 33);
            this.btnSortName.TabIndex = 3;
            this.btnSortName.Text = "Sort by name";
            this.btnSortName.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSortName.UseVisualStyleBackColor = true;
            this.btnSortName.Click += new System.EventHandler(this.btnSortName_Click);
            // 
            // btnSortScore
            // 
            this.btnSortScore.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSortScore.FlatAppearance.BorderSize = 0;
            this.btnSortScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortScore.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnSortScore.Location = new System.Drawing.Point(0, 0);
            this.btnSortScore.Name = "btnSortScore";
            this.btnSortScore.Size = new System.Drawing.Size(178, 33);
            this.btnSortScore.TabIndex = 2;
            this.btnSortScore.Text = "Sort by score";
            this.btnSortScore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSortScore.UseVisualStyleBackColor = true;
            this.btnSortScore.Click += new System.EventHandler(this.btnSortScore_Click);
            // 
            // DataPanel
            // 
            this.DataPanel.AutoScroll = true;
            this.DataPanel.Controls.Add(this.dataPanelDuplicate);
            this.DataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataPanel.Location = new System.Drawing.Point(0, 33);
            this.DataPanel.Name = "DataPanel";
            this.DataPanel.Size = new System.Drawing.Size(800, 417);
            this.DataPanel.TabIndex = 4;
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DataPanel);
            this.Controls.Add(this.ToolBarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChildForm";
            this.Text = "ChildForm";
            this.Activated += new System.EventHandler(this.ChildForm_Activated);
            this.Load += new System.EventHandler(this.ChildForm_Load);
            this.Shown += new System.EventHandler(this.ChildForm_Shown);
            this.Leave += new System.EventHandler(this.ChildForm_Leave);
            this.dataPanelDuplicate.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddEntry)).EndInit();
            this.ToolBarPanel.ResumeLayout(false);
            this.ToolBarPanel.PerformLayout();
            this.DataPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        /// <summary>
        /// Creates the big add entry button and adds to panel
        /// </summary>
        public void InitAddButton(Panel panel)
        {
            this.dataPanelDuplicate = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAddEntry = new System.Windows.Forms.PictureBox();
            dataPanelDuplicate.SuspendLayout();
            panel5.SuspendLayout();
            btnAddEntry.SuspendLayout();
            // 
            // dataPanelDuplicate
            // 
            this.dataPanelDuplicate.Controls.Add(this.panel5);
            this.dataPanelDuplicate.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataPanelDuplicate.Location = new System.Drawing.Point(0, 0);
            this.dataPanelDuplicate.Margin = new System.Windows.Forms.Padding(50);
            this.dataPanelDuplicate.Name = "dataPanelDuplicate";
            this.dataPanelDuplicate.Padding = new System.Windows.Forms.Padding(4);
            this.dataPanelDuplicate.Size = new System.Drawing.Size(138, 417);
            this.dataPanelDuplicate.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.btnAddEntry);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(175, 409);
            this.panel5.TabIndex = 0;
            // 
            // btnAddEntry
            // 
            this.btnAddEntry.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAddEntry.Image = global::CustomList.Properties.Resources.AddEntryStyle2;
            this.btnAddEntry.Location = new System.Drawing.Point(0, 0);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(173, 407);
            this.btnAddEntry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddEntry.TabIndex = 0;
            this.btnAddEntry.TabStop = false;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            this.btnAddEntry.MouseEnter += new System.EventHandler(this.btnAddEntry_MouseEnter);
            this.btnAddEntry.MouseLeave += new System.EventHandler(this.btnAddEntry_MouseLeave);

            panel.Controls.Add(dataPanelDuplicate);
            btnAddEntry.ResumeLayout();
            panel5.ResumeLayout();
            dataPanelDuplicate.ResumeLayout();
        }

        #endregion
        private System.Windows.Forms.Panel dataPanelDuplicate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox btnAddEntry;
        private System.Windows.Forms.Panel ToolBarPanel;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSortName;
        private System.Windows.Forms.Button btnSortScore;
        public System.Windows.Forms.Panel DataPanel;
    }
}