//------------------------------------------------------------------------------
// <auto-generated>
//     這個程式碼是由範本產生。
//
//     對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//     如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace slnPetAdmin.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MsgUser
    {
        public int msgID { get; set; }
        public string msgTime { get; set; }
        public string msgFrom_userID { get; set; }
        public string msgFrom_userName { get; set; }
        public string msgTo_userID { get; set; }
        public string msgType { get; set; }
        public string msgFromURL { get; set; }
        public string msgContent { get; set; }
        public string msgRead { get; set; }
    }
}
