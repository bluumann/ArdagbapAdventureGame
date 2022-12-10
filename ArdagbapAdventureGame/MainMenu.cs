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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDisplayProfiles.Hide();
            groupBoxCreateProfile.Show();
        }

        private void btnStartNewAdventure_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            this.Hide();
            gameForm.ShowDialog();
            this.Close();
        }

        private void btnMenuContinue_Click(object sender, EventArgs e)
        {
            GameForm gameForm = new GameForm();
            this.Hide();
            gameForm.ShowDialog();
            this.Close();
        }

        private void btnMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
