using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace Requests.DB
{
    public partial class ListMessage
    {
        public int ListMessageId { get; set; }
        public int ListMessageChatIdFk { get; set; }
        public int ListMessageMessageIdFk { get; set; }

        public virtual Chat ListMessageChatIdFkNavigation { get; set; }
        public virtual Messages ListMessageMessageIdFkNavigation { get; set; }
    }
}
