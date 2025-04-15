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
	
	/// <summary>
	/// Возможные вариации названия.
	/// </summary>
	public List<string> Names { get; private set; }

	public Franchise(string name, string description, List<string> names)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(name);
		ArgumentException.ThrowIfNullOrWhiteSpace(description);
		ArgumentNullException.ThrowIfNull(names);
		
		Name = name;
		Description = description;
		FranchiseId = Guid.NewGuid();
		Names = names.Select(n => n.ToLower()).ToList();
	}

	private Franchise()
	{ }
}