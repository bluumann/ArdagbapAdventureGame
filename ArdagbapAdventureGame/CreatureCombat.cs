using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdagbapAdventureGame
{
    internal class CreatureCombat : Event
    {
        private int CreatureCurrentHealth;
        private int CreatureMaxHealth;
        private int CreatureDamage;
        private List<Card> PlayerDeck;
        private List<Card> PlayerHand;
        private List<Card> PlayerDiscardPile;

        public CreatureCombat(string eventName, Image eventImage, string eventDescription, string eventType) : base(eventName, eventImage, eventDescription, eventType)
        {
            CreatureCurrentHealth = 10;
            CreatureMaxHealth = 10;
            CreatureDamage = 1;
        }

        public override void UpdateEvent()
        {
            throw new NotImplementedException();
        }

        private void PlayerTurn()
        {

        }

        private void CreatureTurn()
        {

        }


    }
}
