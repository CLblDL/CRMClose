using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Requests.DB
{
    public partial class Chat
    {
        public Chat()
        {
            ListMessage = new HashSet<ListMessage>();
            ListUserChats = new HashSet<ListUserChats>();
            Requests = new HashSet<Requests>();
        }

        public int ChatId { get; set; }
        public DateTime ChatDateCreate { get; set; }
        public int ChatInterlocutor { get; set; }

        public virtual ICollection<ListMessage> ListMessage { get; set; }
        public virtual ICollection<ListUserChats> ListUserChats { get; set; }
        public virtual ICollection<Requests> Requests { get; set; }
    }
}
