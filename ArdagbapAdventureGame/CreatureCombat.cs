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
        public int CreatureCurrentHealth;
        private int CreatureMaxHealth;
        private int CreatureDamage;
        public Image CreatureImage;

        public CreatureCombat(string eventName, Image eventImage, string eventType, Image creatureImage, int creatureMaxHealth, int creatureDamage) : base(eventName, eventImage, eventType)
        {
            CreatureMaxHealth = creatureMaxHealth;
            CreatureCurrentHealth = creatureMaxHealth;
            CreatureDamage = creatureDamage;
            CreatureImage = creatureImage;
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
