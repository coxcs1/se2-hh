//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace se2_loon_hh
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClassAttendance
    {
        public long Id { get; set; }
        public long ClientId { get; set; }
        public string Month { get; set; }
        public Nullable<long> Year { get; set; }
        public Nullable<long> Count { get; set; }
        public string Comment { get; set; }
    
        public virtual Client Client { get; set; }
    }
}
