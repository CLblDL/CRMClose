using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Requests.DB
{
    public partial class RequestsCategory
    {
        public RequestsCategory()
        {
            Requests = new HashSet<Requests>();
        }

        public int RequestsCategoryId { get; set; }
        public string RequestsCategoryName { get; set; }

        public virtual ICollection<Requests> Requests { get; set; }
    }
}
