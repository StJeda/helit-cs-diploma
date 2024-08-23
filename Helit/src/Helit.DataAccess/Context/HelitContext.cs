using Helit.Domain.Models;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using File = Helit.Domain.Models.File;

namespace Helit.DataAccess.Context;

public class HelitContext
{
    private readonly IMongoCollection<Project> _projectsCollection;
    private readonly IMongoCollection<File> _filesCollection;

    public HelitContext(IOptions<MongoDBSettings> mongoDbSettings)
    {
        
    }
}
