using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CustomList.Form1;

namespace CustomList
{
    public partial class ChildForm : Form
    {
        ChildFormType type;
        List<EntryComponent> entryComponents;
        string category;

        public ChildForm(ChildFormType type, string category = null)
        {
            InitializeComponent();
            this.type = type;
            this.category = category;
        }

        private void ChildForm_Load(object sender, EventArgs e)
        {

        }

        private void ChildForm_Activated(object sender, EventArgs e)
        {

        }

        private void ChildForm_Shown(object sender, EventArgs e)
        {
            switch (type)
            {//should probably add some settings that could probably stored in a settings.json
                case ChildFormType.Category:
                    //will display all entries of this category
                    entryComponents = new List<EntryComponent>();

                    var entries = DatabaseClass.GetDataByCategory(category, "");

                    int i = 0;
                    foreach(Entry ent in entries)
                    {
                        EntryComponent entr = new EntryComponent(i, ent);
                        Controls.Add(entr.mainPanel);
                        entryComponents.Add(entr);
                    }
                    break;
                case ChildFormType.Dashboard:
                    Label label = new Label() { Text = "Cool statistic here", Dock = DockStyle.Left };
                    Controls.Add(label);
                    break;
            }
        }

        private void lblWatchCount_Click(object sender, EventArgs e)
        {

        }

        private void btnAddEntry_MouseEnter(object sender, EventArgs e)
        {
            btnAddEntry.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnAddEntry_MouseLeave(object sender, EventArgs e)
        {
            btnAddEntry.BorderStyle = BorderStyle.None;
        }

        private void btnAddEntry_Click(object sender, EventArgs e)
        {
            Form2 dialogue = new Form2(entryComponents, category);
            dialogue.Show();
        }

        private void ChildForm_Leave(object sender, EventArgs e)
        {
            // this.
            //still some memory leaks left
            if (type == ChildFormType.Category)
            {
                foreach (EntryComponent entry in entryComponents)
                {
                    entry.DestroyComponent();
                }
                btnAddEntry.Image.Dispose();
                this.Dispose(true);
                this.Close();
            }
        }
    }
}
