using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdagbapAdventureGame
{
    internal class Adventure
    {
        public int CurrentPath = 0;
        public List<Event> Events = new List<Event>();

        public void DisplayEvents()
        {
            if (CurrentPath == Events.Count - 1) ;
            else CurrentPath++;
        }

        public void SetPath()
        {
            Events.Clear();

            CurrentPath = 0;
            Image event1 = Image.FromFile("Room.jpg");
            Image event2 = Image.FromFile("Mountains.jpg");
            Image event3 = Image.FromFile("Rural.jpg");
            Image event4 = Image.FromFile("Laketown.jpg");
            Image event5 = Image.FromFile("Pathway.jpg");
            Image event6 = Image.FromFile("Bloons.jpg");
            Image event7 = Image.FromFile("CoastCity.jpg");
            Image event8 = Image.FromFile("Beach.jpg");
            Image event9 = Image.FromFile("Sea.jpg");
            Image event10 = Image.FromFile("Cosmic.jpg");

            //Skill, Spell, Strength

            Events.Add(new CreatureCombat("Treta Prison", event1, "Hi", "Skill"));
            Events.Add(new CreatureCombat("Mountains of Colors", event2, "Hi", "Spell"));
            Events.Add(new CreatureCombat("Fields of Colors", event3, "Hi", "Skill"));
            Events.Add(new CreatureCombat("Laketown", event4, "Hi", "Strength"));
            Events.Add(new CreatureCombat("Dirty Old Road", event5, "Hi", "Strength"));
            Events.Add(new CreatureCombat("An Old Friend", event6, "Hi", "Skill"));
            Events.Add(new CreatureCombat("Where the Ocean meets the People", event7, "Hi", "Skill"));
            Events.Add(new CreatureCombat("Where the Ocean meets your Feet", event8, "Hi", "Strength"));
            Events.Add(new CreatureCombat("Look to the Skies", event9, "Hi", "Skill"));
            Events.Add(new CreatureCombat("One Cosmic Ending", event10, "Hi", "Spell"));
            
        }

        public void ExitAdventure()
        {

        }
    }
}
