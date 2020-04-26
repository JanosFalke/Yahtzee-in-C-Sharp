using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee_UI
{
    class Score
    {
        public int nbGames;
        public int nbPoints;
        public int avgPoints;

        public Score(int nbGames, int nbPoints, int avgPoints)
        {
            this.nbGames = nbGames;
            this.nbPoints = nbPoints;
            this.avgPoints = avgPoints;
        }
    }
}
