using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtration
{
    internal class Game
    {
        public Game() { }
        public Game(string name, string studio, string description, int price)
        {
            Name = name;
            Studio = studio;
            Description = description;
            Price = price;
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Studio { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
    }
}
