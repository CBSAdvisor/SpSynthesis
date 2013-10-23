namespace SpSynthesis.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class SpSynthMigrationConfig : DbMigrationsConfiguration<SpSynthDbContext>
    {
        public SpSynthMigrationConfig()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(SpSynthDbContext context)
        {
        }
    }
}
