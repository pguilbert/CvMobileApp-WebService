﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataAccess.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CvModelContainer : DbContext
    {
        public CvModelContainer()
            : base("name=CvModelContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cv> Cvs { get; set; }
        public virtual DbSet<CompetenceGenerale> CompetencesGenerales { get; set; }
        public virtual DbSet<Formation> Formations { get; set; }
        public virtual DbSet<Mission> Missions { get; set; }
        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<SSII> SSIIs { get; set; }
    }
}
