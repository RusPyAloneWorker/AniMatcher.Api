using System.Data.Common;
using AniMatcher.DataAccess;
using AniMatcher.Domain;
using AniMatcherApi.endpoints;
using AniMatcherApi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection = builder.Configuration.GetConnectionString("PostgresConnection");

builder.Services.AddDbContext<AniMatcherContext>(options =>
	options.UseNpgsql(connection));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.AddGetEndpoints();
app.MapPost("franchises", async (FranchiseViewModel vm, [FromServices] AniMatcherContext dbContext) =>
{
	try
	{
		var franchise = new Franchise(vm.Name, vm.Description);
		await dbContext.Franchises.AddAsync(new Franchise(vm.Name, vm.Description));
		return Results.Created($"franchises/{franchise.FranchiseId}", franchise.FranchiseId);
	}
	catch (DbException dbException)
	{
		return Results.BadRequest(new { message = dbException.Message });
	}
});

app.UseHttpsRedirection();

app.Run();