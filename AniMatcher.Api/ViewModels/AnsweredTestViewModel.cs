namespace AniMatcherApi.ViewModels;

public record AnsweredTestViewModel(
	Guid TestId,
	List<Guid> SelectedOptions
	);