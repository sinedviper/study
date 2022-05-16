using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Family.Models {
    public class SystemDBContextFamily : DbContext {
        public SystemDBContextFamily() : base("SystemDbContextFamily1") {
        }

        public DbSet<ExpensesCategory> ExpensesCategoryy { get; set; }
        public DbSet<IncomeCategory> IncomeCategories { get; set; }
        public DbSet<ExpenseRecords> ExpenseRecords { get; set; }
        public DbSet<IncomeRecords>IncomeRecords { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder) {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}