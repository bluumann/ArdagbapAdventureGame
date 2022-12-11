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
        

        public GameForm()
        {
            InitializeComponent();
            lblBarCreature.Text = ""; //just to remove the numbers (placeholder for design).
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            this.Hide();
            mainMenu.ShowDialog();
            this.Close();
        }

        private void debugStart_Click(object sender, EventArgs e)
        {
            Adventure.SetPath();
            lblEventName.Text = Adventure.Events[Adventure.CurrentPath].EventName;
            textEvent.Text = Adventure.Events[Adventure.CurrentPath].EventDescription;
            picEvent.Image = Adventure.Events[Adventure.CurrentPath].EventImage;
            lblEventType.Text = Adventure.Events[Adventure.CurrentPath].EventType;
        }

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

            Adventure.DisplayEvents();

            if(Adventure.Events[Adventure.CurrentPath] is CreatureCombat)
            {
                lblEventName.Text = Adventure.Events[Adventure.CurrentPath].EventName;
                textEvent.Text = Adventure.Events[Adventure.CurrentPath].EventDescription;
                picEvent.Image = Adventure.Events[Adventure.CurrentPath].EventImage;
                lblEventType.Text = Adventure.Events[Adventure.CurrentPath].EventType;

                CreatureCombat current = (CreatureCombat)Adventure.Events[Adventure.CurrentPath];

                lblCreatureName.Text = Adventure.Names[Adventure.ReceiveRandom(Adventure.Names.Count)];
                barCreatureHP.Value = current.CreatureMaxHealth;
                picCreature.Image = current.CreatureImage;

                UpdateCombat();
            }
            if (Adventure.Events[Adventure.CurrentPath] is DialogEncounter)
            {
                lblEventName.Text = Adventure.Events[Adventure.CurrentPath].EventName;
                textEvent.Text = Adventure.Events[Adventure.CurrentPath].EventDescription;
                picEvent.Image = Adventure.Events[Adventure.CurrentPath].EventImage;
                lblEventType.Text = Adventure.Events[Adventure.CurrentPath].EventType;
            }



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
        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (barCreatureHP.Value == 0) MessageBox.Show("Nothing to Attack!");
            else
            {
                Random rnd = new Random();

                int playerDmg = rnd.Next(1,15);
                int creatureDmg = rnd.Next(1,15);

                MessageBox.Show("You attacked " + lblCreatureName.Text + " for " + playerDmg + " and was attacked for " + creatureDmg + ".");

                if (barCreatureHP.Value - playerDmg <= 0) barCreatureHP.Value = 0;
                else barCreatureHP.Value += -playerDmg;

                if (barPlayerHP.Value - creatureDmg <= 0) barPlayerHP.Value = 0;
                else barPlayerHP.Value += -creatureDmg;
                UpdateCombat();
            }
          
        }
        private void btnRest_Click(object sender, EventArgs e)
        {
            if (barPlayerHP.Value + 10 >= 100) barPlayerHP.Value = 100;
            else barPlayerHP.Value += 10;
            UpdateCombat();
        }

        private void UpdateCombat()
        {
            lblBarCreature.Text = barCreatureHP.Value.ToString() + "/" + 100;
            lblBarPlayer.Text = barPlayerHP.Value.ToString() + "/" + 100;

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
                lblCreatureName.Text = "No Combat";
                lblBarCreature.Text = "";
                picCreature.Image = null;
                Advance();
            }
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

    }
}
