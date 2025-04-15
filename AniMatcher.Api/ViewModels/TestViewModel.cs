namespace AniMatcherApi.ViewModels;

public record TestViewModelTestViewModel (
	string Title,
	string Description,
	List<QuestionViewModel> Questions,
	List<Guid> CharactersId,
	List<Guid>? TagsId = null
	);