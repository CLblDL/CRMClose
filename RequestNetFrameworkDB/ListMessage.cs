//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RequestNetFrameworkDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class ListMessage
    {
        public int listMessageID { get; set; }
        public int listMessageChatID_fk_ { get; set; }
        public int listMessageMessageID_fk_ { get; set; }
    
        public virtual Chat Chat { get; set; }
        public virtual Messages Messages { get; set; }
    }
}