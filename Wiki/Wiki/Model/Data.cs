using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wiki.Model
{
    internal class Data
    {
        public static ObservableCollection<Country> Countries { get; set; } = new();
    }
}
