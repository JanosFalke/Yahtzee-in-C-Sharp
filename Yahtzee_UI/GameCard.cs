using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace Yahtzee_UI
{
    class GameCard
    {

        public int aces = -1, twos = -1, threes = -1, fours = -1, fives = -1, sixes = -1;
        public int threeOfKind = -1, fourOfKind = -1;
        public FullHouse fullHouse;
        public SmallStreet smallStreet;
        public LargeStreet largeStreet;
        public Yahtzee yahtzee;
        public int chance = -1;
        public int bonus = 35;
        public int bonusLimit = 63;


        public GameCard()
        {
            this.fullHouse = new FullHouse();
            this.smallStreet = new SmallStreet();
            this.largeStreet = new LargeStreet();
            this.yahtzee = new Yahtzee();
        }

        public bool checkEnd()
        {
            bool ended = false;

            if (this.aces != -1 && this.twos != -1 && this.threes != -1 && this.fours != -1 && this.fives != -1 && this.sixes != -1 && this.threeOfKind != -1
                && this.fourOfKind != -1 && this.fullHouse.obtained && this.smallStreet.obtained && this.largeStreet.obtained && this.yahtzee.obtained && this.chance != -1)
            {
                ended = true;
            }

            return ended;
        }

        public List<bool> checkResult(List<int> dice)
        {

            List<bool> choices = new List<bool>();

            //check upper section
            choices.Add(true); //to cross something out (always available)
            choices.Add((dice.Contains(0) && this.aces == -1));
            choices.Add((dice.Contains(1) && this.twos == -1));
            choices.Add((dice.Contains(2) && this.threes == -1));
            choices.Add((dice.Contains(3) && this.fours == -1));
            choices.Add((dice.Contains(4) && this.fives == -1));
            choices.Add((dice.Contains(5) && this.sixes == -1));

            //check lower section 
            choices.Add(check3OfKind(dice));
            choices.Add(check4OfKind(dice));
            choices.Add(checkFullHouse(dice));
            choices.Add(checkSmallStreet(dice));
            choices.Add(checkLargeStreet(dice));
            choices.Add(checkYahtzee(dice));
            choices.Add(this.chance == -1);

            return choices;
        }


        public List<bool> checkCrossOut()
        {
            List<bool> crossOut = new List<bool>();
            crossOut.Add(false); //to have the same order as checkResult
            crossOut.Add(this.aces == -1);
            crossOut.Add(this.twos == -1);
            crossOut.Add(this.threes == -1);
            crossOut.Add(this.fours == -1);
            crossOut.Add(this.fives == -1);
            crossOut.Add(this.sixes == -1);
            crossOut.Add(this.threeOfKind == -1);
            crossOut.Add(this.fourOfKind == -1);
            crossOut.Add(!this.fullHouse.obtained);
            crossOut.Add(!this.smallStreet.obtained);
            crossOut.Add(!this.largeStreet.obtained);
            crossOut.Add(!this.yahtzee.obtained);
            crossOut.Add(this.chance == -1);

            return crossOut;
        }

        public bool checkGameOption(int key)
        {
            bool result = false;

            switch (key)
            {
                //check if you can still cross out
                case 0:
                    result = (this.aces == -1 || this.twos == -1 || this.threes == -1 || this.fours == -1 || this.fives == -1 || this.sixes == -1 || this.threeOfKind == -1
                || this.fourOfKind == -1 || !this.fullHouse.obtained || !this.smallStreet.obtained || !this.largeStreet.obtained || !this.yahtzee.obtained || this.chance == -1) ? true : false;
                    break;
                case 1:
                    result = (this.aces == -2) ? false : (this.aces == -1) ? true : false;
                    break;
                case 2:
                    result = (this.twos == -2) ? false : (this.twos == -1) ? true : false;
                    break;
                case 3:
                    result = (this.threes == -2) ? false : (this.threes == -1) ? true : false;
                    break;
                case 4:
                    result = (this.fours == -2) ? false : (this.fours == -1) ? true : false;
                    break;
                case 5:
                    result = (this.fives == -2) ? false : (this.fives == -1) ? true : false;
                    break;
                case 6:
                    result = (this.sixes == -2) ? false : (this.sixes == -1) ? true : false;
                    break;
                case 7:
                    result = (this.threeOfKind == -2) ? false : (this.threeOfKind == -1) ? true : false;
                    break;
                case 8:
                    result = (this.fourOfKind == -2) ? false : (this.fourOfKind == -1) ? true : false;
                    break;
                case 9:
                    result = !this.fullHouse.obtained;
                    break;
                case 10:
                    result = !this.smallStreet.obtained;
                    break;
                case 11:
                    result = !this.largeStreet.obtained;
                    break;
                case 12:
                    result = !this.yahtzee.obtained;
                    break;
                case 13:
                    result = (this.chance == -2) ? false : (this.chance == -1) ? true : false;
                    break;
                default:
                    break;
            }
            return result;
        }

        public List<Item> showOptions(List<bool> choices, List<string> choicesNames, List<int> dice)
        {
            List<Item> options = new List<Item>();

            if (choices[0]) 
                options.Add(new Item(choicesNames[0], 0));
            
            if (choices[1])
                options.Add(new Item(choicesNames[1] + " (" + this.diceSum(dice, 0) + ")", 1));
            
            if (choices[2])
                options.Add(new Item(choicesNames[2] + " (" + this.diceSum(dice, 1) + ")", 2));

            if (choices[3])
                options.Add(new Item(choicesNames[3] + " (" + this.diceSum(dice, 2) + ")", 3));

            if (choices[4])
                options.Add(new Item(choicesNames[4] + " (" + this.diceSum(dice, 3) + ")", 4));

            if (choices[5])
                options.Add(new Item(choicesNames[5] + " (" + this.diceSum(dice, 4) + ")", 5));

            if (choices[6])
                options.Add(new Item(choicesNames[6] + " (" + this.diceSum(dice, 5) + ")", 6));

            if (choices[7])
                options.Add(new Item(choicesNames[7] + " (" + this.allDiceSum(dice) + ")", 7));

            if (choices[8])
                options.Add(new Item(choicesNames[8] + " (" + this.allDiceSum(dice) + ")", 8));

            if (choices[9])
                options.Add(new Item(choicesNames[9] + " (" + this.fullHouse.value + ")", 9));

            if (choices[10])
                options.Add(new Item(choicesNames[10] + " (" + this.smallStreet.value + ")", 10));

            if(choices[11])
                options.Add(new Item(choicesNames[11] + " (" + this.largeStreet.value + ")", 11));

            if (choices[12])
                options.Add(new Item(choicesNames[12] + " (" + this.yahtzee.value + ")", 12));

            if (choices[13])
                options.Add(new Item(choicesNames[13] + " (" + this.allDiceSum(dice) + ")", 13));

            return options;
        }



        public List<Item> showCrossOut(List<bool> crossOut, List<string> choicesNames)
        {
            List<Item> options = new List<Item>();

            for (int i = 0; i < crossOut.Count; i++)
            {
                if (crossOut[i])
                {
                    options.Add(new Item(choicesNames[i], i));
                }
            }

            return options;
        }



        public bool insertDice(List<int> dice, int key)
        {
            bool completed = true;
            switch (key)
            {
                case 1:
                    this.aces = this.diceSum(dice, 0);
                    break;
                case 2:
                    this.twos = this.diceSum(dice, 1);
                    break;
                case 3:
                    this.threes = this.diceSum(dice, 2);
                    break;
                case 4:
                    this.fours = this.diceSum(dice, 3);
                    break;
                case 5:
                    this.fives = this.diceSum(dice, 4);
                    break;
                case 6:
                    this.sixes = this.diceSum(dice, 5);
                    break;
                case 7:
                    this.threeOfKind = this.allDiceSum(dice);
                    break;
                case 8:
                    this.fourOfKind = this.allDiceSum(dice);
                    break;
                case 9:
                    this.fullHouse.obtained = true;
                    break;
                case 10:
                    this.smallStreet.obtained = true;
                    break;
                case 11:
                    this.largeStreet.obtained = true;
                    break;
                case 12:
                    this.yahtzee.obtained = true;
                    break;
                case 13:
                    this.chance = this.allDiceSum(dice);
                    break;
                default:
                    completed = false;
                    break;
            }

            return completed;
        }


        public bool crossOutDice(int key)
        {
            bool completed = true;
            switch (key)
            {
                case 1:
                    this.aces = -2;
                    break;
                case 2:
                    this.twos = -2;
                    break;
                case 3:
                    this.threes = -2;
                    break;
                case 4:
                    this.fours = -2;
                    break;
                case 5:
                    this.fives = -2;
                    break;
                case 6:
                    this.sixes = -2;
                    break;
                case 7:
                    this.threeOfKind = -2;
                    break;
                case 8:
                    this.fourOfKind = -2;
                    break;
                case 9:
                    this.fullHouse.obtained = true;
                    this.fullHouse.value = -2;
                    break;
                case 10:
                    this.smallStreet.obtained = true;
                    this.smallStreet.value = -2;
                    break;
                case 11:
                    this.largeStreet.obtained = true;
                    this.largeStreet.value = -2;
                    break;
                case 12:
                    this.yahtzee.obtained = true;
                    this.yahtzee.value = -2;
                    break;
                case 13:
                    this.chance = -2;
                    break;
                default:
                    completed = false;
                    break;
            }

            return completed;
        }

        private int diceSum(List<int> dice, int value)
        {
            int sum = 0;
            foreach (int number in dice)
            {
                if (value == number)
                {
                    sum += value + 1;
                }
            }
            return sum;
        }

        private int allDiceSum(List<int> dice)
        {
            int sum = 0;
            foreach (int number in dice)
            {
                sum += number + 1;
            }
            return sum;
        }

        private bool checkYahtzee(List<int> dice)
        {
            bool available = true;

            if (this.yahtzee.obtained)
            {
                return false;
            }

            int i = 1;
            while (i < dice.Count && available)
            {
                if (dice[i] != dice[i - 1])
                {
                    available = false;
                }
                i++;
            }

            return available;
        }

        private bool checkLargeStreet(List<int> dice)
        {
            if (this.largeStreet.obtained)
            {
                return false;
            }

            int countNeeded = 4;
            int counter = streetCounter(dice, countNeeded);

            return (counter >= countNeeded ? true : false);
        }

        private bool checkSmallStreet(List<int> dice)
        {
            if (this.smallStreet.obtained)
            {
                return false;
            }

            int countNeeded = 3;
            int counter = streetCounter(dice, countNeeded);

            return (counter >= countNeeded ? true : false);
        }

        private int streetCounter(List<int> dice, int countNeeded)
        {
            int counter = 0, i = 1;

            dice.Sort();

            while (i < dice.Count && counter < countNeeded)
            {
                if (dice[i] == (dice[i - 1] + 1))
                {
                    counter++;
                }
                else if (dice[i] != dice[i - 1])
                {
                    counter = 0;
                }
                i++;
            }

            return counter;
        }

        private bool checkFullHouse(List<int> dice)
        {
            if (this.fullHouse.obtained)
            {
                return false;
            }

            bool available = true;

            int[] counts = { 0, 0, 0, 0, 0, 0 };

            for (int j = 0; j < dice.Count; j++)
            {
                counts[dice[j]]++;
            }

            int i = 0;

            while (available && i < counts.Length)
            {
                if (counts[i] == 1 || counts[i] == 4 || counts[i] == 5)
                {
                    available = false;
                }
                i++;
            }

            return available;
        }


        private bool check3OfKind(List<int> dice)
        {
            bool available = false;

            if (this.threeOfKind != -1)
            {
                return available;
            }

            return checkOfAKind(dice, 3);
        }

        private bool check4OfKind(List<int> dice)
        {
            bool available = false;

            if (this.fourOfKind != -1)
            {
                return available;
            }

            return checkOfAKind(dice, 4);
        }

        private bool checkOfAKind(List<int> dice, int countNeeded)
        {
            bool available = false;

            int i = 0;
            int[] counts = { 0, 0, 0, 0, 0, 0 };


            while (i < dice.Count && !available)
            {
                counts[dice[i]]++;

                int j = 0;
                while (j < counts.Length)
                {
                    if (counts[j] >= countNeeded)
                    {
                        available = true;
                    }
                    j++;
                }
                i++;
            }
            return available;
        }

        public int totalScore()
        {
            return (this.aces <= -1 ? 0 : this.aces) + (this.twos <= -1 ? 0 : this.twos) + (this.threes <= -1 ? 0 : this.threes)
                + (this.fours <= -1 ? 0 : this.fours) + (this.fives <= -1 ? 0 : this.fives) + (this.sixes <= -1 ? 0 : this.sixes);
        }

        public int totalLower()
        {
            return (this.threeOfKind <= -1 ? 0 : this.threeOfKind) + (this.fourOfKind <= -1 ? 0 : this.fourOfKind) + (this.fullHouse.obtained && this.fullHouse.value != -2 ? this.fullHouse.value : 0)
                + (this.smallStreet.obtained && this.smallStreet.value != -2 ? this.smallStreet.value : 0) + (this.largeStreet.obtained && this.largeStreet.value != -2 ? this.largeStreet.value : 0)
                + (this.yahtzee.obtained && this.yahtzee.value != -2 ? this.yahtzee.value : 0) + (this.chance <= -1 ? 0 : this.chance);
        }

        public int totalUpper()
        {
            return (this.totalScore() >= this.bonusLimit ? bonus + this.totalScore() : this.totalScore());
        }


    }
}
