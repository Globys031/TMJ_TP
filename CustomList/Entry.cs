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
        private string name; // name of the entry (e.g. "The mummy 1999")
        // placeholder for image
        private double score; // score for entry (e.g. 2, would be 2/10)
        private string description; // description of the entry
        private string image;
        private string date;
        // later on the user will be able to add aditional columns as he desires
        // (e.g. progress, location, ect...)
        private string[] additionalColumns;

        public Entry(string Name, string Image, double Score, string Description, string Date)
        {
            this.name = Name;
            this.image = Image;
            this.score = Score;
            this.description = Description;
            this.date = Date;
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
