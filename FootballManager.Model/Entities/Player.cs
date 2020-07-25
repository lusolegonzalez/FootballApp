using System;
using System.Collections.Generic;
using System.Text;

namespace Football.Model.Entities
{
    public class Player : ApplicationUser //IEntityBase
    {
        public int Id { get; set; }
        //public string Name { get; set; }
        //public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        //public Gender Gender { get; set; }
        public string Dni { get; set; }
        public string CelNumber { get; set; }
        //public string Email { get; set; }
        public bool IsCaptain { get; set; }
        public int Jersey { get; set; }
        public Team Team { get; set; }

        ////stadistic
        //public int Goals { get; set; }
        //public int YellowCards { get; set; }
        //public int RedCards { get; set; }
        //public int GamesPlayed { get; set; }
    }
}
