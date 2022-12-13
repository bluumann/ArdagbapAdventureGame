using System.Collections.Generic;

namespace ArdagbapAdventureGame
{
    public class Profile
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int CurrentHealth { get; set; } = 100;
        public int MaxHealth { get; set; } = 100;
        public int Shielding { get; set; } = 0;
        public int Gold { get; set; } = 0;
        public int Deck { get; set; } = 0;
        public int AvailableCards { get; set; } = 0;
        public int CurrentAdventure { get; set; } = 0;
        public int AdventureLevel { get; set; } = 0;
        public string AvatarImageName { get; set; }


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