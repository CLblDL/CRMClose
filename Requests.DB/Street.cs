using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Requests.DB
{
    public partial class Street
    {
        public Street()
        {
            RequestsAddress = new HashSet<RequestsAddress>();
        }

        public int StreetId { get; set; }
        public string StreetName { get; set; }

        public virtual ICollection<RequestsAddress> RequestsAddress { get; set; }
    }
}
