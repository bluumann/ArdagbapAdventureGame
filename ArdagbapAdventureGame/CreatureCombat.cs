﻿using System;
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
        private List<Card> PlayerDeck;
        private List<Card> PlayerHand;
        private List<Card> PlayerDiscardPile;
        public Image CreatureImage;

        public CreatureCombat(string eventName, Image eventImage, string eventDescription, string eventType, Image creatureImage) : base(eventName, eventImage, eventDescription, eventType)
        {
            CreatureCurrentHealth = 100;
            CreatureMaxHealth = 100;
            CreatureDamage = 1;
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
