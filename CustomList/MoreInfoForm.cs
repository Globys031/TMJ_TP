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
    public partial class MoreInfoForm : Form
    {
        private Entry entry;
        private string category;
        private bool delete;
        private bool changed;
        public MoreInfoForm(Entry entry, string category)
        {
            InitializeComponent();
            this.entry = entry;
            this.category = category;
            this.changed = false;

            //enter the values in the fields
            txtEntryName.Text = entry.name;
            txtEntryDescription.Text = entry.description;
            var indx = drpdRating.Items.IndexOf(entry.score.ToString());
            if(indx >= 0 && indx <= 10)
                 drpdRating.SelectedItem = drpdRating.Items[indx];
            dateRelease.Value = DateTime.Parse(entry.date);
            txtWatchCount.Text = entry.watchCount.ToString();

            //subscribe to events here instead of InitializeComponent because the code above will trigger the changed events and we don't want that
            this.drpdRating.SelectedValueChanged += new System.EventHandler(this.drpdRating_SelectedValueChanged);
            this.txtEntryDescription.TextChanged += new System.EventHandler(this.txtEntryDescription_TextChanged);
            this.dateRelease.ValueChanged += new System.EventHandler(this.dateRelease_ValueChanged);
            this.txtEntryName.TextChanged += new System.EventHandler(this.txtEntryName_TextChanged);
            this.txtWatchCount.TextChanged += new System.EventHandler(this.txtWatchCount_TextChanged);
        }

        private void txtWatchCount_TextChanged(object sender, EventArgs e)
        {
            changed = true;
        }

        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {
            if (delete)
            {
                DatabaseClass.RemoveEntry(category, entry.name);
                this.Close();
            }
            else
            {
                lblAnyText.Text = "Are you sure you want to delete this entry? It will be lost forever. To confirm click that button again.";
                delete = true;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string ErrorMsg;
            if(!changed)
            {
                lblAnyText.Text = "Can't save, nothing has changed.";
                return;
            }
            var errors = ValidateFields();
            if (errors != "")
            {
                ErrorMsg = "Can't save, errors: " + errors;
                lblAnyText.Text = ErrorMsg;
                return;
            }

            entry.SetImage(openFileDialog1.FileName);

            DatabaseClass.UpdateEntries(category, entry.name, txtEntryName.Text, Int32.Parse(drpdRating.SelectedItem.ToString()), txtEntryDescription.Text,
                dateRelease.Value.ToShortDateString(), Int32.Parse(txtWatchCount.Text), entry.image);

            this.Close();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            changed = true;
        }

        private void txtEntryName_TextChanged(object sender, EventArgs e)
        {
            changed = true;
        }

        private void drpdRating_SelectedValueChanged(object sender, EventArgs e)
        {
            changed = true;
        }

        private void dateRelease_ValueChanged(object sender, EventArgs e)
        {
            changed = true;
        }

        private void txtEntryDescription_TextChanged(object sender, EventArgs e)
        {
            changed = true;
        }

        private string ValidateFields()
        {
            string error = "";
            if (txtEntryName.TextLength == 0)//should probably display a different error msg for default title
            {
                error += " name of your entry must not be empty.";
            }
            else if (txtEntryName.TextLength > 50)
            {
                error += " name of your entry must not be longer than 50 characters.";
            }
            if (openFileDialog1.FileName != "" && openFileDialog1.FileName != "openFileDialog1")
            {
                try
                {
                    Image.FromFile(openFileDialog1.FileName);
                }
                catch (Exception)
                {
                    error += " the file you selected can't be used as a poster.";
                }
            }
            int num = -1;
            bool succc = Int32.TryParse(txtWatchCount.Text, out num);
            if(!succc || num < 0)
            {
                error += " watch count of entry must be a positive number.";
            }
            bool succ = Int32.TryParse(drpdRating.SelectedItem as string, out num);
            if(!succ || num > 10 && num < 1)
            {
                error += " score of the entry must be a number from 1 to 10.";
            }
            return error;
        }
    }
}
