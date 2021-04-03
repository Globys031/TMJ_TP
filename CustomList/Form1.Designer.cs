namespace CustomList
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_Nav = new System.Windows.Forms.FlowLayoutPanel();
            this.b_custom = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.b_TvSeries = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.b_Dashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pfpic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InsNameLabel = new System.Windows.Forms.Label();
            this.InsNameBox = new System.Windows.Forms.TextBox();
            this.InsScoreLabel = new System.Windows.Forms.Label();
            this.InsDesLabel = new System.Windows.Forms.Label();
            this.InsScoreBox = new System.Windows.Forms.TextBox();
            this.InsDesBox = new System.Windows.Forms.TextBox();
            this.AddEntry = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.InsCatBox = new System.Windows.Forms.TextBox();
            this.AddCategory = new System.Windows.Forms.Button();
            this.listCat = new System.Windows.Forms.ListBox();
            this.listEntries = new System.Windows.Forms.ListBox();
            this.listCatEnt = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pfpic)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pn_Nav);
            this.panel1.Controls.Add(this.b_custom);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.b_TvSeries);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.b_Dashboard);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 97);
            this.panel1.TabIndex = 0;
            // 
            // pn_Nav
            // 
            this.pn_Nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.pn_Nav.Location = new System.Drawing.Point(103, 3);
            this.pn_Nav.Name = "pn_Nav";
            this.pn_Nav.Size = new System.Drawing.Size(178, 3);
            this.pn_Nav.TabIndex = 1;
            this.pn_Nav.Visible = false;
            // 
            // b_custom
            // 
            this.b_custom.Dock = System.Windows.Forms.DockStyle.Left;
            this.b_custom.FlatAppearance.BorderSize = 0;
            this.b_custom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_custom.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_custom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.b_custom.Location = new System.Drawing.Point(809, 0);
            this.b_custom.Name = "b_custom";
            this.b_custom.Size = new System.Drawing.Size(178, 97);
            this.b_custom.TabIndex = 1;
            this.b_custom.Text = "will scroll later";
            this.b_custom.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_custom.UseVisualStyleBackColor = true;
            this.b_custom.Click += new System.EventHandler(this.b_custom_Click);
            this.b_custom.Leave += new System.EventHandler(this.b_custom_Leave);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button3.Image = global::CustomList.Properties.Resources.anime;
            this.button3.Location = new System.Drawing.Point(631, 0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 97);
            this.button3.TabIndex = 1;
            this.button3.Text = "Anime";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            this.button3.Leave += new System.EventHandler(this.button3_Leave);
            // 
            // b_TvSeries
            // 
            this.b_TvSeries.Dock = System.Windows.Forms.DockStyle.Left;
            this.b_TvSeries.FlatAppearance.BorderSize = 0;
            this.b_TvSeries.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_TvSeries.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_TvSeries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.b_TvSeries.Image = global::CustomList.Properties.Resources.tv;
            this.b_TvSeries.Location = new System.Drawing.Point(453, 0);
            this.b_TvSeries.Name = "b_TvSeries";
            this.b_TvSeries.Size = new System.Drawing.Size(178, 97);
            this.b_TvSeries.TabIndex = 1;
            this.b_TvSeries.Text = "TV Series";
            this.b_TvSeries.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_TvSeries.UseVisualStyleBackColor = true;
            this.b_TvSeries.Click += new System.EventHandler(this.b_TvSeries_Click);
            this.b_TvSeries.Leave += new System.EventHandler(this.b_TvSeries_Leave);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button1.Image = global::CustomList.Properties.Resources.clapperboard;
            this.button1.Location = new System.Drawing.Point(275, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 97);
            this.button1.TabIndex = 1;
            this.button1.Text = "Movies";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Leave += new System.EventHandler(this.button1_Leave);
            // 
            // b_Dashboard
            // 
            this.b_Dashboard.Dock = System.Windows.Forms.DockStyle.Left;
            this.b_Dashboard.FlatAppearance.BorderSize = 0;
            this.b_Dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_Dashboard.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_Dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.b_Dashboard.Image = global::CustomList.Properties.Resources.home;
            this.b_Dashboard.Location = new System.Drawing.Point(97, 0);
            this.b_Dashboard.Name = "b_Dashboard";
            this.b_Dashboard.Size = new System.Drawing.Size(178, 97);
            this.b_Dashboard.TabIndex = 1;
            this.b_Dashboard.Text = "Dashboard";
            this.b_Dashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_Dashboard.UseVisualStyleBackColor = true;
            this.b_Dashboard.Click += new System.EventHandler(this.b_Dashboard_Click);
            this.b_Dashboard.Leave += new System.EventHandler(this.b_Dashboard_Leave);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pfpic);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 97);
            this.panel2.TabIndex = 0;
            // 
            // pfpic
            // 
            this.pfpic.Image = global::CustomList.Properties.Resources.Untitled_11;
            this.pfpic.Location = new System.Drawing.Point(0, 0);
            this.pfpic.Name = "pfpic";
            this.pfpic.Size = new System.Drawing.Size(97, 97);
            this.pfpic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pfpic.TabIndex = 0;
            this.pfpic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(103, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Insert Data:";
            // 
            // InsNameLabel
            // 
            this.InsNameLabel.AutoSize = true;
            this.InsNameLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.InsNameLabel.Location = new System.Drawing.Point(103, 166);
            this.InsNameLabel.Name = "InsNameLabel";
            this.InsNameLabel.Size = new System.Drawing.Size(45, 17);
            this.InsNameLabel.TabIndex = 2;
            this.InsNameLabel.Text = "Name";
            // 
            // InsNameBox
            // 
            this.InsNameBox.Location = new System.Drawing.Point(192, 166);
            this.InsNameBox.Name = "InsNameBox";
            this.InsNameBox.Size = new System.Drawing.Size(100, 22);
            this.InsNameBox.TabIndex = 3;
            // 
            // InsScoreLabel
            // 
            this.InsScoreLabel.AutoSize = true;
            this.InsScoreLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.InsScoreLabel.Location = new System.Drawing.Point(103, 206);
            this.InsScoreLabel.Name = "InsScoreLabel";
            this.InsScoreLabel.Size = new System.Drawing.Size(45, 17);
            this.InsScoreLabel.TabIndex = 4;
            this.InsScoreLabel.Text = "Score";
            // 
            // InsDesLabel
            // 
            this.InsDesLabel.AutoSize = true;
            this.InsDesLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.InsDesLabel.Location = new System.Drawing.Point(103, 244);
            this.InsDesLabel.Name = "InsDesLabel";
            this.InsDesLabel.Size = new System.Drawing.Size(79, 17);
            this.InsDesLabel.TabIndex = 5;
            this.InsDesLabel.Text = "Description";
            // 
            // InsScoreBox
            // 
            this.InsScoreBox.Location = new System.Drawing.Point(192, 206);
            this.InsScoreBox.Name = "InsScoreBox";
            this.InsScoreBox.Size = new System.Drawing.Size(100, 22);
            this.InsScoreBox.TabIndex = 6;
            // 
            // InsDesBox
            // 
            this.InsDesBox.Location = new System.Drawing.Point(192, 244);
            this.InsDesBox.Name = "InsDesBox";
            this.InsDesBox.Size = new System.Drawing.Size(100, 22);
            this.InsDesBox.TabIndex = 7;
            // 
            // AddEntry
            // 
            this.AddEntry.Location = new System.Drawing.Point(146, 281);
            this.AddEntry.Name = "AddEntry";
            this.AddEntry.Size = new System.Drawing.Size(102, 23);
            this.AddEntry.TabIndex = 8;
            this.AddEntry.Text = "Insert data";
            this.AddEntry.UseVisualStyleBackColor = true;
            this.AddEntry.Click += new System.EventHandler(this.Add_Entry_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(103, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Category";
            // 
            // InsCatBox
            // 
            this.InsCatBox.Location = new System.Drawing.Point(192, 130);
            this.InsCatBox.Name = "InsCatBox";
            this.InsCatBox.Size = new System.Drawing.Size(100, 22);
            this.InsCatBox.TabIndex = 10;
            // 
            // AddCategory
            // 
            this.AddCategory.Location = new System.Drawing.Point(325, 128);
            this.AddCategory.Name = "AddCategory";
            this.AddCategory.Size = new System.Drawing.Size(135, 23);
            this.AddCategory.TabIndex = 11;
            this.AddCategory.Text = "Add category";
            this.AddCategory.UseVisualStyleBackColor = true;
            this.AddCategory.Click += new System.EventHandler(this.AddCategory_Click);
            // 
            // listCat
            // 
            this.listCat.FormattingEnabled = true;
            this.listCat.ItemHeight = 16;
            this.listCat.Location = new System.Drawing.Point(486, 166);
            this.listCat.Name = "listCat";
            this.listCat.Size = new System.Drawing.Size(145, 164);
            this.listCat.TabIndex = 12;
            // 
            // listEntries
            // 
            this.listEntries.FormattingEnabled = true;
            this.listEntries.ItemHeight = 16;
            this.listEntries.Location = new System.Drawing.Point(699, 166);
            this.listEntries.Name = "listEntries";
            this.listEntries.Size = new System.Drawing.Size(145, 164);
            this.listEntries.TabIndex = 13;
           // this.listEntries.SelectedIndexChanged += new System.EventHandler(this.listEntries_SelectedIndexChanged);
            // 
            // listCatEnt
            // 
            this.listCatEnt.FormattingEnabled = true;
            this.listCatEnt.ItemHeight = 16;
            this.listCatEnt.Location = new System.Drawing.Point(598, 370);
            this.listCatEnt.Name = "listCatEnt";
            this.listCatEnt.Size = new System.Drawing.Size(145, 164);
            this.listCatEnt.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.listCatEnt);
            this.Controls.Add(this.listEntries);
            this.Controls.Add(this.listCat);
            this.Controls.Add(this.AddCategory);
            this.Controls.Add(this.InsCatBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddEntry);
            this.Controls.Add(this.InsDesBox);
            this.Controls.Add(this.InsScoreBox);
            this.Controls.Add(this.InsDesLabel);
            this.Controls.Add(this.InsScoreLabel);
            this.Controls.Add(this.InsNameBox);
            this.Controls.Add(this.InsNameLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pfpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_Dashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pfpic;
        private System.Windows.Forms.Button b_custom;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button b_TvSeries;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel pn_Nav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InsNameLabel;
        private System.Windows.Forms.TextBox InsNameBox;
        private System.Windows.Forms.Label InsScoreLabel;
        private System.Windows.Forms.Label InsDesLabel;
        private System.Windows.Forms.TextBox InsScoreBox;
        private System.Windows.Forms.TextBox InsDesBox;
        private System.Windows.Forms.Button AddEntry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox InsCatBox;
        private System.Windows.Forms.Button AddCategory;
        private System.Windows.Forms.ListBox listCat;
        private System.Windows.Forms.ListBox listEntries;
        private System.Windows.Forms.ListBox listCatEnt;
    }
}

