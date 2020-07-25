using System;
using System.Collections.Generic;
using System.Text;

namespace Football.Model.Entities
{
    public class Team : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Player Captain { get; set; }
        public IList<Player> Players { get; set; }
        
        ////stadistic by tournament
        //public int Lost { get; set; }
        //public int Won { get; set; }
        //public int Draw { get; set; }
        //public int GoalsFor { get; set; }
        //public int GoalsDiff { get; set; }
        //public int GoalsAgainst { get; set; }
        //public int Points { get; set; }
        //public int GroupPosition { get; set; }
        
    }
}
