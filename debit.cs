//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BankApplikáció
{
    using System;
    using System.Collections.Generic;
    
    public partial class debit
    {
        public int sno { get; set; }
        public string Date { get; set; }
        public Nullable<decimal> Account_No { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Old_Balance { get; set; }
        public string Message { get; set; }
        public Nullable<decimal> Deb_Amount { get; set; }
    }
}