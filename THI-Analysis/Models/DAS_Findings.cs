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
    
    public partial class DAS_Findings
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DAS_Findings()
        {
            this.THI_AnalysisFeedback = new HashSet<THI_AnalysisFeedback>();
        }
    
        public int DAS_FindingsKey { get; set; }
        public string DAS_FindingsDescription { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THI_AnalysisFeedback> THI_AnalysisFeedback { get; set; }
    }
}
