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
        }

        private void btnExitAddDialogue_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string name = txtEntryName.Text;
            string rating = txtRating.Text;
            string description = txtEntryDescription.Text;
            string dateTime = dateRelease.Value.Date.ToShortDateString();

            var ent = new Entry(name, "", Int32.Parse(rating), description, dateTime);
            entryComponents.Add(new EntryComponent(entryComponents.Count + 1, ent, category));

            DatabaseClass.SetData(category, name, "", Int32.Parse(rating), description, dateTime);
            parent.DataPanel.Controls.Add(entryComponents[entryComponents.Count - 1].mainPanel);

            this.Close();
            this.Dispose();
        }

        private void Form2_Shown(object sender, EventArgs e)
        {

        }
    }
}
