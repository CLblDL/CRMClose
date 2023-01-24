using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Requests.DB
{
    public partial class Town
    {
        public Town()
        {
            IdentetyTown = new HashSet<IdentetyTown>();
        }

        public int TownId { get; set; }
        public string TownName { get; set; }

        public virtual ICollection<IdentetyTown> IdentetyTown { get; set; }
    }
}
