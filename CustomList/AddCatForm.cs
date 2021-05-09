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
        List<string> Categories;
        public AddCatForm(List<string> Categories)
        {
            this.Categories = Categories;
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // first do validation
            if(Categories.Contains(txtCatName.Text))
            {
                //set error
                return;
            }
            //      too long?

            //set new category
            DatabaseClass.SetCategory(txtCatName.Text);

            //create and cache new button
            Categories.Add(txtCatName.Text);
            //quick solution to notify that a new category has been added
            //add a string of 50 chars, definitely longer than anything the user can add
            //and when we close this form we invoke FormClosed event and check if the last value length is 50
            //this way I don't have to track any additional variables that keep the last length of the array
            //and will be a tiny bit faster and simpler to implement
            Categories.Add("00000000000000000000000000000000000000000000000000");

            //close this form and open new one
            this.Close();
        }
    }
}
