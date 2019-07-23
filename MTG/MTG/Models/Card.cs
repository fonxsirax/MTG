using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MTG.Models
{
    public class Card
    {
        public int id { get; set; }
        public string name { get; set; }
        public string manaCost { get; set; }
        public int CMC { get; set; }
        public char colorIdentity { get; set; }
        public string typePermanent { get; set; }  //creature enchantment etc
        public string superType { get; set; } // goblin, elf, legend
        public string rarity { get; set; }
        public string set { get; set; } // "SOI"
        public string text { get; set; }
        public string artist { get; set; }
        public int power { get; set; }
        public int toughness { get; set; }
        public string imgURL { get; set; }






    }
}
