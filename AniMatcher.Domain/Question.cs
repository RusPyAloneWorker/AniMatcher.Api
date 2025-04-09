using System.ComponentModel.DataAnnotations.Schema;

namespace AniMatcher.Domain;

/// <summary>
/// Вопрос.
/// </summary>
public class Question
{
	#region Constants
	[NotMapped] private const int MinOptionCount = 2; 
	#endregion
	
	/// <summary>
	/// Идентификатор.
	/// </summary>
	public Guid QuestionId { get; set; }
	
	/// <summary>
	/// Текст вопроса.
	/// </summary>
	public string QuestionText { get; set; }
	
	/// <summary>
	/// Выбор ответа.
	/// </summary>
	public List<QuestionOption> Options { get; set; }

	public Question(string questionText, List<QuestionOption> options)
	{
		ArgumentNullException.ThrowIfNull(options);
		ArgumentException.ThrowIfNullOrWhiteSpace(questionText);
		
		if (options.Count < MinOptionCount)
		{
			throw new ArgumentException("Число ответов должно быть как минимум " + MinOptionCount + ".", nameof(options));
		}
		
		QuestionText = questionText;
		Options = options;
		QuestionId = Guid.NewGuid();
	}

	private Question() { }
}