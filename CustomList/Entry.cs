using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    // the actual class holding the data on entries
    public class Entry
    {
        public string name { get; private set; } // name of the entry (e.g. "The mummy 1999")
        // placeholder for image
        public int score { get; private set; } // score for entry (e.g. 2, would be 2/10)
        public string description { get; private set; } // description of the entry
        // later on the user will be able to add aditional columns as he desires
        // (e.g. progress, location, ect...)
        public string[] additionalColumns { get; private set; }

        public Entry(string Name, int Score, string Description)
        {
            this.name = Name;
            this.score = Score;
            this.description = Description;
        }
        public Entry(string Name)
        {
            this.name = Name;
        }
        public string SelectedColumn(int index)
        {
            return this.additionalColumns[index];
        }
    }
}
