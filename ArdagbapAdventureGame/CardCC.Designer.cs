namespace ArdagbapAdventureGame
{
    partial class CardCC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCardName = new System.Windows.Forms.Label();
            this.pictureBoxElement = new System.Windows.Forms.PictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElement)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCardName
            // 
            this.lblCardName.AutoSize = true;
            this.lblCardName.Location = new System.Drawing.Point(35, 14);
            this.lblCardName.Name = "lblCardName";
            this.lblCardName.Size = new System.Drawing.Size(70, 13);
            this.lblCardName.TabIndex = 0;
            this.lblCardName.Text = "This is a card";
            this.lblCardName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBoxElement
            // 
            this.pictureBoxElement.Location = new System.Drawing.Point(33, 35);
            this.pictureBoxElement.Name = "pictureBoxElement";
            this.pictureBoxElement.Size = new System.Drawing.Size(75, 75);
            this.pictureBoxElement.TabIndex = 1;
            this.pictureBoxElement.TabStop = false;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(20, 118);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(100, 62);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "This is where we will put our short description";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CardCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.pictureBoxElement);
            this.Controls.Add(this.lblCardName);
            this.Name = "CardCC";
            this.Size = new System.Drawing.Size(140, 180);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxElement)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCardName;
        private System.Windows.Forms.PictureBox pictureBoxElement;
        private System.Windows.Forms.Label lblDescription;
    }
}
