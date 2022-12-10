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
        Event currentEvent;
        Adventure Adventure = new Adventure();

        public GameForm()
        {
            InitializeComponent();
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
            Adventure.DisplayEvents();
            lblEventName.Text = Adventure.Events[Adventure.CurrentPath].EventName;
            textEvent.Text = Adventure.Events[Adventure.CurrentPath].EventDescription;
            picEvent.Image = Adventure.Events[Adventure.CurrentPath].EventImage;
            lblEventType.Text = Adventure.Events[Adventure.CurrentPath].EventType;
        }

        private void debugContinue_Click(object sender, EventArgs e)
        {
            Advance();
        }

        private void debugSpell_Click(object sender, EventArgs e)
        {
            if (Adventure.Events[Adventure.CurrentPath].EventType == "Strength")
            {
                MessageBox.Show("Success!");
                Advance();
            }
            else
            {
                MessageBox.Show("Seu merda, vc errou!");
            }
        }

        private void debugSkill_Click(object sender, EventArgs e)
        {
            if (Adventure.Events[Adventure.CurrentPath].EventType == "Spell")
            {
                MessageBox.Show("Success!");
                Advance();
            }
            else
            {
                MessageBox.Show("Seu mojo não está funcionando!");
            }
        }

        private void debugStrength_Click(object sender, EventArgs e)
        {
            if (Adventure.Events[Adventure.CurrentPath].EventType == "Skill")
            {
                MessageBox.Show("Success!");
                Advance();
            }
            else
            {
                MessageBox.Show("Não consegue, né Moisés?");
            }
        }

        private void btnRest_Click(object sender, EventArgs e)
        {
            if (barPlayerHP.Value + 10 >= 100) barPlayerHP.Value = 100;
            else barPlayerHP.Value += 10;
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            if (barCreatureHP.Value - 10 <= 0) barCreatureHP.Value = 0;
            else barCreatureHP.Value += -10;
        }
    }
}
