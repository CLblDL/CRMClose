using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Requests.DB
{
    public partial class User
    {
        public User()
        {
            ListRequestsAtUser = new HashSet<ListRequestsAtUser>();
            ListUserChats = new HashSet<ListUserChats>();
        }

        public int UserId { get; set; }
        public int UserLoginAndpasswordFk { get; set; }
        public int UserConditionFk { get; set; }
        public int UserDepartamentFk { get; set; }
        public int UserCategoryFk { get; set; }
        public string UserName { get; set; }
        public string UserPatranymic { get; set; }
        public string UserSurname { get; set; }
        public DateTime UserDateCreate { get; set; }
        public string UserNumberPhone { get; set; }

        public virtual UserCategory UserCategoryFkNavigation { get; set; }
        public virtual ConditionTheUser UserConditionFkNavigation { get; set; }
        public virtual Department UserDepartamentFkNavigation { get; set; }
        public virtual LoginAndpasswordUsers UserLoginAndpasswordFkNavigation { get; set; }
        public virtual ICollection<ListRequestsAtUser> ListRequestsAtUser { get; set; }
        public virtual ICollection<ListUserChats> ListUserChats { get; set; }
    }
}
