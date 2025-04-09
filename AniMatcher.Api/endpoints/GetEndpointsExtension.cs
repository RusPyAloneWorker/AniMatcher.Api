using AniMatcher.DataAccess;
using AniMatcherApi.ViewModelOutputs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AniMatcherApi.endpoints;

public static class GetEndpointsExtension
{
	public static WebApplication AddGetEndpoints(this WebApplication webApplication)
	{
		webApplication.MapGet("franchises", async ([FromServices] AniMatcherContext dbContext) =>
			Results.Ok(await dbContext.Franchises
				.Select(x => new FranchiseViewModelOutput(x.FranchiseId, x.Name, x.Description))
				.ToListAsync()));
		
		webApplication.MapGet("characters", async ([FromServices] AniMatcherContext dbContext) =>
			Results.Ok(await dbContext.Characters
				.Include(x => x.Copyright)
				.Select(x => new CharacterViewModelOutput(x.CharacterId, x.Name, x.Copyright.Name, x.CharacterId))
				.ToListAsync()));

		webApplication.MapGet("franchises/{guid}", async (Guid guid, [FromServices] AniMatcherContext dbContext) =>
		{
			var franchise = await dbContext.Franchises
				.FirstOrDefaultAsync(x => x.FranchiseId == guid);

			return franchise is null 
				? Results.NotFound() 
				: Results.Ok(new FranchiseViewModelOutput(franchise.FranchiseId, franchise.Name, franchise.Description));
		});

		webApplication.MapGet("characters", async ([FromQuery(Name="id")] Guid guid, [FromServices] AniMatcherContext dbContext) =>
		{
			var character = await dbContext.Characters
				.Include(character => character.Copyright)
				.FirstOrDefaultAsync(x => x.CharacterId == guid);

			return character is not null
				? Results.Ok(new CharacterViewModelOutput(character.CharacterId, character.Name, character.Copyright.Name,
					character.CharacterId))
				: Results.NotFound();
		});
		
		webApplication.MapGet("characters", async ([FromQuery(Name="name")] string name, [FromServices] AniMatcherContext dbContext) =>
		{
			var characters = await dbContext.Characters
				.Include(character => character.Copyright)
				.Where(x => x.Name.Contains(name))
				.Select(x => new CharacterViewModelOutput(x.CharacterId, x.Name, x.Copyright.Name, x.CharacterId))
				.ToListAsync();

			return characters is not null
				? Results.Ok(characters)
				: Results.NotFound();
		});

		return webApplication;
	}
}