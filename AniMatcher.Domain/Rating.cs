using System.ComponentModel.DataAnnotations.Schema;

namespace AniMatcher.Domain;

public class Rating
{
	#region Constants
	[NotMapped] private const int MaxRating = 5;
	[NotMapped] private const int MinRating = 0;
	#endregion
	
	public Guid RatingId { get; private init; }
	
	/// <summary>
	/// Количество голосов.
	/// </summary>
	public int Count { get; private set; } = 0;
	
	/// <summary>
	/// Суммарный рейтинг.
	/// </summary>
	public int Sum { get; private set; } = 0;
	
	/// <summary>
	/// Тест.
	/// </summary>
	public Guid TestId { get; private set; }
	
	/// <summary>
	/// Тест.
	/// </summary>
	public Test Test { get; private set; }

	public Rating(Guid testId)
	{
		TestId = testId;
		RatingId = Guid.NewGuid();
	}

	/// <summary>
	/// Добавить оценку.
	/// </summary>
	/// <param name="rating">Балл.</param>
	/// <exception cref="ArgumentOutOfRangeException">Значение за пределами.</exception>
	public void AddReview(int rating)
	{
		if (rating is < 0 or > 5)
		{
			throw new ArgumentOutOfRangeException(nameof(rating));
		}

		Count++;
		Sum += rating;
	}

	private Rating()
	{ }
}