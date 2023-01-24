using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Requests.DB
{
    public partial class Requests
    {
        public Requests()
        {
            ListRequestsAtUser = new HashSet<ListRequestsAtUser>();
        }

        public int RequestsId { get; set; }
        public string RequestsName { get; set; }
        public string RequestsDescription { get; set; }
        public int RequestsCategoryIdFk { get; set; }
        public int RequestsUrgencyIdFk { get; set; }
        public int RequestsAddressIdFk { get; set; }
        public int RequestsCabinetNumber { get; set; }
        public int RequestsChatIdFk { get; set; }
        public int RequestConditionIdFk { get; set; }
        public int? RequestScore { get; set; }

        public virtual RequestCondition RequestConditionIdFkNavigation { get; set; }
        public virtual RequestsAddress RequestsAddressIdFkNavigation { get; set; }
        public virtual RequestsCategory RequestsCategoryIdFkNavigation { get; set; }
        public virtual Chat RequestsChatIdFkNavigation { get; set; }
        public virtual RequestsUrgency RequestsUrgencyIdFkNavigation { get; set; }
        public virtual ICollection<ListRequestsAtUser> ListRequestsAtUser { get; set; }
    }
}
