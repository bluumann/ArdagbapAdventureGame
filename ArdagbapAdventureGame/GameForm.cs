using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
        private Profile CurrentProfile; // Contains the current player profile with all its properties

        Adventure Adventure = new Adventure();
        bool hasAction = true; //controls wether player rested or investigated scene.
        int currentCreatureMaxHP = 0; //hold the maximum HP of the current creature.
        int currentCreatureBaseDamage = 0;
        int playerBaseDamage = 10;
        int playerMaxHP = 100;

        Random rnd = new Random();

        Card skillCard = new Card() { CardName = "Skill Card", CardType = "Skill", CardDescription = "This is a skill card.", CardImage = Image.FromFile("D_Leonan.png") };
        Card strongCard = new Card() { CardName = "Strength Card", CardType = "Strength", CardDescription = "This is a strong card.", CardImage = Image.FromFile("D_Metal.png") };
        Card spellCard = new Card() { CardName = "Spell Card", CardType = "Spell", CardDescription = "This is a spell card.", CardImage = Image.FromFile("D_Wizard.png") };

        List<CardCC> cardCCs;
        List<Card> possibleCards;
        Card drawnCard;

        // Buffs
        bool hasBossBuff = false;
        bool hasBuffHP = false;
        bool hasBuffBaseDamage = false;
        bool hasBuffRest = false;
        bool hasBuffDef = false;
        int buffHP = 0;
        int buffBaseDamage = 0;
        int buffRest = 0;
        int buffDef = 0;

        MainMenu menu;

        public GameForm(MainMenu main)
        {
            menu = main;
            InitializeComponent();
            EndCombat(); //clears combat indicators that exist for placeholder on design form.
            populatePlayerHand();

            Adventure.SetPath();
            lblEventName.Text = Adventure.Events[Adventure.CurrentPath].EventName;
            textEvent.Text = Adventure.Events[Adventure.CurrentPath].EventDescription;
            picEvent.Image = Adventure.Events[Adventure.CurrentPath].EventImage;
            lblEventType.Text = Adventure.Events[Adventure.CurrentPath].EventType;
            hasAction = true;
        }

        public void SetCurrentProfile(Profile profile)
        {
            CurrentProfile = profile;
        }

        public void UpdatePlayerInfo()
        {
            lblPlayerName.Text = CurrentProfile.Name; // Set player name to that of the current player
            barPlayerHP.Value = CurrentProfile.CurrentHealth; // Set initial value for Player's health bar
            lblBarPlayer.Text = CurrentProfile.CurrentHealth.ToString() + "/" + CurrentProfile.MaxHealth.ToString(); // Set inital value for player current health / max health

            Image avatarImage = Image.FromFile($@"Resources\{CurrentProfile.AvatarImageName}.png");

            picPlayer.Image = avatarImage;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            UpdatePlayerInfo();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.panelCreateProfile.Hide();
            menu.flowLayoutPanelDisplayProfiles.Show();
            MainMenu.selectedProfileControl = null;
            MainMenu.HandleProfileControlSelection();
            menu.Show();
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
            //UseCard("Spell");
        }

        private void debugSkill_Click(object sender, EventArgs e)
        {
            //UseCard("Skill");
        }

        private void debugStrength_Click(object sender, EventArgs e)
        {
            //UseCard("Strength");
        }

        //debug commands end

        private void Advance()
        {
            if (Adventure.CurrentPath == Adventure.Events.Count - 1)
            {
                MessageBox.Show("Congratulations, you won!!!");
                this.Hide();
                menu.Show();
            }

            hasAction = true;
            Adventure.DisplayEvents();

            if (Adventure.Events[Adventure.CurrentPath].EventName == "A Cosmic Ending") //the end scene is less random so it's customized here.
            {
                lblEventName.Text = Adventure.Events[Adventure.CurrentPath].EventName;
                textEvent.Text = "Placeholder Ending Scene Text";
                picEvent.Image = Adventure.Events[Adventure.CurrentPath].EventImage;
                lblEventType.Text = "End Game";

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
                int playerDmg = playerBaseDamage + buffBaseDamage + rnd.Next(1, 5);
                int creatureDmg = currentCreatureBaseDamage - buffDef + rnd.Next(1, 5);

                MessageBox.Show("You attacked " + lblCreatureName.Text + " for " + playerDmg + " and were attacked for " + creatureDmg + ".");

                CalculateDamage(playerDmg, creatureDmg);

            }

        }
        private void btnRest_Click(object sender, EventArgs e)
        {
            if (hasAction && lblEventType.Text != "Combat")
            {
                if (barPlayerHP.Value + 15 + buffRest >= 100 + buffHP) barPlayerHP.Value = 100 + buffHP;
                else barPlayerHP.Value += 15 + buffRest;
                MessageBox.Show("You rest and recover " + (15 + buffRest) + "HP.");
                hasAction = false;
                UpdateCombat();
                populatePlayerHand();
            }
            else if (lblEventType.Text == "Combat")
            {
                MessageBox.Show("You cannot rest during combat...");
            }
            else MessageBox.Show("You've already rested or investigated this area.");
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            string investigateHP = "You come across an elderly lady and are offered a warm bowl of soup. Do you accept?";
            string investigateRest = "You find a bush filled with tasty looking berries, stop and pick some?";
            string investigateDMG = "You come across a pile of unattended weapons, take one?";
            string investigateDEF = "You see an elderly looking man with a large pile of loot, try and take some for yourself?";

            List<string> investigations = new List<string>() { investigateHP, investigateRest, investigateDMG, investigateDEF };

            if (hasAction)
            {
                string currentBuff;
                bool buffCheck = true;
                while (buffCheck)
                {
                    currentBuff = investigations[rnd.Next(investigations.Count)];
                    if (hasBossBuff)
                    {
                        MessageBox.Show("What a beautiful view...", "Investigate", MessageBoxButtons.OK);
                        buffCheck = false;
                    }
                    else if (currentBuff == investigateHP && !hasBuffHP)
                    {
                        DialogResult dialogResult = MessageBox.Show(currentBuff, "Investigation", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            textPlayer.Text += "Health +50\n";
                            hasBuffHP = true;
                            buffHP = 50;
                            playerMaxHP += buffHP;
                            barPlayerHP.Maximum = playerMaxHP;
                            barPlayerHP.Value += buffHP;
                            MessageBox.Show("The soup is delicious! You feel yourself gaining stamina.", "Result", MessageBoxButtons.OK);
                            UpdateCombat();
                        }
                        else MessageBox.Show("You decide not to take any soup, after all, you have no idea who this lady is.", "Result", MessageBoxButtons.OK);
                        buffCheck = false;
                    }
                    else if (currentBuff == investigateRest && !hasBuffRest)
                    {
                        DialogResult dialogResult = MessageBox.Show(currentBuff, "Investigation", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.Yes)
                        {
                            textPlayer.Text += "Rest +15\n";
                            hasBuffRest = true;
                            buffRest = 15;
                            MessageBox.Show("You decided to pick some berries. These might come in handy later and will help when you need to rest!", "Result", MessageBoxButtons.OK);
                        }
                        else MessageBox.Show("You decide not to take any berries, after all, they could be poisonous!", "Result", MessageBoxButtons.OK);
                        buffCheck = false;
                    }
                    else if (currentBuff == investigateDMG && !hasBuffBaseDamage)
                    {
                        DialogResult dialogResult = MessageBox.Show(currentBuff, "Investigation", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.No)
                        {
                            textPlayer.Text += "Damage +5\n";
                            hasBuffBaseDamage = true;
                            buffBaseDamage = 5;
                            MessageBox.Show("You decide against taking any of the weapons as they may belong to someone. " +
                                "However as you are about to walk away you hear someone shout. " +
                                "'Ah, another adventurer! Here take a weapon! It should prove useful on your journey!'", "Result", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("As you reach down to get a weapon you feel something strike the back of your head. " +
                            "'THIEF! THIEF! GET AWAY FROM MY WEAPONS!' " +
                            "You are chased away and take 5 points of damage.", "Result", MessageBoxButtons.OK);

                            if (barPlayerHP.Value - 5 <= 0) barPlayerHP.Value = 0;
                            else barPlayerHP.Value -= 5;
                            UpdateCombat();
                        }
                        buffCheck = false;
                    }
                    else if (currentBuff == investigateDEF && !hasBuffDef)
                    {
                        DialogResult dialogResult = MessageBox.Show(currentBuff, "Investigation", MessageBoxButtons.YesNo);
                        if (dialogResult == DialogResult.No)
                        {
                            textPlayer.Text += "Defense +3\n";
                            hasBuffDef = true;
                            buffDef = 3;
                            MessageBox.Show("You decide against taking any of the loot, after all it doesn't belong to you. " +
                                "However as you are about to walk away you hear the old man say. " +
                                "'Ah, another adventurer! Here let me show you how you can defend yourself!'", "Result", MessageBoxButtons.OK);
                        }
                        else
                        {
                            MessageBox.Show("As you approach to take some loot the elderly man strikes your hand. " +
                            "'Bad idea my friend!' " +
                            "You are chased away and take 5 points of damage.", "Result", MessageBoxButtons.OK);

                            if (barPlayerHP.Value - 5 <= 0) barPlayerHP.Value = 0;
                            else barPlayerHP.Value -= 5;
                            UpdateCombat();
                        }
                        buffCheck = false;
                    }
                    else if (hasBuffHP && hasBuffRest && hasBuffBaseDamage && hasBuffDef)
                    {
                        MessageBox.Show("You discover some ancient texts and after taking some time to decipher them, you reveal an unknown weakness of a being called the great destroyer...", "Investigation", MessageBoxButtons.OK);
                        textPlayer.Text += "Unknown Secrets Revealed";
                        hasBossBuff = true;
                        buffCheck = false;
                    }
                }

                //MessageBox.Show("You investigate the area.");
                hasAction = false;
                //to expand upon.
            }
            else MessageBox.Show("You've already rested or investigated this area.");
        }

        private void UpdateCombat()
        {
            if (barCreatureHP.Value != 0) lblBarCreature.Text = barCreatureHP.Value.ToString() + "/" + currentCreatureMaxHP;
            else lblBarCreature.Text = "";
            lblBarPlayer.Text = barPlayerHP.Value.ToString() + "/" + playerMaxHP;

            if (barPlayerHP.Value == 0)
            {
                MessageBox.Show("Your hitpoints were reduced to zero, you lose.");
                this.Hide();
                menu.ShowDialog();
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
            lblBarCreature.Text = "";
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

        public void UseCard(string type, CardCC clickedCard)
        {
            if (lblEventType.Text == "Spell")
            {
                //MessageBox.Show("We're in the spell game now.");
                if (type == "Spell")
                {
                    MessageBox.Show(Result(false));
                }
                else if (type == "Skill")
                {
                    MessageBox.Show(Result(true));
                    Advance();
                }
                else if (type == "Strength")
                {
                    MessageBox.Show(Result(false));
                }
            }
            else if (lblEventType.Text == "Skill")
            {
                //MessageBox.Show("We're in the skill game now.");
                if (type == "Spell")
                {
                    MessageBox.Show(Result(false));
                }
                else if (type == "Skill")
                {
                    MessageBox.Show(Result(false));
                }
                else if (type == "Strength")
                {
                    MessageBox.Show(Result(true));
                    Advance();
                }
            }
            else if (lblEventType.Text == "Strength")
            {
                //MessageBox.Show("We're in the strength game now.");
                if (type == "Spell")
                {
                    MessageBox.Show(Result(true));
                    Advance();
                }
                else if (type == "Skill")
                {
                    MessageBox.Show(Result(false));
                }
                else if (type == "Strength")
                {
                    MessageBox.Show(Result(false));
                }
            }
            else if (lblEventType.Text == "Combat" || lblEventType.Text == "End Game")
            {
                //MessageBox.Show("We're in the end game now.");
                if (type == "Spell")//spellcasting!
                {
                    if (lblCreatureType.Text == "Wizard")
                    {
                        MessageBox.Show("You cast a spell at " + lblCreatureName.Text + ". Your foe puts effort and blocks your spell!");
                    }
                    else if (lblCreatureType.Text == "Rogue")
                    {
                        MessageBox.Show("You cast a spell at " + lblCreatureName.Text + ". The rogue seems laughs at you and sneak attacks for some damage.");
                        CalculateDamage(0, rnd.Next(4, 6) - buffDef);
                    }
                    else if (lblCreatureType.Text == "Warrior")
                    {
                        MessageBox.Show("You cast a spell at " + lblCreatureName.Text + ". The spell breaks the warrior's defense and deals heavy damage.");
                        CalculateDamage(playerBaseDamage + buffBaseDamage + rnd.Next(1, 11), 0);
                    }
                    else if (lblCreatureType.Text == "The End of All Things")
                    {
                        MessageBox.Show(lblCreatureName.Text + " is immune to your petty magic.");
                    }
                }
                else if (type == "Skill")//roguecasting!
                {
                    if (lblCreatureType.Text == "Wizard")
                    {
                        MessageBox.Show("You trick " + lblCreatureName.Text + ". Your foe is taken by surprise and takes heavy damage!");
                        CalculateDamage(playerBaseDamage + buffBaseDamage + rnd.Next(1, 11), 0);
                    }
                    else if (lblCreatureType.Text == "Rogue")
                    {
                        MessageBox.Show("It seems you and " + lblCreatureName.Text + " are evenly matched!");
                    }
                    else if (lblCreatureType.Text == "Warrior")
                    {
                        MessageBox.Show("You try to outclass " + lblCreatureName.Text + ". However, he is too much for you and fights back!");
                        CalculateDamage(0, rnd.Next(4, 6) - buffDef);
                    }
                    else if (lblCreatureType.Text == "The End of All Things")
                    {
                        MessageBox.Show(lblCreatureName.Text + " is immune to your coniving schemes.");
                    }
                }
                else if (type == "Strength")//wariorcasting!
                {
                    if (lblCreatureType.Text == "Wizard")
                    {
                        MessageBox.Show("How can steel best magic? " + lblCreatureName.Text + " turns your attack back at you!");
                        CalculateDamage(0, rnd.Next(4, 6) - buffDef);
                    }
                    else if (lblCreatureType.Text == "Rogue")
                    {
                        MessageBox.Show("Theatricality and deception. " + lblCreatureName.Text + " schemes are not match for you as you strike them down!");
                        CalculateDamage(playerBaseDamage + buffBaseDamage + rnd.Next(1, 11), 0);
                    }
                    else if (lblCreatureType.Text == "Warrior")
                    {
                        MessageBox.Show("You and " + lblCreatureName.Text + " lock eyes. You both know your might will not make right.");
                    }
                    else if (lblCreatureType.Text == "The End of All Things")
                    {
                        MessageBox.Show(lblCreatureName.Text + " ignores your might.");
                    }
                }
            }
            panelCard.Controls.Remove(clickedCard);
        }
        private void CalculateDamage(int playerDmg, int creatureDmg)
        {
            if (barCreatureHP.Value - playerDmg <= 0) barCreatureHP.Value = 0;
            else barCreatureHP.Value += -playerDmg;

            if (barPlayerHP.Value - creatureDmg <= 0) barPlayerHP.Value = 0;
            else barPlayerHP.Value += -creatureDmg;
            UpdateCombat();
        }
        // Populate the card panel section with cards
        private void btnPopulateCard_Click(object sender, EventArgs e)
        {
            barPlayerHP.Value -= 5;
            UpdateCombat();
            populatePlayerHand();
        }

        // For populating player hand
        private void populatePlayerHand()
        {
            if (lblEventType.Text == "Combat")
            {
                MessageBox.Show("Cannot get new hand while in combat...", "Rest", MessageBoxButtons.OK);
            }

            //Clear for refresh
            panelCard.Controls.Clear();

            //Create a list of possible cards
            possibleCards = new List<Card>() { skillCard, strongCard, spellCard };

            //Create our custom controls and add them to a list
            CardCC card1 = new CardCC(this);
            CardCC card2 = new CardCC(this);
            CardCC card3 = new CardCC(this);
            CardCC card4 = new CardCC(this);
            CardCC card5 = new CardCC(this);

            cardCCs = new List<CardCC>() { card1, card2, card3, card4, card5 };

            //For placement
            int xAxis = 0;

            //Assign values to our shown cards
            for (int i = 0; i < 5; i++)
            {
                drawnCard = possibleCards[rnd.Next(possibleCards.Count)];

                cardCCs[i].LabelName = drawnCard.CardName;
                cardCCs[i].CardType = drawnCard.CardType;
                cardCCs[i].LabelDesc = drawnCard.CardDescription;
                cardCCs[i].CardElement = drawnCard.CardImage;

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

        private void debugUse_Click(object sender, EventArgs e)
        {

        }
    }
}

