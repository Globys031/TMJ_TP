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
using System.Data.SqlClient;
//using System.Data;

namespace CustomList
{
    public partial class Form1 : Form
    {
        #region variables
        protected List<Button> Buttons;
        bool mouseDown;
        Point delta;
        bool mouseMove;
        bool mouseUp;

        public enum ChildFormType
        {
            Category,
            Dashboard
        };
        #endregion

        #region Form Lifecycle

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
            Buttons.Add(button1);
            Buttons.Add(b_TvSeries);
            Buttons.Add(button3);
            Buttons.Add(b_addCat);
        }

        #endregion


        #region buttons

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
            ChildForm childForm = new ChildForm(PnlFormLoader.Size, "Movies")
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
            ChildForm childForm = new ChildForm(PnlFormLoader.Size, "TV_Series")
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
            ChildForm childForm = new ChildForm(PnlFormLoader.Size, "Anime")
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
            pn_Nav.Width = b_addCat.Width;
            pn_Nav.Top = b_addCat.Top;
            pn_Nav.Left = b_addCat.Left;
            b_addCat.BackColor = Color.FromArgb(46, 51, 73);

            foreach (Control control in PnlFormLoader.Controls)
            {
                control.Dispose();//prevent memory leak
            }
            AddCatForm form = new AddCatForm()
            {
                Size = PnlFormLoader.Size,
                TopLevel = false,
                Dock = DockStyle.Left
            };
            PnlFormLoader.Controls.Add(form);
            form.Show();
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

        private void btnCloseForm_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }

        private void windowHandle_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            delta = e.Location;
        }

        private void windowHandle_MouseMove(object sender, MouseEventArgs e)
        {
            if(mouseDown && e.Button == MouseButtons.Left)
            {
                Point dt = new Point(this.Location.X - delta.X, this.Location.Y - delta.Y);
                Point nPos = new Point(e.X + dt.X, this.Location.Y + e.Y);
                this.Location = nPos;

            }
        }

        private void windowHandle_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine("mouseup");
             mouseDown = false;
        }

        private void windowHandle_MouseLeave(object sender, EventArgs e)
        {
            Console.WriteLine("mouseleave");
            mouseDown = false;
        }

        private void btnMinimizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
