using AniMatcher.DataAccess;
using AniMatcher.Domain;
using AniMatcherApi.ViewModelOutputs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AniMatcherApi.endpoints;

public static class GetEndpointsExtension
{
	public static WebApplication AddGetEndpoints(this WebApplication webApplication)
	{
		webApplication.MapGet("franchises", async ([FromQuery(Name="name")] string? name,[FromQuery(Name="guid")] Guid? guid, [FromServices] AniMatcherContext dbContext) =>
		{
			if (guid.HasValue)
			{
				var franchise = await dbContext.Franchises
					.FirstOrDefaultAsync(x => x.FranchiseId == guid);

				return franchise is null 
					? Results.NotFound() 
					: Results.Ok(new FranchiseViewModelOutput(franchise.FranchiseId, franchise.Name, franchise.Description));	
			}
			if (name is not null)
			{
				var franchises = await dbContext.Franchises
					.Where(x => EF.Functions.JsonContains(x.Names, $"\"{name.ToLower()}\""))
					.Select(x => new FranchiseViewModelOutput(x.FranchiseId, x.Name, x.Description))
					.ToListAsync();

				return franchises.Any()
					? Results.Ok(franchises)
					: Results.NotFound();	
			}
			
			return Results.Ok(await dbContext.Franchises
				.Select(x => new FranchiseViewModelOutput(x.FranchiseId, x.Name, x.Description))
				.ToListAsync());
		});
		
		webApplication.MapGet("characters", async ([FromQuery(Name="name")] string? name, [FromQuery(Name="id")] Guid? guid, [FromServices] AniMatcherContext dbContext) =>
		{
			if (guid.HasValue)
			{
				var character = await dbContext.Characters
					.Include(character => character.Copyright)
					.FirstOrDefaultAsync(x => x.CharacterId == guid);

				return character is not null
					? Results.Ok(new CharacterViewModelOutput(character.CharacterId, character.Name, character.Copyright.Name,
						character.CopyrightId))
					: Results.NotFound();
			}
			if (name is not null)
			{
				var characters = await dbContext.Characters
					.Include(character => character.Copyright)
					.Where(x => EF.Functions.JsonContains(x.Names, $"\"{name.ToLower()}\""))
					.Select(x => new CharacterViewModelOutput(x.CharacterId, x.Name, x.Copyright.Name, x.CopyrightId))
					.ToListAsync();

				return characters.Any()
                    ? Results.Ok(characters)
					: Results.NotFound();
			}
			
			return Results.Ok(await dbContext.Characters
				.Include(x => x.Copyright)
				.Select(x => new CharacterViewModelOutput(x.CharacterId, x.Name, x.Copyright.Name, x.CopyrightId))
				.ToListAsync());
		});
		
		webApplication.MapGet(
			"tests", 
			async (
				[FromQuery(Name="name")] string? name, 
				[FromQuery(Name="tags")] string[]? tags,
				[FromQuery(Name="franchise")] string? franchise,
				[FromQuery(Name="id")] Guid? guid, 
				[FromQuery(Name="orderBy")] string? orderBy,
				[FromServices] AniMatcherContext dbContext) =>
		{
			if (guid.HasValue)
			{
				var test = await dbContext.Tests
					.Include(x => x.Characters)
					.Include(x => x.Questions)
					.ThenInclude(x => x.Options)
					.Include(x => x.Rating)
					.Include(x => x.Tags)
					.FirstOrDefaultAsync(x => x.TestId == guid);

				return test is not null
					? Results.Ok(new TestViewModelOutput(test))
					: Results.NotFound();
			}
			
			if (name is not null)
			{
				var tests = await dbContext.Tests
					.Include(x => x.Characters)
					.Include(x => x.Questions)
					.ThenInclude(x => x.Options)
					.Include(x => x.Tags)
					.Include(x => x.Rating)
					.Where(x => EF.Functions.Like(x.Title, $"%{name}%"))
					.Select(x => new TestViewModelOutput(x))
					.ToListAsync();

				return tests.Any()
					? Results.Ok(tests)
					: Results.NotFound();
			}

			if (tags is not null && tags.Length > 0)
			{
				var tests = await dbContext.Tests
					.Include(x => x.Characters)
					.Include(x => x.Questions)
					.ThenInclude(x => x.Options)
					.Include(x => x.Tags)
					.Include(x => x.Rating)
					.Select(x => new TestViewModelOutput(x))
					.ToListAsync();

				tests = tests
					.Where(x => tags.All(t => x.Tags!.Select(t1 => t1.TagName).Contains(t)))
					.ToList();
				
				return tests.Any()
					? Results.Ok(tests)
					: Results.NotFound();
			}
			
			if (franchise is not null)
			{
				var tests = await dbContext.Tests
					.Include(x => x.Characters)
					.Include(x => x.Questions)
					.ThenInclude(x => x.Options)
					.Include(x => x.Tags)
					.Include(x => x.Rating)
					.Where(x => 
						x.Characters.Any(c => EF.Functions.JsonContains(c.Copyright.Names, $"\"{franchise.ToLower()}\"")))
					.Select(x => new TestViewModelOutput(x))
					.ToListAsync();

				return tests.Any()
					? Results.Ok(tests)
					: Results.NotFound();
			}
			
			IQueryable<Test> tests1 = dbContext.Tests;
			
			if (orderBy is not null)
			{
				switch (orderBy)
				{
					case "rating":
						tests1 = tests1.OrderBy(x => x.Rating.Sum != 0 ? (double)x.Rating.Sum / x.Rating.Count : 0).AsQueryable();
						break;
					case "ratingDesc":
						tests1 = tests1.OrderByDescending(x => x.Rating.Sum != 0 ? (double)x.Rating.Sum / x.Rating.Count : 0).AsQueryable();
						break;
				}
			}
			
			return Results.Ok(await tests1.Include(x => x.Characters)
				.Include(x => x.Questions)
				.ThenInclude(x => x.Options)
				.Include(x => x.Tags)
				.Include(x => x.Rating)
				.Select(x => new TestViewModelOutput(x))
				.ToListAsync());
		});
		
		webApplication.MapGet(
			"tags",
			async ([FromServices] AniMatcherContext dbContext) => await dbContext.Tags.ToListAsync());
		
		return webApplication;
	}
}