// Copyright (c) 2020 Janos Falke
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Yahtzee_UI
{
    public partial class UI : Form
    {

        private List<GameCard> gameCards;
        private int nbGames = 4;
        private int nbGamesMax = 4;
        private int nbGamesLastGame = 0;
        private List<bool> keepDice;
        private List<int> dice;
        private List<string> choicesNames;
        private ScoreForm sf;
        private int gameNumber = 1;
        private int nbDice = 5;        
        private bool started = false;

        public UI()
        {
            
            sf = new ScoreForm();
            InitializeComponent();

            rollDiceButton.Text = "Roll the dice (" + (maxAttemps - rollCounter) + " attemps left)";

            nbGamesSelect.SelectedItem = nbGamesSelect.Items[0]; // set first one as selected

            gameCardLoadPicture.Image = Image.FromFile("imgs/loader.png");
        }


        private void startGame()
        {
            gameCards = new List<GameCard>();

            for (int i = 0; i < nbGames; i++)
            {
                gameCards.Add(new GameCard());
            }

            addGamesUIDesigner();

            keepDice = new List<bool>();
            dice = new List<int>();
            choicesNames = new List<string>();
            rollCounter = 0;
            initDice();
            initChoicesNames();

            clearKeepDiceList();
            printGameCardText();
        }

        private void initDice()
        {
            dice.Add(-1);
            dice.Add(-1);
            dice.Add(-1);
            dice.Add(-1);
            dice.Add(-1);
        }

        private void initChoicesNames()
        {
            choicesNames.Add("Cross out");
            choicesNames.Add("Aces");
            choicesNames.Add("Twos");
            choicesNames.Add("Threes");
            choicesNames.Add("Fours");
            choicesNames.Add("Fives");
            choicesNames.Add("Sixes");
            choicesNames.Add("Three of a kind");
            choicesNames.Add("Four of a kind");
            choicesNames.Add("Full House");
            choicesNames.Add("Small Street");
            choicesNames.Add("Large Street");
            choicesNames.Add("Yahtzee");
            choicesNames.Add("Chance");
        }

        private Label [,] getLabels()
        {
            Label[,] labels = new Label[nbGames, 20];

            //init labels Game1
            if (nbGames >= 1)
            {
                labels[0, 0] = acesValueGame1;
                labels[0, 1] = twosValueGame1;
                labels[0, 2] = threesValueGame1;
                labels[0, 3] = foursValueGame1;
                labels[0, 4] = fivesValueGame1;
                labels[0, 5] = sixesValueGame1;
                labels[0, 6] = totalScoreValueGame1;
                labels[0, 7] = bonusValueGame1;
                labels[0, 8] = totalValueGame1;
                labels[0, 9] = threeOfKindValueGame1;
                labels[0, 10] = fourOfKindValueGame1;
                labels[0, 11] = fullHouseValueGame1;
                labels[0, 12] = smallStreetValueGame1;
                labels[0, 13] = largeStreetValueGame1;
                labels[0, 14] = yahtzeeValueGame1;
                labels[0, 15] = chanceValueGame1;
                labels[0, 16] = totalLowerValueGame1;
                labels[0, 17] = totalUpperValueGame1;
                labels[0, 18] = grandTotalValueGame1;
                labels[0, 19] = game1Label;

                if (nbGames >= 2)
                {
                    labels[1, 0] = acesValueGame2;
                    labels[1, 1] = twosValueGame2;
                    labels[1, 2] = threesValueGame2;
                    labels[1, 3] = foursValueGame2;
                    labels[1, 4] = fivesValueGame2;
                    labels[1, 5] = sixesValueGame2;
                    labels[1, 6] = totalScoreValueGame2;
                    labels[1, 7] = bonusValueGame2;
                    labels[1, 8] = totalValueGame2;
                    labels[1, 9] = threeOfKindValueGame2;
                    labels[1, 10] = fourOfKindValueGame2;
                    labels[1, 11] = fullHouseValueGame2;
                    labels[1, 12] = smallStreetValueGame2;
                    labels[1, 13] = largeStreetValueGame2;
                    labels[1, 14] = yahtzeeValueGame2;
                    labels[1, 15] = chanceValueGame2;
                    labels[1, 16] = totalLowerValueGame2;
                    labels[1, 17] = totalUpperValueGame2;
                    labels[1, 18] = grandTotalValueGame2;
                    labels[1, 19] = game2Label;

                    if (nbGames >= 3)
                    {
                        labels[2, 0] = acesValueGame3;
                        labels[2, 1] = twosValueGame3;
                        labels[2, 2] = threesValueGame3;
                        labels[2, 3] = foursValueGame3;
                        labels[2, 4] = fivesValueGame3;
                        labels[2, 5] = sixesValueGame3;
                        labels[2, 6] = totalScoreValueGame3;
                        labels[2, 7] = bonusValueGame3;
                        labels[2, 8] = totalValueGame3;
                        labels[2, 9] = threeOfKindValueGame3;
                        labels[2, 10] = fourOfKindValueGame3;
                        labels[2, 11] = fullHouseValueGame3;
                        labels[2, 12] = smallStreetValueGame3;
                        labels[2, 13] = largeStreetValueGame3;
                        labels[2, 14] = yahtzeeValueGame3;
                        labels[2, 15] = chanceValueGame3;
                        labels[2, 16] = totalLowerValueGame3;
                        labels[2, 17] = totalUpperValueGame3;
                        labels[2, 18] = grandTotalValueGame3;
                        labels[2, 19] = game3Label;

                        if (nbGames >= 4)
                        {
                            labels[3, 0] = acesValueGame4;
                            labels[3, 1] = twosValueGame4;
                            labels[3, 2] = threesValueGame4;
                            labels[3, 3] = foursValueGame4;
                            labels[3, 4] = fivesValueGame4;
                            labels[3, 5] = sixesValueGame4;
                            labels[3, 6] = totalScoreValueGame4;
                            labels[3, 7] = bonusValueGame4;
                            labels[3, 8] = totalValueGame4;
                            labels[3, 9] = threeOfKindValueGame4;
                            labels[3, 10] = fourOfKindValueGame4;
                            labels[3, 11] = fullHouseValueGame4;
                            labels[3, 12] = smallStreetValueGame4;
                            labels[3, 13] = largeStreetValueGame4;
                            labels[3, 14] = yahtzeeValueGame4;
                            labels[3, 15] = chanceValueGame4;
                            labels[3, 16] = totalLowerValueGame4;
                            labels[3, 17] = totalUpperValueGame4;
                            labels[3, 18] = grandTotalValueGame4;
                            labels[3, 19] = game4Label;
                        }
                    }
                }
            }

            return labels;
        }

        private Label[,] getInactiveLabels()
        {
            Label[,] labels = new Label[nbGamesMax - 1, 20];


           if (nbGamesLastGame >= 2)
            { 
                labels[0, 0] = acesValueGame2;
                labels[0, 1] = twosValueGame2;
                labels[0, 2] = threesValueGame2;
                labels[0, 3] = foursValueGame2;
                labels[0, 4] = fivesValueGame2;
                labels[0, 5] = sixesValueGame2;
                labels[0, 6] = totalScoreValueGame2;
                labels[0, 7] = bonusValueGame2;
                labels[0, 8] = totalValueGame2;
                labels[0, 9] = threeOfKindValueGame2;
                labels[0, 10] = fourOfKindValueGame2;
                labels[0, 11] = fullHouseValueGame2;
                labels[0, 12] = smallStreetValueGame2;
                labels[0, 13] = largeStreetValueGame2;
                labels[0, 14] = yahtzeeValueGame2;
                labels[0, 15] = chanceValueGame2;
                labels[0, 16] = totalLowerValueGame2;
                labels[0, 17] = totalUpperValueGame2;
                labels[0, 18] = grandTotalValueGame2;
                labels[0, 19] = game2Label;

                if (nbGamesLastGame >= 3)
                {
                    labels[1, 0] = acesValueGame3;
                    labels[1, 1] = twosValueGame3;
                    labels[1, 2] = threesValueGame3;
                    labels[1, 3] = foursValueGame3;
                    labels[1, 4] = fivesValueGame3;
                    labels[1, 5] = sixesValueGame3;
                    labels[1, 6] = totalScoreValueGame3;
                    labels[1, 7] = bonusValueGame3;
                    labels[1, 8] = totalValueGame3;
                    labels[1, 9] = threeOfKindValueGame3;
                    labels[1, 10] = fourOfKindValueGame3;
                    labels[1, 11] = fullHouseValueGame3;
                    labels[1, 12] = smallStreetValueGame3;
                    labels[1, 13] = largeStreetValueGame3;
                    labels[1, 14] = yahtzeeValueGame3;
                    labels[1, 15] = chanceValueGame3;
                    labels[1, 16] = totalLowerValueGame3;
                    labels[1, 17] = totalUpperValueGame3;
                    labels[1, 18] = grandTotalValueGame3;
                    labels[1, 19] = game3Label;

                    if (nbGamesLastGame >= 4)
                    {
                        labels[2, 0] = acesValueGame4;
                        labels[2, 1] = twosValueGame4;
                        labels[2, 2] = threesValueGame4;
                        labels[2, 3] = foursValueGame4;
                        labels[2, 4] = fivesValueGame4;
                        labels[2, 5] = sixesValueGame4;
                        labels[2, 6] = totalScoreValueGame4;
                        labels[2, 7] = bonusValueGame4;
                        labels[2, 8] = totalValueGame4;
                        labels[2, 9] = threeOfKindValueGame4;
                        labels[2, 10] = fourOfKindValueGame4;
                        labels[2, 11] = fullHouseValueGame4;
                        labels[2, 12] = smallStreetValueGame4;
                        labels[2, 13] = largeStreetValueGame4;
                        labels[2, 14] = yahtzeeValueGame4;
                        labels[2, 15] = chanceValueGame4;
                        labels[2, 16] = totalLowerValueGame4;
                        labels[2, 17] = totalUpperValueGame4;
                        labels[2, 18] = grandTotalValueGame4;
                        labels[2, 19] = game4Label;
                    }
                }
            }
            

            return labels;
        }

        private void printGameCardText()
        {
            gamecardUpperSection.SuspendLayout();
            gamecardLowerSection.SuspendLayout();

            Label[,] labels = getLabels();

            Item selectedItem = (Item)resultChoiceSelect.SelectedItem;
            Item selectedGame = (Item)resultChoiceGameSelect.SelectedItem;

            if (selectedItem is Item)
            {
                int selectedValue = selectedItem.value;

                if(selectedValue == 0)
                {
                    Item selectedCrossOut = (Item)crossOutBoxSelect.SelectedItem;
                    selectedValue = selectedCrossOut.value;
                }

                switch (selectedValue)
                {
                    case 1:
                        labels[selectedGame.value, selectedValue - 1].Text = (gameCards[selectedGame.value].aces == -2) ? "-" : (gameCards[selectedGame.value].aces == -1) ? " " : "" + gameCards[selectedGame.value].aces;
                        break;
                    case 2:
                        labels[selectedGame.value, selectedValue - 1].Text = (gameCards[selectedGame.value].twos == -2) ? "-" : (gameCards[selectedGame.value].twos == -1) ? " " : "" + gameCards[selectedGame.value].twos;
                        break;
                    case 3:
                        labels[selectedGame.value, selectedValue - 1].Text = (gameCards[selectedGame.value].threes == -2) ? "-" : (gameCards[selectedGame.value].threes == -1) ? " " : "" + gameCards[selectedGame.value].threes;
                        break;
                    case 4:
                        labels[selectedGame.value, selectedValue - 1].Text = (gameCards[selectedGame.value].fours == -2) ? "-" : (gameCards[selectedGame.value].fours == -1) ? " " : "" + gameCards[selectedGame.value].fours;
                        break;
                    case 5:
                        labels[selectedGame.value, selectedValue - 1].Text = (gameCards[selectedGame.value].fives == -2) ? "-" : (gameCards[selectedGame.value].fives == -1) ? " " : "" + gameCards[selectedGame.value].fives;
                        break;
                    case 6:
                        labels[selectedGame.value, selectedValue - 1].Text = (gameCards[selectedGame.value].sixes == -2) ? "-" : (gameCards[selectedGame.value].sixes == -1) ? " " : "" + gameCards[selectedGame.value].sixes;
                        break;
                    case 7:
                        labels[selectedGame.value, selectedValue + 2].Text = (gameCards[selectedGame.value].threeOfKind == -2) ? "-" : (gameCards[selectedGame.value].threeOfKind == -1) ? " " : "" + gameCards[selectedGame.value].threeOfKind;
                        break;
                    case 8:
                        labels[selectedGame.value, selectedValue + 2].Text = (gameCards[selectedGame.value].fourOfKind == -2) ? "-" : (gameCards[selectedGame.value].fourOfKind == -1) ? " " : "" + gameCards[selectedGame.value].fourOfKind;
                        break;
                    case 9:
                        labels[selectedGame.value, selectedValue  + 2].Text = gameCards[selectedGame.value].fullHouse.ToString();
                        break;
                    case 10:
                        labels[selectedGame.value, selectedValue + 2].Text = gameCards[selectedGame.value].smallStreet.ToString();
                        break;
                    case 11:
                        labels[selectedGame.value, selectedValue + 2].Text = gameCards[selectedGame.value].largeStreet.ToString();
                        break;
                    case 12:
                        labels[selectedGame.value, selectedValue + 2].Text = gameCards[selectedGame.value].yahtzee.ToString();
                        break;
                    case 13:
                        labels[selectedGame.value, selectedValue + 2].Text = (gameCards[selectedGame.value].chance == -2) ? "-" : (gameCards[selectedGame.value].chance == -1) ? " " : "" + gameCards[selectedGame.value].chance;
                        break;
                    default:
                        break;
                }

                if(selectedValue > 0  && selectedValue <= 6)
                {
                    labels[selectedGame.value, 6].Text = "" + gameCards[selectedGame.value].totalScore();
                    labels[selectedGame.value, 7].Text = (gameCards[selectedGame.value].totalScore() >= gameCards[selectedGame.value].bonusLimit ? "" + gameCards[selectedGame.value].bonus :
                            (gameCards[selectedGame.value].aces != -1 && gameCards[selectedGame.value].twos != -1 && gameCards[selectedGame.value].threes != -1 && gameCards[selectedGame.value].fours != -1 
                            && gameCards[selectedGame.value].fives != -1 && gameCards[selectedGame.value].sixes != -1) ? "-" : " ");
                    labels[selectedGame.value, 8].Text = "" + gameCards[selectedGame.value].totalUpper();
                    labels[selectedGame.value, 17].Text = "" + gameCards[selectedGame.value].totalUpper();
                }
                else
                {
                    labels[selectedGame.value, 16].Text = "" + gameCards[selectedGame.value].totalLower();
                }

                labels[selectedGame.value, 18].Text = "" + (gameCards[selectedGame.value].totalLower() + gameCards[selectedGame.value].totalUpper());
            }

            gamecardUpperSection.ResumeLayout();
            gamecardLowerSection.ResumeLayout();
        }


        async private void addGamesUIDesigner()
        {

            gamecardUpperSection.SuspendLayout();
            gamecardLowerSection.SuspendLayout();

            // 
            // gamecardUpperSection
            // 
            this.gamecardUpperSection.ColumnCount = 2 + nbGames;
            this.gamecardLowerSection.ColumnCount = 2 + nbGames;


            Label[,] labels = getInactiveLabels();

            for (int i = 0; i < labels.GetLength(0); i++)
            {
                for (int j = 0; j < labels.GetLength(1); j++)
                {
                    if (labels[i, j] is Label)
                    {
                        labels[i, j].Visible = false;
                    }
                }
            }
            

            Label[,] activeLabel = getLabels();

            if (activeLabel[0, 0] is Label)
            {
                for (int i = 0; i < activeLabel.GetLength(0); i++)
                {
                    for (int j = 0; j < activeLabel.GetLength(1); j++)
                    {
                        activeLabel[i, j].Visible = true;
                    }
                }
            }

            for (int i = 0; i < nbGames; i++)
            {
                //add columns
                this.gamecardUpperSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
                this.gamecardLowerSection.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            }


            if (nbGames >= 1)
            {
              

                this.gamecardUpperSection.Controls.Add(this.game1Label, 2, 0);
                this.gamecardUpperSection.Controls.Add(this.acesValueGame1, 2, 1);
                this.gamecardUpperSection.Controls.Add(this.twosValueGame1, 2, 2);
                this.gamecardUpperSection.Controls.Add(this.threesValueGame1, 2, 3);
                this.gamecardUpperSection.Controls.Add(this.foursValueGame1, 2, 4);
                this.gamecardUpperSection.Controls.Add(this.fivesValueGame1, 2, 5);
                this.gamecardUpperSection.Controls.Add(this.sixesValueGame1, 2, 6);
                this.gamecardUpperSection.Controls.Add(this.totalScoreValueGame1, 2, 7);
                this.gamecardUpperSection.Controls.Add(this.bonusValueGame1, 2, 8);
                this.gamecardUpperSection.Controls.Add(this.totalValueGame1, 2, 9);

                this.gamecardLowerSection.Controls.Add(this.threeOfKindValueGame1, 2, 1);
                this.gamecardLowerSection.Controls.Add(this.fourOfKindValueGame1, 2, 2);
                this.gamecardLowerSection.Controls.Add(this.fullHouseValueGame1, 2, 3);
                this.gamecardLowerSection.Controls.Add(this.smallStreetValueGame1, 2, 4);
                this.gamecardLowerSection.Controls.Add(this.largeStreetValueGame1, 2, 5);
                this.gamecardLowerSection.Controls.Add(this.yahtzeeValueGame1, 2, 6);
                this.gamecardLowerSection.Controls.Add(this.chanceValueGame1, 2, 7);
                this.gamecardLowerSection.Controls.Add(this.totalLowerValueGame1, 2, 8);
                this.gamecardLowerSection.Controls.Add(this.totalUpperValueGame1, 2, 9);
                this.gamecardLowerSection.Controls.Add(this.grandTotalValueGame1, 2, 10);

                if (nbGames >= 2)
                {
                    this.gamecardUpperSection.Controls.Add(this.game2Label, 3, 0);
                    this.gamecardUpperSection.Controls.Add(this.acesValueGame2, 3, 1);
                    this.gamecardUpperSection.Controls.Add(this.twosValueGame2, 3, 2);
                    this.gamecardUpperSection.Controls.Add(this.threesValueGame2, 3, 3);
                    this.gamecardUpperSection.Controls.Add(this.foursValueGame2, 3, 4);
                    this.gamecardUpperSection.Controls.Add(this.fivesValueGame2, 3, 5);
                    this.gamecardUpperSection.Controls.Add(this.sixesValueGame2, 3, 6);
                    this.gamecardUpperSection.Controls.Add(this.totalScoreValueGame2, 3, 7);
                    this.gamecardUpperSection.Controls.Add(this.bonusValueGame2, 3, 8);
                    this.gamecardUpperSection.Controls.Add(this.totalValueGame2, 3, 9);

                    this.gamecardLowerSection.Controls.Add(this.threeOfKindValueGame2, 3, 1);
                    this.gamecardLowerSection.Controls.Add(this.fourOfKindValueGame2, 3, 2);
                    this.gamecardLowerSection.Controls.Add(this.fullHouseValueGame2, 3, 3);
                    this.gamecardLowerSection.Controls.Add(this.smallStreetValueGame2, 3, 4);
                    this.gamecardLowerSection.Controls.Add(this.largeStreetValueGame2, 3, 5);
                    this.gamecardLowerSection.Controls.Add(this.yahtzeeValueGame2, 3, 6);
                    this.gamecardLowerSection.Controls.Add(this.chanceValueGame2, 3, 7);
                    this.gamecardLowerSection.Controls.Add(this.totalLowerValueGame2, 3, 8);
                    this.gamecardLowerSection.Controls.Add(this.totalUpperValueGame2, 3, 9);
                    this.gamecardLowerSection.Controls.Add(this.grandTotalValueGame2, 3, 10);

                    if (nbGames >= 3)
                    {
                        this.gamecardUpperSection.Controls.Add(this.game3Label, 4, 0);
                        this.gamecardUpperSection.Controls.Add(this.acesValueGame3, 4, 1);
                        this.gamecardUpperSection.Controls.Add(this.twosValueGame3, 4, 2);
                        this.gamecardUpperSection.Controls.Add(this.threesValueGame3, 4, 3);
                        this.gamecardUpperSection.Controls.Add(this.foursValueGame3, 4, 4);
                        this.gamecardUpperSection.Controls.Add(this.fivesValueGame3, 4, 5);
                        this.gamecardUpperSection.Controls.Add(this.sixesValueGame3, 4, 6);
                        this.gamecardUpperSection.Controls.Add(this.totalScoreValueGame3, 4, 7);
                        this.gamecardUpperSection.Controls.Add(this.bonusValueGame3, 4, 8);
                        this.gamecardUpperSection.Controls.Add(this.totalValueGame3, 4, 9);

                        this.gamecardLowerSection.Controls.Add(this.threeOfKindValueGame3, 4, 1);
                        this.gamecardLowerSection.Controls.Add(this.fourOfKindValueGame3, 4, 2);
                        this.gamecardLowerSection.Controls.Add(this.fullHouseValueGame3, 4, 3);
                        this.gamecardLowerSection.Controls.Add(this.smallStreetValueGame3, 4, 4);
                        this.gamecardLowerSection.Controls.Add(this.largeStreetValueGame3, 4, 5);
                        this.gamecardLowerSection.Controls.Add(this.yahtzeeValueGame3, 4, 6);
                        this.gamecardLowerSection.Controls.Add(this.chanceValueGame3, 4, 7);
                        this.gamecardLowerSection.Controls.Add(this.totalLowerValueGame3, 4, 8);
                        this.gamecardLowerSection.Controls.Add(this.totalUpperValueGame3, 4, 9);
                        this.gamecardLowerSection.Controls.Add(this.grandTotalValueGame3, 4, 10);

                        if (nbGames >= 4)
                        {
                            this.gamecardUpperSection.Controls.Add(this.game4Label, 5, 0);
                            this.gamecardUpperSection.Controls.Add(this.acesValueGame4, 5, 1);
                            this.gamecardUpperSection.Controls.Add(this.twosValueGame4, 5, 2);
                            this.gamecardUpperSection.Controls.Add(this.threesValueGame4, 5, 3);
                            this.gamecardUpperSection.Controls.Add(this.foursValueGame4, 5, 4);
                            this.gamecardUpperSection.Controls.Add(this.fivesValueGame4, 5, 5);
                            this.gamecardUpperSection.Controls.Add(this.sixesValueGame4, 5, 6);
                            this.gamecardUpperSection.Controls.Add(this.totalScoreValueGame4, 5, 7);
                            this.gamecardUpperSection.Controls.Add(this.bonusValueGame4, 5, 8);
                            this.gamecardUpperSection.Controls.Add(this.totalValueGame4, 5, 9);

                            this.gamecardLowerSection.Controls.Add(this.threeOfKindValueGame4, 5, 1);
                            this.gamecardLowerSection.Controls.Add(this.fourOfKindValueGame4, 5, 2);
                            this.gamecardLowerSection.Controls.Add(this.fullHouseValueGame4, 5, 3);
                            this.gamecardLowerSection.Controls.Add(this.smallStreetValueGame4, 5, 4);
                            this.gamecardLowerSection.Controls.Add(this.largeStreetValueGame4, 5, 5);
                            this.gamecardLowerSection.Controls.Add(this.yahtzeeValueGame4, 5, 6);
                            this.gamecardLowerSection.Controls.Add(this.chanceValueGame4, 5, 7);
                            this.gamecardLowerSection.Controls.Add(this.totalLowerValueGame4, 5, 8);
                            this.gamecardLowerSection.Controls.Add(this.totalUpperValueGame4, 5, 9);
                            this.gamecardLowerSection.Controls.Add(this.grandTotalValueGame4, 5, 10);
                        }
                    }
                }
            }
            //add (calculate) size for nb of games
            this.gamecardUpperSection.Size = new System.Drawing.Size(205 + (nbGames * (62 - (nbGames * 2))), 212);
            this.gamecardLowerSection.Size = new System.Drawing.Size(205 + (nbGames * (62 - (nbGames * 2))), 237);


            if (!started)
            {
                //some other processing to do possible
                await Task.Delay(1500);
                rollDiceButton.Enabled = true;
                rollDiceButton.Text = "Roll the dice (" + (maxAttemps - rollCounter) + " attemps left)";
                gameCardLoadPicture.Visible = false;
                gameCardLoadPicture.Image = Image.FromFile("imgs/loader.png");
                this.gamecardUpperSection.Visible = true;
                this.gamecardLowerSection.Visible = true;

                gamecardUpperSection.ResumeLayout();
                gamecardLowerSection.ResumeLayout();
            }
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (!started)
            {
                started = true;
            }

            if (!stopDiceButton.Enabled)
            {
                stopDiceButton.Enabled = true;
            }

            string[] imgs = { "aces", "twos", "threes", "fours", "fives", "sixes" };

            if (!keepDice.Contains(true))
            {
                for (int i = 0; i < nbDice; i++)
                {
                    dice[i] = -1;
                }
            }
            else
            {
                //set the not kept dice to 0 
                for (int i = 0; i < keepDice.Count; i++)
                {
                    if (!keepDice[i])
                    {
                        dice[i] = -1;
                    }
                }
            }

            Random random = new Random();

            for (int i = 0; i < nbDice; i++)
            {
                if (dice[i] == -1)
                {
                    int num = random.Next(0, 6); //between 0-5 ==> for imgs list
                    dice[i] = num;
                }
            }


            // random.Next(imgs.Length)

            dicePicture1.Image = Image.FromFile("imgs/" + imgs[dice[0]] + ".png");
            dicePicture2.Image = Image.FromFile("imgs/" + imgs[dice[1]] + ".png");
            dicePicture3.Image = Image.FromFile("imgs/" + imgs[dice[2]] + ".png");
            dicePicture4.Image = Image.FromFile("imgs/" + imgs[dice[3]] + ".png");
            dicePicture5.Image = Image.FromFile("imgs/" + imgs[dice[4]] + ".png");



            rollCounter++;
            rollDiceButton.Text = "Roll the dice (" + (maxAttemps - rollCounter) + " attemps left)";


            clearKeepDiceList();
            printGameCardText();

            if (rollCounter == maxAttemps)
            {
                roundEnd();
            }



        }

        private void roundEnd()
        {
            //disable reroll and stop button
            rollDiceButton.Enabled = false;
            stopDiceButton.Enabled = false;


            //result boxes visible 
            resultChoiceSelect.Visible = true;
            resultChoiceButton.Visible = true;
            resultChoiceGameSelect.Visible = true;
            resultChoiceInLabel.Visible = true;
            resultChoiceDesc.Visible = true;


            List<List<bool>> allChoices = new List<List<bool>>();

            for (int i = 0; i < nbGames; i++)
            {
                List<bool> choices = gameCards[i].checkResult(dice);
                allChoices.Add(choices);
            }

            List<bool> unitedChoices = new List<bool>();

            for (int i = 0; i < allChoices[0].Count; i++)
            {
                bool avail = false;
                int j = 0;
                while (!avail && j < allChoices.Count)
                {
                    if (allChoices[j][i])
                    {
                        unitedChoices.Add(true);
                        avail = true;
                    }
                    j++;
                }

                if (!avail)
                {
                    unitedChoices.Add(false);
                }
            }
            
            resultChoiceSelect.Items.Clear();
            resultChoiceSelect.Items.AddRange(gameCards[0].showOptions(unitedChoices, choicesNames, dice).ToArray()); //can take every game number (should be 0)

            resultChoiceSelect.SelectedItem = resultChoiceSelect.Items[0]; // set first one as selected
        }

        private void Gamecard_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UI_Load(object sender, EventArgs e)
        {

        }

        private void clearKeepDiceList()
        {
            keepDice.Clear();
            keepDice.Add(false);
            keepDice.Add(false);
            keepDice.Add(false);
            keepDice.Add(false);
            keepDice.Add(false);

            this.dicePicture1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dicePicture2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dicePicture3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dicePicture4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dicePicture5.BorderStyle = System.Windows.Forms.BorderStyle.None;
        }

        private void dicePicture1_Click(object sender, EventArgs e)
        {
            if (maxAttemps - rollCounter > 0 && started && stopDiceButton.Enabled)
            {
                if (keepDice[0] == false)
                {
                    this.dicePicture1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    keepDice[0] = true;
                }
                else
                {
                    this.dicePicture1.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    keepDice[0] = false;
                }
            }
        }

        private void dicePicture2_Click(object sender, EventArgs e)
        {
            if (maxAttemps - rollCounter > 0 && started && stopDiceButton.Enabled)
            {
                if (keepDice[1] == false)
                {
                    this.dicePicture2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    keepDice[1] = true;
                }
                else
                {
                    this.dicePicture2.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    keepDice[1] = false;
                }
            }
        }

        private void dicePicture3_Click(object sender, EventArgs e)
        {
            if (maxAttemps - rollCounter > 0 && started && stopDiceButton.Enabled)
            {
                if (keepDice[2] == false)
                {
                    this.dicePicture3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    keepDice[2] = true;
                }
                else
                {
                    this.dicePicture3.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    keepDice[2] = false;
                }
            }
        }

        private void dicePicture4_Click(object sender, EventArgs e)
        {
            if (maxAttemps - rollCounter > 0 && started && stopDiceButton.Enabled)
            {
                if (keepDice[3] == false)
                {
                    this.dicePicture4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    keepDice[3] = true;
                }
                else
                {
                    this.dicePicture4.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    keepDice[3] = false;
                }
            }
        }

        private void dicePicture5_Click(object sender, EventArgs e)
        {
            if (maxAttemps - rollCounter > 0 && started && stopDiceButton.Enabled)
            {
                if (keepDice[4] == false)
                {
                    this.dicePicture5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
                    keepDice[4] = true;
                }
                else
                {
                    this.dicePicture5.BorderStyle = System.Windows.Forms.BorderStyle.None;
                    keepDice[4] = false;
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            resultChoiceGameSelect.Enabled = true;
            resultChoiceButton.Enabled = true;

            Item selectedItem = (Item)resultChoiceSelect.SelectedItem;
            resultChoiceGameSelect.Items.Clear();

            for (int i = 0; i < nbGames; i++)
            {
                if (gameCards[i].checkGameOption(selectedItem.value)) 
                {
                    resultChoiceGameSelect.Items.Add(new Item("Game #" + (i + 1), i));
                }
            }

            resultChoiceGameSelect.SelectedItem = resultChoiceGameSelect.Items[0]; // set first one as selected
        }

        private void resultChoiceButton_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item)resultChoiceSelect.SelectedItem;
            Item selectedGame = (Item)resultChoiceGameSelect.SelectedItem;


            if (selectedItem.value == 0)
            {
                resultChoiceButton.Enabled = false;
                resultChoiceSelect.Enabled = false;
                resultChoiceGameSelect.Enabled = false;

                crossOutBoxSelect.Visible = true;
                crossOutButton.Visible = true;

                List<bool> crossOut = gameCards[selectedGame.value].checkCrossOut();

                crossOutBoxSelect.Items.Clear();
                crossOutBoxSelect.Items.AddRange(gameCards[selectedGame.value].showCrossOut(crossOut, choicesNames).ToArray());

                crossOutBoxSelect.SelectedItem = crossOutBoxSelect.Items[0]; // set first one as selected
            }
            else
            {
                gameCards[selectedGame.value].insertDice(dice, selectedItem.value);
                selectEnd();
            }
        }

        private void stopDiceButton_Click(object sender, EventArgs e)
        {
            rollCounter = 3;
            clearKeepDiceList();
            roundEnd();
        }

        private void crossOutButton_Click(object sender, EventArgs e)
        {
            Item selectedItem = (Item) crossOutBoxSelect.SelectedItem;
            Item selectedGame = (Item)resultChoiceGameSelect.SelectedItem;

            gameCards[selectedGame.value].crossOutDice(selectedItem.value);

            selectEnd();

            crossOutButton.Visible = false;
            crossOutBoxSelect.Visible = false;
        }

        private int getTotalScore()
        {
            int total = 0;
            for (int i = 0; i < nbGames; i++)
            {
                total += (gameCards[i].totalUpper() + gameCards[i].totalLower());
            }

            return total;
        }

        private int getUpperSectionAvgPoints()
        {
            int totalUpperScore = 0;
            for (int i = 0; i < gameCards.Count; i++)
            {
                totalUpperScore += gameCards[i].totalUpper();
            }

            return totalUpperScore / gameCards.Count;
        }

        private int getLowerSectionAvgPoints()
        {
            int totalLowerScore = 0;
            for (int i = 0; i < gameCards.Count; i++)
            {
                totalLowerScore += gameCards[i].totalLower();
            }

            return totalLowerScore / gameCards.Count;
        }

        private int getAvgPoints()
        {
            return getTotalScore()/nbGames;
        }

        private void selectEnd()
        {
            //reload GameCard

            printGameCardText();// --> nur das laden was benötigt wird

            //check if it is the end of the game

            bool gameEnded = true;
            int i = 0;

            while (i < nbGames && gameEnded)
            {
                if (!gameCards[i].checkEnd())
                {
                    gameEnded = false;
                }
                i++;
            }

            if (gameEnded)
            {
                int yahtzeeCounter = 0;
                for (int j = 0; j < gameCards.Count; j++)
                {
                    yahtzeeCounter += (gameCards[j].yahtzee.obtained) ? 1 : 0; 
                }

                string yahtzeeMsg = (yahtzeeCounter == 1) ? "Congratulations to your Yahtzee!\n" : (yahtzeeCounter == 0) ? "" : "Congratulations to your " + yahtzeeCounter + " Yahtzees!\n";

                string message = "Your Total Score was *** " + getTotalScore() + " *** (average of " + getAvgPoints() + " pts.)\n" + yahtzeeMsg + "\nDo you want to play another round ?";
                string caption = "END OF THE GAME";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);


                // If the no button was pressed ...
                if (result == DialogResult.No)
                {
                    System.Environment.Exit(0);
                }
                else if (result == DialogResult.Yes)
                {
                    gamecardUpperSection.Visible = false;
                    gamecardLowerSection.Visible = false;
                    gameCardLoadPicture.Visible = true;

                    Label[,] labels = getLabels();

                    for (int k = 0; k < labels.GetLength(0); k++)
                    {
                        for (int j = 0; j < labels.GetLength(1) - 1; j++)
                        {
                            if (j != 6 && j != 8 && j != 16 && j != 17 && j != 18)
                            {
                                labels[k, j].Text = "";
                            } 
                            else
                            {
                                labels[k, j].Text = "0";
                            }
                        }
                    }

                    nbGamesSelect.Enabled = true;
                    startButton.Enabled = true;
                    rollDiceButton.Enabled = false;
                    started = false;
                    nbGamesLastGame = nbGames;

                    //create new score entry
                    Score newScore = new Score(nbGames, getTotalScore(), getAvgPoints());

                    addScoreToScoreList(newScore);

                    gameNumber++; //next game with new id 
                }
            } 
            else
            {
                //restart
                rollCounter = 0;
                rollDiceButton.Enabled = true;
                rollDiceButton.Text = "Roll the dice (" + (maxAttemps - rollCounter) + " attemps left)";
                stopDiceButton.Enabled = false;
            }

            resultChoiceButton.Visible = false;
            resultChoiceDesc.Visible = false;
            resultChoiceSelect.Visible = false;
            resultChoiceInLabel.Visible = false;
            resultChoiceGameSelect.Visible = false;

            resultChoiceButton.Enabled = true;
            resultChoiceSelect.Enabled = true;
            
        }

        private void addScoreToScoreList(Score score)
        {
            System.Windows.Forms.ListViewItem listViewItem = new System.Windows.Forms.ListViewItem(new string[] {
            "" + this.gameNumber,
            "" + this.nbGamesLastGame ,
            "" + this.getUpperSectionAvgPoints(),
            "" + this.getLowerSectionAvgPoints(),
            "" + this.getAvgPoints(),
            "" + this.getTotalScore() }, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 8.25F));

            sf.scoreListView.Items.Add(listViewItem);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void resultChoiceGameSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void actionPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void crossOutGameSelect_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void gameCardPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (!started)
            {
                nbGames = Convert.ToInt32(nbGamesSelect.Text);
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            gameCardLoadPicture.Image = Image.FromFile("imgs/loading.gif");
            nbGamesSelect.Enabled = false;
            startButton.Enabled = false;

            startGame();

        }

        private void gamecardLowerSection_Paint(object sender, PaintEventArgs e)
        {
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            sf.ShowDialog();
        }
    }

}
