//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MegaCastingV2.DBlib
{
    using System;
    using System.Collections.Generic;
    
    public partial class Professionnel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Professionnel()
        {
            this.Annonces = new HashSet<Annonce>();
        }
    
        public int ID_PRO { get; set; }
        public string Prenom_PRO { get; set; }
        public string Nom_PRO { get; set; }
        public string Mail_PRO { get; set; }
        public string Pass_PRO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Annonce> Annonces { get; set; }
    }
}
