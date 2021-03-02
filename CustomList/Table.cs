using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Dictionary is the java equivalent of hashmap. Key will be
// the data name (e.g. "The mummy 1999" and value will be the class
// holding the rest of the data)
// We'll have a basic category called "movies" at first, but later
// we'll use an array of dictionaries so that further categories can be
// added or removed as they come and go (will create a different class file
// for that entirely)
// values is a list because there may be duplicate names and dictionary
// doesn't allow that
namespace CustomList
{
    class Table
    {
        // categories is an array so that multiple categories can be held
        // key is string because key will be name of the entry
        // value is List<Entry> because some entries might have the same name
        private Dictionary<string, List<Entry>>[] categories;

        public Table()
        {
            // at the start it's enough for it to have 3 categories by default
            // later it'll double its size as needed
            categories = new Dictionary<string, List<Entry>>[2];
        }


    }

}
