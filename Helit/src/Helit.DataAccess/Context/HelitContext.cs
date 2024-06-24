using Helit.Domain.Models;
using Microsoft.EntityFrameworkCore;
using MongoDB.EntityFrameworkCore.Extensions;
using Directory = Helit.Domain.Models.Directory;
using File = Helit.Domain.Models.File;

namespace Helit.DataAccess.Context;

public class HelitContext : DbContext
{
    public HelitContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<Project>(e =>
            e.ToCollection("projects")
        );
        modelBuilder.Entity<Directory>(e =>
            e.ToCollection("directories")
        );
        modelBuilder.Entity<File>(e =>
            e.ToCollection("files")
        );
    }

    public DbSet<Project> Projects { get; set; }
    public DbSet<ProjectConfig> ProjectConfigs { get; set; }
    public DbSet<Directory> Directories { get; set; }
    public DbSet<File> Files { get; set; }
}
