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
    
    public partial class ProgressPointTracking
    {
        public long Id { get; set; }
        public Nullable<long> ClientId { get; set; }
        public string Date { get; set; }
        public string Description { get; set; }
        public Nullable<long> PointsSpent { get; set; }
        public string Letter { get; set; }
        public string NoShow { get; set; }
        public string Comment { get; set; }
    
        public virtual Client Client { get; set; }
    }
}
