//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LBModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class BankBranchPhone
    {
        public int BankBranchPhoneID { get; set; }
        public int BankBranchID { get; set; }
        public int PhoneTypeID { get; set; }
        public string PhoneNum { get; set; }
        public string Extension { get; set; }
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdatedBy { get; set; }
    
        public virtual BankBranch BankBranch { get; set; }
        public virtual PhoneType PhoneType { get; set; }
    }
}
