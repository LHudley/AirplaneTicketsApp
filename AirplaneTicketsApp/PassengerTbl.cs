//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AirplaneTicketsApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class PassengerTbl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PassengerTbl()
        {
            this.AirlineRecords = new HashSet<AirlineRecord>();
        }
    
        public int id { get; set; }
        public string passengerType { get; set; }
        public Nullable<int> destinationId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AirlineRecord> AirlineRecords { get; set; }
        public virtual DestinationTbl DestinationTbl { get; set; }
    }
}
