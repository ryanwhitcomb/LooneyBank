//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LooneyBankModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bank
    {
        public Bank()
        {
            this.BankBranches = new HashSet<BankBranch>();
        }
    
        public int BankID { get; set; }
        public string BankName { get; set; }
        public string BankDesc { get; set; }
        public int RoutingNumber { get; set; }
        public bool IsOpen { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual ICollection<BankBranch> BankBranches { get; set; }
    }
}
