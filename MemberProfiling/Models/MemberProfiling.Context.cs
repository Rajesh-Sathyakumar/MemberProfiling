﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MemberProfiling.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class MemberProfilingEntities : DbContext
    {
        public MemberProfilingEntities()
            : base("name=MemberProfilingEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AppModule> AppModules { get; set; }
        public virtual DbSet<AppModulesInfo> AppModulesInfoes { get; set; }
        public virtual DbSet<Chennai_Business_Analysts> Chennai_Business_Analysts { get; set; }
        public virtual DbSet<MemberProfilingMaster> MemberProfilingMasters { get; set; }
        public virtual DbSet<ProfilingScore> ProfilingScores { get; set; }
        public virtual DbSet<SalesforceProject> SalesforceProjects { get; set; }
        public virtual DbSet<ProjectView> ProjectViews { get; set; }
    }
}
