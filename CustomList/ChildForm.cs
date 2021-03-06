﻿using System;
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
        Size size;

        public ChildForm(Size size, string category = null)
        {
            InitializeComponent(size);
            this.size = size;
            this.category = category;
        }

        public void ChildForm_Load(object sender, EventArgs e)
        {
            //InitializeComponent();
        }

        private void ChildForm_Activated(object sender, EventArgs e)
        {
            
        }

        public void ChildForm_Shown(object sender, EventArgs e)
        {
            if (Controls.Count == 0)//when this is called if an entry is deleted the controls should be empty
                InitializeComponent(size);//need to init because it also has that big plus button

            entryComponents = new List<EntryComponent>();

            var entries = DatabaseClass.GetDataByCategory(category, "");

            int i = 0;
            foreach(Entry ent in entries)
            {
                EntryComponent entr = new EntryComponent(i, ent, category);
                DataPanel.Controls.Add(entr.mainPanel);
                entryComponents.Add(entr);
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
            Form2 dialogue = new Form2(entryComponents, category, this);
            dialogue.Show();
        }

        private void ChildForm_Leave(object sender, EventArgs e)
        {
            if (type == ChildFormType.Category)
            {
                foreach (EntryComponent entry in entryComponents)
                {
                    Entry cons = entry.entry;
                    DatabaseClass.UpdateEntries(category, 
                        cons.name, cons.name, cons.score, cons.description, 
                        cons.date, cons.watchCount, cons.image);
                    entry.DestroyComponent();
                }
                btnAddEntry.Image.Dispose();
                btnSearch.BackgroundImage.Dispose();
                this.Dispose(true);
                this.Close();
            }
        }

        private void btnSortScore_Click(object sender, EventArgs e)
        {
            DataPanel.Controls.Clear();
            InitAddButton(DataPanel);
            entryComponents.Clear();

            var list = DatabaseClass.SortEntries(category, 4, true);//sort by score descending

            int i = 0;
            foreach (Entry ent in list)
            {
                EntryComponent entr = new EntryComponent(i, ent, category);
                DataPanel.Controls.Add(entr.mainPanel);
                entryComponents.Add(entr);
            }
        }

        private void btnSortName_Click(object sender, EventArgs e)
        {
            DataPanel.Controls.Clear();
            InitAddButton(DataPanel);
            entryComponents.Clear();

            var list = DatabaseClass.SortEntries(category, 2, false);//sort by name descending

            int i = 0;
            foreach (Entry ent in list)
            {
                EntryComponent entr = new EntryComponent(i, ent, category);
                DataPanel.Controls.Add(entr.mainPanel);
                entryComponents.Add(entr);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataPanel.Controls.Clear();
            InitAddButton(DataPanel);
            entryComponents.Clear();

            string search = textBox1.Text;
            if (search == "")
                return;//should later add some message
            switch (search)//super secret dev commands hehe
            {
                case "!wipecats":
                    var cats = DatabaseClass.GetCategoriesList();
                    for (int j = 3; j < cats.Count; j++)
                    {
                        var entries = DatabaseClass.GetDataByCategory(cats[j], "");
                        if (entries != null)
                        {
                            foreach (Entry entry in entries)
                            {
                                DatabaseClass.RemoveEntry(category, entry.name);
                            }
                        }
                        DatabaseClass.RemoveCategory(cats[j]);
                    }
                    var pp = Parent.Parent as Form1;
                    pp.RedrawCats();
                    break;
                case "!wipeentries":
                    var entriess = DatabaseClass.GetDataByCategory(category, "");
                    foreach (Entry entry in entriess)
                    {
                        DatabaseClass.RemoveEntry(category, entry.name);
                    }
                    break;
                case "!wipeall":
                    DatabaseClass.RemoveAllEntries();
                    DatabaseClass.RemoveNonMandatoryCategories();
                    var ppp = Parent.Parent as Form1;
                    ppp.RedrawCats();
                    break;
            }
            var list = DatabaseClass.GetCategoryEntry(DatabaseClass.FindCategoryId(category), search);

            int i = 0;
            foreach (Entry ent in list)
            {
                EntryComponent entr = new EntryComponent(i, ent, category);
                DataPanel.Controls.Add(entr.mainPanel);
                entryComponents.Add(entr);
            }
        }

        private void txtEnterUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                btnSearch_Click(null, null);
        }
    }
}
