using SpSynthesis.Core;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpSynthesis.Data
{
    public class SpSynthDbInitializer : CreateDatabaseIfNotExists<SpSynthDbContext>
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
