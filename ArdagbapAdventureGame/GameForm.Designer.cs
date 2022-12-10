namespace ArdagbapAdventureGame
{
    partial class GameForm
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
            this.panelCard = new System.Windows.Forms.Panel();
            this.picPlayer = new System.Windows.Forms.PictureBox();
            this.picCreature = new System.Windows.Forms.PictureBox();
            this.panelEvent = new System.Windows.Forms.Panel();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblCreatureName = new System.Windows.Forms.Label();
            this.barCreatureHP = new System.Windows.Forms.ProgressBar();
            this.barPlayerHP = new System.Windows.Forms.ProgressBar();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.debugStart = new System.Windows.Forms.Button();
            this.debugContinue = new System.Windows.Forms.Button();
            this.picEvent = new System.Windows.Forms.PictureBox();
            this.lblEventType = new System.Windows.Forms.Label();
            this.textEvent = new System.Windows.Forms.RichTextBox();
            this.debugSpell = new System.Windows.Forms.Button();
            this.debugSkill = new System.Windows.Forms.Button();
            this.debugStrength = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCreature)).BeginInit();
            this.panelEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEvent)).BeginInit();
            this.SuspendLayout();
            // 
            // panelCard
            // 
            this.panelCard.Location = new System.Drawing.Point(329, 363);
            this.panelCard.Name = "panelCard";
            this.panelCard.Size = new System.Drawing.Size(743, 186);
            this.panelCard.TabIndex = 0;
            // 
            // picPlayer
            // 
            this.picPlayer.Location = new System.Drawing.Point(12, 40);
            this.picPlayer.Name = "picPlayer";
            this.picPlayer.Size = new System.Drawing.Size(120, 120);
            this.picPlayer.TabIndex = 1;
            this.picPlayer.TabStop = false;
            // 
            // picCreature
            // 
            this.picCreature.Location = new System.Drawing.Point(952, 40);
            this.picCreature.Name = "picCreature";
            this.picCreature.Size = new System.Drawing.Size(120, 120);
            this.picCreature.TabIndex = 2;
            this.picCreature.TabStop = false;
            // 
            // panelEvent
            // 
            this.panelEvent.Controls.Add(this.textEvent);
            this.panelEvent.Controls.Add(this.lblEventType);
            this.panelEvent.Controls.Add(this.picEvent);
            this.panelEvent.Controls.Add(this.lblEventName);
            this.panelEvent.Location = new System.Drawing.Point(138, 12);
            this.panelEvent.Name = "panelEvent";
            this.panelEvent.Size = new System.Drawing.Size(808, 345);
            this.panelEvent.TabIndex = 1;
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(29, 12);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(66, 13);
            this.lblEventName.TabIndex = 13;
            this.lblEventName.Text = "Event Name";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(18, 24);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(67, 13);
            this.lblPlayerName.TabIndex = 3;
            this.lblPlayerName.Text = "Player Name";
            // 
            // lblCreatureName
            // 
            this.lblCreatureName.AutoSize = true;
            this.lblCreatureName.Location = new System.Drawing.Point(959, 24);
            this.lblCreatureName.Name = "lblCreatureName";
            this.lblCreatureName.Size = new System.Drawing.Size(78, 13);
            this.lblCreatureName.TabIndex = 4;
            this.lblCreatureName.Text = "Creature Name";
            // 
            // barCreatureHP
            // 
            this.barCreatureHP.Location = new System.Drawing.Point(962, 166);
            this.barCreatureHP.Name = "barCreatureHP";
            this.barCreatureHP.Size = new System.Drawing.Size(100, 23);
            this.barCreatureHP.TabIndex = 5;
            this.barCreatureHP.Value = 50;
            // 
            // barPlayerHP
            // 
            this.barPlayerHP.Location = new System.Drawing.Point(21, 166);
            this.barPlayerHP.Name = "barPlayerHP";
            this.barPlayerHP.Size = new System.Drawing.Size(100, 23);
            this.barPlayerHP.TabIndex = 6;
            this.barPlayerHP.Value = 50;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(21, 367);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(90, 41);
            this.btnAttack.TabIndex = 7;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(21, 414);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(90, 41);
            this.btnRest.TabIndex = 8;
            this.btnRest.Text = "Rest";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(21, 461);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(90, 41);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(21, 508);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(90, 41);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Exit and Save";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // debugStart
            // 
            this.debugStart.Location = new System.Drawing.Point(170, 367);
            this.debugStart.Name = "debugStart";
            this.debugStart.Size = new System.Drawing.Size(90, 41);
            this.debugStart.TabIndex = 11;
            this.debugStart.Text = "Debug Start";
            this.debugStart.UseVisualStyleBackColor = true;
            this.debugStart.Click += new System.EventHandler(this.debugStart_Click);
            // 
            // debugContinue
            // 
            this.debugContinue.Location = new System.Drawing.Point(170, 414);
            this.debugContinue.Name = "debugContinue";
            this.debugContinue.Size = new System.Drawing.Size(90, 41);
            this.debugContinue.TabIndex = 12;
            this.debugContinue.Text = "Debug Continue";
            this.debugContinue.UseVisualStyleBackColor = true;
            this.debugContinue.Click += new System.EventHandler(this.debugContinue_Click);
            // 
            // picEvent
            // 
            this.picEvent.Location = new System.Drawing.Point(22, 28);
            this.picEvent.Name = "picEvent";
            this.picEvent.Size = new System.Drawing.Size(631, 186);
            this.picEvent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picEvent.TabIndex = 14;
            this.picEvent.TabStop = false;
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(697, 44);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(62, 13);
            this.lblEventType.TabIndex = 15;
            this.lblEventType.Text = "Event Type";
            // 
            // textEvent
            // 
            this.textEvent.Location = new System.Drawing.Point(22, 220);
            this.textEvent.Name = "textEvent";
            this.textEvent.ReadOnly = true;
            this.textEvent.Size = new System.Drawing.Size(768, 111);
            this.textEvent.TabIndex = 16;
            this.textEvent.Text = "";
            // 
            // debugSpell
            // 
            this.debugSpell.Location = new System.Drawing.Point(138, 472);
            this.debugSpell.Name = "debugSpell";
            this.debugSpell.Size = new System.Drawing.Size(48, 41);
            this.debugSpell.TabIndex = 13;
            this.debugSpell.Text = "Debug Spell";
            this.debugSpell.UseVisualStyleBackColor = true;
            this.debugSpell.Click += new System.EventHandler(this.debugSpell_Click);
            // 
            // debugSkill
            // 
            this.debugSkill.Location = new System.Drawing.Point(192, 472);
            this.debugSkill.Name = "debugSkill";
            this.debugSkill.Size = new System.Drawing.Size(48, 41);
            this.debugSkill.TabIndex = 14;
            this.debugSkill.Text = "Debug Skill";
            this.debugSkill.UseVisualStyleBackColor = true;
            this.debugSkill.Click += new System.EventHandler(this.debugSkill_Click);
            // 
            // debugStrength
            // 
            this.debugStrength.Location = new System.Drawing.Point(246, 472);
            this.debugStrength.Name = "debugStrength";
            this.debugStrength.Size = new System.Drawing.Size(48, 41);
            this.debugStrength.TabIndex = 15;
            this.debugStrength.Text = "Debug Strong";
            this.debugStrength.UseVisualStyleBackColor = true;
            this.debugStrength.Click += new System.EventHandler(this.debugStrength_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.debugStrength);
            this.Controls.Add(this.debugSkill);
            this.Controls.Add(this.debugSpell);
            this.Controls.Add(this.debugContinue);
            this.Controls.Add(this.debugStart);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.barPlayerHP);
            this.Controls.Add(this.barCreatureHP);
            this.Controls.Add(this.lblCreatureName);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.panelEvent);
            this.Controls.Add(this.picCreature);
            this.Controls.Add(this.picPlayer);
            this.Controls.Add(this.panelCard);
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCreature)).EndInit();
            this.panelEvent.ResumeLayout(false);
            this.panelEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picEvent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelCard;
        private System.Windows.Forms.PictureBox picPlayer;
        private System.Windows.Forms.PictureBox picCreature;
        private System.Windows.Forms.Panel panelEvent;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblCreatureName;
        private System.Windows.Forms.ProgressBar barCreatureHP;
        private System.Windows.Forms.ProgressBar barPlayerHP;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnRest;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button debugStart;
        private System.Windows.Forms.Button debugContinue;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.RichTextBox textEvent;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.PictureBox picEvent;
        private System.Windows.Forms.Button debugSpell;
        private System.Windows.Forms.Button debugSkill;
        private System.Windows.Forms.Button debugStrength;
    }
}

