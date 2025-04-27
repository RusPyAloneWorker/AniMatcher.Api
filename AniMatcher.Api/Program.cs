using AniMatcher.DataAccess;
using AniMatcher.Domain;
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
	try
	{
		await AddTests(db);
	}
	catch
	{
		// ignored
	}
}

app.UseSwagger();
app.UseSwaggerUI();

app.AddGetEndpoints();
app.AddPostEndpoints();

app.Run();

async Task AddTests(AniMatcherContext db)
{
	var flash = db.Characters.First(x => EF.Functions.Like(x.Name, $"%{"Flash"}%"));
	var batman = db.Characters.First(x => EF.Functions.Like(x.Name, $"%{"Batman"}%"));
	var superman = db.Characters.First(x => EF.Functions.Like(x.Name, $"%{"Superman"}%"));
	
	var hulk = db.Characters.First(x => EF.Functions.Like(x.Name, $"%{"Hulk"}%"));
	var spiderMan = db.Characters.First(x => EF.Functions.Like(x.Name, $"%{"Spider Man"}%"));
	var ironMan = db.Characters.First(x => EF.Functions.Like(x.Name, $"%{"Iron Man"}%"));
	
	var tags = new List<Tag>()
    		{
    			new Tag("Комиксы"),
    			new Tag("Аниме"),
    			new Tag("Geek")
    		};
    
    		var testDC = new Test (
    				"Кто ты из DC?",
    				"Тест покажет, кто ты из персонажей вселенной DC",
    				new ()
    				{
    					new ("Твоя любимая супер способность?", new ()
    					{
    						new ("Скорость", 0),
    						new ("Супер сила", 1),
    						new ("Интеллект и деньги", 2),
    					}),
    					new ("Твоя любимый цвет?", new ()
    					{
    						new ("Красный", 0),
    						new ("Синий", 1),
    						new ("Черный", 2),
    					}),
    					new ("Что ты больше всего боишься?", new ()
    					{
    						new ("Боюсь не успеть", 0),
    						new ("Боюсь зеленого камня", 1),
    						new ("Я ничего не боюсь", 2),
    					}),
    				},
    				new () { flash, superman, batman },
    				new () { tags[0], tags[2] }
    			);
    		
    		var testMARVEL = new Test (
    			"Кто ты из MARVEL?",
    			"Тест покажет, кто ты из персонажей вселенной MARVEL",
    			new ()
    			{
    				new ("Твоя любимая супер способность?", new ()
    				{
    					new ("Супер сила", 0),
    					new ("Ловкость", 1),
    					new ("Интеллект и деньги", 2),
    				}),
    				new ("Твоя любимый цвет?", new ()
    				{
    					new ("Зеленый", 0),
    					new ("Красный и синий", 1),
    					new ("Красный и желтый", 2),
    				}),
    				new ("Что тебе больше нравится?", new ()
    				{
    					new ("Все ломать и крушить", 0),
    					new ("Прыгать по зданиям Нью-Йорка", 1),
    					new ("Мастерить", 2),
    				}),
    			},
    			new () { hulk, spiderMan, ironMan },
    			new () { tags[0], tags[2] }
    		);
		    
	db.Tags.AddRange(tags);
	db.Tests.AddRange(testMARVEL, testDC);
	await db.SaveChangesAsync();
}