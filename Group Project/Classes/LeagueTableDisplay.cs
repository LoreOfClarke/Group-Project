namespace Group_Project.Classes
{
    /// <summary>
    /// A class to format a datagridview report
    /// </summary>
     class LeagueTableDisplay
    {
        public string Name { get; set; }
        public int GP { get; set; }
        public int W { get; set; }
        public int D { get; set; }
        public int L { get; set; }
        public int GF { get; set; }
        public int GA { get; set; }
        public int GD { get { return GF - GA; } }
        public int Pts { get; set; }
    }
}
