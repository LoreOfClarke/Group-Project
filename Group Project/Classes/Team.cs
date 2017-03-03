namespace Group_Project.Classes
{
    /// <summary>
    /// A class to hold details about a team
    /// </summary>
    public class Team
    {
        /// <summary>
        /// The ID of the team
        /// </summary>
        public int TeamID;
        /// <summary>
        /// The name of the team
        /// </summary>
        public string TeamName;
        /// <summary>
        /// THe stadium that the team plays in
        /// </summary>
        public string Stadium;
        /// <summary>
        /// The number of games that the team have won
        /// </summary>
        public int GamesWon;
        /// <summary>
        /// The number of games that the team have lost
        /// </summary>
        public int GamesLost;
        /// <summary>
        /// The number of games that the team have drawn
        /// </summary>
        public int GamesDrawn;
        /// <summary>
        /// A calculated field calculating the number of points a team has
        /// </summary>
        public int Points
        {
            get { return 3 * GamesWon + GamesDrawn; }
        }
        /// <summary>
        /// A calculated field calculating the number of matches a team has played
        /// </summary>
        public int Matches
        {
            get { return GamesWon + GamesDrawn + GamesLost; }
        }
        /// <summary>
        /// the number of goals the team has scored
        /// </summary>
        public int GoalsFor;
        /// <summary>
        /// THe number of goals that the team has conceded
        /// </summary>
        public int GoalsAgainst;
    }
}
