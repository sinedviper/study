namespace Family.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTableExpensesRecords : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ExpenseRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ExpensesCategoryId = c.Int(nullable: false),
                        ExpensesRecords = c.DateTime(nullable: false),
                        Value = c.Int(nullable: false),
                        Details = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ExpensesCategory", t => t.ExpensesCategoryId, cascadeDelete: true)
                .Index(t => t.ExpensesCategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ExpenseRecords", "ExpensesCategoryId", "dbo.ExpensesCategory");
            DropIndex("dbo.ExpenseRecords", new[] { "ExpensesCategoryId" });
            DropTable("dbo.ExpenseRecords");
        }
    }
}
