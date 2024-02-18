using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace Domain.Core.Extensions;

public static class ModelBuilderExtensions
{
    public static void AddAllEntities<TBaseType>(this ModelBuilder modelBuilder, params Assembly[] assemblies)
    {
        var entityTypes = assemblies
            .SelectMany(x => x.GetExportedTypes())
            .Where(p => p is { IsPublic: true, IsAbstract: false } &&
                        p.IsSubclassOf(typeof(TBaseType)));
        foreach (var type in entityTypes)
        {
            modelBuilder.Entity(type);
        }
    }
}