namespace AniMatcherApi.ViewModels;

public record QuestionViewModel(
	string Text,
	List<OptionViewModel> Options
	);