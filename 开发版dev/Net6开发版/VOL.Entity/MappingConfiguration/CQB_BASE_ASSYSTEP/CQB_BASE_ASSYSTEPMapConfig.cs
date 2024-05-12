using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class CQB_BASE_ASSYSTEPMapConfig : EntityMappingConfiguration<CQB_BASE_ASSYSTEP>
    {
        public override void Map(EntityTypeBuilder<CQB_BASE_ASSYSTEP>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

