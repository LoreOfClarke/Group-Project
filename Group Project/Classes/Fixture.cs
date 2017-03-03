using System;
namespace Group_Project.Classes
{
    /// <summary>
    /// A class containing the details of each fixture
    /// </summary>
    public class Fixture
    {
        /// <summary>
        /// The ID of the fixture
        /// </summary>
        public int FixtureID;
        /// <summary>
        /// The ID of the team playing at home
        /// </summary>
        public int HomeTeamID;
        /// <summary>
        /// The ID of the team playing away
        /// </summary>
        public int AwayTeamID;
        /// <summary>
        /// The name of the team playing at home
        /// </summary>
        public string HomeTeamName;
        /// <summary>
        /// The Name of the team playing away
        /// </summary>
        public string AwayTeamName;
        /// <summary>
        /// The date that the schedule is timed for
        /// </summary>
        public DateTime FixtureDate;
        /// <summary>
        /// The time that the fixture is scheduled for
        /// </summary>
        public DateTime FixtureTime;
        /// <summary>
        /// The goals the home team scored
        /// </summary>
        public string GoalsFor;
        /// <summary>
        /// The goals that the away team scored
        /// </summary>
        public string GoalsAgainst;
        /// <summary>
        /// Whether the match has been played
        /// </summary>
        public bool Played;
    }
}
