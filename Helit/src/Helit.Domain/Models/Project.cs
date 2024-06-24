using MongoDB.Bson;

namespace Helit.Domain.Models;

public class Project()
{
    public ObjectId ProjectId { get; set; }
    public required string ProjectName { get; set; }
    public virtual ProjectConfig Config { get; set; } = new ProjectConfig();
    public virtual ICollection<Directory> Directories { get; set; } = new List<Directory>();
}
