using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StoryGenerator
{
    public partial class Form1 : Form
    {
        static int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            lbn_Story.Text = SelectStory();
            lbn_Creature.Text = SelectCreature();
            playerHp.Value = 100;
            lbn_PointScore.Text = "0";
            score = 0;
        }
        public string SelectStory()
        {
            string story;
            Random rnd = new Random();

            List<string> Stories = new List<string>();

            List<string> Verbs = new List<string>();
            
            Verbs.Add("As the chambers around you deepen and deepen, you begin to feel a tantalizing fear that something is following you...");
            Verbs.Add("The cavernous depths give way a lush underground biome, full with mycotic fungi and weird floating particles, you...");
            Verbs.Add("You are walking in the wood, lost and without any guidance. The dark night sky seems to churn with an incomming storm, you...");
            Verbs.Add("As you venture inside the haunted house, spectral motes of light begin to form around the rooms you go in, you...");
            Verbs.Add("Arriving at the old man's farm, you notice that the smell of blood is still in the air. The bandits must be close, you...");
            Verbs.Add("You and your friends are the last people on earth. You are all inside a small cottage, relaxing, when you hear a knock on the door, you...");
            Verbs.Add("There is no adventure here, you...");

            story = Verbs[rnd.Next(Verbs.Count)];

            return story;
        }

        public string SelectCreature()
        {
            string creature = "Hi";
            Random rnd = new Random();

            List<string> Verbs = new List<string>();
            List<Image> creatImg = new List<Image>();

            Verbs.Add("Croaala");
            Verbs.Add("Tigeest");
            Verbs.Add("Cheuksin");
            Verbs.Add("Geeti");
            Verbs.Add("Teegee");

            creatImg.Add(Image.FromFile("1.png"));
            creatImg.Add(Image.FromFile("2.png"));
            creatImg.Add(Image.FromFile("3.png"));

            creature = Verbs[rnd.Next(Verbs.Count)];
            creatureHp.Value = 100;
            creaturePic.Image = creatImg[rnd.Next(creatImg.Count)];
            creaturePic.SizeMode = PictureBoxSizeMode.StretchImage;

            return creature;
        }

        private void btn_Attack_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int damageP = rnd.Next(1, 10);
            int damageC = rnd.Next(1, 10);

            lbn_Turn.Text = "You attack the " + lbn_Creature.Text + " dealing " + damageP + " damage. While being targeted for " + damageC + " damage.";


            if (creatureHp.Value <= damageP) creatureHp.Value = 0;
            else creatureHp.Value += -damageP;


            if (playerHp.Value <= damageC) playerHp.Value = 0;
            else playerHp.Value += -damageC;

            if (creatureHp.Value <= 0 )
            {
                MessageBox.Show("You win!");
                lbn_Story.Text = SelectStory();
                lbn_Creature.Text = SelectCreature();
                score++;
                lbn_PointScore.Text = score.ToString();
                lbn_Turn.Text = "You defeated the " + lbn_Creature.Text + ".";
            }

            if (playerHp.Value <= 0)
            {
                MessageBox.Show("You lose!");
            }
        }

        private void btn_Defend_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int defense = rnd.Next(1, 5);
            lbn_Turn.Text = "You defend, recovering " + defense + " damage.";

            if (playerHp.Value >= 100) playerHp.Value = 100;
            else playerHp.Value += defense;
        }

        private void btn_Run_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You run! Coward!");
            lbn_Turn.Text = "You evaded the " + lbn_Creature.Text + " last time. Finding yourself in a new room...";
            lbn_Story.Text = SelectStory();
            lbn_Creature.Text = SelectCreature();
        }

        private void btn_Solve_Click(object sender, EventArgs e)
        {
            lbn_Turn.Text = "You attempt to investigate the room, revealing a small puzzle.";
            DialogResult Puzzle;
            Puzzle = MessageBox.Show("The puzzle stands in from of you, what will succeed on it?", "Puzzle", MessageBoxButtons.YesNo);
            if (Puzzle == DialogResult.Yes)
            {
                lbn_Turn.Text = "You succeeded on the puzzle and got a point!";
                score++;
                lbn_PointScore.Text = score.ToString(); 
            }
            if (Puzzle == DialogResult.No)
            {
                lbn_Turn.Text = "You failed on the puzzle and showed you can be humble!";
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
