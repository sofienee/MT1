//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MT.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ARTICLES
    {
        public int ARTID { get; set; }
        public string ARTCODE { get; set; }
        public Nullable<int> ARTTYPE { get; set; }
        public Nullable<int> ARTISACTIF { get; set; }
        public Nullable<int> ARTORDRE { get; set; }
        public Nullable<int> AFMID { get; set; }
        public string ARTUNCODE { get; set; }
        public Nullable<int> ARUNLIBELLE { get; set; }
        public string ARTDESIGNATION { get; set; }
        public string ARTDESIGNATIONMOBILE { get; set; }
        public string ARTCODEBARRE { get; set; }
        public Nullable<int> ARTISSTOCK { get; set; }
        public Nullable<int> ARTISVENDU { get; set; }
        public Nullable<int> ARTISFORFAIT { get; set; }
        public Nullable<int> ARTSUIVISTOCK { get; set; }
        public Nullable<int> ARTISSTATISTIQUE { get; set; }
        public Nullable<int> ARTISGARANTIE { get; set; }
        public Nullable<int> ARTISSOUMISCOM { get; set; }
        public Nullable<int> ARTISSOUMISREM { get; set; }
        public Nullable<decimal> ARTPRIXACH { get; set; }
        public Nullable<decimal> ARTPRIXVEN { get; set; }
        public Nullable<int> ARTPVISTTC { get; set; }
        public Nullable<decimal> ARTSEUILVENTE { get; set; }
        public Nullable<decimal> ARTQTEVENTEMINI { get; set; }
        public Nullable<decimal> ARTPOIDS { get; set; }
        public string ARTUNITEPOIDS { get; set; }
        public Nullable<decimal> ARTVOLUME { get; set; }
        public string ARTUNITEVOL { get; set; }
        public Nullable<decimal> ARTLARGEUR { get; set; }
        public Nullable<decimal> ARTLONGUEUR { get; set; }
        public Nullable<decimal> ARTHAUTEUR { get; set; }
        public Nullable<int> TVAID { get; set; }
        public string ARTPHOTO { get; set; }
        public Nullable<decimal> ARTCOLISAGE { get; set; }
        public string USERUPDATE { get; set; }
        public string USERCREATE { get; set; }
        public Nullable<System.DateTime> DATECREATE { get; set; }
        public Nullable<System.DateTime> DATEUPDATE { get; set; }
        public string DISTRIBUTEUR { get; set; }
        public object Article { get; internal set; }
    }
}