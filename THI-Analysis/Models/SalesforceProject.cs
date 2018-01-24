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
    
    public partial class SalesforceProject
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalesforceProject()
        {
            this.CustomOPPEinfoes = new HashSet<CustomOPPEinfo>();
            this.ProjectHospitals = new HashSet<ProjectHospital>();
            this.THI_AnalysisFeedback = new HashSet<THI_AnalysisFeedback>();
        }
    
        public int ProjectKey { get; set; }
        public string ProjectName { get; set; }
        public string ProdDBName { get; set; }
        public string DataManagerName { get; set; }
        public string STGDBName { get; set; }
        public string CCC_3M { get; set; }
        public string RunAPRDRG { get; set; }
        public Nullable<int> CustomOPPE { get; set; }
        public Nullable<int> PG { get; set; }
        public Nullable<System.DateTime> MAxRR { get; set; }
        public Nullable<bool> APRDRGAggregate { get; set; }
        public string ProjectID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomOPPEinfo> CustomOPPEinfoes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProjectHospital> ProjectHospitals { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<THI_AnalysisFeedback> THI_AnalysisFeedback { get; set; }
    }
}
