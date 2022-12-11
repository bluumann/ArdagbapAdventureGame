using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ArdagbapAdventureGame
{
    internal class DialogEncounter : Event
    {
        public DialogEncounter(string eventName, Image eventImage, string eventType, int key) : base(eventName, eventImage, eventType)
        {
            EventDescription = "";
            switch (eventType)
            {
                case "Spell":
                    switch (key)
                    {
                        case 0:
                            EventDescription = "Spell Case0: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 1:
                            EventDescription = "Spell Case1: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 2:
                            EventDescription = "Spell Case2: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 3:
                            EventDescription = "Spell Case3: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 4:
                            EventDescription = "Spell Case4: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        default:
                            EventDescription = "Spell A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                    }
                    break;
                case "Skill":
                    switch (key)
                    {
                        case 0:
                            EventDescription = "Skill Case0: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 1:
                            EventDescription = "Skill Case1: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 2:
                            EventDescription = "Skill Case2: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 3:
                            EventDescription = "Skill Case3: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 4:
                            EventDescription = "Skill Case4: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        default:
                            EventDescription = "Skill A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                    }
                    break;
                case "Strength":
                    switch (key)
                    {
                        case 0:
                            EventDescription = "Strength Case0: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 1:
                            EventDescription = "Strength Case1: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 2:
                            EventDescription = "Strength Case2: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 3:
                            EventDescription = "Strength Case3: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        case 4:
                            EventDescription = "Strength Case4: A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                        default:
                            EventDescription = "Strength A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                    }
                    break;
            }
        }

        public override void UpdateEvent()
        {
            throw new NotImplementedException();
        }

        private void DrawEvent()
        {

        }
    }
}
