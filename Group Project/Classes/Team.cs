namespace Group_Project.Classes
{
    public class Team
    {
        public int TeamID;
        public string TeamName;
        public string Stadium;
        public int GamesWon;
        public int GamesLost;
        public int GamesDrawn;
        public int Points
        {
            get { return 3 * GamesWon + GamesDrawn; }
        }
        public int Matches
        {
            get { return GamesWon + GamesDrawn + GamesLost; }
        }
        public int GoalsFor;
        public int GoalsAgainst;
    }
}
