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
    
    public partial class AirlineRecord
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Nullable<System.DateTime> departuredt { get; set; }
        public Nullable<System.DateTime> returndt { get; set; }
        public string departureFrom { get; set; }
        public string tripType { get; set; }
        public Nullable<int> passengerId { get; set; }
    
        public virtual PassengerTbl PassengerTbl { get; set; }
    }
}
