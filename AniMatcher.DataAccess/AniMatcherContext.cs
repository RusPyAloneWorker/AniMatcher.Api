using AniMatcher.Domain;
using Microsoft.EntityFrameworkCore;

namespace AniMatcher.DataAccess;

public class AniMatcherContext: DbContext
{
	public DbSet<Test> Tests { get; set; }
	public DbSet<Question> Questions { get; set; }
	public DbSet<QuestionOption> QuestionOptions { get; set; }
	public DbSet<Character> Characters { get; set; }
	public DbSet<Tag> Tags { get; set; }
	public DbSet<Franchise> Franchises { get; set; }
	public DbSet<Rating> Ratings { get; set; }
	
	public AniMatcherContext(DbContextOptions<AniMatcherContext> options)
		: base(options)
	{ }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Franchise>()
			.HasMany<Character>()
			.WithOne(x => x.Copyright)
			.HasForeignKey(character => character.CopyrightId);
		
		var franchises = new List<Franchise>()
		{
			new Franchise("Marvel", "Comic Franchise"),
			new Franchise("DC", "Comic Franchise"),
			new Franchise("Naruto", "Manga Franchise")
		};

		var characters = new List<Character>()
		{
			new Character("Batman", franchises[1].FranchiseId),
			new Character("Superman", franchises[1].FranchiseId),
			new Character("Flash", franchises[1].FranchiseId),
			new Character("Hulk", franchises[0].FranchiseId),
			new Character("Spider Man", franchises[0].FranchiseId),
			new Character("Iron Man", franchises[0].FranchiseId),
			new Character("Naruto", franchises[2].FranchiseId),
			new Character("Sasuke", franchises[2].FranchiseId),
			new Character("Sakura", franchises[2].FranchiseId),
		};
		
		modelBuilder.Entity<Franchise>(c => c.HasData(franchises));
		modelBuilder.Entity<Character>(c => c.HasData(characters));
		
		base.OnModelCreating(modelBuilder);
	}
}