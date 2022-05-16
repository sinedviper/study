namespace Family.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTableIncomeThree : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IncomeRecords",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IncomeCategoryId = c.Int(nullable: false),
                        IncomeRecordss = c.DateTime(nullable: false),
                        Value = c.Int(nullable: false),
                        Information = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.IncomeCategory", t => t.IncomeCategoryId, cascadeDelete: true)
                .Index(t => t.IncomeCategoryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IncomeRecords", "IncomeCategoryId", "dbo.IncomeCategory");
            DropIndex("dbo.IncomeRecords", new[] { "IncomeCategoryId" });
            DropTable("dbo.IncomeRecords");
        }
    }
}
