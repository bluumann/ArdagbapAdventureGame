using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArdagbapAdventureGame
{
    public partial class ProfileControl : UserControl
    {
        public ProfileControl()
        {
            InitializeComponent();
        }

        private string _profileName;
        private string _profileGender;
        private int _profileCurrentHealth;
        private int _profileMaxHealth;
        private int _profileShielding;
        private int _profileGold;
        private int _profileDeck;
        private int _profileAvailableCards;
        private int _profileCurrentAdventure;
        private int _profileAdventureLevel;
        private string _profileAvatarImageName;
        private Image _profileAvatar;

        public string ProfileName
        {
            get { return _profileName; }
            set { _profileName = value; lblProfileName.Text = value; }
        }

        public string ProfileGender
        {
            get { return _profileGender; }
            set { _profileGender = value; lblProfileGender.Text = value; }
        }

        public int ProfileCurrentHealth
        {
            get { return _profileCurrentHealth; }
            set { _profileCurrentHealth = value; }
        }

        public int ProfileMaxHealth
        {
            get { return _profileMaxHealth; }
            set { _profileMaxHealth = value; }
        }

        public int ProfileShielding
        {
            get { return _profileShielding; }
            set { _profileShielding = value; }
        }

        public int ProfileGold
        {
            get { return _profileGold; }
            set { _profileGold = value; lblProfileGold.Text = value.ToString(); }
        }

        public int ProfileDeck
        {
            get { return _profileDeck; }
            set { _profileDeck = value; }
        }

        public int ProfileAvailableCards
        {
            get { return _profileAvailableCards; }
            set { _profileAvailableCards = value; }
        }

        public int ProfileCurrentAdventure
        {
            get { return _profileCurrentAdventure; }
            set { _profileCurrentAdventure = value; lblProfileCurrentAd.Text = value.ToString(); }
        }

        public int ProfileAdventureLevel
        {
            get { return _profileAdventureLevel; }
            set { _profileAdventureLevel = value; lblProfileAdLevel.Text = value.ToString(); }
        }

        public string ProfileAvatarImageName
        {
            get { return _profileAvatarImageName; }
            set { _profileAvatarImageName = value; }
        }

        public Image ProfileAvatar
        {
            get { return _profileAvatar; }
            set { _profileAvatar = value; pictureBoxAvatar.Image = value; }
        }

        private void ProfileControl_MouseClick(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Black;

            // Set text color for all labels
            this.lblProfileNameText.ForeColor = Color.NavajoWhite;
            this.lblProfileGenderText.ForeColor = Color.NavajoWhite;
            this.lblProfileGoldText.ForeColor = Color.NavajoWhite;
            this.lblProfileCurrentAdText.ForeColor = Color.NavajoWhite;
            this.lblProfileAdLevelText.ForeColor = Color.NavajoWhite;

            // Set text color for all values
            this.lblProfileName.ForeColor = Color.NavajoWhite;
            this.lblProfileGender.ForeColor = Color.NavajoWhite;
            this.lblProfileGold.ForeColor = Color.NavajoWhite;
            this.lblProfileCurrentAd.ForeColor = Color.NavajoWhite;
            this.lblProfileAdLevel.ForeColor = Color.NavajoWhite;

            MainMenu.selectedProfileControl = this;
            MainMenu.HandleProfileControlSelection();
        }

        private void btnDeleteProfileControl_Click(object sender, EventArgs e)
        {
            string profileName = this.ProfileName;

            // Create the connection.
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                SqlCommand command = new SqlCommand("DELETE FROM Profiles WHERE Name='" + profileName + "'", connection);

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                //MessageBox.Show("Profile deleted!");
                this.Hide();
            }
        }
    }
}
