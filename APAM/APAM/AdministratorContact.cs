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
    
    public partial class AdministratorContact
    {
        public int AdministratorContactId { get; set; }
        public string Value { get; set; }
        public int AdministratorId { get; set; }
        public int ContactTypeId { get; set; }
    
        public virtual Administrator Administrator { get; set; }
        public virtual ContactType ContactType { get; set; }
    }
}