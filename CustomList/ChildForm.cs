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
                   /* Panel panel = new Panel() { Dock = DockStyle.Left, Size = dataPanel.Size,
                        BorderStyle = dataPanel.BorderStyle, Padding = dataPanel.Padding};
                    Controls.Add(panel);*/
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
    }
}
