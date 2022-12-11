using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArdagbapAdventureGame
{
    public partial class GameForm : Form
    {
        Adventure Adventure = new Adventure();
        bool hasAction = true; //controls wether player rested or investigated scene.
        int currentCreatureMaxHP = 0; //hold the maximum HP of the current creature.
        int currentCreatureBaseDamage = 0;
        int playerBaseDamage = 10;
        int playerMaxHP = 100;

        Card skillCard = new Card() { CardName = "Skill Card", CardType = "Skill", CardDescription = "This is a skill card.", CardImage = Image.FromFile("D_Leonan.png") };
        Card strongCard = new Card() { CardName = "Strong Card", CardType = "Strong", CardDescription = "This is a strong card.", CardImage = Image.FromFile("D_Metal.png") };
        Card spellCard = new Card() { CardName = "Spell Card", CardType = "Spell", CardDescription = "This is a spell card.", CardImage = Image.FromFile("D_Wizard.png") };


        public GameForm()
        {
            InitializeComponent();
            EndCombat(); //clears combat indicators that exist for placeholder on design form.
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();
        }

        //debug commands begin
        private void debugStart_Click(object sender, EventArgs e)
        {
            Adventure.SetPath();
            lblEventName.Text = Adventure.Events[Adventure.CurrentPath].EventName;
            textEvent.Text = Adventure.Events[Adventure.CurrentPath].EventDescription;
            picEvent.Image = Adventure.Events[Adventure.CurrentPath].EventImage;
            lblEventType.Text = Adventure.Events[Adventure.CurrentPath].EventType;
            hasAction = true;
        }
        private void debugContinue_Click(object sender, EventArgs e)
        {
            Advance();
        }

        private void debugSpell_Click(object sender, EventArgs e)
        {
            if (Adventure.Events[Adventure.CurrentPath].EventType == "Strength")
            {
                MessageBox.Show(Result(true));
                Advance();
            }
            else
            {
                MessageBox.Show(Result(false));
            }
        }

        private void debugSkill_Click(object sender, EventArgs e)
        {
            if (Adventure.Events[Adventure.CurrentPath].EventType == "Spell")
            {
                MessageBox.Show(Result(true));
                Advance();
            }
            else
            {
                MessageBox.Show(Result(false));
            }
        }

        private void debugStrength_Click(object sender, EventArgs e)
        {
            if (Adventure.Events[Adventure.CurrentPath].EventType == "Skill")
            {
                MessageBox.Show(Result(true));
                Advance();
            }
            else
            {
                MessageBox.Show(Result(false));
            }
        }

        //debug commands end

        private void Advance()
        {
            if (Adventure.CurrentPath == Adventure.Events.Count - 1)
            {
                MessageBox.Show("Congratulations, you won!!!");
                MainMenu mainMenu = new MainMenu();
                this.Hide();
                mainMenu.ShowDialog();
                this.Close();
            }

            hasAction = true;
            Adventure.DisplayEvents();

            if (Adventure.Events[Adventure.CurrentPath].EventName == "A Cosmic Ending") //the end scene is less random so it's customized here.
            {
                lblEventName.Text = Adventure.Events[Adventure.CurrentPath].EventName;
                textEvent.Text = "Placeholder Ending Scene Text";
                picEvent.Image = Adventure.Events[Adventure.CurrentPath].EventImage;
                lblEventType.Text = "";

                CreatureCombat current = (CreatureCombat)Adventure.Events[Adventure.CurrentPath];

                lblCreatureName.Text = "The Great Destroyer";
                barCreatureHP.Maximum = current.CreatureMaxHealth;
                barCreatureHP.Value = current.CreatureMaxHealth;
                currentCreatureMaxHP = current.CreatureMaxHealth;
                picCreature.Image = current.CreatureImage;
                lblCreatureDmg.Text = "Base Damage: " + current.CreatureDamage;
                lblCreatureType.Text = current.EventType;
                currentCreatureBaseDamage = current.CreatureDamage;
            }
            else if (Adventure.Events[Adventure.CurrentPath] is CreatureCombat && Adventure.Events[Adventure.CurrentPath].EventName != "A Cosmic Ending")
            {
                lblEventName.Text = Adventure.Events[Adventure.CurrentPath].EventName;
                textEvent.Text = Adventure.Events[Adventure.CurrentPath].EventDescription;
                picEvent.Image = Adventure.Events[Adventure.CurrentPath].EventImage;
                lblEventType.Text = "Combat";
                //block updates the event itself.

                CreatureCombat current = (CreatureCombat)Adventure.Events[Adventure.CurrentPath]; //casting

                lblCreatureName.Text = Adventure.Names[Adventure.ReceiveRandom(Adventure.Names.Count)];
                barCreatureHP.Maximum = current.CreatureMaxHealth;
                barCreatureHP.Value = current.CreatureMaxHealth;
                currentCreatureMaxHP = current.CreatureMaxHealth;
                picCreature.Image = current.CreatureImage;
                lblCreatureDmg.Text = "Base Damage: " + current.CreatureDamage;
                lblCreatureType.Text = current.EventType;
                currentCreatureBaseDamage = current.CreatureDamage;
                //block updated the combat features.

            }
            else if (Adventure.Events[Adventure.CurrentPath] is DialogEncounter)
            {
                lblEventName.Text = Adventure.Events[Adventure.CurrentPath].EventName;
                textEvent.Text = Adventure.Events[Adventure.CurrentPath].EventDescription;
                picEvent.Image = Adventure.Events[Adventure.CurrentPath].EventImage;
                lblEventType.Text = Adventure.Events[Adventure.CurrentPath].EventType;
                //block updates the event itself.
            }
            UpdateCombat();
            //always try to update combat at the end.
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (barCreatureHP.Value == 0) MessageBox.Show("Nothing to Attack!");
            else
            {
                Random rnd = new Random();

                int playerDmg = playerBaseDamage + rnd.Next(1,5);
                int creatureDmg = currentCreatureBaseDamage + rnd.Next(1,5);

                MessageBox.Show("You attacked " + lblCreatureName.Text + " for " + playerDmg + " and were attacked for " + creatureDmg + ".");

                if (barCreatureHP.Value - playerDmg <= 0) barCreatureHP.Value = 0;
                else barCreatureHP.Value += -playerDmg;

                if (barPlayerHP.Value - creatureDmg <= 0) barPlayerHP.Value = 0;
                else barPlayerHP.Value += -creatureDmg;
                UpdateCombat();
            }
          
        }
        private void btnRest_Click(object sender, EventArgs e)
        {
            if (hasAction)
            {
                if (barPlayerHP.Value + 15 >= 100) barPlayerHP.Value = 100;
                else barPlayerHP.Value += 15;
                MessageBox.Show("You rest and recover 15HP.");
                hasAction = false;
                UpdateCombat();
            }
            else MessageBox.Show("You've already rested or investigated this area.");
            
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            if (hasAction)
            {
                MessageBox.Show("You investigate the area.");
                hasAction = false;
                //to expand upon.
            }
            else MessageBox.Show("You've already rested or investigated this area.");
        }

        private void UpdateCombat()
        {
            lblBarCreature.Text = barCreatureHP.Value.ToString() + "/" + currentCreatureMaxHP;
            lblBarPlayer.Text = barPlayerHP.Value.ToString() + "/" + playerMaxHP;

            if (barPlayerHP.Value == 0)
            {
                MessageBox.Show("You hitpoints were reduced to zero, you lose.");

                MainMenu mainMenu = new MainMenu();
                this.Hide();
                mainMenu.ShowDialog();
                this.Close();
            }
            if (barCreatureHP.Value == 0 && lblCreatureName.Text != "No Combat")
            {
                MessageBox.Show("You defeated " + lblCreatureName.Text + "!");
                EndCombat();
                Advance();
            }
        }

        private void EndCombat()
        {
            lblCreatureName.Text = "No Combat";
            lblBarCreature.Text = "";
            lblCreatureDmg.Text = "";
            lblCreatureType.Text = "";
            picCreature.Image = null;
        }

        private string Result(bool result)
        {
            string message = "";
            if (result)
            {
                Random rnd = new Random();
                List<string> list = new List<string>();

                list.Add("You succcesfully conducted your task!");
                list.Add("Congratulations, you succeeded.");
                list.Add("Great job, well done!");
                list.Add("You did great!");
                list.Add("Success!!!");

                message = list[rnd.Next(list.Count)];
            }
            else
            {
                Random rnd = new Random();
                List<string> list = new List<string>();

                list.Add("You succcesfully failed in your task!");
                list.Add("Oh no, you failed.");
                list.Add("Bad job, done rare! You fail");
                list.Add("You did poorly!");
                list.Add("Failure!!!");

                message = list[rnd.Next(list.Count)];
            }
            
            return message;
        }

        // Populate the card panel section with cards
        private void btnPopulateCard_Click(object sender, EventArgs e)
        {
            //Clear for refresh
            panelCard.Controls.Clear();

            //Create a list of possible cards
            List<Card> possibleCards = new List<Card>();
            possibleCards.Add(skillCard);
            possibleCards.Add(strongCard);
            possibleCards.Add(spellCard);

            //For picking random cards
            Random random = new Random();

            //Create a list of the random cards to fill the panel with options
            List<Card> availableCards= new List<Card>();
            availableCards.Add(possibleCards[random.Next(0, 3)]);
            availableCards.Add(possibleCards[random.Next(0, 3)]);
            availableCards.Add(possibleCards[random.Next(0, 3)]);
            availableCards.Add(possibleCards[random.Next(0, 3)]);
            availableCards.Add(possibleCards[random.Next(0, 3)]);

            //Create our custom controls and add them to a list
            CardCC card1 = new CardCC();
            CardCC card2 = new CardCC();
            CardCC card3 = new CardCC();
            CardCC card4 = new CardCC();
            CardCC card5 = new CardCC();

            List<CardCC> cardCCs = new List<CardCC>() { card1, card2, card3, card4, card5};
            
            //For placement
            int xAxis = 0;

            //Assign values to our shown cards
            for (int i = 0; i < 5; i++)
            {
                cardCCs[i].LabelName = availableCards[i].CardName;
                cardCCs[i].CardType = availableCards[i].CardType;
                cardCCs[i].LabelDesc = availableCards[i].CardDescription;
                cardCCs[i].CardElement = availableCards[i].CardImage;

                cardCCs[i].Location = new Point(xAxis - panelCard.HorizontalScroll.Value, 0);
                xAxis += cardCCs[i].Width + 5;

                panelCard.Controls.Add(cardCCs[i]);
            }
        }

        //Trying to call from inside CardCC
        public void checkResult(string cardType)
        {
            if (Adventure.Events[Adventure.CurrentPath].EventType == cardType)
            {
                MessageBox.Show(Result(true));
                Advance();
            }
            else
            {
                MessageBox.Show(Result(false));
            }
        }
    }
}
