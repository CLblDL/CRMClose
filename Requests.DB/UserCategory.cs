using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Requests.DB
{
    public partial class UserCategory
    {
        public UserCategory()
        {
            User = new HashSet<User>();
        }

        public int UserCategoryId { get; set; }
        public string UserCategoryName { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
