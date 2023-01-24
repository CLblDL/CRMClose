using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Requests.DB
{
    public partial class RequestsAddress
    {
        public RequestsAddress()
        {
            Requests = new HashSet<Requests>();
        }

        public int RequestsAddressId { get; set; }
        public int RequestsAdressTownFk { get; set; }
        public int RequestAdressStreetFk { get; set; }
        public string RequestAdressBuilding { get; set; }
        public int RequestAsressNumberHouse { get; set; }

        public virtual Street RequestAdressStreetFkNavigation { get; set; }
        public virtual IdentetyTown RequestsAdressTownFkNavigation { get; set; }
        public virtual ICollection<Requests> Requests { get; set; }
    }
}
