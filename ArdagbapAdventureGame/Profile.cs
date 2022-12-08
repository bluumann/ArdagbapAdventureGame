using System.Collections.Generic;

namespace ArdagbapAdventureGame
{
    public class Profile
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public int CurrentHealth { get; set; }
        public int MaxHealth { get; set; }
        public int Shielding { get; set; } = 0;
        public int Gold { get; set; }
        public List<Card> Deck { get; set; }
        public List<Card> AvailableCards { get; set; }
        public int CurrentAdventure { get; set; } = 1;
        public int AdventureLevel { get; set; } = 1;


        public void SaveProfile()
        {

        }

        public void UpdateDeck()
        {

        }

        public void CreateNewDeck()
        {

        }
    }
}