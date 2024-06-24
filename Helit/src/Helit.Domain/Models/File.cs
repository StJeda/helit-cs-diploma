using MongoDB.Bson;
using System.ComponentModel.DataAnnotations.Schema;

namespace Helit.Domain.Models
{
    public class File
    {
        public ObjectId FileId { get; set; }
        public required string Name { get; set; }
        public string? Content { get; set; }

        [ForeignKey(nameof(Directory))]
        public virtual Directory? Directory { get; set; }
    }
}
