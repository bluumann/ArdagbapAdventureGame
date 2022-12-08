namespace StoryGenerator
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
            this.btnCreate = new System.Windows.Forms.Button();
            this.lbn_Story = new System.Windows.Forms.Label();
            this.btn_Attack = new System.Windows.Forms.Button();
            this.btn_Defend = new System.Windows.Forms.Button();
            this.btn_Run = new System.Windows.Forms.Button();
            this.lbn_Creature = new System.Windows.Forms.Label();
            this.playerHp = new System.Windows.Forms.ProgressBar();
            this.creatureHp = new System.Windows.Forms.ProgressBar();
            this.lbn_Turn = new System.Windows.Forms.Label();
            this.btn_Solve = new System.Windows.Forms.Button();
            this.lbn_Points = new System.Windows.Forms.Label();
            this.lbn_PointScore = new System.Windows.Forms.Label();
            this.creaturePic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.creaturePic)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(12, 12);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create Story";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // lbn_Story
            // 
            this.lbn_Story.AutoSize = true;
            this.lbn_Story.Location = new System.Drawing.Point(12, 73);
            this.lbn_Story.Name = "lbn_Story";
            this.lbn_Story.Size = new System.Drawing.Size(90, 13);
            this.lbn_Story.TabIndex = 1;
            this.lbn_Story.Text = "Story will go here.";
            // 
            // btn_Attack
            // 
            this.btn_Attack.Location = new System.Drawing.Point(114, 372);
            this.btn_Attack.Name = "btn_Attack";
            this.btn_Attack.Size = new System.Drawing.Size(75, 23);
            this.btn_Attack.TabIndex = 2;
            this.btn_Attack.Text = "Attack";
            this.btn_Attack.UseVisualStyleBackColor = true;
            this.btn_Attack.Click += new System.EventHandler(this.btn_Attack_Click);
            // 
            // btn_Defend
            // 
            this.btn_Defend.Location = new System.Drawing.Point(195, 372);
            this.btn_Defend.Name = "btn_Defend";
            this.btn_Defend.Size = new System.Drawing.Size(75, 23);
            this.btn_Defend.TabIndex = 3;
            this.btn_Defend.Text = "Defend";
            this.btn_Defend.UseVisualStyleBackColor = true;
            this.btn_Defend.Click += new System.EventHandler(this.btn_Defend_Click);
            // 
            // btn_Run
            // 
            this.btn_Run.Location = new System.Drawing.Point(276, 372);
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(75, 23);
            this.btn_Run.TabIndex = 4;
            this.btn_Run.Text = "Run";
            this.btn_Run.UseVisualStyleBackColor = true;
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // lbn_Creature
            // 
            this.lbn_Creature.AutoSize = true;
            this.lbn_Creature.Location = new System.Drawing.Point(604, 130);
            this.lbn_Creature.Name = "lbn_Creature";
            this.lbn_Creature.Size = new System.Drawing.Size(106, 13);
            this.lbn_Creature.TabIndex = 5;
            this.lbn_Creature.Text = "Creature will go here.";
            // 
            // playerHp
            // 
            this.playerHp.Location = new System.Drawing.Point(114, 401);
            this.playerHp.Name = "playerHp";
            this.playerHp.Size = new System.Drawing.Size(100, 23);
            this.playerHp.TabIndex = 6;
            this.playerHp.Value = 50;
            // 
            // creatureHp
            // 
            this.creatureHp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.creatureHp.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.creatureHp.Location = new System.Drawing.Point(607, 155);
            this.creatureHp.Name = "creatureHp";
            this.creatureHp.Size = new System.Drawing.Size(100, 23);
            this.creatureHp.TabIndex = 7;
            this.creatureHp.Value = 50;
            // 
            // lbn_Turn
            // 
            this.lbn_Turn.AutoSize = true;
            this.lbn_Turn.Location = new System.Drawing.Point(111, 346);
            this.lbn_Turn.Name = "lbn_Turn";
            this.lbn_Turn.Size = new System.Drawing.Size(88, 13);
            this.lbn_Turn.TabIndex = 8;
            this.lbn_Turn.Text = "Turn will go here.";
            // 
            // btn_Solve
            // 
            this.btn_Solve.Location = new System.Drawing.Point(357, 372);
            this.btn_Solve.Name = "btn_Solve";
            this.btn_Solve.Size = new System.Drawing.Size(75, 23);
            this.btn_Solve.TabIndex = 9;
            this.btn_Solve.Text = "Investigate";
            this.btn_Solve.UseVisualStyleBackColor = true;
            this.btn_Solve.Click += new System.EventHandler(this.btn_Solve_Click);
            // 
            // lbn_Points
            // 
            this.lbn_Points.AutoSize = true;
            this.lbn_Points.Location = new System.Drawing.Point(13, 388);
            this.lbn_Points.Name = "lbn_Points";
            this.lbn_Points.Size = new System.Drawing.Size(36, 13);
            this.lbn_Points.TabIndex = 10;
            this.lbn_Points.Text = "Points";
            // 
            // lbn_PointScore
            // 
            this.lbn_PointScore.AutoSize = true;
            this.lbn_PointScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbn_PointScore.Location = new System.Drawing.Point(19, 410);
            this.lbn_PointScore.Name = "lbn_PointScore";
            this.lbn_PointScore.Size = new System.Drawing.Size(25, 25);
            this.lbn_PointScore.TabIndex = 11;
            this.lbn_PointScore.Text = "0";
            // 
            // creaturePic
            // 
            this.creaturePic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.creaturePic.Location = new System.Drawing.Point(513, 198);
            this.creaturePic.Name = "creaturePic";
            this.creaturePic.Size = new System.Drawing.Size(275, 240);
            this.creaturePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.creaturePic.TabIndex = 12;
            this.creaturePic.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.creaturePic);
            this.Controls.Add(this.lbn_PointScore);
            this.Controls.Add(this.lbn_Points);
            this.Controls.Add(this.btn_Solve);
            this.Controls.Add(this.lbn_Turn);
            this.Controls.Add(this.creatureHp);
            this.Controls.Add(this.playerHp);
            this.Controls.Add(this.lbn_Creature);
            this.Controls.Add(this.btn_Run);
            this.Controls.Add(this.btn_Defend);
            this.Controls.Add(this.btn_Attack);
            this.Controls.Add(this.lbn_Story);
            this.Controls.Add(this.btnCreate);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.creaturePic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label lbn_Story;
        private System.Windows.Forms.Button btn_Attack;
        private System.Windows.Forms.Button btn_Defend;
        private System.Windows.Forms.Button btn_Run;
        private System.Windows.Forms.Label lbn_Creature;
        private System.Windows.Forms.ProgressBar playerHp;
        private System.Windows.Forms.ProgressBar creatureHp;
        private System.Windows.Forms.Label lbn_Turn;
        private System.Windows.Forms.Button btn_Solve;
        private System.Windows.Forms.Label lbn_Points;
        private System.Windows.Forms.Label lbn_PointScore;
        private System.Windows.Forms.PictureBox creaturePic;
    }
}

