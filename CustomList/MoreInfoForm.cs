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
        public MoreInfoForm(Entry entry, string category)
        {
            InitializeComponent();
            this.entry = entry;
            this.category = category;
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
            //currently does nothing :(
        }
    }
}
