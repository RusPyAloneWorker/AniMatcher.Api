namespace AniMatcher.Domain;

/// <summary>
/// Франшиза.
/// </summary>
public class Franchise
{
	/// <summary>
	/// Идентификатор.
	/// </summary>
	public Guid FranchiseId { get; private init; }
	
	/// <summary>
	/// Название франшизы.
	/// </summary>
	public string Name { get; private init; }
	
	/// <summary>
	/// Описание франшизы.
	/// </summary>
	public string Description { get; private set; }

	public Franchise(string name, string description)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(name);
		ArgumentException.ThrowIfNullOrWhiteSpace(description);
		
		Name = name;
		Description = description;
		FranchiseId = Guid.NewGuid();
	}

	private Franchise()
	{ }
}