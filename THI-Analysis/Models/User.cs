//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace THI_Analysis.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            this.ACLBridges = new HashSet<ACLBridge>();
            this.UsageActivityLogs = new HashSet<UsageActivityLog>();
        }
    
        public int Userkey { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public Nullable<int> Admin { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string UserGUID { get; set; }
        public string Username { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> Role { get; set; }
        public Nullable<int> Product { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ACLBridge> ACLBridges { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<UsageActivityLog> UsageActivityLogs { get; set; }
    }
}
