using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomList
{
    public partial class Form2 : Form
    {
        private List<EntryComponent> entryComponents;
        private string category;
        private ChildForm parent;
        public Form2(List<EntryComponent> entryComponents, string category, ChildForm parent)
        {
            InitializeComponent();
            this.entryComponents = entryComponents;
           this.category = category;
            this.parent = parent;

            drpdRating.SelectedIndex = 0;
        }

        private void btnExitAddDialogue_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtEntryName.Text;
            string rating = drpdRating.SelectedItem.ToString();
            string description = txtEntryDescription.Text;
            string dateTime = dateRelease.Value.Date.ToShortDateString();

            var errors = ValidateFields(name);
            string ErrorMsg;
            if (errors != "")
            {
                ErrorMsg = "Can't save, errors: " + errors;
                lblAnyText.Text = ErrorMsg;
                return;
            }

            var ent = new Entry(name, openFileDialog1.FileName, Int32.Parse(rating), description, dateTime,0);
            entryComponents.Add(new EntryComponent(entryComponents.Count + 1, ent, category));

            DatabaseClass.SetData(category, name, Int32.Parse(rating), description, dateTime, ent.image);
            parent.DataPanel.Controls.Add(entryComponents[entryComponents.Count - 1].mainPanel);

            this.Close();
            this.Dispose();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {

        }

        private void btnSelectPoster_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }
        private string ValidateFields(string name)
        {
            string error = "";
            if(name.Length == 0 || name == "Title of your entry here...")//should probably display a different error msg for default title
            {
                error += " name of your entry must not be empty.";
            }
            else if (name.Length > 50)
            {
                error += " name of your entry must not be longer than 50 characters.";
            }
            if(openFileDialog1.FileName != "" && openFileDialog1.FileName != "openFileDialog1")
            {
                try
                {
                    Image.FromFile(openFileDialog1.FileName);
                }
                catch (Exception)
                {
                    error += " the file you selected can't be used as a poster";
                }
            }
            return error;
        }

        private void txtEntryName_Click(object sender, EventArgs e)
        {
            if (txtEntryName.Text == "Title of your entry here...")
                txtEntryName.Text = "";
        }

        private void txtEntryDescription_Click(object sender, EventArgs e)
        {
            if (txtEntryDescription.Text == "Description of your entry here..")
                txtEntryDescription.Text = "";
        }
    }
}
