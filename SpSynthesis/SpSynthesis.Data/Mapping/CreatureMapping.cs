using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpSynthesis.Domain;

namespace SpSynthesis.Data.Mapping
{
    internal partial class CreatureMapping : EntityTypeConfiguration<Creature>
    {
        public CreatureMapping()
        {
            this.ToTable("Creatures");
            this.HasKey(creature => creature.Id)
                .Property(creature => creature.Id).HasColumnName("Id")
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(creature => creature.Name).HasColumnName("Name")
                .IsMaxLength();
            this.Property(creature => creature.Description).HasColumnName("Description")
                .IsMaxLength();
            this.Property(creature => creature.Image).HasColumnName("Image")
                .IsOptional().IsMaxLength();
        
            this.Property(creature => creature.Leadership).HasColumnName("Leadership");
            this.Property(creature => creature.Health).HasColumnName("Health");

            this.Property(creature => creature.MinDamage).HasColumnName("MinDamage");
            this.Property(creature => creature.MaxDamage).HasColumnName("MaxDamage");

            this.Property(creature => creature.Range).HasColumnName("Range");
            this.Property(creature => creature.Attack).HasColumnName("Attack");
            this.Property(creature => creature.Defence).HasColumnName("Defence");
            this.Property(creature => creature.Initiative).HasColumnName("Initiative");
            this.Property(creature => creature.Speed).HasColumnName("Speed");
            this.Property(creature => creature.CriticalHit).HasColumnName("CriticalHit");

            this.Property(creature => creature.FResistance).HasColumnName("FResistance");
            this.Property(creature => creature.AResistance).HasColumnName("AResistance");
            this.Property(creature => creature.MResistance).HasColumnName("MResistance");
        }
    }
}
