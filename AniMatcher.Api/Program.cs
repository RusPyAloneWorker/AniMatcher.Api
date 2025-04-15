using AniMatcher.DataAccess;
using AniMatcherApi.endpoints;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connection = builder.Configuration.GetConnectionString("PostgresConnection");

builder.Services.AddDbContext<AniMatcherContext>(options =>
	options.UseNpgsql(connection));

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
	var db = scope.ServiceProvider.GetRequiredService<AniMatcherContext>();
	await db.Database.MigrateAsync();
}

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.AddGetEndpoints();
app.AddPostEndpoints();

app.UseHttpsRedirection();

app.Run();