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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class banking_dbEntities : DbContext
    {
        public banking_dbEntities()
            : base("name=banking_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Admin_Table> Admin_Table { get; set; }
        public virtual DbSet<debit> debit { get; set; }
        public virtual DbSet<deposit> deposit { get; set; }
        public virtual DbSet<employeeAccount> employeeAccount { get; set; }
        public virtual DbSet<FD> FD { get; set; }
        public virtual DbSet<transfer> transfer { get; set; }
        public virtual DbSet<userAccount> userAccount { get; set; }
        public virtual DbSet<userTable> userTable { get; set; }
    }
}
