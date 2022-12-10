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
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblCreatureName = new System.Windows.Forms.Label();
            this.barCreatureHP = new System.Windows.Forms.ProgressBar();
            this.barPlayerHP = new System.Windows.Forms.ProgressBar();
            this.btnAttack = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCreature)).BeginInit();
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
            this.panelEvent.Location = new System.Drawing.Point(138, 12);
            this.panelEvent.Name = "panelEvent";
            this.panelEvent.Size = new System.Drawing.Size(808, 345);
            this.panelEvent.TabIndex = 1;
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
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(21, 414);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(90, 41);
            this.btnRest.TabIndex = 8;
            this.btnRest.Text = "Rest";
            this.btnRest.UseVisualStyleBackColor = true;
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
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
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
    }
}

