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
    
    public partial class petTodo
    {
        public int petTodoID { get; set; }
        public Nullable<int> petTodo_animalID { get; set; }
        public Nullable<int> petTodo_todoDataID { get; set; }
        public string petTododate { get; set; }
        public string petTodoYN { get; set; }
    
        public virtual animalData animalData { get; set; }
    }
}
