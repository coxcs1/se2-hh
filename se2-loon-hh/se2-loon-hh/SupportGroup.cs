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
    
    public partial class SupportGroup
    {
        public long Id { get; set; }
        public long ClientFreshStartId { get; set; }
        public string MonthAttended { get; set; }
        public Nullable<long> Year { get; set; }
    
        public virtual ClientFreshStart ClientFreshStart { get; set; }
    }
}