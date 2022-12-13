using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace ArdagbapAdventureGame
{
    public partial class MainMenu : Form
    {
        // Containing all "ProfileControl" instances of profiles created by the user
        public static List<ProfileControl> profileControlList = new List<ProfileControl>();

        // Containing all "Profile" instances of profiles created by the user
        List<Profile> profiles = new List<Profile>();

        // The currenlty selected ProfileControl
        public static ProfileControl selectedProfileControl;

        // Avatar selected
        public static string selectedAvatar;

        // List of all available avatars
        public List<PictureBox> pictureBoxeAvatars = new List<PictureBox>();

        private bool readyToPlay = false;

        GameForm gameForm;

        public MainMenu()
        {
            InitializeComponent();
            profileControlList.Clear();
            gameForm = new GameForm(this);
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // Fetch all existing profiles from the DB
            GetAllProfilesFromDB();
            RegisterAllAvatars();
        }

        private void btnStartNewAdventure_Click(object sender, EventArgs e)
        {
            flowLayoutPanelDisplayProfiles.Hide();
            panelCreateProfile.Show();
            checkBoxProfileMale.Checked = true;
            readyToPlay = false;

            if (btnCreateProfileCreate.Enabled == false)
            {
                btnCreateProfileCreate.Enabled = true;
            }
        }

        private void btnMenuContinue_Click(object sender, EventArgs e)
        {
            if (selectedProfileControl != null)
            {
                Profile profile = new Profile()
                {
                    Name = selectedProfileControl.ProfileName,
                    Gender = selectedProfileControl.ProfileGender,
                    CurrentHealth = selectedProfileControl.ProfileCurrentHealth,
                    MaxHealth = selectedProfileControl.ProfileMaxHealth,
                    Shielding = selectedProfileControl.ProfileShielding,
                    Gold = selectedProfileControl.ProfileGold,
                    Deck = selectedProfileControl.ProfileDeck,
                    AvailableCards = selectedProfileControl.ProfileAvailableCards,
                    CurrentAdventure = selectedProfileControl.ProfileCurrentAdventure,
                    AdventureLevel = selectedProfileControl.ProfileAdventureLevel,
                    AvatarImageName = selectedProfileControl.ProfileAvatarImageName,
                };

                gameForm.SetCurrentProfile(profile);
                gameForm.UpdatePlayerInfo();

                this.Hide();
                gameForm.Show();
            }
            else
            {
                MessageBox.Show("You haven't selected a profile yet.", "Select a Profile", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMenuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void checkBoxProfileMale_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxProfileFemale.Checked = !checkBoxProfileMale.Checked;
        }

        private void checkBoxProfileFemale_CheckedChanged(object sender, EventArgs e)
        {
            checkBoxProfileMale.Checked = !checkBoxProfileFemale.Checked;
        }

        private void btnCreateProfileExit_Click(object sender, EventArgs e)
        {
            panelCreateProfile.Hide();
            flowLayoutPanelDisplayProfiles.Show();
            textBoxProfileName.Text = string.Empty;
            checkBoxProfileMale.Checked = false;
            checkBoxProfileFemale.Checked = false;
            lblReadyToPlayText.Visible = false;
        }

        private void btnCreateProfileCreate_Click(object sender, EventArgs e)
        {
            if (textBoxProfileName.Text == "")
            {
                MessageBox.Show("You haven't entered a name yet.", "Enter a Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (selectedAvatar == null)
            {
                MessageBox.Show("You haven't selected an avatar yet.", "Select an Avatar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Profile created. Click 'Play Game' to start a new game.", "Success!", MessageBoxButtons.OK);

                string selectedGender = string.Empty;

                if (checkBoxProfileMale.Checked)
                {
                    selectedGender = "Male";
                }
                else
                {
                    selectedGender = "Female";
                }

                Profile newProfile = new Profile()
                {
                    Name = textBoxProfileName.Text,
                    Gender = selectedGender,
                    AvatarImageName = selectedAvatar,
                };

                Image avatarImage = Image.FromFile($@"Resources\{selectedAvatar}.png");

                ProfileControl profileControl = new ProfileControl()
                {
                    ProfileName = newProfile.Name,
                    ProfileGender = newProfile.Gender,
                    ProfileCurrentHealth = newProfile.CurrentHealth,
                    ProfileMaxHealth = newProfile.MaxHealth,
                    ProfileShielding = newProfile.Shielding,
                    ProfileGold = newProfile.Gold,
                    ProfileDeck = newProfile.Deck,
                    ProfileAvailableCards = newProfile.AvailableCards,
                    ProfileCurrentAdventure = newProfile.CurrentAdventure,
                    ProfileAdventureLevel = newProfile.AdventureLevel,
                    ProfileAvatarImageName = newProfile.AvatarImageName,
                    ProfileAvatar = avatarImage,
                };

                selectedProfileControl = profileControl;

                profileControlList.Add(profileControl);
                gameForm.SetCurrentProfile(newProfile);

                foreach (var pc in profileControlList)
                {
                    flowLayoutPanelDisplayProfiles.Controls.Add(pc);
                }

                SaveProfileToDB(newProfile, selectedGender, selectedAvatar);
                readyToPlay = true;
                textBoxProfileName.Text = "";
                btnCreateProfileCreate.Enabled = false;

                if (readyToPlay)
                {
                    lblReadyToPlayText.Visible = false;
                }
            }
        }

        private void GetAllProfilesFromDB()
        {
            // Create the connection.
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                // Create a SqlCommand, and identify it as a stored procedure.
                using (SqlDataAdapter profileDataAdapter = new SqlDataAdapter("SELECT * FROM Profiles", connection))
                {

                    DataTable profileData = new DataTable();

                    try
                    {
                        connection.Open();
                        profileDataAdapter.Fill(profileData);

                        profileData.DefaultView.Sort = "Id";
                        profileData = profileData.DefaultView.ToTable();
                        for (int row = 0; row < profileData.Rows.Count; row++)
                        {
                            int profileId = (int)profileData.Rows[row]["Id"];
                            string profileName = profileData.Rows[row]["Name"].ToString();
                            string profileGender = profileData.Rows[row]["Gender"].ToString();
                            int profileCurrentHealth = (int)profileData.Rows[row]["CurrentHealth"];
                            int profileMaxHealth = (int)profileData.Rows[row]["MaxHealth"];
                            int profileShielding = (int)profileData.Rows[row]["Shielding"];
                            int profileGold = (int)profileData.Rows[row]["Gold"];
                            int profileDeck = (int)profileData.Rows[row]["Deck"];
                            int profileAvailableCards = (int)profileData.Rows[row]["AvailableCards"];
                            int profileCurrentAdventure = (int)profileData.Rows[row]["CurrentAdventure"];
                            int profileAdventureLevel = (int)profileData.Rows[row]["AdventureLevel"];
                            string profileAvatarImageName = profileData.Rows[row]["Avatar"].ToString();


                            Profile profile = new Profile()
                            {
                                Id = profileId,
                                Name = profileName,
                                Gender = profileGender,
                                CurrentHealth = profileCurrentHealth,
                                MaxHealth = profileMaxHealth,
                                Shielding = profileShielding,
                                Gold = profileGold,
                                Deck = profileDeck,
                                AvailableCards = profileAvailableCards,
                                CurrentAdventure = profileCurrentAdventure,
                                AdventureLevel = profileAdventureLevel,
                                AvatarImageName = profileAvatarImageName,
                            };

                            profiles.Add(profile);

                          
                            Image avatarImage = Image.FromFile($@"Resources\{profileAvatarImageName}.png");

                            ProfileControl profileControl = new ProfileControl()
                            {
                                ProfileName = profileName,
                                ProfileGender = profileGender,
                                ProfileCurrentHealth = profileCurrentHealth,
                                ProfileMaxHealth = profileMaxHealth,
                                ProfileShielding = profileShielding,
                                ProfileGold = profileGold,
                                ProfileDeck = profileDeck,
                                ProfileAvailableCards = profileAvailableCards,
                                ProfileCurrentAdventure = profileCurrentAdventure,
                                ProfileAdventureLevel = profileAdventureLevel,
                                ProfileAvatarImageName = profileAvatarImageName,
                                ProfileAvatar = avatarImage,
                            };

                            profileControlList.Add(profileControl);
                        }

                    }
                    catch
                    {
                        MessageBox.Show("Customer ID was not returned. Account could not be created.");
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
            }

            foreach (var pc in profileControlList)
            {
                flowLayoutPanelDisplayProfiles.Controls.Add(pc);
            }
        }

        private void SaveProfileToDB(Profile profile, string selectedGender, string selectedAvatarName)
        {
            // Create the connection.
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.connString))
            {
                SqlCommand command = new SqlCommand("INSERT INTO Profiles VALUES('"+textBoxProfileName.Text+"','"+selectedGender+"',"+100+","+100+","+0+","+0+","+0+","+0+","+0+","+0+",'"+selectedAvatarName+ "')", connection);  

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                //MessageBox.Show("Profile saved!");
            }
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

        private void btnPlayNewGame_Click(object sender, EventArgs e)
        {
            if (!readyToPlay)
            {
                lblReadyToPlayText.Visible = true;
            }
            else
            {
                //gameForm.SetCurrentProfile(profile);
                gameForm.UpdatePlayerInfo();

                this.Hide();
                gameForm.Show();
            }
        }

        private void RegisterAllAvatars()
        {
            pictureBoxeAvatars.Add(pictureBoxMale1);
            pictureBoxeAvatars.Add(pictureBoxMale2);
            pictureBoxeAvatars.Add(pictureBoxMale3);
            pictureBoxeAvatars.Add(pictureBoxMale4);
            pictureBoxeAvatars.Add(pictureBoxFemale1);
            pictureBoxeAvatars.Add(pictureBoxFemale2);
            pictureBoxeAvatars.Add(pictureBoxFemale3);
            pictureBoxeAvatars.Add(pictureBoxFemale4);
        }

        private void pictureBoxAvatar_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox selectedAvatar = (PictureBox)sender;
            MainMenu.selectedAvatar = selectedAvatar.Tag.ToString();
            selectedAvatar.BorderStyle = BorderStyle.Fixed3D;

            foreach (var avatarPB in pictureBoxeAvatars)
            {
                if (!(selectedAvatar == avatarPB))
                {
                    avatarPB.BorderStyle = BorderStyle.None;
                }
            }
        }
    }
}
