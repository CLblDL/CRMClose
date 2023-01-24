using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Requests.DB
{
    public partial class ListRequestsAtUser
    {
        public int ListRequestsAtUserId { get; set; }
        public int ListRequestsAtUserUserIdFk { get; set; }
        public int ListRequestsAtUserRequestIdFk { get; set; }
        public int ListRequestsAtUserUserRoleFk { get; set; }

        public virtual Requests ListRequestsAtUserRequestIdFkNavigation { get; set; }
        public virtual User ListRequestsAtUserUserIdFkNavigation { get; set; }
        public virtual UserRoleInrequest ListRequestsAtUserUserRoleFkNavigation { get; set; }
    }
}
