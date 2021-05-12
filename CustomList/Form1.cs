using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace CustomList
{
    public partial class Form1 : Form
    {
        #region variables
        public List<string> Categories;
        public List<Button> Buttons;
        bool mouseDown;
        Point delta;


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

            //Fill list with categories
            Categories = new List<string>();
            foreach (string cat in DatabaseClass.GetCategoriesList())
            {
                Categories.Add(cat);
            }

            Buttons = new List<Button>();
            Buttons.Add(button1);
            Buttons.Add(button3);
            Buttons.Add(b_TvSeries);
            Buttons.Add(b_addCat);

            bool added = false;
            for (int i = 3; i < Categories.Count; i++)
            {
                added = true;
                CreateAndAddCatBut(Categories[i], false);
            }
            if (added)
                RedrawCats();

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
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
            AddCatForm form = new AddCatForm(Categories)
            {
                Size = PnlFormLoader.Size,
                TopLevel = false,
                Dock = DockStyle.Left
            };
            PnlFormLoader.Controls.Add(form);
            form.FormClosed += AddCatForm_Closed;
            form.Show();
        }

        private void AddCatForm_Closed(object sender, EventArgs e)
        {
            //Add Category Form was close, now we must check if our list of categories changed
            //would be even better to have an event where that list changes and then calls this method
            if(Categories.Last().Length > 40)
            {
                Categories.RemoveAt(Categories.Count - 1);//remove the dummy indicator value

                //now create and add new button
                CreateAndAddCatBut(Categories.Last());
            }
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

        private void btnMinimizeForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        protected void CreateAndAddCatBut(string cat, bool redraw = true)
        {
            Button button = new Button();
            button.Dock = DockStyle.Left;
            button.FlatAppearance.BorderSize = 0;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Nirmala UI", 10.2f, FontStyle.Bold, GraphicsUnit.Point, 0);
            button.ForeColor = Color.FromArgb(0, 126, 249);
            //if we ever decide to add image do it here
            //button.Location
            button.Name = "btn_" + cat;
            button.Size = new Size(134, 97);
            button.Text = cat;
            button.UseVisualStyleBackColor = true;
            button.Click += new System.EventHandler(GenericCat_Click);

            //add cat must be last
            Buttons.Insert(Buttons.Count - 1, button);

            if (redraw)
            {
                RedrawCats();
            }
        }

        private void GenericCat_Click(object sender, EventArgs e)
        {
            var but = sender as Button;

            ChangeBackButtonColor();
            pn_Nav.Visible = true;
            pn_Nav.Width = but.Width;
            pn_Nav.Top = but.Top;
            pn_Nav.Left = but.Left;
            pn_Nav.BackColor = Color.FromArgb(46, 51, 73);

            foreach (Control control in PnlFormLoader.Controls)
            {
                control.Dispose();//prevent memory leak
            }
            PnlFormLoader.Controls.Clear();
            ChildForm childForm = new ChildForm(PnlFormLoader.Size, but.Text)
            {
                Dock = DockStyle.Fill,
                TopLevel = false,
                TopMost = true,
                Size = PnlFormLoader.Size
            };
            PnlFormLoader.Controls.Add(childForm);
            childForm.Show();
        }

        /// <summary>
        /// Redraws category buttons in the correct order
        /// We need to call this to display the category buttons correctly, because if you just add it
        /// it will go to the front of the panel
        /// </summary>
        public void RedrawCats()
        {
            panel1.Controls.Clear();
            Categories = new List<string>();
            Categories = DatabaseClass.GetCategoriesList();
            if (Categories.Count == 3)
            {
                for (int i = 0; i < Buttons.Count - 1; i++)
                {
                    if (i == 3) 
                    {
                        Buttons.RemoveAt(i);
                        i--;
                    }
                }
                panel1.Controls.Add(Buttons[Buttons.Count - 1]);
                for (int i = 3 - 1; i >= 0; i--)
                    panel1.Controls.Add(Buttons[i]);
            }
            else 
            {
                for (int i = Buttons.Count - 1; i >= 0; i--)
                    panel1.Controls.Add(Buttons[i]);
            }
        }
    }
}
