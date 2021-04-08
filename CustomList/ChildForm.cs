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

        public ChildForm(ChildFormType type)
        {
            InitializeComponent();
            this.type = type;
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
                    entryComponents = new List<EntryComponent>();

                    //var list = DatabaseClass.GetDataByCategory("Movies");

                    EntryComponent entry = new EntryComponent(0, new Entry("fuck"));
                    Controls.Add(entry.mainPanel);
                    EntryComponent entry2 = new EntryComponent(0, new Entry("fuck č"));
                    Controls.Add(entry2.mainPanel);
                    entryComponents.Add(entry);
                    entryComponents.Add(entry2);
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
            //button to add entry has been clicked
            //make a class for entry
            EntryComponent entry = new EntryComponent(0, new Entry("fuck"));
            Controls.Add(entry.mainPanel);
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
