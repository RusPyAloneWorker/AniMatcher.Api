using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization.Metadata;
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
	{
		AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
	}

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.Entity<Franchise>()
			.HasMany<Character>()
			.WithOne(x => x.Copyright)
			.HasForeignKey(character => character.CopyrightId);

		modelBuilder.Entity<Test>()
			.HasMany(x => x.Characters)
			.WithMany();
		
		modelBuilder.Entity<Test>()
			.HasMany(x => x.Tags)
			.WithMany();

		modelBuilder.Entity<Tag>()
			.HasIndex(x => x.TagName)
			.IsUnique();
		
		var franchises = new List<Franchise>()
		{
			new Franchise("Marvel", "Comic Franchise", new () { "marvel", "марвел" }),
			new Franchise("DC", "Comic Franchise", new () { "dc", "диси", "дс" }),
			new Franchise("Naruto", "Manga Franchise", new () { "наруто", "naruto" })
		};

		var characters = new List<Character>()
		{
			new Character("Batman", franchises[1].FranchiseId, new () { "бэтмэн", "бэтмен", "batman" }),
			new Character("Superman", franchises[1].FranchiseId, new () { "superman", "супермен", "супермэн" }),
			new Character("Flash", franchises[1].FranchiseId, new () { "flash", "флэш" }),
			new Character("Hulk", franchises[0].FranchiseId, new () { "hulk", "халк" }),
			new Character("Spider Man", franchises[0].FranchiseId, new () { "человек-паук", "человек паук", "spider-man", "spider man" }),
			new Character("Iron Man", franchises[0].FranchiseId, new () { "iron man", "ironman", "железный человек" }),
			new Character("Naruto", franchises[2].FranchiseId, new () { "наруто", "naruto" }),
			new Character("Sasuke", franchises[2].FranchiseId, new () { "саске", "сасуке", "sasuke" }),
			new Character("Sakura", franchises[2].FranchiseId, new () { "sakura", "сакура" }),
		};
		
		modelBuilder.Entity<Franchise>(c =>
		{
			c.HasData(franchises);
			c.Property(s => s.Names)
				.HasColumnType("jsonb")
				.HasConversion(
					v => JsonSerializer.Serialize(v,  new JsonSerializerOptions 
					{ 
						Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping 
					}),
					v => JsonSerializer.Deserialize<List<string>>(v, JsonSerializerOptions.Default) ?? new List<string>()
				);
		});
		modelBuilder.Entity<Character>(c =>
		{
			c.HasData(characters);
			c.Property(s => s.Names)
				.HasColumnType("jsonb")
				.HasConversion(
					v => JsonSerializer.Serialize(v,  new JsonSerializerOptions 
					{ 
						Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
					}),
					v => JsonSerializer.Deserialize<List<string>>(v, JsonSerializerOptions.Default) ?? new List<string>()
				);
		});
		
		base.OnModelCreating(modelBuilder);
	}
}