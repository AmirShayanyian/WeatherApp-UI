using Application.Entities.BaseEntity;
using Domain.Core.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Application;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) 
        : base(options)
    {
        
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        var assemblies = typeof(BaseEntity).Assembly;
        modelBuilder.AddAllEntities<BaseEntity>(assemblies);
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(IBaseEntity).Assembly);
    }
}