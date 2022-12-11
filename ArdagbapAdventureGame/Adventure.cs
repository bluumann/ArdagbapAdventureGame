﻿using System;
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
        public List<string> Names = new List<string>();

        Random rnd = new Random();

        Image img_Room = Image.FromFile("Room.jpg");
        Image img_Mountains = Image.FromFile("Mountains.jpg");
        Image img_Rural = Image.FromFile("Rural.jpg");
        Image img_Lake = Image.FromFile("Laketown.jpg");
        Image img_Path = Image.FromFile("Pathway.jpg");
        Image img_Bloons = Image.FromFile("Bloons.jpg");
        Image img_City = Image.FromFile("CoastCity.jpg");
        Image img_Beach = Image.FromFile("Beach.jpg");
        Image img_Sea = Image.FromFile("Sea.jpg");
        Image img_Cosmic = Image.FromFile("Cosmic.jpg");

        Image img_Metal = Image.FromFile("D_Metal.png");
        Image img_Wizard = Image.FromFile("D_Wizard.png");
        Image img_Fairy = Image.FromFile("D_Fairy.png");
        Image img_Faun = Image.FromFile("D_Faun.png");
        Image img_Leonan = Image.FromFile("D_Leonan.png");

        public void DisplayEvents()
        {
            if (CurrentPath == Events.Count - 1) ;
            else CurrentPath++;
        }
        public void SetPath()
        {
            Events.Clear();
            CurrentPath = 0;

            Names.Add("the Coleen");
            Names.Add("the Bedron");
            Names.Add("the Kosa");
            Names.Add("the Buddeh");
            Names.Add("the Tiger Gheist");
            Names.Add("Duck Quackor");
            Names.Add("Dom Metal");
            Names.Add("Leonan");
            Names.Add("Wicked Witch");
            Names.Add("Bad Wolf");
            Names.Add("Inconspicious Person");
            Names.Add("Final Project");

            Events.Add(new DialogEncounter("A Dank and Dark Prison", img_Room, GeneratePuzzle(ReceiveRandom(3)), ReceiveRandom(5)));
            Events.Add(new DialogEncounter("Scene 1", GenerateImage(ReceiveRandom(8)), GeneratePuzzle(ReceiveRandom(3)), ReceiveRandom(5)));
            Events.Add(new CreatureCombat("Combat 1", GenerateImage(ReceiveRandom(8)), GenerateClass(ReceiveRandom(3)), ReceiveRandom(5), GenerateEnemy(ReceiveRandom(5)), 100, 10));
            Events.Add(new DialogEncounter("Scene 2", GenerateImage(ReceiveRandom(8)), GeneratePuzzle(ReceiveRandom(3)), ReceiveRandom(5)));
            Events.Add(new DialogEncounter("Scene 3", GenerateImage(ReceiveRandom(8)), GeneratePuzzle(ReceiveRandom(3)), ReceiveRandom(5)));
            Events.Add(new CreatureCombat("Combat 2", GenerateImage(ReceiveRandom(8)), GenerateClass(ReceiveRandom(3)), ReceiveRandom(5), GenerateEnemy(ReceiveRandom(5)), 100, 10));
            Events.Add(new DialogEncounter("Scene 4", GenerateImage(ReceiveRandom(8)), GeneratePuzzle(ReceiveRandom(3)), ReceiveRandom(5)));
            Events.Add(new DialogEncounter("Scene 5", GenerateImage(ReceiveRandom(8)), GeneratePuzzle(ReceiveRandom(3)), ReceiveRandom(5)));
            Events.Add(new DialogEncounter("Scene 6", GenerateImage(ReceiveRandom(8)), GeneratePuzzle(ReceiveRandom(3)), ReceiveRandom(5)));
            Events.Add(new CreatureCombat("Combat 3", GenerateImage(ReceiveRandom(8)), GenerateClass(ReceiveRandom(3)), ReceiveRandom(5), GenerateEnemy(ReceiveRandom(5)), 100, 10));
            Events.Add(new DialogEncounter("Scene 7", GenerateImage(ReceiveRandom(8)), GeneratePuzzle(ReceiveRandom(3)), ReceiveRandom(5)));
            Events.Add(new DialogEncounter("Scene 8", GenerateImage(ReceiveRandom(8)), GeneratePuzzle(ReceiveRandom(3)), ReceiveRandom(5)));

            Events.Add(new DialogEncounter("A Cosmic Ending", img_Cosmic, GenerateClass(ReceiveRandom(3)), ReceiveRandom(5)));

        }

        public void ExitAdventure()
        {

        }

        private string GeneratePuzzle(int number)//generates the rock paper scissors options.
        {
            string key = "";

            switch (number)
            {
                case 0:
                    key = "Spell";
                    break;
                case 1:
                    key = "Skill";
                    break;
                case 2:
                    key = "Strength";
                    break;
            }
            return key;
        }

        private string GenerateClass(int number)//generates the rock paper scissors options.
        {
            string key = "";

            switch (number)
            {
                case 0:
                    key = "Wizard";
                    break;
                case 1:
                    key = "Rogue";
                    break;
                case 2:
                    key = "Warrior";
                    break;
            }
            return key;
        }

        private Image GenerateImage(int number) //picks a random image out of the stock options.
        {
            Image key = null;

            switch (number)
            {
                case 0:
                    key = img_Beach;
                    break;
                case 1:
                    key = img_Bloons;
                    break;
                case 2:
                    key = img_City;
                    break;
                case 3:
                    key = img_Sea;
                    break;
                case 4:
                    key = img_Lake;
                    break;
                case 5:
                    key = img_Mountains;
                    break;
                case 6:
                    key = img_Path;
                    break;
                case 7:
                    key = img_Rural;
                    break;
            }
            return key;
        }
        private Image GenerateEnemy(int number) //picks a random image out of the stock options.
        {
            Image key = null;

            switch (number)
            {
                case 0:
                    key = img_Wizard;
                    break;
                case 1:
                    key = img_Metal;
                    break;
                case 2:
                    key = img_Fairy;
                    break;
                case 3:
                    key = img_Faun;
                    break;
                case 4:
                    key = img_Leonan;
                    break;
            }
            return key;
        }
        public int ReceiveRandom(int n) //method created to ensure randomness.
        {
            return rnd.Next(0, n);
        }
    }
}
