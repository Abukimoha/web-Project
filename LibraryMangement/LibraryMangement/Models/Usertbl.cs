//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryMangement.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Usertbl
    {
        public Usertbl()
        {
            this.Transactiontbls = new HashSet<Transactiontbl>();
        }
    
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserGender { get; set; }
        public string UserDep { get; set; }
        public Nullable<int> UserAdminNo { get; set; }
        public string UserEmail { get; set; }
        public string UserPass { get; set; }
    
        public virtual ICollection<Transactiontbl> Transactiontbls { get; set; }
    }
}