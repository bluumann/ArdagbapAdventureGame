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
            if (eventName == "A Dank and Dark Prison") EventDescription = "You wake up on a dank and dark prison, as you look around you realize you've been tricked by your old foe, as he went for the Temple of the Great Destroyer. You can only hope, while he betrayed you, he still wants to prevent the destroyer's release." + " ";
            switch (eventType)
            {
                case "Spell":
                    switch (key)
                    {
                        case 0:
                            EventDescription += "You see floating fireflies; they seem to shimmer with a odd magical glow. As you approach one of the bugs, you realize it is reacting to you. The whole swarm seems to be some sort of alarm system to keep you from moving forward. You'll have to move carefuly through them to avoid detection.";
                            break;
                        case 1:
                            EventDescription += "You notice a nearby surface covered in runes. It is clearly a trap! Perhaps some other runes are hidden on the floor or surfaces around you, better be careful.";
                            break;
                        case 2:
                            EventDescription += "You hear the loud roar of a dragon in the distance, if it notices you, you will sure be dead.";
                            break;
                        case 3:
                            EventDescription += "You find yourself surrounded by a magical forcefield; you know not how it activated but you realize it comes from an arcane lockbox hidden on a nearby rock. Perhaps you should try to open the box to disable the forcefield?";
                            break;
                        case 4:
                            EventDescription += "Complex swirling arcane symbols float all around you. Every one of them seems to react to you harmlessly. However, when trying to go through them, they lock and solidify themselves. Perhaps you'll have to arrange them in the correct order to pass?";
                            break;
                        default:
                            EventDescription += "Spell A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                    }
                    break;
                case "Skill":
                    switch (key)
                    {
                        case 0:
                            EventDescription += "Two guards stand before you. They say one of them always lie, the other always tells the truth. You remember and old tale of the mighty Garbazi, who when faced with this dilemma, ripped the head of one of the guards and asked the other, is he dead?";
                            break;
                        case 1:
                            EventDescription += "A wooden donkey wheel sits between you and you path. You realize to pass; you'll need to turn the wheel as once the mighty Nanoc did. That is good, that is good.";
                            break;
                        case 2:
                            EventDescription += "You see an old ghost. You scream and tell him to go away. It doesn't. It starts to ramble about some sort of old warrior and some hygiene process call Dago-Bath. You don't understand anything, but the ghost tells you to use the force! What force? Maybe he means your might!";
                            break;
                        case 3:
                            EventDescription += "As you venture further into the depths of your surroundings, you realize an old monk is exiting a nearby dungeon. He is carrying a lot of junk and gently asks for you help to carry everything. Before you depart on your way, perhaps you should help the old man, no?";
                            break;
                        case 4:
                            EventDescription += "You hear a gigantic boulder rolling down the hill, you see it's going to hit a nearby house. You remember Nanoc, you scream, NANOC! Perhaps you should intercept the boulder with all your might!";
                            break;
                        default:
                            EventDescription += "Skill A generic event description has been generated." + "KEY WAS:" + key;
                            break;
                    }
                    break;
                case "Strength":
                    switch (key)
                    {
                        case 0:
                            EventDescription += "A gigantic golem blocks the way. It is immobile and indestructible. Perhaps he would answer to his master or the mages of old. Luckily, you remember you have a few tricks on your sleeve.";
                            break;
                        case 1:
                            EventDescription += "You hear a nearby bard, telling a story about how a mysterious entity was defeated. And the their soul stones were destroyed into the hell forge... All except one. The bard reveals a small, glimmering yellow stone. Nearby, a wandering stranger begins to approach and reach for the stone. You realize, it's not the Archangel Tyrael, but Baal. You must act to destroy the stone before he takes it!";
                            break;
                        case 2:
                            EventDescription += "Six orbs of shimmer on the distance, mirrored by a single light. Creatio Ex Nihilo, you realize as you are blessed. You open up your soul to them, basking as the Redeemer, the Tempest, the Baron, the Doctor, the Maelstrom and the Empress smile at you. At a distance, a Wolf howls inconspicuously. You feel your magical energy bursting and ready to take you even further.";
                            break;
                        case 3:
                            EventDescription += "A golden miasma flows from everywhere, you realize time is shifting and quaking. On the golden road of nothingness, for a second that never was, the Empress That Always Been and her Golden Army of Meanwhiles and Always Weres spearhead into the void, calling heroes and wolves alike in a fight for hope and creation. Was it a dream? Did it really happen? You don't know, but you feel like you should leave some of your magic here, as to serve the bearers of gifts.";
                            break;
                        case 4:
                            EventDescription += "You see a nearby tablet with an odd prophecy written on it. As you begin to read, your eyes swirl into a reddish form with pointy dots. You realize your blood is boiling with magic and you must contain the power before you're lost in a kaleidoscopic maze of infinite dreams.";
                            break;
                        default:
                            EventDescription += "Strength A generic event description has been generated." + "KEY WAS:" + key;
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

