using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    // class meant for handling all the input and output (might have separate classes later on for input and output)
    public class InOutUtils
    {
        // function meant for inserting only the basic entries that we have by default
        // (missing image entry)
        internal static void InsertBasicEntry(Dictionary<string, List<Entry>> category, 
            string name,
            string image,
            int score, 
            string description,
            string date)
        {
            // if key doesn't exist, create a new list of values for that key
            if (!category.ContainsKey(name))
                category.Add(name, new List<Entry>());

            Entry entry = new Entry(name, image, score, description, date);
            // add the actual value
            category[name].Add(entry);

        }
    }
}
