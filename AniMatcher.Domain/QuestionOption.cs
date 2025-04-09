namespace AniMatcher.Domain;

/// <summary>
/// Пункт вопроса.
/// </summary>
public class QuestionOption
{
	/// <summary>
	/// Идентификатор.
	/// </summary>
	public Guid QuestionOptionId { get; set; }
	
	/// <summary>
	/// Текст ответа.
	/// </summary>
	public string Text { get; set; }
	
	/// <summary>
	/// Балл к персонажу.
	/// </summary>
	public int CharacterOrder { get; set; }

	public QuestionOption(string text, int characterOrder)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(text, nameof(text));
		
		Text = text;
		CharacterOrder = characterOrder;
		QuestionOptionId = Guid.NewGuid();
	}

	private QuestionOption()
	{ }
}