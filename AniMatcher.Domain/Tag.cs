namespace AniMatcher.Domain;

/// <summary>
/// Тег.
/// </summary>
public class Tag
{
	public Tag(string tagName)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(tagName);
		
		TagName = tagName;
		TagId = Guid.NewGuid();
	}

	public Tag(Guid id)
	{
		TagId = id;
	}
	
	/// <summary>
	/// Идентификатор.
	/// </summary>
	public Guid TagId { get; private init; }
	
	/// <summary>
	/// Название.
	/// </summary>
	public string TagName { get; private init; }
}