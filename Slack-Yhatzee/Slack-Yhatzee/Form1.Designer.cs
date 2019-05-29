namespace Slack_Yhatzee
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageListDice = new System.Windows.Forms.ImageList(this.components);
            this.pictureBoxDie1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDie2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDie3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDie4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDie5 = new System.Windows.Forms.PictureBox();
            this.buttonRoll = new System.Windows.Forms.Button();
            this.labelGameState = new System.Windows.Forms.Label();
            this.labelLock1 = new System.Windows.Forms.Label();
            this.labelLock2 = new System.Windows.Forms.Label();
            this.labelLock3 = new System.Windows.Forms.Label();
            this.labelLock4 = new System.Windows.Forms.Label();
            this.labelLock5 = new System.Windows.Forms.Label();
            this.groupBoxTop = new System.Windows.Forms.GroupBox();
            this.buttonSixes = new System.Windows.Forms.Button();
            this.buttonFives = new System.Windows.Forms.Button();
            this.buttonFours = new System.Windows.Forms.Button();
            this.buttonThrees = new System.Windows.Forms.Button();
            this.buttonTwos = new System.Windows.Forms.Button();
            this.buttonOnes = new System.Windows.Forms.Button();
            this.groupBoxBottom = new System.Windows.Forms.GroupBox();
            this.buttonChance = new System.Windows.Forms.Button();
            this.buttonYhatzee = new System.Windows.Forms.Button();
            this.buttonLargeStraight = new System.Windows.Forms.Button();
            this.buttonSmallStraight = new System.Windows.Forms.Button();
            this.buttonFullHouse = new System.Windows.Forms.Button();
            this.button4OfAKind = new System.Windows.Forms.Button();
            this.button3OfAKind = new System.Windows.Forms.Button();
            this.labelTopScore = new System.Windows.Forms.Label();
            this.labelBottomScore = new System.Windows.Forms.Label();
            this.labelTopBonus = new System.Windows.Forms.Label();
            this.labelTotalScore = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie5)).BeginInit();
            this.groupBoxTop.SuspendLayout();
            this.groupBoxBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageListDice
            // 
            this.imageListDice.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListDice.ImageStream")));
            this.imageListDice.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListDice.Images.SetKeyName(0, "1Die.bmp");
            this.imageListDice.Images.SetKeyName(1, "2Die.bmp");
            this.imageListDice.Images.SetKeyName(2, "3Die.bmp");
            this.imageListDice.Images.SetKeyName(3, "4Die.bmp");
            this.imageListDice.Images.SetKeyName(4, "5Die.bmp");
            this.imageListDice.Images.SetKeyName(5, "6Die.bmp");
            // 
            // pictureBoxDie1
            // 
            this.pictureBoxDie1.Image = global::Slack_Yhatzee.Properties.Resources.Die1;
            this.pictureBoxDie1.Location = new System.Drawing.Point(33, 30);
            this.pictureBoxDie1.Name = "pictureBoxDie1";
            this.pictureBoxDie1.Size = new System.Drawing.Size(104, 104);
            this.pictureBoxDie1.TabIndex = 0;
            this.pictureBoxDie1.TabStop = false;
            this.pictureBoxDie1.Click += new System.EventHandler(this.pictureBoxDie1_Click);
            // 
            // pictureBoxDie2
            // 
            this.pictureBoxDie2.Image = global::Slack_Yhatzee.Properties.Resources.Die1;
            this.pictureBoxDie2.Location = new System.Drawing.Point(152, 30);
            this.pictureBoxDie2.Name = "pictureBoxDie2";
            this.pictureBoxDie2.Size = new System.Drawing.Size(104, 104);
            this.pictureBoxDie2.TabIndex = 1;
            this.pictureBoxDie2.TabStop = false;
            this.pictureBoxDie2.Click += new System.EventHandler(this.pictureBoxDie2_Click);
            // 
            // pictureBoxDie3
            // 
            this.pictureBoxDie3.Image = global::Slack_Yhatzee.Properties.Resources.Die1;
            this.pictureBoxDie3.Location = new System.Drawing.Point(274, 30);
            this.pictureBoxDie3.Name = "pictureBoxDie3";
            this.pictureBoxDie3.Size = new System.Drawing.Size(104, 104);
            this.pictureBoxDie3.TabIndex = 2;
            this.pictureBoxDie3.TabStop = false;
            this.pictureBoxDie3.Click += new System.EventHandler(this.pictureBoxDie3_Click);
            // 
            // pictureBoxDie4
            // 
            this.pictureBoxDie4.Image = global::Slack_Yhatzee.Properties.Resources.Die1;
            this.pictureBoxDie4.Location = new System.Drawing.Point(396, 30);
            this.pictureBoxDie4.Name = "pictureBoxDie4";
            this.pictureBoxDie4.Size = new System.Drawing.Size(104, 104);
            this.pictureBoxDie4.TabIndex = 3;
            this.pictureBoxDie4.TabStop = false;
            this.pictureBoxDie4.Click += new System.EventHandler(this.pictureBoxDie4_Click);
            // 
            // pictureBoxDie5
            // 
            this.pictureBoxDie5.Image = global::Slack_Yhatzee.Properties.Resources.Die1;
            this.pictureBoxDie5.Location = new System.Drawing.Point(520, 30);
            this.pictureBoxDie5.Name = "pictureBoxDie5";
            this.pictureBoxDie5.Size = new System.Drawing.Size(104, 104);
            this.pictureBoxDie5.TabIndex = 4;
            this.pictureBoxDie5.TabStop = false;
            this.pictureBoxDie5.Click += new System.EventHandler(this.pictureBoxDie5_Click);
            // 
            // buttonRoll
            // 
            this.buttonRoll.Location = new System.Drawing.Point(36, 192);
            this.buttonRoll.Name = "buttonRoll";
            this.buttonRoll.Size = new System.Drawing.Size(75, 23);
            this.buttonRoll.TabIndex = 5;
            this.buttonRoll.Text = "Roll";
            this.buttonRoll.UseVisualStyleBackColor = true;
            this.buttonRoll.Click += new System.EventHandler(this.buttonRoll_Click);
            // 
            // labelGameState
            // 
            this.labelGameState.AutoSize = true;
            this.labelGameState.Location = new System.Drawing.Point(33, 226);
            this.labelGameState.Name = "labelGameState";
            this.labelGameState.Size = new System.Drawing.Size(93, 13);
            this.labelGameState.TabIndex = 6;
            this.labelGameState.Text = "Click Roll to Begin";
            // 
            // labelLock1
            // 
            this.labelLock1.AutoSize = true;
            this.labelLock1.Location = new System.Drawing.Point(58, 137);
            this.labelLock1.Name = "labelLock1";
            this.labelLock1.Size = new System.Drawing.Size(50, 13);
            this.labelLock1.TabIndex = 7;
            this.labelLock1.Text = "LOCKED";
            this.labelLock1.Visible = false;
            // 
            // labelLock2
            // 
            this.labelLock2.AutoSize = true;
            this.labelLock2.Location = new System.Drawing.Point(177, 137);
            this.labelLock2.Name = "labelLock2";
            this.labelLock2.Size = new System.Drawing.Size(50, 13);
            this.labelLock2.TabIndex = 8;
            this.labelLock2.Text = "LOCKED";
            this.labelLock2.Visible = false;
            // 
            // labelLock3
            // 
            this.labelLock3.AutoSize = true;
            this.labelLock3.Location = new System.Drawing.Point(302, 137);
            this.labelLock3.Name = "labelLock3";
            this.labelLock3.Size = new System.Drawing.Size(50, 13);
            this.labelLock3.TabIndex = 9;
            this.labelLock3.Text = "LOCKED";
            this.labelLock3.Visible = false;
            // 
            // labelLock4
            // 
            this.labelLock4.AutoSize = true;
            this.labelLock4.Location = new System.Drawing.Point(423, 137);
            this.labelLock4.Name = "labelLock4";
            this.labelLock4.Size = new System.Drawing.Size(50, 13);
            this.labelLock4.TabIndex = 10;
            this.labelLock4.Text = "LOCKED";
            this.labelLock4.Visible = false;
            // 
            // labelLock5
            // 
            this.labelLock5.AutoSize = true;
            this.labelLock5.Location = new System.Drawing.Point(547, 137);
            this.labelLock5.Name = "labelLock5";
            this.labelLock5.Size = new System.Drawing.Size(50, 13);
            this.labelLock5.TabIndex = 11;
            this.labelLock5.Text = "LOCKED";
            this.labelLock5.Visible = false;
            // 
            // groupBoxTop
            // 
            this.groupBoxTop.Controls.Add(this.buttonSixes);
            this.groupBoxTop.Controls.Add(this.buttonFives);
            this.groupBoxTop.Controls.Add(this.buttonFours);
            this.groupBoxTop.Controls.Add(this.buttonThrees);
            this.groupBoxTop.Controls.Add(this.buttonTwos);
            this.groupBoxTop.Controls.Add(this.buttonOnes);
            this.groupBoxTop.Location = new System.Drawing.Point(351, 173);
            this.groupBoxTop.Name = "groupBoxTop";
            this.groupBoxTop.Size = new System.Drawing.Size(70, 197);
            this.groupBoxTop.TabIndex = 12;
            this.groupBoxTop.TabStop = false;
            this.groupBoxTop.Text = "Top";
            // 
            // buttonSixes
            // 
            this.buttonSixes.Location = new System.Drawing.Point(6, 164);
            this.buttonSixes.Name = "buttonSixes";
            this.buttonSixes.Size = new System.Drawing.Size(49, 23);
            this.buttonSixes.TabIndex = 5;
            this.buttonSixes.Text = "Sixes";
            this.buttonSixes.UseVisualStyleBackColor = true;
            this.buttonSixes.Click += new System.EventHandler(this.buttonSixes_Click);
            // 
            // buttonFives
            // 
            this.buttonFives.Location = new System.Drawing.Point(6, 135);
            this.buttonFives.Name = "buttonFives";
            this.buttonFives.Size = new System.Drawing.Size(49, 23);
            this.buttonFives.TabIndex = 4;
            this.buttonFives.Text = "Fives";
            this.buttonFives.UseVisualStyleBackColor = true;
            this.buttonFives.Click += new System.EventHandler(this.buttonFives_Click);
            // 
            // buttonFours
            // 
            this.buttonFours.Location = new System.Drawing.Point(6, 106);
            this.buttonFours.Name = "buttonFours";
            this.buttonFours.Size = new System.Drawing.Size(49, 23);
            this.buttonFours.TabIndex = 3;
            this.buttonFours.Text = "Fours";
            this.buttonFours.UseVisualStyleBackColor = true;
            this.buttonFours.Click += new System.EventHandler(this.buttonFours_Click);
            // 
            // buttonThrees
            // 
            this.buttonThrees.Location = new System.Drawing.Point(6, 77);
            this.buttonThrees.Name = "buttonThrees";
            this.buttonThrees.Size = new System.Drawing.Size(49, 23);
            this.buttonThrees.TabIndex = 2;
            this.buttonThrees.Text = "Threes";
            this.buttonThrees.UseVisualStyleBackColor = true;
            this.buttonThrees.Click += new System.EventHandler(this.buttonThrees_Click);
            // 
            // buttonTwos
            // 
            this.buttonTwos.Location = new System.Drawing.Point(6, 48);
            this.buttonTwos.Name = "buttonTwos";
            this.buttonTwos.Size = new System.Drawing.Size(49, 23);
            this.buttonTwos.TabIndex = 1;
            this.buttonTwos.Text = "Twos";
            this.buttonTwos.UseVisualStyleBackColor = true;
            this.buttonTwos.Click += new System.EventHandler(this.buttonTwos_Click);
            // 
            // buttonOnes
            // 
            this.buttonOnes.Location = new System.Drawing.Point(6, 19);
            this.buttonOnes.Name = "buttonOnes";
            this.buttonOnes.Size = new System.Drawing.Size(49, 23);
            this.buttonOnes.TabIndex = 0;
            this.buttonOnes.Text = "Ones";
            this.buttonOnes.UseVisualStyleBackColor = true;
            this.buttonOnes.Click += new System.EventHandler(this.buttonOnes_Click);
            // 
            // groupBoxBottom
            // 
            this.groupBoxBottom.Controls.Add(this.buttonChance);
            this.groupBoxBottom.Controls.Add(this.buttonYhatzee);
            this.groupBoxBottom.Controls.Add(this.buttonLargeStraight);
            this.groupBoxBottom.Controls.Add(this.buttonSmallStraight);
            this.groupBoxBottom.Controls.Add(this.buttonFullHouse);
            this.groupBoxBottom.Controls.Add(this.button4OfAKind);
            this.groupBoxBottom.Controls.Add(this.button3OfAKind);
            this.groupBoxBottom.Location = new System.Drawing.Point(427, 153);
            this.groupBoxBottom.Name = "groupBoxBottom";
            this.groupBoxBottom.Size = new System.Drawing.Size(137, 217);
            this.groupBoxBottom.TabIndex = 13;
            this.groupBoxBottom.TabStop = false;
            this.groupBoxBottom.Text = "Bottom";
            // 
            // buttonChance
            // 
            this.buttonChance.Location = new System.Drawing.Point(6, 193);
            this.buttonChance.Name = "buttonChance";
            this.buttonChance.Size = new System.Drawing.Size(92, 23);
            this.buttonChance.TabIndex = 6;
            this.buttonChance.Text = "Chance";
            this.buttonChance.UseVisualStyleBackColor = true;
            this.buttonChance.Click += new System.EventHandler(this.buttonChance_Click);
            // 
            // buttonYhatzee
            // 
            this.buttonYhatzee.Location = new System.Drawing.Point(6, 164);
            this.buttonYhatzee.Name = "buttonYhatzee";
            this.buttonYhatzee.Size = new System.Drawing.Size(92, 23);
            this.buttonYhatzee.TabIndex = 5;
            this.buttonYhatzee.Text = "Yhatzee";
            this.buttonYhatzee.UseVisualStyleBackColor = true;
            this.buttonYhatzee.Click += new System.EventHandler(this.buttonYhatzee_Click);
            // 
            // buttonLargeStraight
            // 
            this.buttonLargeStraight.Location = new System.Drawing.Point(6, 135);
            this.buttonLargeStraight.Name = "buttonLargeStraight";
            this.buttonLargeStraight.Size = new System.Drawing.Size(92, 23);
            this.buttonLargeStraight.TabIndex = 4;
            this.buttonLargeStraight.Text = "Large Straight";
            this.buttonLargeStraight.UseVisualStyleBackColor = true;
            this.buttonLargeStraight.Click += new System.EventHandler(this.buttonLargeStraight_Click);
            // 
            // buttonSmallStraight
            // 
            this.buttonSmallStraight.Location = new System.Drawing.Point(6, 106);
            this.buttonSmallStraight.Name = "buttonSmallStraight";
            this.buttonSmallStraight.Size = new System.Drawing.Size(92, 23);
            this.buttonSmallStraight.TabIndex = 3;
            this.buttonSmallStraight.Text = "Small Straight";
            this.buttonSmallStraight.UseVisualStyleBackColor = true;
            this.buttonSmallStraight.Click += new System.EventHandler(this.buttonSmallStraight_Click);
            // 
            // buttonFullHouse
            // 
            this.buttonFullHouse.Location = new System.Drawing.Point(6, 77);
            this.buttonFullHouse.Name = "buttonFullHouse";
            this.buttonFullHouse.Size = new System.Drawing.Size(92, 23);
            this.buttonFullHouse.TabIndex = 2;
            this.buttonFullHouse.Text = "Full House";
            this.buttonFullHouse.UseVisualStyleBackColor = true;
            this.buttonFullHouse.Click += new System.EventHandler(this.buttonFullHouse_Click);
            // 
            // button4OfAKind
            // 
            this.button4OfAKind.Location = new System.Drawing.Point(6, 48);
            this.button4OfAKind.Name = "button4OfAKind";
            this.button4OfAKind.Size = new System.Drawing.Size(92, 23);
            this.button4OfAKind.TabIndex = 1;
            this.button4OfAKind.Text = "4 of a Kind";
            this.button4OfAKind.UseVisualStyleBackColor = true;
            this.button4OfAKind.Click += new System.EventHandler(this.button4OfAKind_Click);
            // 
            // button3OfAKind
            // 
            this.button3OfAKind.Location = new System.Drawing.Point(6, 19);
            this.button3OfAKind.Name = "button3OfAKind";
            this.button3OfAKind.Size = new System.Drawing.Size(92, 23);
            this.button3OfAKind.TabIndex = 0;
            this.button3OfAKind.Text = "3 of a Kind";
            this.button3OfAKind.UseVisualStyleBackColor = true;
            this.button3OfAKind.Click += new System.EventHandler(this.button3OfAKind_Click);
            // 
            // labelTopScore
            // 
            this.labelTopScore.AutoSize = true;
            this.labelTopScore.Location = new System.Drawing.Point(33, 259);
            this.labelTopScore.Name = "labelTopScore";
            this.labelTopScore.Size = new System.Drawing.Size(72, 13);
            this.labelTopScore.TabIndex = 14;
            this.labelTopScore.Text = "Top Score - 0";
            // 
            // labelBottomScore
            // 
            this.labelBottomScore.AutoSize = true;
            this.labelBottomScore.Location = new System.Drawing.Point(33, 298);
            this.labelBottomScore.Name = "labelBottomScore";
            this.labelBottomScore.Size = new System.Drawing.Size(86, 13);
            this.labelBottomScore.TabIndex = 15;
            this.labelBottomScore.Text = "Bottom Score - 0";
            // 
            // labelTopBonus
            // 
            this.labelTopBonus.AutoSize = true;
            this.labelTopBonus.Location = new System.Drawing.Point(33, 279);
            this.labelTopBonus.Name = "labelTopBonus";
            this.labelTopBonus.Size = new System.Drawing.Size(74, 13);
            this.labelTopBonus.TabIndex = 16;
            this.labelTopBonus.Text = "Top Bonus - 0";
            // 
            // labelTotalScore
            // 
            this.labelTotalScore.AutoSize = true;
            this.labelTotalScore.Location = new System.Drawing.Point(33, 318);
            this.labelTotalScore.Name = "labelTotalScore";
            this.labelTotalScore.Size = new System.Drawing.Size(77, 13);
            this.labelTotalScore.TabIndex = 17;
            this.labelTotalScore.Text = "Total Score - 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelTotalScore);
            this.Controls.Add(this.labelTopBonus);
            this.Controls.Add(this.labelBottomScore);
            this.Controls.Add(this.labelTopScore);
            this.Controls.Add(this.groupBoxBottom);
            this.Controls.Add(this.groupBoxTop);
            this.Controls.Add(this.labelLock5);
            this.Controls.Add(this.labelLock4);
            this.Controls.Add(this.labelLock3);
            this.Controls.Add(this.labelLock2);
            this.Controls.Add(this.labelLock1);
            this.Controls.Add(this.labelGameState);
            this.Controls.Add(this.buttonRoll);
            this.Controls.Add(this.pictureBoxDie5);
            this.Controls.Add(this.pictureBoxDie4);
            this.Controls.Add(this.pictureBoxDie3);
            this.Controls.Add(this.pictureBoxDie2);
            this.Controls.Add(this.pictureBoxDie1);
            this.Name = "Form1";
            this.Text = "Joseph Slack Yhatzee";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDie5)).EndInit();
            this.groupBoxTop.ResumeLayout(false);
            this.groupBoxBottom.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageListDice;
        private System.Windows.Forms.PictureBox pictureBoxDie1;
        private System.Windows.Forms.PictureBox pictureBoxDie2;
        private System.Windows.Forms.PictureBox pictureBoxDie3;
        private System.Windows.Forms.PictureBox pictureBoxDie4;
        private System.Windows.Forms.PictureBox pictureBoxDie5;
        private System.Windows.Forms.Button buttonRoll;
        private System.Windows.Forms.Label labelGameState;
        private System.Windows.Forms.Label labelLock1;
        private System.Windows.Forms.Label labelLock2;
        private System.Windows.Forms.Label labelLock3;
        private System.Windows.Forms.Label labelLock4;
        private System.Windows.Forms.Label labelLock5;
        private System.Windows.Forms.GroupBox groupBoxTop;
        private System.Windows.Forms.Button buttonSixes;
        private System.Windows.Forms.Button buttonFives;
        private System.Windows.Forms.Button buttonFours;
        private System.Windows.Forms.Button buttonThrees;
        private System.Windows.Forms.Button buttonTwos;
        private System.Windows.Forms.Button buttonOnes;
        private System.Windows.Forms.GroupBox groupBoxBottom;
        private System.Windows.Forms.Button buttonYhatzee;
        private System.Windows.Forms.Button buttonLargeStraight;
        private System.Windows.Forms.Button buttonSmallStraight;
        private System.Windows.Forms.Button buttonFullHouse;
        private System.Windows.Forms.Button button4OfAKind;
        private System.Windows.Forms.Button button3OfAKind;
        private System.Windows.Forms.Button buttonChance;
        private System.Windows.Forms.Label labelTopScore;
        private System.Windows.Forms.Label labelBottomScore;
        private System.Windows.Forms.Label labelTopBonus;
        private System.Windows.Forms.Label labelTotalScore;
    }
}

