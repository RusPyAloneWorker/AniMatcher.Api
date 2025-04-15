using System.ComponentModel.DataAnnotations.Schema;

namespace AniMatcher.Domain;

/// <summary>
/// Персонаж.
/// </summary>
public class Character
{
	/// <summary>
	/// Идентификатор.
	/// </summary>
	public Guid CharacterId { get; private init; }
	
	/// <summary>
	/// Имя персонажа.
	/// </summary>
	public string Name { get; private init; }
	
	/// <summary>
	/// Франшиза, к которой он принадлежит.
	/// </summary>
	[ForeignKey("CopyrightId")]
	public Franchise Copyright { get; private init; }
	
	/// <summary>
	/// Франшиза, к которой он принадлежит.
	/// </summary>
	public Guid CopyrightId { get; private init; }
	
	/// <summary>
	/// Возможные вариации названия.
	/// </summary>
	public List<string> Names { get; private set; }
	
	public Character(string name, Guid copyrightId, List<string> names)
	{
		ArgumentException.ThrowIfNullOrWhiteSpace(name);
		ArgumentNullException.ThrowIfNull(names);
		
		if (Guid.Empty.Equals(copyrightId))
		{
			throw new ArgumentException($"'{nameof(copyrightId)}' cannot be empty.", nameof(copyrightId));
		}
		
		Name = name;
		Names = names.Select(n => n.ToLower()).ToList();
		CopyrightId = copyrightId;
		CharacterId = Guid.NewGuid();
	}

	public Character(Guid Id)
	{
		CharacterId = Id;
	}

	private Character()
	{ }
}