using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Requests.DB
{
    public partial class RequestsUrgency
    {
        public RequestsUrgency()
        {
            Requests = new HashSet<Requests>();
        }

        public int RequestsUrgencyId { get; set; }
        public string RequestsUrgencyName { get; set; }

        public virtual ICollection<Requests> Requests { get; set; }
    }
}
