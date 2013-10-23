using SpSynthesis.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpSynthesis.Data.Migrations;

namespace SpSynthesis.Data
{
    internal class SpSynthDbInitializer : CreateAndMigrateDatabaseInitializer<SpSynthDbContext, Configuration>
    {
        public SpSynthDbInitializer()
            : base()
        {
        }

        protected override void Seed(SpSynthDbContext context)
        {
        }
    }
}
