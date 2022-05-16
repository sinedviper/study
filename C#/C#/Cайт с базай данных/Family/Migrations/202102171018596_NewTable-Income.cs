namespace Family.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NewTableIncome : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IncomeCategory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Informations = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.IncomeCategory");
        }
    }
}
