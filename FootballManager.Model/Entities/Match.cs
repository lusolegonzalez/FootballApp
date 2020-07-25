using System;
using System.Collections.Generic;
using System.Text;

namespace Football.Model.Entities
{
    public class Match : IEntityBase
    {
        public int Id { get; set; }
        public Team Local { get; set; }
        public Team Visit { get; set; }
        public int Field { get; set; }
        public DateTime? DateMatch { get; set; }

    }
}
