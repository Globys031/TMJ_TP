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
        protected List<Button> Buttons;
        #endregion

        #region Constructor

        /// <summary>
        /// default constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Region = new Region(new Rectangle(0, 0, Width, Height));
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Filling list of buttons, so we can change colors when switching between forms
            Buttons = new List<Button>();
            Buttons.Add(b_Dashboard);
            Buttons.Add(button1);
            Buttons.Add(b_TvSeries);
            Buttons.Add(button3);
            Buttons.Add(b_custom);
        }

        #endregion


        #region buttons

        private void b_Dashboard_Click(object sender, EventArgs e)
        {
            ChangeBackButtonColor();
            pn_Nav.Visible = true;
            pn_Nav.Width = b_Dashboard.Width;
            pn_Nav.Top = b_Dashboard.Top;
            pn_Nav.Left = b_Dashboard.Left;
            b_Dashboard.BackColor = Color.FromArgb(46, 51, 73);

            foreach(Control control in PnlFormLoader.Controls)
            {
                Console.WriteLine(control.ToString());
                control.Dispose();//prevent memory leak
            }
            ChildForm childForm = new ChildForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                Size = PnlFormLoader.Size
            };
            PnlFormLoader.Controls.Add(childForm);
            childForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeBackButtonColor();
            pn_Nav.Visible = true;
            pn_Nav.Width = button1.Width;
            pn_Nav.Top = button1.Top;
            pn_Nav.Left = button1.Left;
            button1.BackColor = Color.FromArgb(46, 51, 73);

            foreach (Control control in PnlFormLoader.Controls)
            {
                control.Dispose();//prevent memory leak
            }
            PnlFormLoader.Controls.Clear();
            ChildForm childForm = new ChildForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                Size = PnlFormLoader.Size
            };
            PnlFormLoader.Controls.Add(childForm);
            childForm.Show();
        }

        private void b_TvSeries_Click(object sender, EventArgs e)
        {
            ChangeBackButtonColor();
            pn_Nav.Visible = true;
            pn_Nav.Width = b_TvSeries.Width;
            pn_Nav.Top = b_TvSeries.Top;
            pn_Nav.Left = b_TvSeries.Left;
            b_TvSeries.BackColor = Color.FromArgb(46, 51, 73);

            foreach (Control control in PnlFormLoader.Controls)
            {
                control.Dispose();//prevent memory leak
            }
            PnlFormLoader.Controls.Clear();
            ChildForm childForm = new ChildForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                Size = PnlFormLoader.Size
            };
            PnlFormLoader.Controls.Add(childForm);
            childForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeBackButtonColor();
            pn_Nav.Visible = true;
            pn_Nav.Width = b_TvSeries.Width;
            pn_Nav.Top = button3.Top;
            pn_Nav.Left = button3.Left;
            button3.BackColor = Color.FromArgb(46, 51, 73);

            PnlFormLoader.Controls.Clear();
            foreach (Control control in PnlFormLoader.Controls)
            {
                control.Dispose();
            }
            ChildForm childForm = new ChildForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                Size = PnlFormLoader.Size
            };
            PnlFormLoader.Controls.Add(childForm);
            childForm.Show();
        }

        private void b_custom_Click(object sender, EventArgs e)
        {
            ChangeBackButtonColor();
            pn_Nav.Visible = true;
            pn_Nav.Width = b_custom.Width;
            pn_Nav.Top = b_custom.Top;
            pn_Nav.Left = b_custom.Left;
            b_custom.BackColor = Color.FromArgb(46, 51, 73);

            foreach (Control control in PnlFormLoader.Controls)
            {
                control.Dispose();//prevent memory leak
            }
            PnlFormLoader.Controls.Clear();
            ChildForm childForm = new ChildForm()
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                Size = PnlFormLoader.Size
            };
            PnlFormLoader.Controls.Add(childForm);
            childForm.Show();
        }

        private void b_Dashboard_Leave(object sender, EventArgs e)
        {
        }

        private void button1_Leave(object sender, EventArgs e)
        {
        }

        private void b_TvSeries_Leave(object sender, EventArgs e)
        {
        }

        private void button3_Leave(object sender, EventArgs e)
        {
        }

        private void b_custom_Leave(object sender, EventArgs e)
        {
        }

        #endregion


    #region     Helpers
        void ChangeBackButtonColor()
        {//46, 51, 73
            
            foreach( Button b in Buttons)
            {
                b.BackColor = Color.FromArgb(24, 30, 54);
            }
        }
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

    }
}
