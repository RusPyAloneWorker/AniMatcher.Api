using System.Data.Common;
using AniMatcher.DataAccess;
using AniMatcher.Domain;
using AniMatcherApi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AniMatcherApi.endpoints;

public static class PostEndpointsExtension
{
	public static WebApplication AddPostEndpoints(this WebApplication app)
	{
		app.MapPost("franchises", async (FranchiseViewModel vm, [FromServices] AniMatcherContext dbContext) =>
		{
			try
			{
				var franchise = new Franchise(vm.Name, vm.Description, vm.AdditionalNames);
				await dbContext.Franchises.AddAsync(franchise);
				return Results.Created($"franchises?guid={franchise.FranchiseId}", franchise.FranchiseId);
			}
			catch (DbException dbException)
			{
				return Results.BadRequest(new { message = dbException.Message });
			}
		});

		app.MapPost("tests", async (
			TestViewModelTestViewModel vm, 
			[FromServices] AniMatcherContext dbContext,
			CancellationToken token) =>
		{
			try
			{
				var questions = vm.Questions
					.Select(x => new Question(
						x.Text, 
						x.Options.Select(o => new QuestionOption(o.Text, o.CharacterOrder)).ToList()
					))
					.ToList();
		
				var test = new Test(
					vm.Title, 
					vm.Description, 
					questions, 
					vm.CharactersId.Select(x => new Character(x)).ToList(), 
					vm.TagsId?.Select(x => new Tag(x)).ToList());
				
				foreach (var character in test.Characters)
					dbContext.Attach(character);
				
				if (test.Tags != null && test.Tags.Any())
				{
					foreach (var tag in test.Tags) 
						dbContext.Attach(tag);
				}
				
				await dbContext.Tests.AddAsync(test, token);
				await dbContext.SaveChangesAsync(token);
		
				return Results.Created($"tests?guid={test.TestId}", test.TestId);
			}
			catch (DbException dbException)
			{
				return Results.BadRequest(new { message = dbException.Message });
			}
		});

		app.MapPut("tests/{id}/rate", async (
			[FromQuery(Name="rate")] int rate, 
			[FromRoute] Guid id, 
			[FromServices] AniMatcherContext dbContext,
			CancellationToken token) =>
		{
			var test = await dbContext.Tests
				.Include(x => x.Rating)
				.SingleOrDefaultAsync(t => t.TestId == id, cancellationToken: token);

			if (test == null)
			{
				return Results.NotFound();
			}
			
			test.Rating.AddReview(rate);
			await dbContext.SaveChangesAsync(token);
			
			return Results.NoContent();
		});
		
		app.MapPost("tests/pass", async (
			AnsweredTestViewModel vm,
			[FromServices] AniMatcherContext dbContext,
			CancellationToken token) =>
		{
			var test = await dbContext.Tests
				.Include(x => x.Questions)
				.ThenInclude(x => x.Options)
				.Include(test => test.Rating)
				.Include(test => test.Characters)
				.SingleOrDefaultAsync(t => t.TestId == vm.TestId, cancellationToken: token);

			var optionsResult = test?.Questions
				.SelectMany(x => x.Options)
				.Where(x => vm.SelectedOptions.Contains(x.QuestionOptionId))
				.GroupBy(x => x.CharacterOrder)
				.Select(x => new { Count = x.Count(), CharOrder = x.Key });
			
			var charOrder = optionsResult?.MaxBy(x => x.Count)?.CharOrder;
			var result = test?.Characters[charOrder!.Value];
			
			return result != null 
				? Results.Ok(result) 
				: Results.BadRequest("No matching questions were found");
		});
		
		app.MapPost("tags", async ([FromBody] TagViewModel vm, [FromServices] AniMatcherContext dbContext) =>
		{
			try
			{
				var tag = new Tag(vm.Name);
				await dbContext.Tags.AddAsync(tag);
				await dbContext.SaveChangesAsync();
		
				return Results.Created($"tests?guid={tag.TagId}", tag.TagId);
			}
			catch (DbException dbException)
			{
				return Results.BadRequest(new { message = dbException.Message });
			}
		});
		
		return app;
	}
}