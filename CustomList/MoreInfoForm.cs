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
        public MoreInfoForm(Entry entry, string category)
        {
            InitializeComponent();
            this.entry = entry;
            this.category = category;
        }

        private void btnDeleteEntry_Click(object sender, EventArgs e)
        {
            DatabaseClass.RemoveEntry(category, entry.name);
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
