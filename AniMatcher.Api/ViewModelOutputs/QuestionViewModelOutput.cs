namespace AniMatcherApi.ViewModelOutputs;

public class QuestionViewModelOutput
{
	public Guid Id { get; set; }
	public string Text { get; set; }
	public List<QuestionOptionViewModelOutput> Options { get; set; }
}