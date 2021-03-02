using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomList
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Dictionary is the java equivalent of hashmap. Key will be
            // the data name (e.g. "The mummy 1999" and value will be the class
            // holding the rest of the data)
            // We'll have a basic category called "movies" at first, but later
            // we'll use an array of dictionaries so that further categories can be
            // added or removed as they come and go (will create a different class file
            // for that entirely)
            // values is a list because there may be duplicate names and dictionary
            // doesn't allow that
            Dictionary<string, List<ClassForHoldingElements>>


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
