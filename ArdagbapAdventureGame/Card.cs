using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdagbapAdventureGame
{
    public class Card
    {
        public string CardName { get; set; }
        public string CardType { get; set; }
        public Image  CardImage { get; set; }
        public string CardDescription { get; set; }
        public bool IsTemporary { get; set; }
        public string CardEffect { get; set; }
        public int CardPower { get; set; }
    }
}
