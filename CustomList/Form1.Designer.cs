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
            this.EntryNameInput = new System.Windows.Forms.TextBox();
            this.AddEntry = new System.Windows.Forms.Button();
            this.ScoreEntry = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.descriptionEntry = new System.Windows.Forms.TextBox();
            this.category0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EntryNameInput
            // 
            this.EntryNameInput.Location = new System.Drawing.Point(27, 30);
            this.EntryNameInput.Name = "EntryNameInput";
            this.EntryNameInput.Size = new System.Drawing.Size(103, 20);
            this.EntryNameInput.TabIndex = 0;
            this.EntryNameInput.Text = "name";
            this.EntryNameInput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AddEntry
            // 
            this.AddEntry.Location = new System.Drawing.Point(571, 27);
            this.AddEntry.Name = "AddEntry";
            this.AddEntry.Size = new System.Drawing.Size(75, 23);
            this.AddEntry.TabIndex = 1;
            this.AddEntry.Text = "AddEntry";
            this.AddEntry.UseVisualStyleBackColor = true;
            this.AddEntry.Click += new System.EventHandler(this.AddEntry_Click);
            // 
            // ScoreEntry
            // 
            this.ScoreEntry.DisplayMember = "1";
            this.ScoreEntry.FormattingEnabled = true;
            this.ScoreEntry.Location = new System.Drawing.Point(224, 27);
            this.ScoreEntry.Name = "ScoreEntry";
            this.ScoreEntry.Size = new System.Drawing.Size(67, 21);
            this.ScoreEntry.TabIndex = 2;
            this.ScoreEntry.Text = "score";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(27, 74);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(619, 364);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // descriptionEntry
            // 
            this.descriptionEntry.Location = new System.Drawing.Point(364, 27);
            this.descriptionEntry.Name = "descriptionEntry";
            this.descriptionEntry.Size = new System.Drawing.Size(100, 20);
            this.descriptionEntry.TabIndex = 4;
            this.descriptionEntry.Text = "description";
            // 
            // category0
            // 
            this.category0.Location = new System.Drawing.Point(27, 1);
            this.category0.Name = "category0";
            this.category0.Size = new System.Drawing.Size(75, 23);
            this.category0.TabIndex = 5;
            this.category0.Text = "category0";
            this.category0.UseVisualStyleBackColor = true;
            this.category0.Click += new System.EventHandler(this.category1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.category0);
            this.Controls.Add(this.descriptionEntry);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ScoreEntry);
            this.Controls.Add(this.AddEntry);
            this.Controls.Add(this.EntryNameInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EntryNameInput;
        private System.Windows.Forms.Button AddEntry;
        private System.Windows.Forms.ComboBox ScoreEntry;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox descriptionEntry;
        private System.Windows.Forms.Button category0;
    }
}

