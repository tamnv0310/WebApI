//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapBullEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class INTEREST_RATES
    {
        public int RateID { get; set; }
        public int LoanID { get; set; }
        public decimal Value { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
    
        public virtual LOAN LOAN { get; set; }
    }
}
