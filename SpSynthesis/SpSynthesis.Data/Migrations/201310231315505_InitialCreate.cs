namespace SpSynthesis.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Creatures",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        Image = c.Binary(),
                        Leadership = c.Int(nullable: false),
                        Health = c.Int(nullable: false),
                        MinDamage = c.Int(nullable: false),
                        MaxDamage = c.Int(nullable: false),
                        Range = c.Int(nullable: false),
                        Attack = c.Int(nullable: false),
                        Defence = c.Int(nullable: false),
                        Initiative = c.Int(nullable: false),
                        Speed = c.Int(nullable: false),
                        CriticalHit = c.Int(nullable: false),
                        FResistance = c.Int(nullable: false),
                        AResistance = c.Int(nullable: false),
                        MResistance = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Creatures");
        }
    }
}
