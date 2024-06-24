using Helit.Domain.Models.Enum;
using MongoDB.Bson;

namespace Helit.Domain.Models;
public class ProjectConfig()
{
    public ObjectId ProjectConfigId { get; set; }
    public FileLangEnum Lang { get; set; } = FileLangEnum.txt;
}
