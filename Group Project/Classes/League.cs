namespace Group_Project.Classes
{
    /// <summary>
    /// A class to hold the details of a league
    /// </summary>
    public class League
    {
        /// <summary>
        /// The League's ID
        /// </summary>
        public int LeagueId { get; set; }
        /// <summary>
        /// The name of the league
        /// </summary>
        public string LeagueName { get; set; }
        /// <summary>
        /// The capacity of the league
        /// </summary>
        public int Capacity { get; set; }
        /// <summary>
        /// The sponsor of the league
        /// </summary>
        public string Sponsor { get; set; }
    }
}
