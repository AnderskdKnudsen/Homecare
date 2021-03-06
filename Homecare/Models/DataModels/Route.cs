//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Homecare.Models.DataModels
{
    using System;
    using System.Collections.Generic;
    
    public partial class Route
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Route()
        {
            this.Schedules = new HashSet<Schedule>();
        }
    
        public int id_route { get; set; }
        public System.TimeSpan arrival { get; set; }
        public System.DateTime date { get; set; }
        public int fk_caretaker_route { get; set; }
        public int fk_address_route { get; set; }
    
        public virtual Address Address { get; set; }
        public virtual Caretaker Caretaker { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Schedule> Schedules { get; set; }
    }
}
