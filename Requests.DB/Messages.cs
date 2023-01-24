using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Requests.DB
{
    public partial class Messages
    {
        public Messages()
        {
            ListMessage = new HashSet<ListMessage>();
        }

        public int MessagesId { get; set; }
        public int SenderId { get; set; }
        public string MessageContent { get; set; }
        public DateTime MessageDateCreate { get; set; }
        public bool MessageCondition { get; set; }

        public virtual ICollection<ListMessage> ListMessage { get; set; }
    }
}
