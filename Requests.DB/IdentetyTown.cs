using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Requests.DB
{
    public partial class IdentetyTown
    {
        public IdentetyTown()
        {
            RequestsAddress = new HashSet<RequestsAddress>();
        }

        public int IdentetyTownId { get; set; }
        public int TownIndex { get; set; }
        public int NameTownId { get; set; }

        public virtual Town NameTown { get; set; }
        public virtual ICollection<RequestsAddress> RequestsAddress { get; set; }
    }
}
