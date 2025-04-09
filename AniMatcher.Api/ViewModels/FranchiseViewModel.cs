using System.Diagnostics.CodeAnalysis;

namespace AniMatcherApi.ViewModels;

public class FranchiseViewModel
{
	[NotNull]
	public string Name { get; set; } = string.Empty;
	
	[NotNull]
	public string Description { get; set; } = string.Empty;
}