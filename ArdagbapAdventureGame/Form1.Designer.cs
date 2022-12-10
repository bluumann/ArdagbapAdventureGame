namespace ArdagbapAdventureGame
{
    partial class Form1
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
            this.panelEvent = new System.Windows.Forms.Panel();
            this.picturePlayer = new System.Windows.Forms.PictureBox();
            this.pictureCreature = new System.Windows.Forms.PictureBox();
            this.panelCards = new System.Windows.Forms.Panel();
            this.playerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCreature)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEvent
            // 
            this.panelEvent.Location = new System.Drawing.Point(138, 31);
            this.panelEvent.Name = "panelEvent";
            this.panelEvent.Size = new System.Drawing.Size(808, 317);
            this.panelEvent.TabIndex = 0;
            // 
            // picturePlayer
            // 
            this.picturePlayer.Location = new System.Drawing.Point(12, 12);
            this.picturePlayer.Name = "picturePlayer";
            this.picturePlayer.Size = new System.Drawing.Size(120, 120);
            this.picturePlayer.TabIndex = 1;
            this.picturePlayer.TabStop = false;
            // 
            // pictureCreature
            // 
            this.pictureCreature.Location = new System.Drawing.Point(952, 12);
            this.pictureCreature.Name = "pictureCreature";
            this.pictureCreature.Size = new System.Drawing.Size(120, 120);
            this.pictureCreature.TabIndex = 2;
            this.pictureCreature.TabStop = false;
            // 
            // panelCards
            // 
            this.panelCards.Location = new System.Drawing.Point(329, 374);
            this.panelCards.Name = "panelCards";
            this.panelCards.Size = new System.Drawing.Size(743, 175);
            this.panelCards.TabIndex = 1;
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.Location = new System.Drawing.Point(12, 144);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(64, 13);
            this.playerName.TabIndex = 3;
            this.playerName.Text = "PlayerName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PlayerName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.panelCards);
            this.Controls.Add(this.pictureCreature);
            this.Controls.Add(this.picturePlayer);
            this.Controls.Add(this.panelEvent);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picturePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCreature)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelEvent;
        private System.Windows.Forms.PictureBox picturePlayer;
        private System.Windows.Forms.PictureBox pictureCreature;
        private System.Windows.Forms.Panel panelCards;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.Label label1;
    }
}

