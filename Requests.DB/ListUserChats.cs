using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Requests.DB
{
    public partial class ListUserChats
    {
        public int ListUserChatId { get; set; }
        public int ListUserChatUserId { get; set; }
        public int ListUserChatChatId { get; set; }

        public virtual Chat ListUserChatChat { get; set; }
        public virtual User ListUserChatUser { get; set; }
    }
}
