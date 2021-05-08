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
    public partial class AddCatForm : Form
    {
        public AddCatForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // first do validation

            //set new category
            DatabaseClass.SetCategory(txtCatName.Text);

            //create and cache new button

            //close this form and open new one
        }
    }
}
