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
                            EventDescription = "A mysterious figure materializes from the shadows. They look at you menacing and their hands begin sporting an eerie glow. What stands before you is clearly a Wizard or Sorceror, ready to blast you into oblivion with spells and incantations.";
                            break;
                        case 1:
                            EventDescription = "A nearby portal shimmer with light. On it's inside, you can see a clearing with nice trees and yellow butterflies. As you gaze up to marvel at their beauty, the portal colapses into a hellish landscape and a furious foe comes through.";
                            break;
                        case 2:
                            EventDescription = "A pool of ooze smells nearby. As you approach to see what's inside, it seems to dissolve anything that falls into it. As you come even close, the pool churls and jumps towards you, revealing itself to be a slime creature taking a more distinguishable form.";
                            break;
                        case 3:
                            EventDescription = "You wake up... But you don't recall sleeping. As you look around you, you hear a laughter as the seemingly witch-like figure stands behind you hands raised with a glimmering potion and a shimmering sigil. The witch crackles at you and proceeds to attack viciously.";
                            break;
                        case 4:
                            EventDescription = "A child wearing armor comes running at you. Upon closer inspection you realize it's not a child, but a halfling cleric. She screams and points towards a tenebrous figure that chasing her. The lich approaches and you take up your arms beside your newfound ally to fight the evil force!";
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
                            EventDescription = "As you walk by in your quest, you hear a faint hustling of leaves. As you turn to check, you see a silhoute amongst the trees. You are being chased by a some brigand or rogue-like being. Before you can do anything, you realize you are surrounded and take up your arms.";
                            break;
                        case 1:
                            EventDescription = "You fall into a trap and spring your ankle. However, worse than that, you realize the trap is also home to an assassin who was waiting to ambush you. It's time to fight or die.";
                            break;
                        case 2:
                            EventDescription = "You meet a strange in the road. As he offers you some sweet candy, you remember you mom's words that you should never take candy from strangers. When denied, the stranger begins to act agressively and decides to shank you. You quickly defend yourself and steel up for combat!";
                            break;
                        case 3:
                            EventDescription = "You see a small sign in the street. Upon getting close, you read: This is a generic event and is going to trigger a combat encounter. Before you can make anything of the message, you are sprung into action by the sound of flying daggers. They almost hit you as you turn to face an assassin sent to kill you.";
                            break;
                        case 4:
                            EventDescription = "You begin to hear a squeaky sound getting close and closer. It reminds you of the shoes clowns used to wear on the parties in your childhood. As the squeakyness gets more annoying, you realize you are being followed by a mysterious figure in clown shoes. What does it want you ask, as it looks towards you getting close and close without uttering a single word. When the clownish figure is at arms reach, you decide to act wether or not you should.";
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
                            EventDescription = "You hear a faint cheer over the distance. Someone is remarking on what is good in life and apparently, it is to crush your enemies, see them driven before you and hear the lamentations of their women. As you approach, you realize a gigantic towering figure is about to challenge you to combat!";
                            break;
                        case 1:
                            EventDescription = "You stand before a shrine. You remember those who wronged you in the past. As you remember you are not the praying kind, you just state your words to Crom, asking for justice. Before you can finish, you hear the footsteps of your old nemesis, as Crom himself seems to be delivering your change for revenge.";
                            break;
                        case 2:
                            EventDescription = "The smell of graham crackers fills the air. A loud and fuzzy creature approaches and looks at you. It seems almost decided to tank you and everything you build with your sweat and tears. You decide to fight back before this thing takes from you all you love.";
                            break;
                        case 3:
                            EventDescription = "On the distance, you see a Goliath with a gigantic war hammer. As he turns to you, his bare chest gleaming against the sunlight, he exclaims that he shall be the greatest of the Garbazi and you shall be dead!";
                            break;
                        case 4:
                            EventDescription = "You hear a faint whistling of wind. A quick-footed warrior dashes towards you, his skin almost as if made of minerals, his eyes gleaming with a fiery force. The quartz-like warrior seems as eager to prove himself in combat as he is to shine in his arts. You have no choice, but to defend yourself!";
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
