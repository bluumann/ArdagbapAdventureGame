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
    public partial class CardCC : UserControl
    {
        public CardCC()
        {
            InitializeComponent();
        }

        public string CardType { get; set; }

        public string LabelName
        {
            get
            {
                return lblCardName.Text;
            }
            set
            {
                lblCardName.Text = value;
            }
        }

        public string LabelDesc
        {
            get
            {
                return lblDescription.Text;
            }
            set
            {
                lblDescription.Text = value;
            }
        }

        public Image CardElement
        {
            get { return pictureBoxElement.Image; }
            set { pictureBoxElement.Image = value; }
        }

        private void CardCC_Click(object sender, EventArgs e)
        {
            //GameForm.checkResult(CardType);
            MessageBox.Show("Working");
        }
    }
}
