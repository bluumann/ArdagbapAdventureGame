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

        private void btnPopulateCard_Click(object sender, EventArgs e)
        {

        }
    }
}
