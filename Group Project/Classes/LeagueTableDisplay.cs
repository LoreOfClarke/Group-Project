using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Group_Project.Classes
{
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
