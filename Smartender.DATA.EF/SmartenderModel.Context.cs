﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Smartender.DATA.EF
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SmartenderEntities : DbContext
    {
        public SmartenderEntities()
            : base("name=SmartenderEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Alcohol> Alcohols { get; set; }
        public virtual DbSet<Cocktail> Cocktails { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}
