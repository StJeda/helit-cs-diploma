using MongoDB.Bson;
using System.ComponentModel.DataAnnotations.Schema;

namespace Helit.Domain.Models;

public class Directory
{
    public ObjectId DirectoryId { get; set; }
    public required string Name { get; set; }

    [ForeignKey(nameof(Project))]
    public virtual Project? Project { get; set; }
    public virtual ICollection<File> Files { get; set; } = new List<File>();
}
