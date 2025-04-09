namespace AniMatcherApi.ViewModelOutputs;

public record CharacterViewModelOutput (
	Guid Id, 
	string Name, 
	string Franchise, 
	Guid FranchiseId
	);