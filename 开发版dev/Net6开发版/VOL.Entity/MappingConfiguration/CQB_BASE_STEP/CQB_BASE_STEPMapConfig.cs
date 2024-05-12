using VOL.Entity.MappingConfiguration;
using VOL.Entity.DomainModels;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VOL.Entity.MappingConfiguration
{
    public class CQB_BASE_STEPMapConfig : EntityMappingConfiguration<CQB_BASE_STEP>
    {
        public override void Map(EntityTypeBuilder<CQB_BASE_STEP>
        builderTable)
        {
          //b.Property(x => x.StorageName).HasMaxLength(45);
        }
     }
}

