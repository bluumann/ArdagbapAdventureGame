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
        // Containing all "ProfileControl" instances of profiles created by the user
        public static List<ProfileControl> profileControlList = new List<ProfileControl>();

        // The currenlty selected ProfileControl
        public static ProfileControl selectedProfileControl;

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

        public static void HandleProfileControlSelection()
        {
            foreach (var pf in profileControlList)
            {
                if (pf != selectedProfileControl)
                {
                    pf.BackColor = Color.DarkGray;
                    // Set text color for all labels
                    pf.lblProfileNameText.ForeColor = SystemColors.ControlText;
                    pf.lblProfileGenderText.ForeColor = SystemColors.ControlText;
                    pf.lblProfileGoldText.ForeColor = SystemColors.ControlText;
                    pf.lblProfileCurrentAdText.ForeColor = SystemColors.ControlText;
                    pf.lblProfileAdLevelText.ForeColor = SystemColors.ControlText;

                    // Set text color for all values
                    pf.lblProfileName.ForeColor = SystemColors.ControlText;
                    pf.lblProfileGender.ForeColor = SystemColors.ControlText;
                    pf.lblProfileGold.ForeColor = SystemColors.ControlText;
                    pf.lblProfileCurrentAd.ForeColor = SystemColors.ControlText;
                    pf.lblProfileAdLevel.ForeColor = SystemColors.ControlText;
                }
            }
        }
    }
}
