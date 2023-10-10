using Microsoft.EntityFrameworkCore;

namespace Persistence;

public class DatabaseContext : DbContext

{

#pragma warning disable CS8618
	public DatabaseContext() : base()
#pragma warning restore CS8618

	{
		Database.EnsureCreated();
	}

	public DbSet<Domain.User> Users { get; set; }

	protected override void OnConfiguring
		(DbContextOptionsBuilder optionsBuilder)

	{
        var connectionString =
 
        "Server=.;Database=PhoneBook ;MultipleActiveResultSets=true;Trusted_Connection=True;TrustServerCertificate=True;";

        optionsBuilder.UseSqlServer
			(connectionString: connectionString);
	}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly
            (assembly: typeof(Configurations.UserConfiguration).Assembly);
    }
}
