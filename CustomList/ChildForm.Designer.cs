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
            this.dataPanelDuplicate.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnAddEntry)).BeginInit();
            this.SuspendLayout();
            // 
            // dataPanelDuplicate
            // 
            this.dataPanelDuplicate.Controls.Add(this.panel5);
            this.dataPanelDuplicate.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataPanelDuplicate.Location = new System.Drawing.Point(10, 10);
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
            this.btnAddEntry.Image = global::CustomList.Properties.Resources.AddEntryStyle2;
            this.btnAddEntry.Location = new System.Drawing.Point(0, 0);
            this.btnAddEntry.Name = "btnAddEntry";
            this.btnAddEntry.Size = new System.Drawing.Size(173, 420);
            this.btnAddEntry.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnAddEntry.TabIndex = 0;
            this.btnAddEntry.TabStop = false;
            this.btnAddEntry.Click += new System.EventHandler(this.btnAddEntry_Click);
            this.btnAddEntry.MouseEnter += new System.EventHandler(this.btnAddEntry_MouseEnter);
            this.btnAddEntry.MouseLeave += new System.EventHandler(this.btnAddEntry_MouseLeave);
            // 
            // ChildForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataPanelDuplicate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChildForm";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "ChildForm";
            this.Activated += new System.EventHandler(this.ChildForm_Activated);
            this.Load += new System.EventHandler(this.ChildForm_Load);
            this.Shown += new System.EventHandler(this.ChildForm_Shown);
            this.Leave += new System.EventHandler(this.ChildForm_Leave);
            this.dataPanelDuplicate.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnAddEntry)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel dataPanelDuplicate;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox btnAddEntry;
    }
}