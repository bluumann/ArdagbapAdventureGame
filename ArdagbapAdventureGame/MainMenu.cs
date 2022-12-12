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
        GameForm gameForm;
        public MainMenu()
        {
            InitializeComponent();
            gameForm = new GameForm(this);
        }

        private void btnCreateProfile_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDisplayProfiles.Hide();
            groupBoxCreateProfile.Show();
        }

        private void btnStartNewAdventure_Click(object sender, EventArgs e)
        {
            this.Hide();
            gameForm.ShowDialog();
        }

        private void btnMenuContinue_Click(object sender, EventArgs e)
        {
            this.Hide();
            gameForm.ShowDialog();
        }

        private void btnMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            
        }
    }
}
