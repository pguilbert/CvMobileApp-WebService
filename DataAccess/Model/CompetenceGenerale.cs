//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class CompetenceGenerale
    {
        public string Categorie { get; set; }
        public string Nom { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public int CvId { get; set; }
    
        public virtual Cv Cv { get; set; }
    }
}
