using System;
using System.Collections.Generic;
using System.Text;

namespace Football.Model.Entities
{
    public class Tournament : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public TournamentType TournamentType { get; set; }
        public DateTime InitDate { get; set; }
        public DateTime FinishDate { get; set; }
        public int PointsForWin { get; set; }
        public int PointsForLost { get; set; }
        public int PointsForDraw { get; set; }

    }
}
