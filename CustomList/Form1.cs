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
    public partial class Form1 : Form
    {
        #region variables
        private Table table;
        #endregion

        #region Constructor

        /// <summary>
        /// default constructor
        /// </summary>
        public Form1()
        {
            table = new Table();
            InitializeComponent();
        }

        #endregion


        #region entryBoxes
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        #endregion


        #region buttons
        private void AddEntry_Click(object sender, EventArgs e)
        {
            // missing an entry for images as well
            // table.Category(0) is a place holder. Instead of a 0 it will later
            // be the index of the actual category we want to query
          /*  InOutUtils.InsertBasicEntry(table.GetCategory(0),
                EntryNameInput.Text, 
                ScoreEntry.Text, 
                descriptionEntry.Text);*/
        }

        // later here we will have buttons for removal and modification

        #endregion

        private void category1_Click(object sender, EventArgs e)
        {

        }
    }
}
