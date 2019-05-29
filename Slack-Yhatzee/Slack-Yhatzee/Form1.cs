using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slack_Yhatzee
{
    public partial class Form1 : Form
    {

        List<Die> listDice = new List<Die>();
        Die gameDie1 = new Die();
        Die gameDie2 = new Die();
        Die gameDie3 = new Die();
        Die gameDie4 = new Die();
        Die gameDie5 = new Die();

        Yhatzee ourGame = new Yhatzee(Yhatzee.gameStateTypes.FirstRoll);

        List<Label> listLockLabels = new List<Label>();

        List<PictureBox> listDicePictures = new List<PictureBox>();

        int diceRoll = 0;
        System.Windows.Forms.Timer t = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();

            listDice.Add(gameDie1);
            listDice.Add(gameDie2);
            listDice.Add(gameDie3);
            listDice.Add(gameDie4);
            listDice.Add(gameDie5);

            listLockLabels.Add(labelLock1);
            listLockLabels.Add(labelLock2);
            listLockLabels.Add(labelLock3);
            listLockLabels.Add(labelLock4);
            listLockLabels.Add(labelLock5);

            listDicePictures.Add(pictureBoxDie1);
            listDicePictures.Add(pictureBoxDie2);
            listDicePictures.Add(pictureBoxDie3);
            listDicePictures.Add(pictureBoxDie4);
            listDicePictures.Add(pictureBoxDie5);

            rollButtonClickActions();
        }

        private void pictureBoxDie3_Click(object sender, EventArgs e)
        {
            lockDie(pictureBoxDie3);
        }

        private void pictureBoxDie4_Click(object sender, EventArgs e)
        {
            lockDie(pictureBoxDie4);
        }

        private void pictureBoxDie5_Click(object sender, EventArgs e)
        {
            lockDie(pictureBoxDie5);
        }

        private void pictureBoxDie2_Click(object sender, EventArgs e)
        {
            lockDie(pictureBoxDie2);
        }

        private void pictureBoxDie1_Click(object sender, EventArgs e)
        {
            lockDie(pictureBoxDie1);
        }

        private void lockDie(PictureBox dieClicked)
        {
            for(int i = 0; i < 5; i++)
            {
                if(dieClicked == listDicePictures[i])
                {
                    if (listLockLabels[i].Visible == false)
                    {
                        listLockLabels[i].Visible = true;
                    }
                    else if(listLockLabels[i].Visible == true)
                    {
                        listLockLabels[i].Visible = false;
                    }
                }
            }
        }

        private void buttonRoll_Click(object sender, EventArgs e)
        {

            rollButtonClickActions();
            //This method so I can call the exact same thing when the form loads
        }

        public void rollButtonClickActions()
        {
            setupGameRound(); // Set up the round

            rollDice(); // Roll the dice
        }

        public void rollDice()
        {
            //ListDice.Clear(); Don't clear the list of dice, bad bad, the dice always exist

            diceRollEffect(); //Cool effect for that sweet extra credit

            for(int i = 0; i < 5; i++)
            {
                //Need to check for held dice
                if (listLockLabels[i].Visible == false)
                {
                    listDice[i].roll();
                }
            }

            pictureBoxDie1.Image = imageListDice.Images[listDice[0].ImageIndex];
            pictureBoxDie2.Image = imageListDice.Images[listDice[1].ImageIndex];
            pictureBoxDie3.Image = imageListDice.Images[listDice[2].ImageIndex];
            pictureBoxDie4.Image = imageListDice.Images[listDice[3].ImageIndex];
            pictureBoxDie5.Image = imageListDice.Images[listDice[4].ImageIndex];

            //labelNumber.Text = listDice[0].Value.ToString(); // For troubleshooting the image vs value
        }

        public void setupGameRound()
        {
            //Game order:
            //Pregame - Nothing is happening yet
                //This is where the player hasn't started yet
                //I shouldn't need this state in the final game
            //Round 1
                //First Dice Roll
                //Lock in dice
                //Allow to score early
            //Round 2
                //Second Dice Roll
                //Lock in dice
                //Allow to score early
            //Round 3
                //Last dice roll
                //Force a score to continue

            if (ourGame.GameStatus == Yhatzee.gameStateTypes.FirstRoll)
            {
                unlockAllDice();
                buttonRoll.Enabled = true;
                //Set up for the second roll
                labelGameState.Text = "This is your first roll, choose the dice to lock";
                //Move the game round forward
                ourGame.GameStatus = Yhatzee.gameStateTypes.SecondRoll;
            }
            else if (ourGame.GameStatus == Yhatzee.gameStateTypes.SecondRoll)
            {
                //Set up for final roll
                labelGameState.Text = "This is your second roll, last chance to lock in some dice";
                //Move game round
                ourGame.GameStatus = Yhatzee.gameStateTypes.FinalRoll;
            }
            else if (ourGame.GameStatus == Yhatzee.gameStateTypes.FinalRoll)
            {
                //Show Final roll info
                labelGameState.Text = "These are your final dice this round, now choose your score";
                //Only allow the game to continue if a score is selected
                buttonRoll.Enabled = false; // Comment out this line for easy troubleshooting               
                //Force game back to first round in scoring method, not here
            }
            else if (ourGame.GameStatus == Yhatzee.gameStateTypes.Pregame)
            {
                labelGameState.Text = "Something is broken because Pregame was activated";
                //This was only used when I was setting up the game
            }
        }

        public void unlockAllDice()
        {
            for(int i = 0; i < 5; i++)
            {
                listLockLabels[i].Visible = false;
            }
        }

        public void diceRollEffect()
        {
            //I used a timer on a personal project and thought it would be fun to use it here

            //Originally got it off Stack Overflow https://stackoverflow.com/questions/12535722/what-is-the-best-way-to-implement-a-timer
            //Generates random dice images before showing the actual value

            diceRoll = 0;

            t = new System.Windows.Forms.Timer();
            t.Interval = 100; // tenth second
            t.Tick += new EventHandler(timer_Tick);
            t.Start();

            
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            diceRoll += 1;

            int number; //image index for random picture
            Random rand = new Random(Guid.NewGuid().GetHashCode());
            number = rand.Next(0, 6);

            //pictureBoxDie1.Image = imageListDice.Images[number];
            //pictureBoxDie2.Image = imageListDice.Images[number];
            //pictureBoxDie3.Image = imageListDice.Images[number];
            //pictureBoxDie4.Image = imageListDice.Images[number];
            //pictureBoxDie5.Image = imageListDice.Images[number];

            for(int i = 0; i<5; i++)
            {
                if(listLockLabels[i].Visible == false)
                {
                    listDicePictures[i].Image = imageListDice.Images[number];
                }
            }

            if (diceRoll == 5)
            {
                t.Stop();
                pictureBoxDie1.Image = imageListDice.Images[listDice[0].ImageIndex];
                pictureBoxDie2.Image = imageListDice.Images[listDice[1].ImageIndex];
                pictureBoxDie3.Image = imageListDice.Images[listDice[2].ImageIndex];
                pictureBoxDie4.Image = imageListDice.Images[listDice[3].ImageIndex];
                pictureBoxDie5.Image = imageListDice.Images[listDice[4].ImageIndex];
            }
        }

        private void buttonOnes_Click(object sender, EventArgs e)
        {
            buttonOnes.Text = scoreRound(buttonOnes, "Top");
            rollButtonClickActions();
        }

        private void buttonFives_Click(object sender, EventArgs e)
        {
            buttonFives.Text = scoreRound(buttonFives, "Top");
            rollButtonClickActions();
        }

        private void buttonFours_Click(object sender, EventArgs e)
        {
            buttonFours.Text = scoreRound(buttonFours, "Top");
            rollButtonClickActions();
        }

        private void buttonThrees_Click(object sender, EventArgs e)
        {
            buttonThrees.Text = scoreRound(buttonThrees, "Top");
            rollButtonClickActions();
        }

        private void buttonTwos_Click(object sender, EventArgs e)
        {
            buttonTwos.Text = scoreRound(buttonTwos, "Top");
            rollButtonClickActions();
        }

        private void buttonSixes_Click(object sender, EventArgs e)
        {
            buttonSixes.Text = scoreRound(buttonSixes, "Top");
            rollButtonClickActions();
        }

        private string scoreRound(Button buttonClicked, string topOrBottom)
        {
            string scoreString;
            int scoreInt;
            Score roundScore = new Score(listDice[0].Value, listDice[1].Value, listDice[2].Value, listDice[3].Value, listDice[4].Value, buttonClicked.Text);

            scoreString = roundScore.returnScore().ToString();
            scoreInt = roundScore.returnScore();

            buttonClicked.Enabled = false;

            //Get Top or Bottom, and use that to add to the score
            if(topOrBottom == "Top")
            {
                //Use Yhatzee class top method
                ourGame.addTopScore(scoreInt);
                labelTopScore.Text = "Top Score - " + ourGame.TopScore;
                labelTopBonus.Text = "Top Bonus - " + ourGame.TopBonus;
                labelTotalScore.Text = "Total Score - " + ourGame.TotalScore;
            }
            else if (topOrBottom == "Bottom")
            {
                //Use Bottom method
                ourGame.addBottomScore(scoreInt);
                labelBottomScore.Text = "Bottom Score - " + ourGame.BottomScore;
                labelTotalScore.Text = "Total Score - " + ourGame.TotalScore;
            }

            //Need to reset the game back to first round here 
            ourGame.GameStatus = Yhatzee.gameStateTypes.FirstRoll;


            return scoreString;
        }

        private void buttonYhatzee_Click(object sender, EventArgs e)
        {
            buttonYhatzee.Text = scoreRound(buttonYhatzee, "Bottom");
            rollButtonClickActions();
        }

        private void buttonChance_Click(object sender, EventArgs e)
        {
            buttonChance.Text = scoreRound(buttonChance, "Bottom");
            rollButtonClickActions();
        }

        private void buttonLargeStraight_Click(object sender, EventArgs e)
        {
            buttonLargeStraight.Text = scoreRound(buttonLargeStraight, "Bottom");
            rollButtonClickActions();
        }

        private void buttonSmallStraight_Click(object sender, EventArgs e)
        {
            buttonSmallStraight.Text = scoreRound(buttonSmallStraight, "Bottom");
            rollButtonClickActions();
        }

        private void buttonFullHouse_Click(object sender, EventArgs e)
        {
            buttonFullHouse.Text = scoreRound(buttonFullHouse, "Bottom");
            rollButtonClickActions();
        }

        private void button4OfAKind_Click(object sender, EventArgs e)
        {
            button4OfAKind.Text = scoreRound(button4OfAKind, "Bottom");
            rollButtonClickActions();
        }

        private void button3OfAKind_Click(object sender, EventArgs e)
        {
            button3OfAKind.Text = scoreRound(button3OfAKind, "Bottom");
            rollButtonClickActions();
        }

    }
}
