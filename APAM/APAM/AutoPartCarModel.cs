//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APAM
{
    using System;
    using System.Collections.Generic;
    
    public partial class AutoPartCarModel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AutoPartCarModel()
        {
            this.AutoParts = new HashSet<AutoPart>();
        }
    
        public int AutoPartCarModelId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AutoPart> AutoParts { get; set; }
    }
}
