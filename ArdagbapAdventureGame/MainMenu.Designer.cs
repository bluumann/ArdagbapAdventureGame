namespace ArdagbapAdventureGame
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnStartNewAdventure = new System.Windows.Forms.Button();
            this.btnMenuContinue = new System.Windows.Forms.Button();
            this.btnCreateProfile = new System.Windows.Forms.Button();
            this.btnMenuExit = new System.Windows.Forms.Button();
            this.flowLayoutPanelDisplayProfiles = new System.Windows.Forms.FlowLayoutPanel();
            this.profileControl1 = new ArdagbapAdventureGame.ProfileControl();
            this.profileControl2 = new ArdagbapAdventureGame.ProfileControl();
            this.profileControl3 = new ArdagbapAdventureGame.ProfileControl();
            this.groupBoxCreateProfile = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelDisplayProfiles.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartNewAdventure
            // 
            this.btnStartNewAdventure.Location = new System.Drawing.Point(98, 203);
            this.btnStartNewAdventure.Margin = new System.Windows.Forms.Padding(6);
            this.btnStartNewAdventure.Name = "btnStartNewAdventure";
            this.btnStartNewAdventure.Size = new System.Drawing.Size(198, 42);
            this.btnStartNewAdventure.TabIndex = 2;
            this.btnStartNewAdventure.Text = "Start New Adventure";
            this.btnStartNewAdventure.UseVisualStyleBackColor = true;
            this.btnStartNewAdventure.Click += new System.EventHandler(this.btnStartNewAdventure_Click);
            // 
            // btnMenuContinue
            // 
            this.btnMenuContinue.Location = new System.Drawing.Point(98, 257);
            this.btnMenuContinue.Margin = new System.Windows.Forms.Padding(6);
            this.btnMenuContinue.Name = "btnMenuContinue";
            this.btnMenuContinue.Size = new System.Drawing.Size(198, 42);
            this.btnMenuContinue.TabIndex = 3;
            this.btnMenuContinue.Text = "Continue";
            this.btnMenuContinue.UseVisualStyleBackColor = true;
            this.btnMenuContinue.Click += new System.EventHandler(this.btnMenuContinue_Click);
            // 
            // btnCreateProfile
            // 
            this.btnCreateProfile.Location = new System.Drawing.Point(98, 149);
            this.btnCreateProfile.Margin = new System.Windows.Forms.Padding(6);
            this.btnCreateProfile.Name = "btnCreateProfile";
            this.btnCreateProfile.Size = new System.Drawing.Size(198, 42);
            this.btnCreateProfile.TabIndex = 1;
            this.btnCreateProfile.Text = "Create Profile";
            this.btnCreateProfile.UseVisualStyleBackColor = true;
            this.btnCreateProfile.Click += new System.EventHandler(this.btnCreateProfile_Click);
            // 
            // btnMenuExit
            // 
            this.btnMenuExit.Location = new System.Drawing.Point(98, 311);
            this.btnMenuExit.Margin = new System.Windows.Forms.Padding(6);
            this.btnMenuExit.Name = "btnMenuExit";
            this.btnMenuExit.Size = new System.Drawing.Size(198, 42);
            this.btnMenuExit.TabIndex = 4;
            this.btnMenuExit.Text = "Exit";
            this.btnMenuExit.UseVisualStyleBackColor = true;
            this.btnMenuExit.Click += new System.EventHandler(this.btnMenuExit_Click);
            // 
            // flowLayoutPanelDisplayProfiles
            // 
            this.flowLayoutPanelDisplayProfiles.Controls.Add(this.profileControl1);
            this.flowLayoutPanelDisplayProfiles.Controls.Add(this.profileControl2);
            this.flowLayoutPanelDisplayProfiles.Controls.Add(this.profileControl3);
            this.flowLayoutPanelDisplayProfiles.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanelDisplayProfiles.Location = new System.Drawing.Point(707, 0);
            this.flowLayoutPanelDisplayProfiles.Name = "flowLayoutPanelDisplayProfiles";
            this.flowLayoutPanelDisplayProfiles.Size = new System.Drawing.Size(377, 561);
            this.flowLayoutPanelDisplayProfiles.TabIndex = 1;
            // 
            // profileControl1
            // 
            this.profileControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileControl1.Location = new System.Drawing.Point(6, 6);
            this.profileControl1.Margin = new System.Windows.Forms.Padding(6);
            this.profileControl1.Name = "profileControl1";
            this.profileControl1.Size = new System.Drawing.Size(363, 137);
            this.profileControl1.TabIndex = 0;
            this.profileControl1.TabStop = false;
            // 
            // profileControl2
            // 
            this.profileControl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileControl2.Location = new System.Drawing.Point(6, 155);
            this.profileControl2.Margin = new System.Windows.Forms.Padding(6);
            this.profileControl2.Name = "profileControl2";
            this.profileControl2.Size = new System.Drawing.Size(363, 137);
            this.profileControl2.TabIndex = 1;
            this.profileControl2.TabStop = false;
            // 
            // profileControl3
            // 
            this.profileControl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileControl3.Location = new System.Drawing.Point(6, 304);
            this.profileControl3.Margin = new System.Windows.Forms.Padding(6);
            this.profileControl3.Name = "profileControl3";
            this.profileControl3.Size = new System.Drawing.Size(363, 137);
            this.profileControl3.TabIndex = 2;
            this.profileControl3.TabStop = false;
            // 
            // groupBoxCreateProfile
            // 
            this.groupBoxCreateProfile.Location = new System.Drawing.Point(394, 23);
            this.groupBoxCreateProfile.Name = "groupBoxCreateProfile";
            this.groupBoxCreateProfile.Size = new System.Drawing.Size(656, 503);
            this.groupBoxCreateProfile.TabIndex = 5;
            this.groupBoxCreateProfile.TabStop = false;
            this.groupBoxCreateProfile.Text = "Create Profile";
            this.groupBoxCreateProfile.Visible = false;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.groupBoxCreateProfile);
            this.Controls.Add(this.flowLayoutPanelDisplayProfiles);
            this.Controls.Add(this.btnMenuExit);
            this.Controls.Add(this.btnMenuContinue);
            this.Controls.Add(this.btnCreateProfile);
            this.Controls.Add(this.btnStartNewAdventure);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.flowLayoutPanelDisplayProfiles.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStartNewAdventure;
        private System.Windows.Forms.Button btnMenuContinue;
        private System.Windows.Forms.Button btnCreateProfile;
        private System.Windows.Forms.Button btnMenuExit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelDisplayProfiles;
        private ProfileControl profileControl1;
        private ProfileControl profileControl2;
        private ProfileControl profileControl3;
        private System.Windows.Forms.GroupBox groupBoxCreateProfile;
    }
}