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
        public int CreatureMaxHealth;
        public int CreatureDamage;
        public Image CreatureImage;

        public CreatureCombat(string eventName, Image eventImage, string eventType, int key, Image creatureImage, int creatureMaxHealth, int creatureDamage) : base(eventName, eventImage, eventType)
        {
            CreatureMaxHealth = creatureMaxHealth;
            CreatureCurrentHealth = creatureMaxHealth;
            CreatureDamage = creatureDamage;
            CreatureImage = creatureImage;

            EventDescription = "";
            switch (eventType)
            {
                case "Wizard":
                    switch (key)
                    {
                        case 0:
                            EventDescription = "Wizard Case0: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 1:
                            EventDescription = "Wizard Case1: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 2:
                            EventDescription = "Wizard Case2: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 3:
                            EventDescription = "Wizard Case3: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 4:
                            EventDescription = "Wizard Case4: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        default:
                            EventDescription = "Wizard A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                    }
                    break;
                case "Rogue":
                    switch (key)
                    {
                        case 0:
                            EventDescription = "Rogue Case0: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 1:
                            EventDescription = "Rogue Case1: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 2:
                            EventDescription = "Rogue Case2: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 3:
                            EventDescription = "Rogue Case3: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 4:
                            EventDescription = "Rogue Case4: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        default:
                            EventDescription = "Rogue A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                    }
                    break;
                case "Warrior":
                    switch (key)
                    {
                        case 0:
                            EventDescription = "Warrior Case0: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 1:
                            EventDescription = "Warrior Case1: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 2:
                            EventDescription = "Warrior Case2: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 3:
                            EventDescription = "Warrior Case3: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 4:
                            EventDescription = "Warrior Case4: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        default:
                            EventDescription = "Warrior A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                    }
                    break;
            }
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
