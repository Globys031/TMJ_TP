﻿namespace CustomList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_Nav = new System.Windows.Forms.FlowLayoutPanel();
            this.b_custom = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.b_TvSeries = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.b_Dashboard = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pfpic = new System.Windows.Forms.PictureBox();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.windowHandle = new System.Windows.Forms.Panel();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.btnMinimizeForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pfpic)).BeginInit();
            this.windowHandle.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(0, 39);
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
            // PnlFormLoader
            // 
            this.PnlFormLoader.Location = new System.Drawing.Point(0, 142);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(951, 479);
            this.PnlFormLoader.TabIndex = 1;
            // 
            // windowHandle
            // 
            this.windowHandle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.windowHandle.Controls.Add(this.btnMinimizeForm);
            this.windowHandle.Controls.Add(this.btnCloseForm);
            this.windowHandle.Dock = System.Windows.Forms.DockStyle.Top;
            this.windowHandle.Location = new System.Drawing.Point(0, 0);
            this.windowHandle.Name = "windowHandle";
            this.windowHandle.Size = new System.Drawing.Size(951, 39);
            this.windowHandle.TabIndex = 0;
            this.windowHandle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windowHandle_MouseDown);
            this.windowHandle.MouseLeave += new System.EventHandler(this.windowHandle_MouseLeave);
            this.windowHandle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.windowHandle_MouseMove);
            this.windowHandle.MouseUp += new System.Windows.Forms.MouseEventHandler(this.windowHandle_MouseUp);
            // 
            // btnCloseForm
            // 
            this.btnCloseForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCloseForm.FlatAppearance.BorderSize = 0;
            this.btnCloseForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseForm.Image")));
            this.btnCloseForm.Location = new System.Drawing.Point(900, 0);
            this.btnCloseForm.Name = "btnCloseForm";
            this.btnCloseForm.Size = new System.Drawing.Size(51, 39);
            this.btnCloseForm.TabIndex = 0;
            this.btnCloseForm.Text = "\r\n";
            this.btnCloseForm.UseVisualStyleBackColor = true;
            this.btnCloseForm.Click += new System.EventHandler(this.btnCloseForm_Click);
            // 
            // btnMinimizeForm
            // 
            this.btnMinimizeForm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimizeForm.FlatAppearance.BorderSize = 0;
            this.btnMinimizeForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeForm.Font = new System.Drawing.Font("Wide Latin", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizeForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btnMinimizeForm.Location = new System.Drawing.Point(849, 0);
            this.btnMinimizeForm.Name = "btnMinimizeForm";
            this.btnMinimizeForm.Size = new System.Drawing.Size(51, 39);
            this.btnMinimizeForm.TabIndex = 1;
            this.btnMinimizeForm.Text = "_";
            this.btnMinimizeForm.UseVisualStyleBackColor = true;
            this.btnMinimizeForm.Click += new System.EventHandler(this.btnMinimizeForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 615);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.windowHandle);
            this.Controls.Add(this.PnlFormLoader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pfpic)).EndInit();
            this.windowHandle.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Panel PnlFormLoader;
        private System.Windows.Forms.Panel windowHandle;
        private System.Windows.Forms.Button btnCloseForm;
        private System.Windows.Forms.Button btnMinimizeForm;
    }
}

