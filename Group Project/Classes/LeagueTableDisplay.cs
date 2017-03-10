namespace Group_Project.Classes
{
    /// <summary>
    /// A class to format a datagridview report
    /// </summary>
     class LeagueTableDisplay
    {
        public string Name { get; set; }
        public int Goals_Played { get; set; }
        public int Wins { get; set; }
        public int Draws { get; set; }
        public int Losses { get; set; }
        public int Goals_For { get; set; }
        public int Goals_Against { get; set; }
        public int Goals_Difference { get { return Goals_For - Goals_Against; } }
        public int Points { get; set; }
    }
}
