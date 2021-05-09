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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pn_Nav = new System.Windows.Forms.FlowLayoutPanel();
            this.b_addCat = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.b_TvSeries = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.PnlFormLoader = new System.Windows.Forms.Panel();
            this.windowHandle = new System.Windows.Forms.Panel();
            this.btnMinimizeForm = new System.Windows.Forms.Button();
            this.btnCloseForm = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.windowHandle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.pn_Nav);
            this.panel1.Controls.Add(this.b_addCat);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.b_TvSeries);
            this.panel1.Controls.Add(this.button1);
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
            // b_addCat
            // 
            this.b_addCat.Dock = System.Windows.Forms.DockStyle.Left;
            this.b_addCat.FlatAppearance.BorderSize = 0;
            this.b_addCat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.b_addCat.Font = new System.Drawing.Font("Nirmala UI", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_addCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.b_addCat.Location = new System.Drawing.Point(534, 0);
            this.b_addCat.Name = "b_addCat";
            this.b_addCat.Size = new System.Drawing.Size(178, 97);
            this.b_addCat.TabIndex = 1;
            this.b_addCat.Text = "+";
            this.b_addCat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.b_addCat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.b_addCat.UseVisualStyleBackColor = true;
            this.b_addCat.Click += new System.EventHandler(this.b_custom_Click);
            this.b_addCat.Leave += new System.EventHandler(this.b_custom_Leave);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.button3.Image = global::CustomList.Properties.Resources.anime;
            this.button3.Location = new System.Drawing.Point(356, 0);
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
            this.b_TvSeries.Location = new System.Drawing.Point(178, 0);
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
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(178, 97);
            this.button1.TabIndex = 1;
            this.button1.Text = "Movies";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.Leave += new System.EventHandler(this.button1_Leave);
            // 
            // PnlFormLoader
            // 
            this.PnlFormLoader.Location = new System.Drawing.Point(0, 135);
            this.PnlFormLoader.Name = "PnlFormLoader";
            this.PnlFormLoader.Size = new System.Drawing.Size(951, 492);
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
            this.windowHandle.MouseMove += new System.Windows.Forms.MouseEventHandler(this.windowHandle_MouseMove);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 630);
            this.Controls.Add(this.PnlFormLoader);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.windowHandle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Custom List";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.panel1.ResumeLayout(false);
            this.windowHandle.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button b_addCat;
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

