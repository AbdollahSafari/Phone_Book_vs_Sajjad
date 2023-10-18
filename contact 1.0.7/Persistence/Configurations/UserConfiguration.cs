using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations;

internal class UserConfiguration : object,

	IEntityTypeConfiguration<Domain.User>

{
	public UserConfiguration() : base()
	{

	}

	public void Configure(EntityTypeBuilder<Domain.User> builder)
	{
	
		//builder
		//	.Property(current => current.Name)
		//	.IsUnicode(unicode: false)
		//	;

        builder
            .HasIndex(current => new { current.Name })
            .IsUnique(unique: false)
            ;

        builder
			.HasIndex(current => new { current.LastName })
			.IsUnique(unique: false)
			;

		builder
			.HasIndex(current => new { current.Position })
			.IsUnique(unique: false)
			;
       
        builder
			.HasIndex(current => new { current.OfficePhone })
			.IsUnique(unique: false)
			;

		builder
			.HasIndex(current => new { current.MobilePhone })
			.IsUnique(unique: false)
			;

		var user =
			new Domain.User();
			
		//builder.HasData(data: user);
	
	}
}
