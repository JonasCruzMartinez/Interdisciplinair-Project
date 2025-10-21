namespace InterdisciplinairProject.Core.Models;

/// <summary>
/// Represents a DMX scene.
/// </summary>
public class Scene
{
    /// <summary>
    /// Gets or sets the unique identifier of the scene.
    /// </summary>
    public Guid Id { get; set; } = Guid.NewGuid();

    /// <summary>
    /// Gets or sets the name of the scene.
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the creation date of the scene.
    /// </summary>
    public DateTime CreatedAt { get; set; } = DateTime.Now;

    /// <summary>
    /// Gets or sets the list of scene fixtures in this scene.
    /// </summary>
    public List<SceneFixture> Fixtures { get; set; } = new();
}
