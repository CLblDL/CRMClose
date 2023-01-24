using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Requests.DB
{
    public partial class UserRoleInrequest
    {
        public UserRoleInrequest()
        {
            ListRequestsAtUser = new HashSet<ListRequestsAtUser>();
        }

        public int UserRoleInrequestId { get; set; }
        public string UserRoleInrequestName { get; set; }

        public virtual ICollection<ListRequestsAtUser> ListRequestsAtUser { get; set; }
    }
}
