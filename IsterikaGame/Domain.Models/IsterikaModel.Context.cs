﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class IsterikaGameDBEntities : DbContext
    {
        private const string DbCopyName = "name=IsterikaGameSiteDBEntities_v2";
       private const string connectionString = "name=IsterikaGameSiteDBEntities";

        public IsterikaGameDBEntities()
            : base(DbCopyName)
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Word> Words { get; set; }
    }
}
