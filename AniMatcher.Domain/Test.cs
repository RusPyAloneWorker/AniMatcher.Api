using System.ComponentModel.DataAnnotations.Schema;

namespace AniMatcher.Domain;

/// <summary>
/// Тест.
/// </summary>
public class Test 
{
	#region Constants
	[NotMapped] private const int MinQuestionCount = 2;
	#endregion
	
	/// <summary>
	/// Идентификатор.
	/// </summary>
	public Guid TestId { get; private init; }
	
	/// <summary>
	/// Название теста.
	/// </summary>
	public string Title { get; private init; }
	
	/// <summary>
	/// Описание теста.
	/// </summary>
	public string Description { get; private init; }
	
	/// <summary>
	/// Дата создания теста.
	/// </summary>
	public DateTime CreationDate { get; private init; }
	
	/// <summary>
	/// Рейтинг.
	/// </summary>
	public Rating Rating { get; private set; }
	
	/// <summary>
	/// Персонажи.
	/// </summary>
	public List<Character> Characters { get; private init; }
	
	/// <summary>
	/// Вопросы.
	/// </summary>
	public List<Question> Questions { get; private set; }
	
	/// <summary>
	/// Теги.
	/// </summary>
	public List<Tag>? Tags { get; private set; }
	
	public Test(
		string title, 
		string description, 
		List<Question> questions, 
		List<Character> characters,
		List<Tag>? tags)
	{
		ArgumentNullException.ThrowIfNull(title);
		ArgumentNullException.ThrowIfNull(questions);
		ArgumentNullException.ThrowIfNull(description);
		ArgumentNullException.ThrowIfNull(characters);

		if (questions.Count < MinQuestionCount)
		{
			throw new ArgumentException($"Число вопрос должно быть больше {MinQuestionCount}.");
		}
		
		var charactersCount = questions.Count;
		var isOrderBeyondBounds = questions.SelectMany(x => x.Options).Any(x => x.CharacterOrder < 0 || x.CharacterOrder >= charactersCount);

		if (isOrderBeyondBounds)
		{
			throw new ArgumentException($"Ответ в оциях должен быть в пределах от 0 до {questions.Count - 1}.");
		}
		
		Title = title;
		Description = description;
		Questions = questions;
		Characters = characters;
		Tags = tags;
		CreationDate = DateTime.Now;
		TestId = Guid.NewGuid();
		Rating = new Rating(TestId);
	}

	private Test()
	{ }
}