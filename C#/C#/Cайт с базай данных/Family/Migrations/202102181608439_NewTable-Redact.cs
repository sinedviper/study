namespace Family.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTableRedact : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.IncomeRecord", "IncomeCategoryId", "dbo.IncomeCategory");
            DropIndex("dbo.IncomeRecord", new[] { "IncomeCategoryId" });
            DropTable("dbo.IncomeRecord");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.IncomeRecord",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IncomeCategoryId = c.Int(nullable: false),
                        ExpensesRecords = c.DateTime(nullable: false),
                        Value = c.Int(nullable: false),
                        Details = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.IncomeRecord", "IncomeCategoryId");
            AddForeignKey("dbo.IncomeRecord", "IncomeCategoryId", "dbo.IncomeCategory", "Id", cascadeDelete: true);
        }
    }
}
