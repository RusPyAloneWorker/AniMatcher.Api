using AniMatcher.Domain;

namespace AniMatcherApi.ViewModelOutputs;

public class TestViewModelOutput
{
	public Guid Id { get; set; }
	public string Title { get; set; }
	public string Description { get; set; }
	public List<QuestionViewModelOutput> Questions { get; set; }
	public List<Tag>? Tags { get; set; }
	
	public double Score { get; set; }
	public int RatingCount { get; set; }

	public TestViewModelOutput(Test test)
	{
		Title = test.Title;
		Description = test.Description;
		Id = test.TestId;
		Tags = test.Tags;
		Score = test.Rating.Count != 0 ? (double)test.Rating.Sum / test.Rating.Count : 0;
		RatingCount = test.Rating.Count;
		
		Questions = test.Questions
			.Select(x => new QuestionViewModelOutput()
			{
				Id = x.QuestionId,
				Text = x.QuestionText,
				Options = x.Options
					.Select(o => new QuestionOptionViewModelOutput()
					{
						Id = o.QuestionOptionId,
						Text = o.Text,
						CharacterOrder = o.CharacterOrder
					})
					.ToList()
			}).ToList();
	}
}