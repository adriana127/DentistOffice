//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cabinet_Stomatologic.Model.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class personinformation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public personinformation()
        {
            this.doctors = new HashSet<doctor>();
            this.patients = new HashSet<patient>();
        }
    
        public int idPersonInformation { get; set; }
        public string adress { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public Nullable<System.DateTime> birthdate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<doctor> doctors { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<patient> patients { get; set; }
    }
}
