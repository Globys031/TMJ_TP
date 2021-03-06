using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Runtime.InteropServices;

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

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
              int nHeightEllipse

          );

        private void Form1_Load(object sender, EventArgs e)
        {
            Region = new Region(new Rectangle(0, 0, Width, Height));
        }

        private void b_Dashboard_Click(object sender, EventArgs e)
        {
            pn_Nav.Visible = true;
            pn_Nav.Width = b_Dashboard.Width;
            pn_Nav.Top = b_Dashboard.Top;
            pn_Nav.Left = b_Dashboard.Left;
            b_Dashboard.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pn_Nav.Visible = true;
            pn_Nav.Width = button1.Width;
            pn_Nav.Top = button1.Top;
            pn_Nav.Left = button1.Left;
            button1.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void b_TvSeries_Click(object sender, EventArgs e)
        {
            pn_Nav.Visible = true;
            pn_Nav.Width = b_TvSeries.Width;
            pn_Nav.Top = b_TvSeries.Top;
            pn_Nav.Left = b_TvSeries.Left;
            b_TvSeries.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pn_Nav.Visible = true;
            pn_Nav.Width = b_TvSeries.Width;
            pn_Nav.Top = button3.Top;
            pn_Nav.Left = button3.Left;
            button3.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void b_custom_Click(object sender, EventArgs e)
        {
            pn_Nav.Visible = true;
            pn_Nav.Width = b_custom.Width;
            pn_Nav.Top = b_custom.Top;
            pn_Nav.Left = b_custom.Left;
            b_custom.BackColor = Color.FromArgb(46, 51, 73);
        }

        private void b_Dashboard_Leave(object sender, EventArgs e)
        {
            b_Dashboard.BackColor = Color.FromArgb(23, 30, 54);
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(23, 30, 54);
        }

        private void b_TvSeries_Leave(object sender, EventArgs e)
        {
            b_TvSeries.BackColor = Color.FromArgb(23, 30, 54);
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            button3.BackColor = Color.FromArgb(23, 30, 54);
        }

        private void b_custom_Leave(object sender, EventArgs e)
        {
            b_custom.BackColor = Color.FromArgb(23, 30, 54);
        }
    }
}
